#region Derechos de autor
/****************************************************************************
*Advertencia este programa esta protegido po las leyes de derechos de autor *
*y otros tratados internacionales.                                          *
*la reproducción o distribución ilícitas de este programa ,o de cualquier   *
*parte del mismo,esta penada por la ley con severas sanciones civiles y     *
*penales,y sera objeto de todas las acciones judiciales que correspondan.   *
*Autor: Francisco Reyes Sánchez.     ¬~~~~~~~~°@°='o'                       *
*                            * 
****************************************************************************/
#endregion
#region Referencias
using System;
using System.Collections;
// se agrego framework para mysql
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
#endregion
namespace Datos
{
    class conexion
    {
        #region Variable privadas
        MySqlConnection _conexion = new MySqlConnection();//conexion ala base de datos con MySqlConnection 
        MySqlCommand _cmd = null;//Inicia a _cmd como vacio
      /*  MySqlDataAdapter _da = null;*///Inicia a _da como vacio
        bool _continuar = false;
        //Bitacora //miBitacora ;//= new Bitacora(

        #endregion
        #region Constructor
        public conexion()//publicacion de la clase conexion para que pueda ser visible para las demas clases
        {
            
            //miBitacora = new Bitacora();
            try//inicia el bloque try para cachar los posibles errores
            {
                ////miBitacora.RegistrarAccion(DateTime.Now, "Iniciando Constructor");
                string gestor = ConfigurationManager.AppSettings["Gestor"].ToString();//asignacion a la variable gestor las configuraciones de ["Gestor"]
                ConnectionStringSettings configuracion = ConfigurationManager.ConnectionStrings[gestor];//variable que conecta a Gestor 
                _conexion.ConnectionString = configuracion.ConnectionString.ToString();//envia la configuraciones ala BD con las configuraciones correspondientes

                ////miBitacora.RegistrarAccion(DateTime.Now, "Variables Inicializadas");
            }
            catch (Exception ex)//atrapa los errores y los envia ala variable ex
            {
                throw new Exception(ex.Message);
              
                ////miBitacora.RegistrarAccion(DateTime.Now, ex.Message);

            }
            finally {
                //miBitacora = null;
            }
        }
        #endregion
        #region Destructor
        ~conexion() {
            //miBitacora = new Bitacora();
            if (_conexion.State == ConnectionState.Open)//abre la conexion a la base de datos
            {
                _conexion.Close();//cierra la conexion ala Base de datos 
            }
            ////miBitacora.RegistrarAccion(DateTime.Now, "Destruyendo Objeto Conexion");
            //miBitacora = null;
        }
        #endregion

        #region Métodos Públicos
        public DataTable seleccionar(string instruccion)//creacion de la tabla de memoria DataTable Seleccionar
        {
            //miBitacora = new Bitacora();
            try//inicia el bloque try 
            {
                _conexion.Open();//abre la conexion ala BD

                ////miBitacora.RegistrarAccion(DateTime.Now, "Abriendo Conexion");
                _cmd = new MySqlCommand();//asignación a _cmd de SqlCommand
                _cmd.CommandText = instruccion;//inicia la instruccion del comando de texto.

                ////miBitacora.RegistrarAccion(DateTime.Now, "Ejecutando Instruccion");

                //////miBitacora.RegistrarAccion(DateTime.Now, instruccion);
                if (instruccion.ToLower().StartsWith("sp_"))
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    _cmd.CommandType = CommandType.Text;
                }
                _cmd.Connection = _conexion;//iniciacion de la variable _conexion
                MySqlDataAdapter da = new MySqlDataAdapter();//creacion del objeto da del tipo SqlDataAdapter
                da.SelectCommand = _cmd;
                DataSet ds = new DataSet();
                da.Fill(ds, "Datos");
                _cmd = null;
                _conexion.Close();

                ////miBitacora.RegistrarAccion(DateTime.Now, "Cerrando Conexion");
                return ds.Tables["Datos"];
            }
            catch (Exception ex)
            {
                if (_conexion.State == ConnectionState.Open)
                {
                    _conexion.Close();
                }
                ////miBitacora.RegistrarAccion(DateTime.Now, ex.Message);
                throw new Exception(ex.Message);
            }
            finally
            {
                //miBitacora = null;
            }
        }

        //public void  Backup(/*string files*/)
        //{

        //    string constring = "server=localhost;user=root;pwd= ;database=sys_ventas;";
        //    string file = "C:\\backup.sql";
        //    using (MySqlConnection conn = new MySqlConnection(constring))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand())
        //        {
        //            using (MySqlBackup mb = new MySqlBackup(cmd))
        //            {
        //                cmd.Connection = conn;
        //                conn.Open();
        //                mb.ExportToFile(file);
        //                conn.Close();
        //            }
        //        }
        //    }
        //    //try
        //    //{
        //    // _conexion.Open();
        //    // _cmd = new MySqlCommand();
        //    // _cmd.Connection = _conexion;

        //    //string file = "C:\\backup.sql";

        //    // using (MySqlBackup mb = new MySqlBackup(_cmd))
        //    // {

        //    //     mb.ExportToFile(file);


        //    // }
        //    // if (_conexion.State == ConnectionState.Open)

        //    // {
        //    //     _conexion.Close();
        //    // }
        //    // _cmd = null;
        //    // return true;
        //    //}
        //    //catch (Exception)
        //    //{

        //    //    throw;
        //    //}



        //}
        public bool Insertar(string Tabla, Hashtable[] Campos)
        {
            MySqlTransaction Transaccion = null;
            //miBitacora = new Bitacora();
            try
            {
                _conexion.Open();

                
                Transaccion = _conexion.BeginTransaction();
                _cmd = new MySqlCommand();
                _cmd.Connection = _conexion;
                _cmd.Transaction = Transaccion;
                foreach (Hashtable HT in Campos)
                {
                    MySqlParameter[] parametros = new MySqlParameter[HT.Count];
                    IDictionaryEnumerator oEnumerador;
                    oEnumerador = HT.GetEnumerator();
                    int indice = 0;
                    string nombreCampo = string.Empty;//asigna vacio a la variable nombreCampo
                    string valorCampo = string.Empty;
                    while (oEnumerador.MoveNext())
                    {
                        MySqlParameter p = new MySqlParameter();//_factoria.CreateParameter();
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
            MySqlTransaction Transaccion = null;
          
            //miBitacora = new Bitacora();
            try
            {
                _conexion.Open();
                Transaccion = _conexion.BeginTransaction();
                _cmd = new MySqlCommand();
                _cmd.Connection = _conexion;
                _cmd.Transaction = Transaccion;

                MySqlParameter[] parametros = new MySqlParameter[HT.Count];
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
                //modificadp
               // _cmd.Parameters.AddRange(parametros);
                _cmd.ExecuteNonQuery();
                //modificado
                //_cmd.Parameters.Clear();

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
            MySqlTransaction Transaccion = null;
            //miBitacora = new Bitacora();
            try
            {
                _conexion.Open();

                ////miBitacora.RegistrarAccion(DateTime.Now, "Insertando Datos");
                Transaccion = _conexion.BeginTransaction();
                _cmd = new MySqlCommand();
                _cmd.Connection = _conexion;
                _cmd.Transaction = Transaccion;

                _cmd.CommandText = Transact_SQL;
                _cmd.ExecuteNonQuery();

                foreach (Hashtable HT in Campos)
                {
                    MySqlParameter[] parametros = new MySqlParameter[HT.Count];
                    IDictionaryEnumerator oEnumerador;
                    oEnumerador = HT.GetEnumerator();
                    int indice = 0;
                    string nombreCampo = string.Empty;
                    string valorCampo = string.Empty;
                    while (oEnumerador.MoveNext())
                    {
                        MySqlParameter p = new MySqlParameter();//_factoria.CreateParameter();
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
            MySqlTransaction Transaccion = null;
            //miBitacora = new Bitacora();
            try
            {
                _conexion.Open();

                ////miBitacora.RegistrarAccion(DateTime.Now, "Insertando Datos");
                Transaccion = _conexion.BeginTransaction();
                _cmd = new MySqlCommand();
                _cmd.Connection = _conexion;
                _cmd.Transaction = Transaccion;

                IDictionaryEnumerator oEnumerador;
                oEnumerador = Datos.GetEnumerator();
                int indice = 0;
                string nombreCampo = string.Empty;
                string valorCampo = string.Empty;
                MySqlParameter[] parametros = new MySqlParameter[Datos.Count];
                while (oEnumerador.MoveNext())
                {
                    MySqlParameter p = new MySqlParameter();//_factoria.CreateParameter();
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
                          parametros = new MySqlParameter[HT.Count];
                    //    IDictionaryEnumerator oEnumerador;
                        oEnumerador = HT.GetEnumerator();
                          indice = 0;
                          nombreCampo = string.Empty;
                          valorCampo = string.Empty;
                        while (oEnumerador.MoveNext())
                        {
                            MySqlParameter p = new MySqlParameter();//_factoria.CreateParameter();
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
                          parametros = new MySqlParameter[HT.Count];
                     //   IDictionaryEnumerator oEnumerador;
                        oEnumerador = HT.GetEnumerator();
                          indice = 0;
                          nombreCampo = string.Empty;
                          valorCampo = string.Empty;
                        while (oEnumerador.MoveNext())
                        {
                            MySqlParameter p = new MySqlParameter();//_factoria.CreateParameter();
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
            catch (Exception )
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
