#region Referencias
using System;//libreria que hace uso de la interfaz del sistema operativo
using System.Collections.Generic;
using System.Data;//libreria que hace uso de los datos del sistema 
using System.Collections;//libreria que hace uso de las colecciones de datos del sistema
#endregion

namespace Datos
{
    public class clsProveedor//publicacion de la clase clsProveedor
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();
        public DataTable Listar()//se publica la tabla de memoria para listar los registros de la tabla proveedores
        {
            try//inicializa el bloque de insrucciones try-catch
            {
                string sql = string.Empty;//se crea la cadena sql y se inicializa como vacia 
                sql = "select idproveedor,rfc,nombre,direccion,";
                sql += "colonia,ciudad,estado,cp,telefono,correo from Proveedor where baja=0;";//a la cadena sql se le asigna el valor de una consulta a la tabla proveedor
                DataTable dt;//se crea la tabla de memoria dt
                dt = _cnn.seleccionar(sql);//a la tabla de memoria dt se le asigna el valor que trae la cadena sql
                sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
                sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Proveedor','Listando proveedor')";
                _cnn.seleccionar(sql);
                return dt;//retorna lo que trae como valor la tabla dt
            }
            catch (Exception)
            {
                throw;
            }
        }
        #region Constructor
        public clsProveedor() { }//publicacion de el contructor para la clase clsProveedor
        #endregion
        #region Destructor
        ~clsProveedor()//destructor de la clase clsProveedor
        {
            _cnn = null;//a la instancia _cnnProveedor se le asigna el valor null
        }
        #endregion
        public bool Guardar(Hashtable[] Proveedor)//publicacion del metodo booleano Guardar 
        {
            bool continuar = false;//declaracion de la variable continuar como falsa
            try
            {
                _cnn.Insertar("Proveedor", Proveedor);//a la instancia _cnnProveedor se le asigna la funcion Insertar y el nombre de la tabla a la que se va a modificaf
                string sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
                sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Proveedor','Guardando proveedor')";
                continuar = true;//a la variable continuar se le asigna el valor de verdadero
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

        public bool Actualizar(string campo, int clave, Hashtable nuevosProveedor)
        {
            bool seguir = false;
            try
            {
                _cnn.Actualizar("Proveedor", campo, clave, nuevosProveedor);
             string   sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
             sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Proveedor','Actualizando proveedor')";
             _cnn.seleccionar(sql);
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

        public bool Eliminar(int clave)
        {
            string sql = "DELETE FROM Proveedor  WHERE idproveedor =" + clave;
            DataTable dt;
            dt = _cnn.seleccionar(sql);
            sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
            sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Proveedor','Eliminado proveedor')";
            _cnn.seleccionar(sql);
            return true;

        }
    }
}