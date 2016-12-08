using System;
using System.Data;
using System.Collections;

namespace Datos
{
    public class clsUsuario
    {

        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();

        public DataTable Listar()
        {
            try
            {
                string sql = string.Empty;
                sql = "select * from usuario where baja=0;";

                DataTable dt;
                dt = _cnn.seleccionar(sql);
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Ingresar(string usuario, string clave)
        {
            //try
            //{
                string sql = string.Empty;
                sql = "insert into bitacora (fechahora,tabla,comentario) values(";
                sql += "'" + DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss") + "','usuario','Inicio de sesion')";
                _cnn.seleccionar(sql);
                sql = "select count(idusuario) from usuario where nick='" + usuario.Replace("'", "") + "' and contrasenia='" + clave.Replace("'", "") + "'";
                DataTable dt;
                dt = _cnn.seleccionar(sql);
                if (dt == null)
                {
                    return false;
                }
                else
                {
                    if (int.Parse(dt.Rows[0].ItemArray[0].ToString()) > 0)
                    {
                        return true;
                    }
                    else {

                        return false;
                    
                    }                
                }
            //}
            //catch (Exception)
            //{
                
            //    throw;
            //}
        }

        #region Constructor
       public clsUsuario() { }
        #endregion
       #region Destructor
        ~clsUsuario()
        {
            _cnn=null;
        }
       #endregion
        public bool Guardar(Hashtable[] Usuarios)
        {
            bool continuar = false;
            try
            {
                _cnn.Insertar("Usuario", Usuarios);
                continuar = true;
            }
            catch (Exception)
            {
                continuar = false;
            }
            finally
            {
            }
            return continuar;
        }
        public bool Actualizar(string campo,int clave, Hashtable Usuarios)
        {
            bool continuar = false;
            try
            {
                _cnn.Actualizar("Usuario",campo,clave, Usuarios);
                continuar = true;
            }
            catch (Exception)
            {
                continuar = false;
            }
            finally
            {
            }
            return continuar;
        }
    }

}


