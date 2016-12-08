#region Referencias
using System;
using System.Collections;
using System.Data; 
#endregion

namespace Datos
{
    public class clsProducto//publicacion de la clase clsProducto
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();
        public bool Eliminar(int clave)//publicación de la variable boleana Eliminar asignandole la variable clave
        {
            string sql = "DELETE FROM producto WHERE idproducto ='" + clave+"';";//declaracion de la transaccion sql en la cual actualiza los productos más la clave
            DataTable dt;//creacion de la tabla de memoria 
            dt = _cnn.seleccionar(sql);//asigna la cadena de conexion a la tabla de memoria dt
            sql = "insert into Bitacora (fechahora,tabla,comentario) values(";//declaración de la transaccion sql que inserta una bitacora ala Bd
            sql += "'" + DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss") + "','Producto','Eliminando el producto')";//formato de la transaccion en la cual se declara el formato de la fecha 
            _cnn.seleccionar(sql);//asignacion de la consulta sql ala variable _cnn.seleccionar
            return true;//retorna verdadero

        }
        #region Constructor
        public clsProducto() { }//inicia el contructor de la clase clsProducto
        #endregion
        #region Destructor
        ~clsProducto()//desctruccion de la clase clsProducto
        {
            _cnn = null;//inicia la variable _cnn en vacio
        }
        #endregion
        public DataTable Buscar(int clave)//publicación de la tabla de memoria DataTable Buscar con la variable clave
        {
            try//inicia el bloque try
            {
                string sql = string.Empty;//asigna como vacia la instruccion sql 
                sql = "SELECT * FROM producto WHERE idproducto='" + clave +"';";//inicia la transaccion sql para consultar la tabla productos
                DataTable DT;//creacion de la tabla de memoria DT
                DT = _cnn.seleccionar(sql);//se le asigna la transaccion sql ala tabla de memoria DT
                return DT;//retorna lo que lleva DT
            }
            catch (Exception)//atrapa la exepcion si que hay una 
            {
                throw;
            }
        }
        public DataTable BuscarPorNombre(string nombre)//publicación de la tabla de memoria DataTable Buscar con la variable clave
        {
            try//inicia el bloque try
            {
                string sql = string.Empty;//asigna como vacia la instruccion sql 
                sql = "SELECT * FROM producto WHERE nombre REGEXP '" + nombre + "'";//inicia la transaccion sql para consultar la tabla productos
                DataTable DT;//creacion de la tabla de memoria DT
                DT = _cnn.seleccionar(sql);//se le asigna la transaccion sql ala tabla de memoria DT
                return DT;//retorna lo que lleva DT
            }
            catch (Exception)//atrapa la exepcion si que hay una 
            {
                throw;
            }
        }
        public DataTable BuscarBarcodeProducto(string barcode)//publicación de la tabla de memoria DataTable Buscar con la variable clave
        {
            try//inicia el bloque try
            {
                string sql = string.Empty;//asigna como vacia la instruccion sql 
                sql = "SELECT * FROM Producto WHERE codigoBarras='" + barcode + "';";//inicia la transaccion sql para consultar la tabla productos
                DataTable DT;//creacion de la tabla de memoria DT
                DT = _cnn.seleccionar(sql);//se le asigna la transaccion sql ala tabla de memoria DT
                return DT;//retorna lo que lleva DT
            }
            catch (Exception)//atrapa la exepcion si que hay una 
            {
                throw;
            }
        }
        public DataTable ListarBusqueda( string datos)
        {
            try
            {
                string sql = string.Empty;//asignacion de la variable sql como vacia 
                sql = "SELECT idproducto,nombre,marca,descripcion,";//cadena de conexión que hace una consulta select sobre la BD
                sql += "idproveedor,fechacompra,preciounitario,idCategoria,imagen,stockMin,stockMax,existencia,codigoBarras FROM producto WHERE codigoBarras REGEXP '"+datos+ "' OR nombre REGEXP '" + datos+"' ";
                sql += "OR marca REGEXP '" + datos+ "' OR descripcion REGEXP '" + datos+ "' OR preciounitario REGEXP '" + datos+"' AND baja=0 LIMIT 25;";
                DataTable dt;//se crea la tabla dt
                dt = _cnn.seleccionar(sql);//se le asigna a la tabla dt lo que trae la consulta sql
                //sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
                //sql += "'" + DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss") + "','Producto','Buscando producto "+datos+"')";//se hace una consulta insert sobre la tabla bitacora que se encuentra en la BD
                //_cnn.seleccionar(sql);// se conecta la transaccion sql mediante la variable de conexion _cnn 
                return dt;//retorna lo que trae la tabla dt
            }
            catch (Exception)
            {

                throw;
            }
        }
       public DataTable Listar(int paginaInicial, int tamanio)//publica la tabla de memoria que se encarga de listar la consulta
        {
            try//inicia el bloque try
            {
                string sql = string.Empty;//asignacion de la variable sql como vacia 
                sql = "select idproducto,nombre,marca,descripcion,";//cadena de conexión que hace una consulta select sobre la BD
                sql += "idproveedor,fechacompra,preciounitario,idCategoria,imagen,stockMin,stockMax,existencia,codigoBarras from producto where baja=0 LIMIT "+ paginaInicial +","+ tamanio +"";
                DataTable dt;//se crea la tabla dt
                dt = _cnn.seleccionar(sql);//se le asigna a la tabla dt lo que trae la consulta sql
                //sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
                //sql += "'" + DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss") + "','Producto','Listando Productos')";//se hace una consulta insert sobre la tabla bitacora que se encuentra en la BD
                //_cnn.seleccionar(sql);// se conecta la transaccion sql mediante la variable de conexion _cnn 
                return dt;//retorna lo que trae la tabla dt

            }
            catch (Exception)//en caso de que no se cumpla lo que hay adentro del bloque try manda una Exception
            {
                throw;
            }
        }
        public bool Actualizar(string campo, int clave, Hashtable nuevosProductos)//se publica un metodo del tipo boolean con el nombre Actualizar que trae los datos de Hashtable 
        {
            bool seguir = false;//declara la variable booleana seguir y la inicializa como vacia 
            try//inicia el bloque try-catch
            {
                _cnn.Actualizar("producto", campo, clave, nuevosProductos);//se conecta con la BD con la variable _cnn y hace referencia a Actualizar los nuevos Productos 
                string sql = string.Empty;
                sql = "insert into Bitacora(fechahora,tabla,comentario) values(";
                sql += "'" + DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss") + "','Producto','Actualizando Producto con Clave Num. " + int.Parse(clave.ToString()) +"')";
                _cnn.seleccionar(sql);
                seguir = true; //si se cumple la instruccion anterior se inicializa la variable seguir en verdadero 
                
            }
            catch (Exception)//en caso de que suceda una exepción dentro del bloque try se manda un Exception
            {
                seguir = false;//se inicializa la variable seguir en falso
            }
            finally
            {
            }
            return seguir;//retorna ala variable seguir 
        }
        public bool Guardar(Hashtable[] Productos)//publica al metodo guardar que trae el Hashtable de tipo Productos 
        {
            bool continuar = false;//declara la variable booleana continuar a la cual se inicializa como falso
            try//inicia el bloque de instrucciones try-catch
            {
                _cnn.Insertar("producto", Productos);//se envia lo que trae el metodo insertar a la variable de conexión a la BD osea a _cnn
                continuar = true;//se le asigna verdadero a la variable continuar
            }
            catch (Exception)//En caso de que ocurra alguna exepción en tiempo de ejecucion el catch lo atrapa y manda la exepción ala variable ex
            {
                continuar = false;//se le asigna a la variable booleana continuar como falso
            }
            finally
            {
            }
            return continuar;//retorna lo que trae la variable continuar
        }
    }

}
