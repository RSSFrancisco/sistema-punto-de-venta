using System;
using System.Data;
using System.Collections;

namespace Datos
{
   public class clsProductosVenta
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();

        #region Constructor
        public clsProductosVenta()
            {

            }
        #endregion
        #region Destructor
        ~clsProductosVenta()
        {
            _cnn = null;
        }
        #endregion
        #region Metodos Públicos
        public bool Eliminar(int clave)
        {
            string sql = "DELETE FROM tb_productos_venta WHERE idProductosVenta=" + clave + ";";
            DataTable dt; 
            dt = _cnn.seleccionar(sql);

            return true;//retorna verdadero
        }
        public bool Guardar(Hashtable[] Ventas)
        {
            bool continuar = false;
            try
            {
                _cnn.Insertar("tb_productos_venta", Ventas);
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

        public DataTable ListarProductosVenta(int num_venta)
        {
            try
            {
                string sql = string.Empty;
                sql = "select tb_productos_venta.idProductosVenta,producto.idproducto,producto.codigoBarras,tb_productos_venta.idVenta, producto.nombre,producto.descripcion,producto.preciounitario,tb_productos_venta.cantidad,tb_productos_venta.subtotal from producto inner join tb_productos_venta on producto.idproducto=tb_productos_venta.idproducto where tb_productos_venta.idVenta =" + num_venta+"";
                DataTable dt;
                dt = _cnn.seleccionar(sql);
               
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }
        //public DataTable calcularTotalVenta(int num_venta)
        //{
        //    try
        //    {
        //        string sql = string.Empty;
        //        sql = "select sum(subtotal) as total from tb_productos_venta where num_venta="+num_venta+"";
        //        DataTable dt;
        //        dt = _cnn.seleccionar(sql);
        //        return dt;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        public DataTable verificarProductoVenta(int idProducto,int num_venta)
        {
            try
            {
                string sql = string.Empty;
                sql = "select idProductosVenta from tb_productos_venta where idproducto='"+idProducto+"' and idVenta='"+num_venta+"' ";
                DataTable dt;
                dt = _cnn.seleccionar(sql);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Actualizar(string campo, int clave, Hashtable nuevosProductosVenta)//se publica un metodo del tipo boolean con el nombre Actualizar que trae los datos de Hashtable 
        {
            bool seguir = false;//declara la variable booleana seguir y la inicializa como vacia 
            try//inicia el bloque try-catch
            {
                _cnn.Actualizar("tb_productos_venta", campo, clave, nuevosProductosVenta);//se conecta con la BD con la variable _cnn y hace referencia a Actualizar los nuevos Productos 
              
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
        #endregion

    }
}
