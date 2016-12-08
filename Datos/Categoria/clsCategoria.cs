#region Referencias
using System;//libreria de la interfaz del sistema
using System.Collections;
using System.Data;//libreria que hace uso de los datos del sistema 
#endregion

namespace Datos
{
    public class clsCategoria
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();
        public bool eliminar(int clave)
        {
            string sql = "DELETE FROM Categoria WHERE idCategoria=" + clave;
            DataTable dt;
            dt = _cnn.seleccionar(sql);
            return true;
        }
        public clsCategoria() { }

        ~clsCategoria() { _cnn = null; }
        public DataTable Buscar(int clave)
        {
            string sql = string.Empty;
            sql = "select * from categoria where idCategoria='" + clave + "';";
            DataTable DT;
            DT = _cnn.seleccionar(sql);
            return DT;
        }
        public DataTable Listar()
        {
            try
            {
                string sql = string.Empty;
                sql = "select * from categoria where baja=0;";
                DataTable dt;
                dt = _cnn.seleccionar(sql);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Actualizar(string campo, int clave, Hashtable nuevasCategorias)
        {
            bool seguir = false;
            try
            {
                _cnn.Actualizar("categoria", campo, clave, nuevasCategorias);
                seguir = true;
            }
            catch (Exception)
            {

                seguir = false;
            }
            finally
            {
            }
            return seguir;
        }
        public bool Guardar(Hashtable[] Categorias)
        {
            bool continuar = false;
            try
            {
                _cnn.Insertar("categoria", Categorias);


                string sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
                sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Empleado','guardando categoria')";
                continuar = true;
            }
            catch (Exception )
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
