#region Referencias
using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
#endregion

namespace Datos.Compras
{
 public class clsCompras//publicacion de la clase compras 
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();
        public bool Eliminar(int clave)//publicacion del metodo booleano eliminar
      {
          string sql = "UPDATE Compra SET baja=1 WHERE idcompra =" + clave;
          _cnn.seleccionar(sql);
          return true;

      }
      #region Constructor
      public clsCompras() { }
      #endregion                                   
      #region Destructor
      ~clsCompras()
      {
          _cnn = null;
      }
      #endregion
      public DataTable Buscar(int clave)
      {
          try
          {
              string sql = string.Empty;
              sql = "select * from Compra where idcompra=" + clave;
              DataTable DT;
              DT = _cnn.seleccionar(sql);
               sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
              sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','compra','busqueda de producto con clave"+clave+"')";
              _cnn.seleccionar(sql);
              return DT;
          }
          catch (Exception)
          {
              throw;
          }
      }
      public DataTable Listar()
      {
          try
          {
              string sql = string.Empty;
              sql = "select idproducto,nombre,marca,descripcion,";
              sql += "idproveedor,fechacompra from Producto where baja=0;";
              DataTable dt;
              dt = _cnn.seleccionar(sql);
              sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
              sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','producto','seleccion de productos')";
              _cnn.seleccionar(sql);
              return dt;

          }
          catch (Exception)
          {
              throw;
          }
      }
      public bool Actualizar(string campo, int clave, Hashtable nuevosProductos)
      {
          bool seguir = false;
          try
          {
              _cnn.Actualizar("Producto", campo, clave, nuevosProductos);

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
        public bool Guardar(long folio, DateTime fecha, int ClaveProveedor, Hashtable[] Productos)
        {
            bool continuar = false;
            try
            {
                string _sql = "INSERT INTO compra (idcompra, fechacompra, fecharegistro, idproveedor) ";
                _sql += " values (" + folio + ", '" + fecha.ToString("yyyyMMdd HH:mm:ss") + "','" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "'," + ClaveProveedor + ")";
                _cnn.InsertarCompra(_sql, "ProductoCompra", Productos);
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