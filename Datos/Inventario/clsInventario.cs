using System;
using System.Data;
using System.Collections;

namespace Datos
{
  public class clsInventario:clsVentas
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();
        public DataTable ListarInventario(int numeroPagina, int tamanio)
        {
            try
            {
                string sql = string.Empty;
                sql = "select tb_ventas.idVenta,empresa.nombre as cliente,empleado.nombre as atendio,tb_ventas.fecha,tb_ventas.importe,tb_ventas.cambio,tb_ventas.total FROM tb_ventas ";
                sql += " inner join empresa on empresa.idempresa = tb_ventas.idCliente inner join empleado on empleado.idempleado = tb_ventas.idEmpleado  WHERE empresa.nombre='Inventario' ORDER BY tb_ventas.fecha DESC LIMIT " + numeroPagina + "," + tamanio + "";
                DataTable dt;
                dt = _cnn.seleccionar(sql);
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
