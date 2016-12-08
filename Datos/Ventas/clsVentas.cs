#region leeme
/* Capa:Datos
 * Clase: clsVentas
 * Autor: Ing.Francisco Reyes Sanchez
 * Fecha de creación: 29/09/2016
*/
#endregion
#region Referencias
using System;
using System.Data;
using System.Collections;
#endregion
namespace Datos
{
    public class clsVentas
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();
        public bool Eliminar(int clave)
        {
            string sql = "DELETE FROM  tb_ventas WHERE idVenta ='" + clave + "';";//declaracion de la transaccion sql en la cual actualiza los productos más la clave
            DataTable dt;//creacion de la tabla de memoria 
            dt = _cnn.seleccionar(sql);//asigna la cadena de conexion a la tabla de memoria dt

            return true;//retorna verdadero
        }
        #region Constructor
        public clsVentas()
        {
        }
        #endregion
        #region Destructor
        ~clsVentas()//desctruccion de la clase clsProducto
        {
            _cnn = null;//inicia la variable _cnn en vacio
        }
        #endregion
        public DataTable BuscarVenta(string buscar)
        {
            try
            {
                string sql = string.Empty;
                sql = "SELECT tb_ventas.idVenta,empresa.nombre AS cliente,empleado.nombre AS atendio,tb_ventas.fecha,tb_ventas.importe,tb_ventas.cambio,tb_ventas.total FROM tb_ventas  ";
                sql += " INNER JOIN empresa ON empresa.idempresa = tb_ventas.idCliente INNER JOIN empleado ON empleado.idempleado = tb_ventas.idEmpleado  ";
                sql += " WHERE tb_ventas.idVenta='"+buscar+ "' OR empresa.nombre RLIKE '" + buscar + "' OR empleado.nombre RLIKE '" + buscar + "' OR tb_ventas.fecha RLIKE '" + buscar + "' OR tb_ventas.importe RLIKE '" + buscar + "' ";
                sql += " OR tb_ventas.cambio RLIKE '" + buscar + "' OR tb_ventas.total RLIKE '" + buscar + "'  ORDER BY tb_ventas.fecha DESC LIMIT 0,25";
                DataTable dt;
                dt = _cnn.seleccionar(sql);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Fecha de creación: 08/10/2016 
        // Ing.Francisco Reyes Sánchez
        public DataTable BuscarVentaPorClave(int clave)
        {
            try
            {
                string sql = string.Empty;
                sql = "SELECT tb_ventas.idVenta,empresa.idempresa,empleado.idempleado,tb_ventas.fecha,tb_ventas.importe,tb_ventas.cambio,tb_ventas.total FROM tb_ventas  ";
                sql += " INNER JOIN empresa ON empresa.idempresa = tb_ventas.idCliente INNER JOIN empleado ON empleado.idempleado = tb_ventas.idEmpleado  ";
                sql += " WHERE tb_ventas.idVenta="+clave+" LIMIT 0,1";
                DataTable dt;
                dt = _cnn.seleccionar(sql);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable BuscarVentaHoy()
        {
            try
            {
                string fechaHoy = DateTime.Now.ToShortDateString();
                string sql = string.Empty;
                sql = "SELECT tb_ventas.idVenta,empresa.nombre AS cliente,empleado.nombre AS atendio,tb_ventas.fecha,tb_ventas.importe,tb_ventas.cambio,tb_ventas.total FROM tb_ventas  ";
                sql += " INNER JOIN empresa ON empresa.idempresa = tb_ventas.idCliente INNER JOIN empleado ON empleado.idempleado = tb_ventas.idEmpleado  ";
                sql += " WHERE tb_ventas.fecha RLIKE '"+fechaHoy+"' ";

                DataTable dt;
                dt = _cnn.seleccionar(sql);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        } 
        public DataTable BuscarPorSemana(string semana)
        {
            try
            {
                string sql = string.Empty;
                sql = "SELECT tb_ventas.idVenta,empresa.nombre AS cliente,empleado.nombre AS atendio,tb_ventas.fecha,tb_ventas.importe,tb_ventas.cambio,tb_ventas.total FROM tb_ventas  ";
                sql += " INNER JOIN empresa ON empresa.idempresa = tb_ventas.idCliente INNER JOIN empleado ON empleado.idempleado = tb_ventas.idEmpleado  ";
                sql += " WHERE tb_ventas.fecha RLIKE '" + semana + "' LIMIT 0,25 ";

                DataTable dt;
                dt = _cnn.seleccionar(sql);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable Listar(int numeroPagina, int tamanio)
        {
            try
            {
                string sql = string.Empty;//asignacion de la variable sql como vacia 
                sql = "select tb_ventas.idVenta,empresa.nombre as cliente,empleado.nombre as atendio,tb_ventas.fecha,tb_ventas.importe,tb_ventas.cambio,tb_ventas.total FROM tb_ventas "; 
                   sql+= " inner join empresa on empresa.idempresa = tb_ventas.idCliente inner join empleado on empleado.idempleado = tb_ventas.idEmpleado ORDER BY tb_ventas.fecha DESC LIMIT "+numeroPagina+","+tamanio+"";
                DataTable dt;//se crea la tabla dt
                dt = _cnn.seleccionar(sql);//se le asigna a la tabla dt lo que trae la consulta sql
                return dt;//retorna lo que trae la tabla dt

            }
            catch (Exception)//en caso de que no se cumpla lo que hay adentro del bloque try manda una Exception
            {
                throw;
            }
        }
      public DataTable listarProductosVenta(int clave)
        {
            try
            {
                string sql = string.Empty;//asignacion de la variable sql como vacia 
                sql = "select * from tb_producto_venta where idVenta=" + clave+" and baja=0;";
                DataTable dt;//se crea la tabla dt
                dt = _cnn.seleccionar(sql);//se le asigna a la tabla dt lo que trae la consulta sql
                return dt;//retorna lo que trae la tabla dt
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable ListarUltimoProductosVenta()
        {
            try
            {
                string sql = string.Empty;//asignacion de la variable sql como vacia 
                sql = "select * from tb_producto_venta where baja=0 order by desc LIMIT 0,1;";
                DataTable dt;//se crea la tabla dt
                dt = _cnn.seleccionar(sql);//se le asigna a la tabla dt lo que trae la consulta sql
                return dt;//retorna lo que trae la tabla dt
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Guardar(Hashtable[] Ventas)
        {
            bool continuar = false;
            try
            {
                _cnn.Insertar("tb_ventas", Ventas);
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
        public bool GuardarProductoVenta(Hashtable[] ProductoVenta )
        {
            bool continuar = false;
            try
            {
                _cnn.Insertar("tb_producto_venta", ProductoVenta);
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
        // Obtiene el ultimo id registrado en la tabla tb_ventas
        public int ObtenerFolio()
        {

            DataTable dt = _cnn.seleccionar("SELECT MAX(idVenta) AS folio FROM tb_ventas");
            string folio =Convert.ToString(dt.Rows[0].ItemArray[0]);
            if (folio=="NULL" || folio=="")
            {
                return 1;
            }else
            {
                return (int.Parse(dt.Rows[0].ItemArray[0].ToString()) + 1);
            }
          
            
        }
    }
}
