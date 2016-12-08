#region Referencias
using System;//libreria que hace uso de el entorno del sistema operativo
using System.Collections.Generic;//libreria que hace uso de la coleccion de datos del sistema 
using System.Data;//libreria que hace uso de los  datos del sistema 
using System.Collections;
#endregion

namespace Datos
{
  public  class clsContacto//publicacion de la clase clsContacto
  {
        #region Variables Privadas
        /// <summary>
        /// variable que hacer referencia ala clase conexion
        /// </summary>
        conexion _cnn = new conexion();//se crea una instancia del objeto _cnn que va hacia la clase conexion
        //conexionSQLite _cnn = new conexionSQLite();
      /// <summary>
      /// Metodo encargado de eliminar los registros de la clase 
      /// </summary>
      /// <param name="clave">parametro usado para hacer referencia al registro que se desea eliminar</param>
      /// <returns>regresa un resultado</returns>
        public bool Eliminar(int clave)//declaracion del metodo Eliminar con la variable clave del tipo entero
       
       
        {
            string sql = "DELETE FROM Contacto WHERE idcontacto =" + clave;//se le asigna la variable sql lo que trae la consulta Update mas la clave 
         
            DataTable dt;//crea la tabla de memoria dt
            dt = _cnn.seleccionar(sql);//se le asigna la cadena de conexion  a la variable de dt
            sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
            sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','contacto','eliminar contacto')";//transacción sql que envia a la tabla Bitacora si se llevo a cabo alguna inserción
            _cnn.seleccionar(sql);//se le asigna ala variable _cnn.seleccionar lo que trae la cadena sql 
            return true;//retorna verdadero si se cumple el bloque de instrucciones anterior

        }
         #endregion
      /// <summary>
      /// constructor de la clase contacto
      /// </summary>
        #region Constructor
        public clsContacto() { }//se inicializa el constructor de la clase clsContaco
        #endregion

        #region Destructor
      /// <summary>
      /// Destructor de la clase contacto
      /// </summary>
        ~clsContacto()//destruccion de la clase de tipo Contacto
        {
            _cnn = null;//asigna ala variable _cnn como vacia 
        }
        #endregion
        #region Metodos Públicos 
      /// <summary>
      /// Tabla que enlista mis datos de la clase contacto
      /// </summary>
      /// <returns></returns>
        public DataTable Listar()//publica la tabla de memoria para Listar
        {
            try//inicia el bloque try
            {
                string sql = string.Empty;//si la variable sql esta vacia 
                sql = "select idcontacto,nombre,appaterno,apmaterno,";//cadena sql que hace una consulta ala BD
                sql += "telefono,extencion,correo,puesto,idempresa from Contacto where baja=0;";
                DataTable dt;//declaración de la tabla dt 
                dt = _cnn.seleccionar(sql);//se le asigna a la tabla dt la cadena que trae la consulta que se hace a la BD
                sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
                sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','contacto','Listar contacto')";//intruccion sql que envia datos a la tabla Bitacora si se hizo una consulta 
                _cnn.seleccionar(sql);//se manda la transacción sql ala variable de conexion _cnn.seleccionar
                return dt;//retorna la tabla dt
               
            }
            catch (Exception)//catch que atrapa el error si es que no se cumple el try
            {
                throw;
            }
        }
      /// <summary>
      /// Metodo que sirve para actualizar los Contactos
      /// </summary>
      /// <param name="campo">Atributo de Contacto</param>
      /// <param name="clave">Clave de IdContacto</param>
      /// <param name="nuevosContactos">Nuevos Contactos de la Clase Contactos</param>
      /// <returns></returns>
        public bool Actualizar(string campo, int clave, Hashtable nuevosContactos)//publica la variable actualizar del tipo booleano
        {
            bool seguir = false;// se le asigna ala variable seguir como falso
            try//inicia el bloque try-catch
            {

                _cnn.Actualizar("Contacto", campo, clave, nuevosContactos);//se le envia a la variable de conexión lo que trae Contacto 

                
              string  sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
                sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','contacto','actualizar datos del contacto "+clave+"')";
                seguir = true;//se le asigna como verdadero a la variable seguir
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
      /// <summary>
      /// metodo encargado de guardar los registros de la clase contacto en la base de datos
      /// </summary>
      /// <param name="Contactos"></param>
      /// <returns></returns>
        public bool Guardar(Hashtable[] Contactos)
        {
            bool continuar = false;//se crea la variable booleana continuar y se inicializa como falso
            try//inicia el bloque de instrucciones try-catch
            {
                _cnn.Insertar("Contacto", Contactos);//al objeto _cnn se le asignan los parametros que trae la instruccion insertar
                string sql = "insert into Bitacora (fechahora,tabla,comentario) values(";
                sql += "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "','contacto','Guardar datos del contacto  ')";
                continuar = true;//si el bloque de instrucciones anterior se cumple correctamente a la variable continau se le asigna como verdadera
            }
            catch (Exception)
            {
                continuar = false;//si ocurre una exepcion a la variable continuar se le asigna como falso
            }
            finally
            {
            }
            return continuar;//se retorna lo que trae la variable continuar
        }
  }
        #endregion

}
