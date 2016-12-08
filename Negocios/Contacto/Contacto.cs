#region librerias
using System;//libreria que hace uso de la interfaz de sistema
using System.Collections.Generic;//libreria que hace uso de la coleccion de datos del sistema
using System.Linq;
using System.Text;
#endregion

namespace Negocios
{
  public  class Contacto//publicacion de la clase de tipo contacto
    {
       #region Atributos
        int _IdCliente = -1;/*atributo id cliente de tipo entero*/
        string _nombre = string.Empty;/*atributo nombre de tipo cadena inicializado en vacio*/
        string _apellidoPaterno = string.Empty;/*atributo apellido paterno de tipo cadena inicializado en vacio*/
        string _apellidoMaterno = string.Empty;/*atributo apellido materno de tipo cadena inicliazdo en vaio*/
        string _telefono = string.Empty;/*atributo telefono de tipo cadena inicializado en vacio*/
        string _extension = string.Empty;/*atributo extension de tipo cadena inicializado en vacio*/
        string _correo = string.Empty;/*atributo correo de tipo cadena inicializado en vacio*/
        string _puesto = string.Empty;/*atributo puesto de tipo cadena inicializado en vacio*/
        int _idempresa = -1;/*atributo id empresa de tipo cadena inicializado con -1*/
         #endregion
        #region Propiedades Públicas
      /// <summary>
      /// Clave de Contacto
      /// </summary>
        public int Clave//publicacion de la propiedad clave
        {
            set { _IdCliente = value; }//envia lo que trae _idCliente 
            get { return _IdCliente; }//recibe lo que retorna _idCliente
        }
      /// <summary>
      /// Atributo Nombre de Contacto
      /// </summary>
        public string Nombre//publicacion de la propiedad de tipo Nombre
        {
            set { _nombre = value; }//envia el valor que trae _nombre
            get { return _nombre; }//recibe el valor que retorna _nombre
        }
      /// <summary>
      /// Atributo Apellido Paterno de Contacto
      /// </summary>
        public string ApellidoPaterno//publicación de la propiedad de tipo ApellidoPaterno
        {
            set { _apellidoPaterno = value; }//envia el valor que trae _apellidoPaterno
            get { return _apellidoPaterno; }//recibe el valor que retorna _apellidoPaterno
        }
      /// <summary>
      /// Atributo Apellido Materno De Contacto
      /// </summary>
        public string ApellidoMaterno//publicación de la propiedad ApellidoMaterno
        {
            set { _apellidoMaterno = value; }//envia el valor que trae _apellidoMaterno
            get { return _apellidoMaterno; }//recibe el valor que retorna _apelldoMaterno
        }
      /// <summary>
      /// Atributo Telefono de Contacto
      /// </summary>
        public string Telefono//publicación de la propiedad Telefono
        {
            set { _telefono = value; }//envia el valor que trae _telefono
            get { return _telefono; }//recibe el valor que retorna _telefono
       }
      /// <summary>
      /// Atributo Extension De Contacto
      /// </summary>
        public string Extension//publicación de la propiedad Extension
        {
            set { _extension = value; }//envia el valor que trae _extension
            get { return _extension; }//recibe el valor que retorna _extension
        }
      /// <summary>
      /// Atributo Correo de Contacto
      /// </summary>
            public string Correo//publicación de la propiedad Correo
            {
                set{_correo =value;}//envia el valor que trae _correo
                get{return _correo;}//recibe el valor que retorna _correo
            }
      /// <summary>
      /// Atributo Puesto De Contacto
      /// </summary>
        public string Puesto//publicación de la propiedad Puesto
        {
            set{_puesto=value;}//envia el valor que trae _puesto
            get{return _puesto;}//recibe el valor que retorna _puesto
        }
      /// <summary>
      /// Atributo Id De la Empresa Llave Foranea Del Contacto
      /// </summary>
        public int Idempresa //publicación de la propiedad Idempresa
        {
            set{_idempresa = value;}//envia el valor que trae _idempresa
            get{return _idempresa;}//recibe el valor que retorna _idempresa
        }
   
#endregion   
        #region Constructor
      /// <summary>
      /// Constructor Inizilizador de los atriburtos de la clase Contacto
      /// </summary>
      /// <param name="IdCliente">Atributo del Id del Contacto</param>
      /// <param name="nombre">Atributo Nombre Del Contacto</param>
      /// <param name="apellidoPaterno">Atributo Apellido Paterno Del Contacto</param>
      /// <param name="apellidoMaterno">Atributo Apellido Materno Del Contacto</param>
      /// <param name="telefono">Atributo Telefono Del Contacto</param>
      /// <param name="extension">Atributo Extension Del Contacto</param>
      /// <param name="correo">Atributo Correo Del Contacto</param>
      /// <param name="puesto">Atributo Puesto Del Contacto</param>
      /// <param name="idempresa">Atributo Id De La Empresa Llave Forane Del Contacto</param>
        public Contacto(int IdCliente, string nombre, string apellidoPaterno,string apellidoMaterno,string telefono,string extension,string correo,string puesto,int idempresa)
        {
            this._IdCliente = IdCliente;
            this._nombre = nombre;
            this._apellidoPaterno = apellidoPaterno;
            this._apellidoMaterno = apellidoMaterno;
            this._telefono = telefono;
            this._extension = extension;
            this._correo = correo;
            this._puesto = puesto;
            this._idempresa =idempresa;   
        }
      /// <summary>
      /// Constructor Inizilizador Sin El Atributo Id Contacto de la Clase Contacto
      /// </summary>
      /// <param name="nombre">Atributo Nombre De La Clase Contacto</param>
      /// <param name="apellidoPaterno">Atributo Apellido Paterno De La Clase Contacto</param>
        /// <param name="apellidoMaterno">Atributo Apellido Materno De La Clase Contacto</param>
      /// <param name="telefono">Atributo Telefono De La Clase Contacto</param>
        /// <param name="extension">Atributo Extension Del Contacto</param>
        /// <param name="correo">Atributo Correo Del Contacto</param>
        /// <param name="puesto">Atributo Puesto Del Contacto</param>
        /// <param name="idempresa">Atributo Id De La Empresa Llave Forane Del Contacto</param>
        public Contacto(string nombre, string apellidoPaterno, string apellidoMaterno, string telefono, string extension, string correo, string puesto, int idempresa) 
        {

            this._nombre = nombre;
            this._apellidoPaterno = apellidoPaterno;
            this._apellidoMaterno = apellidoMaterno;
            this._telefono = telefono;
            this._extension = extension;
            this._correo = correo;
            this._puesto = puesto;
            this._idempresa = idempresa;
   
        }

        
        public Contacto()
        { }
        #endregion


    }
}