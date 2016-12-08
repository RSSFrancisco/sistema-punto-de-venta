#region librerias
using System;
using System.Data;
#endregion

namespace Datos
{
   public class clsHistorial
    {
        conexion _cnn = new conexion();
        //conexionSQLite _cnn = new conexionSQLite();
        #region Constructor
       public clsHistorial() { }
        #endregion
        #region Destructor
       ~clsHistorial()
       {
           _cnn = null;
       }
        #endregion

       public bool Eliminar(int clave)
       {
           string sql = "DELETE FROM bitacora WHERE idHistorial=" + clave;
           DataTable dt;
           dt = _cnn.seleccionar(sql);
           return true;
       }
       public DataTable Listar(int paginaInicial, int tamanio)
       {
           try
           {
               string sql = string.Empty;
               sql = "SELECT * FROM bitacora ORDER BY idHistorial DESC LIMIT "+paginaInicial+","+tamanio+"";
               DataTable dt;
               dt = _cnn.seleccionar(sql);
               return dt;
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    
       public DataTable ListarPorTabla(string tabla)
       {
           try
           {
               string sql = string.Empty;
               sql = "SELECT * FROM bitacora WHERE tabla LIKE '" + tabla + "%';";
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
