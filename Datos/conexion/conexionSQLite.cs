#region Derechos de autor
/****************************************************************************
*Advertencia este programa esta protegido po las leyes de derechos de autor *
*y otros tratados internacionales.                                          *
*la reproducción o distribución ilícitas de este programa ,o de cualquier   *
*parte del mismo,esta penada por la ley con severas sanciones civiles y     *
*penales,y sera objeto de todas las acciones judiciales que correspondan.   *
*Autor: Ing.Francisco Reyes Sánchez.                                        *
*Fecha de creación: 12/10/2016                                              * 
****************************************************************************/
#endregion
#region Referencias
using System;
using System.Collections;
// se agrego framework para SQLite
using System.Data.SQLite;
using System.Data;
#endregion
namespace Datos
{
    class conexionSQLite
    {
        #region Variable privadas
        SQLiteConnection _conexion = new SQLiteConnection();
        SQLiteCommand _cmd = null;
        bool _continuar = false;
        #endregion
        #region Constructor
        public conexionSQLite()
        {

           
            try
            {


                // aqui se debe de establecer la cadena de conexion hacia la base de datos en SQLite
                _conexion.ConnectionString = "Data Source=sys_ventas.db;Version=3;New=False;Compress=True;";
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                
            }
        }
        #endregion
        #region Destructor
        //~conexionSQLite()
        //{

        //    if (_conexion.State == ConnectionState.Open)
        //    {
        //        _conexion.Close();
        //    }



        //}
        #endregion

        #region Métodos Públicos
        public DataTable seleccionar(string instruccion)
        {
            
            try
            {
                _conexion.Open();
                _cmd = new SQLiteCommand();
                _cmd.CommandText = instruccion;

               if (instruccion.ToLower().StartsWith("sp_"))
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    _cmd.CommandType = CommandType.Text;
                }
                _cmd.Connection = _conexion;
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.SelectCommand = _cmd;
                DataSet ds = new DataSet();
                da.Fill(ds, "Datos");
                _cmd = null;
                _conexion.Close();
                return ds.Tables["Datos"];
            }
            catch (Exception ex)
            {
                if (_conexion.State == ConnectionState.Open)
                {
                    _conexion.Close();
                }
                throw new Exception(ex.Message);
            }
            finally
            {
              
            }
        }

        public bool Insertar(string Tabla, Hashtable[] Campos)
        {
            
            SQLiteTransaction Transaccion = null;
            //miBitacora = new Bitacora();
            try
            {
                _conexion.Open();


                Transaccion = _conexion.BeginTransaction();
                _cmd = new SQLiteCommand();
                _cmd.Connection = _conexion;
                _cmd.Transaction = Transaccion;
                foreach (Hashtable HT in Campos)
                {
                    SQLiteParameter[] parametros = new SQLiteParameter[HT.Count];
                    IDictionaryEnumerator oEnumerador;
                    oEnumerador = HT.GetEnumerator();
                    int indice = 0;
                    string nombreCampo = string.Empty;
                    string valorCampo = string.Empty;
                    while (oEnumerador.MoveNext())
                    {
                        SQLiteParameter p = new SQLiteParameter();
                        p.ParameterName = oEnumerador.Key.ToString();
                        p.Value = oEnumerador.Value.ToString();
                        p.Direction = System.Data.ParameterDirection.Input;
                        parametros[indice] = p;
                        nombreCampo += oEnumerador.Key.ToString() + ", ";
                        valorCampo += "@" + oEnumerador.Key.ToString().Trim() + ", ";
                        indice++;
                    }
                    nombreCampo = nombreCampo.Trim();
                    nombreCampo = nombreCampo.Substring(0, nombreCampo.Length - 1);
                    valorCampo = valorCampo.Trim();
                    valorCampo = valorCampo.Substring(0, valorCampo.Length - 1);
                    string sql = string.Empty;
                    sql = "INSERT INTO " + Tabla + "(";
                    sql += nombreCampo + ") ";
                    sql += " VALUES ( ";
                    sql += valorCampo + ")";
                    _cmd.CommandType = CommandType.Text;
                    _cmd.CommandText = sql;
                    _cmd.Parameters.AddRange(parametros);
                    _cmd.ExecuteNonQuery();
                    _cmd.Parameters.Clear();
                }
                _cmd.Dispose();
                Transaccion.Commit();
                _continuar = true;
            }
            catch (Exception)
            {

                ////miBitacora.RegistrarAccion(DateTime.Now,ex.Message);
                if (_conexion.State == ConnectionState.Open)
                {
                    Transaccion.Rollback();
                }
                _continuar = false;
            }
            finally

            {
                if (_conexion.State == ConnectionState.Open)

                {
                    _conexion.Close();
                }
                _cmd = null;
                //miBitacora = null;
            }
            return _continuar;
        }

        public bool Actualizar(string Tabla, string claveprimaria, int valorclaveprimaria, Hashtable HT)
        {
            SQLiteTransaction Transaccion = null;
            try
            {
                _conexion.Open();
                Transaccion = _conexion.BeginTransaction();
                _cmd = new SQLiteCommand();
                _cmd.Connection = _conexion;
                _cmd.Transaction = Transaccion;

                SQLiteParameter[] parametros = new SQLiteParameter[HT.Count];
                IDictionaryEnumerator oEnumerador;
                oEnumerador = HT.GetEnumerator();

                string nombreCampo = string.Empty;
                string valorCampo = string.Empty;

                while (oEnumerador.MoveNext())
                {
                    nombreCampo += oEnumerador.Key.ToString() + " =  ";
                    nombreCampo += "'" + oEnumerador.Value.ToString().Trim() + "', ";

                }
                nombreCampo = nombreCampo.Trim();
                nombreCampo = nombreCampo.Substring(0, nombreCampo.Length - 1);
                string sql = string.Empty;
                sql = "UPDATE " + Tabla + " SET ";
                sql += nombreCampo;
                sql += " WHERE " + claveprimaria + " ='" + valorclaveprimaria + "'";
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = sql;
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                Transaccion.Commit();
                _continuar = true;
            }
            catch (Exception)
            {

                ////miBitacora.RegistrarAccion(DateTime.Now, ex.Message);
                if (_conexion.State == ConnectionState.Open)
                {
                    Transaccion.Rollback();
                }
                _continuar = false;
            }
            finally
            {
                if (_conexion.State == ConnectionState.Open)
                {
                    _conexion.Close();
                }
                _cmd = null;
                //miBitacora = null;
            }
            return _continuar;
        }

        public bool InsertarCompra(string Transact_SQL, string Tabla, Hashtable[] Campos)
        {
            SQLiteTransaction Transaccion = null;
            //miBitacora = new Bitacora();
            try
            {
                _conexion.Open();

                ////miBitacora.RegistrarAccion(DateTime.Now, "Insertando Datos");
                Transaccion = _conexion.BeginTransaction();
                _cmd = new SQLiteCommand();
                _cmd.Connection = _conexion;
                _cmd.Transaction = Transaccion;

                _cmd.CommandText = Transact_SQL;
                _cmd.ExecuteNonQuery();

                foreach (Hashtable HT in Campos)
                {
                    SQLiteParameter[] parametros = new SQLiteParameter[HT.Count];
                    IDictionaryEnumerator oEnumerador;
                    oEnumerador = HT.GetEnumerator();
                    int indice = 0;
                    string nombreCampo = string.Empty;
                    string valorCampo = string.Empty;
                    while (oEnumerador.MoveNext())
                    {
                        SQLiteParameter p = new SQLiteParameter();//_factoria.CreateParameter();
                        p.ParameterName = oEnumerador.Key.ToString();
                        p.Value = oEnumerador.Value.ToString();
                        p.Direction = System.Data.ParameterDirection.Input;
                        parametros[indice] = p;
                        nombreCampo += oEnumerador.Key.ToString() + ", ";
                        valorCampo += "@" + oEnumerador.Key.ToString().Trim() + ", ";
                        indice++;
                    }
                    nombreCampo = nombreCampo.Trim();
                    nombreCampo = nombreCampo.Substring(0, nombreCampo.Length - 1);
                    valorCampo = valorCampo.Trim();
                    valorCampo = valorCampo.Substring(0, valorCampo.Length - 1);
                    string sql = string.Empty;
                    sql = "INSERT INTO " + Tabla + "(";
                    sql += nombreCampo + ") ";
                    sql += " VALUES ( ";
                    sql += valorCampo + ")";
                    _cmd.CommandType = CommandType.Text;
                    _cmd.CommandText = sql;
                    _cmd.Parameters.AddRange(parametros);
                    _cmd.ExecuteNonQuery();
                    _cmd.Parameters.Clear();
                }

                Transaccion.Commit();
                _cmd.Dispose();
                _continuar = true;
            }
            catch (Exception)
            {

                ////miBitacora.RegistrarAccion(DateTime.Now, ex.Message);
                if (_conexion.State == ConnectionState.Open)
                {
                    Transaccion.Rollback();
                }
                _continuar = false;
            }
            finally
            {
                if (_conexion.State == ConnectionState.Open)
                {
                    _conexion.Close();
                }
                _cmd = null;
                //miBitacora = null;
            }
            return _continuar;
        }
        public bool InsertarRequisicion(Hashtable Datos, Hashtable[] misProductos, Hashtable[] misServicios)
        {
            SQLiteTransaction Transaccion = null;
            //miBitacora = new Bitacora();
            try
            {
                _conexion.Open();

                ////miBitacora.RegistrarAccion(DateTime.Now, "Insertando Datos");
                Transaccion = _conexion.BeginTransaction();
                _cmd = new SQLiteCommand();
                _cmd.Connection = _conexion;
                _cmd.Transaction = Transaccion;

                IDictionaryEnumerator oEnumerador;
                oEnumerador = Datos.GetEnumerator();
                int indice = 0;
                string nombreCampo = string.Empty;
                string valorCampo = string.Empty;
                SQLiteParameter[] parametros = new SQLiteParameter[Datos.Count];
                while (oEnumerador.MoveNext())
                {
                    SQLiteParameter p = new SQLiteParameter();//_factoria.CreateParameter();
                    p.ParameterName = oEnumerador.Key.ToString();
                    p.Value = oEnumerador.Value.ToString();
                    p.Direction = System.Data.ParameterDirection.Input;
                    parametros[indice] = p;
                    nombreCampo += oEnumerador.Key.ToString() + ", ";
                    valorCampo += "@" + oEnumerador.Key.ToString().Trim() + ", ";
                    indice++;
                }
                nombreCampo = nombreCampo.Trim();
                nombreCampo = nombreCampo.Substring(0, nombreCampo.Length - 1);
                valorCampo = valorCampo.Trim();
                valorCampo = valorCampo.Substring(0, valorCampo.Length - 1);
                string sql = string.Empty;
                sql = "INSERT INTO RequisicionServicio (";
                sql += nombreCampo + ") ";
                sql += " VALUES ( ";
                sql += valorCampo + ")";
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = sql;
                _cmd.Parameters.AddRange(parametros);
                _cmd.ExecuteNonQuery();
                _cmd.Parameters.Clear();
                parametros = null;
                if (misProductos.Length > 0)
                {
                    foreach (Hashtable HT in misProductos)
                    {
                        parametros = new SQLiteParameter[HT.Count];
                        //    IDictionaryEnumerator oEnumerador;
                        oEnumerador = HT.GetEnumerator();
                        indice = 0;
                        nombreCampo = string.Empty;
                        valorCampo = string.Empty;
                        while (oEnumerador.MoveNext())
                        {
                            SQLiteParameter p = new SQLiteParameter();//_factoria.CreateParameter();
                            p.ParameterName = oEnumerador.Key.ToString();
                            p.Value = oEnumerador.Value.ToString();
                            p.Direction = System.Data.ParameterDirection.Input;
                            parametros[indice] = p;
                            nombreCampo += oEnumerador.Key.ToString() + ", ";
                            valorCampo += "@" + oEnumerador.Key.ToString().Trim() + ", ";
                            indice++;
                        }
                        nombreCampo = nombreCampo.Trim();
                        nombreCampo = nombreCampo.Substring(0, nombreCampo.Length - 1);
                        valorCampo = valorCampo.Trim();
                        valorCampo = valorCampo.Substring(0, valorCampo.Length - 1);
                        sql = string.Empty;
                        sql = "INSERT INTO VentaServicio (";
                        sql += nombreCampo + ") ";
                        sql += " VALUES ( ";
                        sql += valorCampo + ")";
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = sql;
                        _cmd.Parameters.AddRange(parametros);
                        _cmd.ExecuteNonQuery();
                        _cmd.Parameters.Clear();
                    }
                }

                parametros = null;
                if (misServicios.Length > 0)
                {
                    foreach (Hashtable HT in misServicios)
                    {
                        parametros = new SQLiteParameter[HT.Count];
                        //   IDictionaryEnumerator oEnumerador;
                        oEnumerador = HT.GetEnumerator();
                        indice = 0;
                        nombreCampo = string.Empty;
                        valorCampo = string.Empty;
                        while (oEnumerador.MoveNext())
                        {
                            SQLiteParameter p = new SQLiteParameter();//_factoria.CreateParameter();
                            p.ParameterName = oEnumerador.Key.ToString();
                            p.Value = oEnumerador.Value.ToString();
                            p.Direction = System.Data.ParameterDirection.Input;
                            parametros[indice] = p;
                            nombreCampo += oEnumerador.Key.ToString() + ", ";
                            valorCampo += "@" + oEnumerador.Key.ToString().Trim() + ", ";
                            indice++;
                        }
                        nombreCampo = nombreCampo.Trim();
                        nombreCampo = nombreCampo.Substring(0, nombreCampo.Length - 1);
                        valorCampo = valorCampo.Trim();
                        valorCampo = valorCampo.Substring(0, valorCampo.Length - 1);
                        sql = string.Empty;
                        sql = "INSERT INTO DetalleServicio (";
                        sql += nombreCampo + ") ";
                        sql += " VALUES ( ";
                        sql += valorCampo + ")";
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = sql;
                        _cmd.Parameters.AddRange(parametros);
                        _cmd.ExecuteNonQuery();
                        _cmd.Parameters.Clear();
                    }
                }
                Transaccion.Commit();
                _cmd.Dispose();
                _continuar = true;
            }
            catch (Exception)
            {

                ////miBitacora.RegistrarAccion(DateTime.Now, ex.Message);
                if (_conexion.State == ConnectionState.Open)
                {
                    Transaccion.Rollback();
                }
                _continuar = false;
            }
            finally
            {
                if (_conexion.State == ConnectionState.Open)
                {
                    _conexion.Close();
                }
                _cmd = null;
                //miBitacora = null;
            }
            return _continuar;

        }


    }


    #endregion
}
