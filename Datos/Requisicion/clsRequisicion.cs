#region Referencias
using System;//libreria de la interfaz del sistema
using System.Collections.Generic;//libreria Collections
using System.Collections;
using System.Data;//libreria que hace uso de los datos del sistema 
#endregion

namespace Datos
{
   public class clsRequisicion
    {
        conexion _cnn = new conexion();//inicia una nueva conexion ala BD y se la asigna a la variable _cnn
        //conexionSQLite _cnn = new conexionSQLite();
        public bool LimpiarPapelera()
       {
           string sql = "DELETE FROM requisicion WHERE baja=1";
           DataTable dt;
           dt = _cnn.seleccionar(sql);
           sql = "insert into Bitacora(fechahora ,tabla,comentario) values(";
           sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Servicio','Limpiando Papelera de reciclaje')";
           _cnn.seleccionar(sql);
           return true;
       }
       public bool ObtenerFolioFilas()
       {
           string sql = "select isnull(MAX(totalfilas),0) AS folio from Requisicion";
           DataTable dt;
           dt = _cnn.seleccionar(sql);
           return true;
       }
       public bool BorraPermanente(int clave)
       {
           string sql = "DELETE FROM requisicion WHERE folio=" + clave;
           DataTable dt;
           dt = _cnn.seleccionar(sql);
           sql = "insert into Bitacora(fechahora ,tabla,comentario) values(";
           sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Servicio','Eliminado el servicio Permanentemente')";
           _cnn.seleccionar(sql);
           return true;
       }
       public bool Eliminar(int clave)
       {
           string sql = "update requisicion set baja=1 where folio=" + clave;
           DataTable dt;
           dt = _cnn.seleccionar(sql);
           sql = "insert into Bitacora(fechahora ,tabla,comentario) values(";
           sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Servicio','Eliminado el servicio')";
           _cnn.seleccionar(sql);
           return true;

       }
       public clsRequisicion() { }
       ~clsRequisicion()
       {
           _cnn = null;
       }
       
       public DataTable Listar()
       {

           try
           {
               string sql = string.Empty;
               sql = "select * from requisicion where baja=0";
               DataTable dt;
               dt = _cnn.seleccionar(sql);
               return dt;
           }
           catch (Exception)
           {
               
               throw;
           }
       }
       public DataTable ListarTodo()
       {

           try
           {
               string sql = string.Empty;
               sql = "select * from requisicion";
               DataTable dt;
               dt = _cnn.seleccionar(sql);
               return dt;
           }
           catch (Exception)
           {

               throw;
           }
       }
    
       public DataTable ListarAscendente()
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from requisicion where baja=0 order by folio asc");
               string sql = "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Requisicion','Listando en forma Ascendente')";
               return dt;
           }
           catch (Exception)
           {
               
               throw;
           }
       }
       public DataTable ListarDecendente()
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from requisicion where baja=0 order by folio desc;");
               string sql = "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Requisicion','Listando en forma Descendente')";
               return dt;
           }
           catch (Exception)
           {

               throw;
           }
       }
     
       public DataTable ListarPorCliente(string cliente)
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from requisicion where cliente like '" + cliente+"%' and baja=0;");
               return dt;
           }
           catch (Exception)
           {
               
               throw;
           }
       }
       public DataTable ListarPorEmpleado(string empleado)
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from requisicion where empleado like '" + empleado+"%' and baja=0;");
               return dt;
           }
           catch (Exception)
           {
               
               throw;
           }

       }
       public DataTable ListarPorFecha(DateTime fecha)
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from requisicion where fecha like '" + fecha+"%' and baja=0;");
               return dt;
           }
           catch (Exception)
           {
               
               throw;
           }
       }
       public DataTable ListarPorTopUltimo()
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from requisicion where baja=0 order by folio desc Limit 1;");//consulta que me trae solo la ultima fila de mi lista de requisiciones
               return dt;
           }
           catch (Exception)
           {
               
               throw;
           }

       }
       public DataTable ListarEliminados()
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from requisicion where baja=1 order by folio desc;");//consulta que me trae solo la ultima fila de mi lista de requisiciones
               return dt;
           }
           catch (Exception)
           {

               throw;
           }

       }
       public DataTable ListarRecientes()
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from requisicion where baja=0 order by fecha desc");//consulta que me trae solo la ultima fila de mi lista de requisiciones
               return dt;
           }
           catch (Exception)
           {

               throw;
           }

       }
       public DataTable ListarAntiguos()
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from requisicion where baja=0 order by fecha asc");//consulta que me trae solo la ultima fila de mi lista de requisiciones
               return dt;
           }
           catch (Exception)
           {

               throw;
           }

       }
       
       public bool Actualizar(string campo, int clave, Hashtable nuevaRequisicion)
       {
           bool seguir = false;
           try
           {
               _cnn.Actualizar("Requisicion", campo, clave, nuevaRequisicion);
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
       public bool GuardarRequisicion(Hashtable[] Requisiciones)
       {
           bool continuar = false;
           try
           {
               _cnn.Insertar("Requisicion", Requisiciones);
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
       public long ObtenerFolio() {
           DataTable dt = _cnn.seleccionar("select isnull(MAX(totalfilas),0) AS folio from Requisicion");     
           return (long.Parse(dt.Rows[0].ItemArray[0].ToString())+1);
       }

       public bool Guardar(Hashtable Datos, Hashtable []Productos, Hashtable []Servicios) {
           try
           {
               _cnn.InsertarRequisicion(Datos, Productos, Servicios);
               return true;
           }
           catch (Exception ex)
           {
               
               throw new Exception(ex.Message);
           }
       }
    }
}
