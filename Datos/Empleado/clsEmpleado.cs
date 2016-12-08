#region Referencias
using System;//libreria que hace uso del sistema
using System.Collections;
using System.Data;

#endregion

namespace Datos
{
   public class clsEmpleado //publica la clase clsEmpleado
   {
        #region Variables Privadas
        /// <summary>
        /// Variable que hace referencia ala clase conexion
        /// </summary>
        conexion _cnn = new conexion();//se le asigna al objeto _cnn lo que trae la clase conexion
        //conexionSQLite _cnn = new conexionSQLite();
        public bool empleado(Hashtable[] campos)
       {
           _cnn.Insertar("empleado", campos);
         
           //string sql = "UPDATE empleado set estatus=1 where idempleado="+campos;
           return true;
       }

       /// <summary>
       /// Metodo encargado de eliminar los registros de la clase
       /// </summary>
       /// <param name="clave">parametro usado para hacer referencia al registro que se desea eliminar</param>
       /// <returns>Regresa un resultado</returns>
       public bool Eliminar(int clave)
       {
           string sql = "DELETE FROM empleado WHERE idempleado =" + clave;
           DataTable dt;
           dt = _cnn.seleccionar(sql);
          /* sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
           sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Empleado','eliminar empleado')";
           _cnn.seleccionar(sql);*/
           return true;

       }
       #endregion
        //public bool BuscarEmpleado(string nombre)
        //{
        //    try
        //    {
        //        string sql = "select * from Empleado where nombre like '" + nombre + "%'";
        //        DataTable dt;
        //        dt = _cnn.seleccionar(sql);
        //        sql = "insert into Bitacora(fechahora,tabla,comentario) values(";
        //        sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Empleado','Buscar empleado')";
        //        _cnn.seleccionar(sql);
        //        return true;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
       
       public DataTable BuscarPorNombre(string nombre)//publicación de la tabla de memoria DataTable Buscar con la variable clave
       {
           try//inicia el bloque try
           {
               string sql = string.Empty;//asigna como vacia la instruccion sql 
               sql = "select * from Empleado where baja=0 and nombre like '" + nombre + "%'";//inicia la transaccion sql para consultar la tabla productos
               DataTable DT;//creacion de la tabla de memoria DT
               DT = _cnn.seleccionar(sql);//se le asigna la transaccion sql ala tabla de memoria DT
               return DT;//retorna lo que lleva DT
           }
           catch (Exception)//atrapa la exepcion si que hay una 
           {
               throw;
           }
       }
       
 
       #region Constructor
       /// <summary>
       /// constructor de la clase Empleado
       /// </summary>
       public clsEmpleado() { }
       #endregion
       #region Destructor
       /// <summary>
       /// Destructor de la clase Empleado
       /// </summary>
       ~clsEmpleado()
       {
           _cnn = null;
       }
       #endregion
       #region  Metodos Públicos
       public bool AgregarUsuario(Hashtable[] campos,int estatus){//publicacion del metodo booleano agregar usuario 
           try//inicia el bloque try-catch
           {
               _cnn.Insertar("usuario", campos);

               string sql = "UPDATE empleado SET estatus=1 WHERE idempleado =" + estatus;
               DataTable dt;
               dt = _cnn.seleccionar(sql);
               //se le manda a la instancia _cnn lo que trae los campos mas la funcion inertar
               return true;//si se cumple el bloque de instrucciones anterior entonces retorna verdadero
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
       }
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public DataTable sinUsuario()
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select * from Empleado where estatus=0 and baja=0;");
           
             
              /*string sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
               sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Empleado','seleccinando empleado')";*/
               return dt;
           }
           catch (Exception)
           {
               throw;
           }
       }
       
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
      
       public DataTable Listar()
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select idempleado,nombre,appaterno,apmaterno,nss,fechanacimiento,direccion,colonia,ciudad,estado,cp,telefono,correo,nivelescolar,especialidad from Empleado where baja=0 order by idempleado desc");
             
           
             /*string  sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
               sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Empleado','listando empleado')";*/
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
               dt = _cnn.seleccionar("select idempleado,nombre,appaterno,apmaterno,nss,fechanacimiento,direccion,colonia,ciudad,estado,cp,telefono,correo,nivelescolar,especialidad from Empleado where baja=0 order by idempleado asc");


              /* string sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
               sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Empleado','listando empleado')";*/
               return dt;
           }
           catch (Exception)
           {
               throw;
           }
       }
       public DataTable ListarDescendente()
       {
           try
           {
               DataTable dt;
               dt = _cnn.seleccionar("select idempleado,nombre,appaterno,apmaterno,nss,fechanacimiento,direccion,colonia,ciudad,estado,cp,telefono,correo,nivelescolar,especialidad from Empleado where baja=0 order by idempleado desc");


              /* string sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
               sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Empleado','listando empleado')";*/
               return dt;
           }
           catch (Exception)
           {
               throw;
           }
       }
       public DataTable ListarEntre(string minimo, string maximo)
       {
           try
           {
               DataTable dt;
               dt =_cnn.seleccionar("select * from Empleado where idempleado>="+minimo+" and idempleado<="+maximo+" order by idempleado asc");
               return dt; 
           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message);
           }
       }
       public DataTable ListarApellidoPaterno(string appaterno)
       {
           try
           {
               DataTable dt;
               string sql=("select * from Empleado where baja=0 and appaterno like '"+appaterno+"%' order by appaterno asc;");
               dt = _cnn.seleccionar(sql);//se le asigna la transaccion sql ala tabla de memoria DT
               
               return dt;
           }
           catch (Exception)
           {
               throw;
           }
       }
       public DataTable ListarNombre(string nombre)
       {
           try
           {
               DataTable dt;
               string sql = ("select * from Empleado where baja=0 and nombre like '"+nombre+"%' order by nombre asc;");
               dt = _cnn.seleccionar(sql);//se le asigna la transaccion sql ala tabla de memoria DT

               return dt;
           }
           catch (Exception)
           {
               throw;
           }
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="Empleados"></param>
       /// <returns></returns>
       public bool Guardar(Hashtable []Empleados){
           bool continuar =false;
           try
           {
               _cnn.Insertar("Empleado",Empleados);
            
               
             /* string sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
               sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Empleado','guardando empleado')";*/
               continuar=true;
           }
           catch(Exception)
           {
               continuar=false;
           }
           finally{
           }
           return continuar;
         }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="campo"></param>
       /// <param name="clave"></param>
       /// <param name="nuevosEmpleados"></param>
       /// <returns></returns>
       public bool Actualizar(string campo, int clave, Hashtable nuevosEmpleados)
       {
           bool seguir = false;
           try
           {
               _cnn.Actualizar("Empleado", campo, clave, nuevosEmpleados);
              
             
            /*  string sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
               sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','Empleado','actualizando empleado "+clave.ToString()+"')";
               _cnn.seleccionar(sql);*/
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
      
   }
    
       #endregion

}

