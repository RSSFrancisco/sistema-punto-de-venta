#region Librerias
using System;//libreria que hace uso de la interfaz de sistema 
using System.Collections.Generic;
using System.Collections;//libreria que hace uso de la coleccion de datos del sistema
using System.Data;
using Datos;
#endregion
namespace Negocios
{
 public class RegistrarContacto:CollectionBase
    {
        #region Variables Privadas
        clsContacto _oContacto = new clsContacto();//declaracion instancia de la clase clsContacto
        #endregion

        #region Metodos de la coleccion base
        public int Add(Contacto NuevoContacto)//publicacion de la funcion agregar NuevoContacto
        {
            return (List.Add(NuevoContacto));//retorna lo que se agrego en la lista del NuevoContacto
        }
        public int IndexOf(Contacto PosicionDelContacto)//publicacion de la propiedad IndexOf para la posicion del contacto
        {
            return (List.IndexOf(PosicionDelContacto));//retorna lo que trae del indice de la lista del contacto

        }
        public void Insert(int Indice/*variable entera Indice*/, Contacto InsertarContacto)//publicacion del metodo Insert 
        {
            List.Insert(Indice, InsertarContacto);//lista lo que se inserto en el indice 
        }
        #endregion
        #region Sobreescritura de métodos.
        protected override void OnInsert(int index, Object value)//metodo que sobreescribe lo que inserta el metodo insert en el indice 
        {
            if (value.GetType() != Type.GetType("Negocios.Contacto"))//si el valor que se consigue es diferente de lo que trae Negocios.Contacto
                throw new ArgumentException("El valor debe ser del tipo Contacto.", "Contacto");

        }

        protected override void OnRemove(int index/*varible entera index*/, Object value)//metodo que elimina lo que trae la instancia 
        {
            if (value.GetType() != Type.GetType("Negocios.Contacto"))//si el valor que se consigue es diferente de lo que trae Negocios.Contacto
                throw new ArgumentException("El valor debe ser del tipo Contacto.", "Contacto");
        }

        protected override void OnSet(int index, Object oldValue, Object newValue)//metodo envia al indice el valor del nuevo objeto
        {
            if (newValue.GetType() != Type.GetType("Negocios.Contacto"))//si el valor que se consigue es diferente de lo que trae Negocios.Contacto
                throw new ArgumentException("El nuevo valor debe ser del tipo Contacto.", "NuevoContacto");
        }

        protected override void OnValidate(Object value)//metodo que valida lo que trae dentro la instancia 
        {
            if (value.GetType() != Type.GetType("Negocios.Contacto"))//si el valor que se consigue es diferente de lo que trae Negocios.Contacto
                throw new ArgumentException("El valor debe ser del tipo Contacto.");
        }
        #endregion

        /// <summary>
     /// lista de la clase contacto
     /// </summary>
     /// <returns></returns>
        public List<Contacto> Listar()//publica´ción del metodo listar para la clase Contacto  
        {
            try//inicia el bloque try-catch
            {
                DataTable dt = _oContacto.Listar();//creacion de la tabla de memoria dt y asignacion de lo que trae _oContacto
                if (dt != null)//si dt es diferente de vacio
                {
                    List<Contacto> misContactos = new List<Contacto>();//asignacion de la isntancia misContactos lo que trae la nueva lista de la clase Contacto 
                    foreach (DataRow dr in dt.Rows)//se hace un foreach sobre la tabla de memoria y se crea una instancia dr
                    {
                        Contacto c = new Contacto();//creacion de la instancia c de tipo contacto
                        c.Clave = int.Parse(dr["idcontacto"].ToString());//se le asigna a la instacia c lo que trae idContacto
                        c.Nombre = dr["nombre"].ToString();//se le asigna a la instacia c lo que trae nombre
                        c.ApellidoPaterno = dr["appaterno"].ToString();//se le asigna a la instacia c lo que trae appaterno
                        c.ApellidoMaterno = dr["apmaterno"].ToString();//se le asigna a la instacia c lo que trae apmaterno
                        c.Telefono = dr["telefono"].ToString();//se le asigna a la instacia c lo que trae telefono
                        c.Extension = dr["extencion"].ToString();//se le asigna a la instacia c lo que trae extension
                        c.Correo = dr["correo"].ToString();//se le asigna  a la instacia c lo que trae correo
                        c.Puesto = dr["puesto"].ToString();//se le asigna a la instacia c lo que trae puesto
                        c.Idempresa = int.Parse(dr["idempresa"].ToString());//se le asigna a la instacia c lo que trae idempresa
                        misContactos.Add(c);//se le agrega a misContactos lo que trae la instacia c
                        c = null;//se inicializa c en vacio
                    }
                    return misContactos;//retorna lo que trae misContactos

                }
                else//en caso de que no se cumpla el bloque de instrucciones anterior
                {
                    return null;//retorna en vacio
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
     /// <summary>
     /// metodo actualizar de la clase contacto
     /// </summary>
     /// <param name="c"></param>
     /// <returns></returns>
        public bool Actualizar(Contacto c)//publicacion del metodo booleano Actualizar
        {
            try//inicia el bloque try-catch
            {
                Hashtable ht = new Hashtable();//se crea un Hashtable 
                ht.Add("nombre", c.Nombre);//al objeto ht se le agrega lo que trae la instacia c.Nombre
                ht.Add("appaterno", c.ApellidoPaterno);//al objeto ht se le agrega lo que trae la instacia c.ApellidoPaterno
                ht.Add("apmaterno", c.ApellidoMaterno);//al objeto ht se le agrega lo que trae la instancia ApellidoMaterno
                ht.Add("telefono", c.Telefono);//al objeto ht se le agrega lo que trae la instancia c.Telefono
                ht.Add("extencion", c.Extension);//al objeto ht se le agrega lo que trae la instancia c.Extension
                ht.Add("correo", c.Correo);//al objeto ht se le agrega lo que trae la instancia c.Correo
                ht.Add("puesto", c.Puesto);//al objeto ht se le agrega lo que trae la instancia c.Puesto
                ht.Add("idempresa", c.Idempresa);//al objeto ht se le agrega lo que trae la instancia c.Idempresa
                _oContacto.Actualizar("idcontacto", c.Clave, ht);//al objeto _oContacto se le agrega lo que trae c.Clave de la instancia ht
                return true;//si el bloque de instruccione anterior se cumple retorna en verdadero
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
     /// <summary>
     /// 
     /// </summary>
     /// <param name="BajaContacto"></param>
     /// <returns></returns>
        public bool Eliminar(Contacto BajaContacto)//publicacion del metodo booleano eliminar
        {
            try//inicia el bloque de instruccion try-catch
            {
                _oContacto.Eliminar(BajaContacto.Clave);//al onjeto _oContacto se le manda lo que trae la instruccion eliminar por clave 
                return true;//si el bloque de instrucciones anterior se cumple entonces retorna verdadero
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
        public bool Guardar()
        {
            if (this.Count == 0)
            {
                return false;
            }
            try
            {
                Hashtable[] MisContactos = new Hashtable[this.Count];
                int indice = 0;
                foreach (Contacto c in this)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("nombre", c.Nombre);
                    ht.Add("appaterno", c.ApellidoPaterno);
                    ht.Add("apmaterno", c.ApellidoMaterno);
                    ht.Add("telefono", c.Telefono);
                    ht.Add("extencion", c.Extension);
                    ht.Add("correo", c.Correo);
                    ht.Add("puesto", c.Puesto);
                    ht.Add("idempresa", c.Idempresa);
                    MisContactos[indice] = ht;
                    ht = null;
                    indice++;
                }
                return (_oContacto.Guardar(MisContactos));
            }

            catch (Exception )
            {
                return false;
            }
        }
    }
}
