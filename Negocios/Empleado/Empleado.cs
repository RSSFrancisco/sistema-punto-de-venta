#region Librerias
using System;
#endregion 

namespace Negocios
{
  public  class Empleado
  {
      #region Atributos
      int _estatus = 1;
      int _clave = -1;///--<atributo int _clave>atributo clave inicializado en -1 [°-°]</atributo>
      string _nombre = string.Empty;///---<atributo string _nombre>atributo _nombre  inicializado en vacio [°-°]</atributo>
      string _apPaterno = string.Empty;///---<variable string _apPaterno>variable _appaterno inicializado en vacio[°-°]</variable>
      string _apMaterno = string.Empty;///---<variable string _apmaterno>variable _apmaterno inicializado en vacio [°-°]</variable>
      string _nss = string.Empty;///---<variable string _nss>variable _nss inicializado en vacio [°-°]</variable>
      DateTime _fechanacimiento = DateTime.Today;///---<variable DateTime _fechanacimiento>variable _fechanacimiento inicializado con la fecha actual [°-°]</variable>
      string _direccion = string.Empty;///---<variable string _direccion>variable _direccion inicilizado como vacio [°-°]</variable>
      string _colonia = string.Empty;///---<variable string _colonia>variable string colonia inicializada como vacia [°-°]</variable>
      string _ciudad = string.Empty;///---<variable string _ciudad>variable string _ciudad inicializada como vacia [°-°]</variable>
      string _estado = string.Empty;///---<variable string _estado>variable string _estado inicializada como vacia [°-°]</variable>
      int _cp = -1;///---<variable int _cp>variable int _cp inicializada como -1 [°-°]</variable>
      string _telefono = string.Empty;///---<variable string _telefono>variable string _telefono inicializada como vacia [°-°]</variable>
      string _correo = string.Empty;///---<variable string _correo >variable string _correo inicializada como vacia [°-°]</variable>
      string _nivelescolar = string.Empty;///---<variable string _nivelescolar>variable string _nivelescolar inicializada como vacia [°-°]</variable>
      string _especialidad = string.Empty;///---<variable string _especialidad>variable string _especialidad inicializada como vacia [°-°]</variable>
      string _nick = string.Empty;///---<variable variable string _nick>variable string _nick inicializada como vacia [°-°]</variable>
      string _contrasenia = string.Empty;///---<variable string _contrasenia>variable string _contrasenia inicializada como vacia [°-°]</variable>
      int _idempleado = -1;///---<variable int _idempleado>variable int _idempleado inicializada como vacia [°-°]</variable>
      
      #endregion
      #region Propiedades Públicas
      public int Estatus 
      {
          set { _estatus = value; }
          get { return _estatus; }

      }
      public string Nick///--<metodo string Nick>publicacion del metodo string nick <metodo> 
      {
          set { _nick = value; }
          get { return _nick; }
      }
      public string Contrasenia//publicacion de la funcion Contrasenia del tipo cadena
      {
          set { _contrasenia = value; }
          get { return _contrasenia; }
      }
      public int Idempleado//publicacion de la funcion IdEmpleado del tipo entero
      {
          set { _idempleado = value; }
          get { return _idempleado; }
      }

      public int Clave//publicacion de la funcion Clave del tipo entero
      {
          set { _clave = value; }
          get { return _clave; }
      }
      public string Nombre//publicacion  de la funcion Nombre de tipo cadena
      {
          set { _nombre = value; }
          get { return _nombre; }
      }
      public string ApPaterno//publicacion de la funcion ApPaterno del tipo cadena
      {
          set { _apPaterno = value; }
          get { return _apPaterno; }
      }
      public string ApMaterno
      {
          set { _apMaterno = value; }
          get { return _apMaterno; }
      }
      public string NSS
      {
          set { _nss = value; }
          get { return _nss; }
      }
      public DateTime FechaNacimiento
      {
       
          set 
          { 
            
              _fechanacimiento = value; 
          }
         
          get 
          { 
              return _fechanacimiento; 
          }
      }
      public string Direccion
      {
          set { _direccion = value; }
          get { return _direccion; }
      }
      public string Colonia
      {
          set { _colonia = value; }
          get { return _colonia; }
      }
      public string Ciudad
      {
          set { _ciudad = value; }
          get { return _ciudad; }
      }
      public string Estado
      {
          set { _estado = value; }
          get { return _estado; }
      }
      public int CP
      {
          set { _cp = value; }
          get { return _cp; }
      }
      public string Telefono
      {
          set { _telefono = value; }
          get { return _telefono; }
      }
      public string Correo
      {
          set { _correo = value; }
          get { return _correo; }
      }
      public string NivelEscolar
      {
          set { _nivelescolar = value; }
          get { return _nivelescolar; }
      }
      public string Especialidad
      {
          set { _especialidad = value; }
          get { return _especialidad; }
      }
    


   // public string Baja
      //{
        //  set { _baja = value; }
         // get { return _baja; }
     // }
      #endregion
      #region Constructor
      /// <summary>
      /// 
      /// </summary>
      /// <param name="clave"></param>
      /// <param name="nombre"></param>
      /// <param name="apPaterno"></param>
      /// <param name="apMaterno"></param>
      /// <param name="nss"></param>
      /// <param name="fechanacimiento"></param>
      /// <param name="direccion"></param>
      /// <param name="colonia"></param>
      /// <param name="ciudad"></param>
      /// <param name="estado"></param>
      /// <param name="cp"></param>
      /// <param name="telefono"></param>
      /// <param name="correo"></param>
      /// <param name="nivelescolar"></param>
      /// <param name="especialidad"></param>
      /// <param name="baja"></param>
      public Empleado(int clave, string nombre, string apPaterno
          , string apMaterno, string nss, DateTime fechanacimiento
          , string direccion, string colonia, string ciudad, string estado
          , int cp, string telefono
          , string correo, string nivelescolar, string especialidad, string baja)
      {
          this._clave = clave;
          this._nombre = nombre;
          this._apPaterno = apPaterno;
          this._apMaterno = apMaterno;
          this._nss = nss;
          this._fechanacimiento = fechanacimiento;
          this._direccion = direccion;
          this._colonia = colonia;
          this._ciudad = ciudad;
          this._estado = estado;
          this._cp = cp;
          this._telefono = telefono;
          this._correo = correo;
          this._nivelescolar = nivelescolar;
          this._especialidad = especialidad;
        ///  this._baja = baja;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="nombre"></param>
      /// <param name="apPaterno"></param>
      /// <param name="apMaterno"></param>
      /// <param name="nss"></param>
      /// <param name="fechanacimiento"></param>
      /// <param name="direccion"></param>
      /// <param name="colonia"></param>
      /// <param name="ciudad"></param>
      /// <param name="estado"></param>
      /// <param name="cp"></param>
      /// <param name="telefono"></param>
      /// <param name="correo"></param>
      /// <param name="nivelescolar"></param>
      /// <param name="especialidad"></param>
      public Empleado(string nombre, string apPaterno
         , string apMaterno, string nss, DateTime fechanacimiento
         , string direccion, string colonia, string ciudad, string estado
         , int cp, string telefono
         , string correo, string nivelescolar, string especialidad )//,string baja)
      {

          this._nombre = nombre;
          this._apPaterno = apPaterno;
          this._apMaterno = apMaterno;
          this._nss = nss;
          this._fechanacimiento = fechanacimiento;
          this._direccion = direccion;
          this._colonia = colonia;
          this._ciudad = ciudad;
          this._estado = estado;
          this._cp = cp;
          this._telefono = telefono;
          this._correo = correo;
          this._nivelescolar = nivelescolar;
          this._especialidad = especialidad;
        // this._baja = baja;
      }
    /// <summary>
    /// 
    /// </summary>
      public Empleado() { }
      #endregion 
  }
    
}
