using System;
using System.Collections.Generic;

namespace Negocios
{
  public  class Empresa
  {
      #region Atributos
      int _idempresa = -1;
      string _rfc = string.Empty;
      string _siglas = string.Empty;
      string _nombre = string.Empty;
      string _giro = string.Empty;
      string _direccion = string.Empty;
      string _colonia = string.Empty;
      string _ciudad = string.Empty;
      string _estado = string.Empty;
      int _cp = -1;
      string _telefono = string.Empty;
      #endregion

      #region Propiedades Pùblicas
      public int Clave
      {
          set { _idempresa = value; }
          get { return _idempresa; }
      }
      public string Rfc
      {
          set { _rfc = value; }
          get { return _rfc; }
      }
      public string Siglas
      {
          set { _siglas = value; }
          get { return _siglas; }
      }
      public string Nombre
      {
          set { _nombre = value; }
          get { return _nombre; }
      }
      public string Giro
      {
          set { _giro = value; }
          get { return _giro; }
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
      public int Cp
      {
          set { _cp = value; }
          get { return _cp; }
      }
      public string Telefono
      {
          set { _telefono = value; }
          get { return _telefono; }
      }
      #endregion

      #region Constructor
      public Empresa(int idempresa,string rfc, string siglas, string nombre, string giro, string direccion, string colonia, string ciudad, string estado, int cp, string telefono)
      {
          this._idempresa=idempresa;
          this._rfc=rfc;
          this._siglas = siglas;
          this._nombre = nombre;
          this._giro = giro;
          this._direccion = direccion;
          this._colonia = colonia;
          this._ciudad = ciudad;
          this._estado = estado;
          this._cp = cp;
          this._telefono = telefono;
      }
     public Empresa(string rfc, string siglas, string nombre, string giro, string direccion, string colonia, string ciudad, string estado, int cp, string telefono)
        {
            this._rfc = rfc;
            this._siglas = siglas;
            this._nombre = nombre;
            this._giro = giro;
            this._direccion = direccion;
            this._colonia = colonia;
            this._ciudad = ciudad;
            this._estado = estado;
            this._cp = cp;
            this._telefono = telefono;

        }
        public Empresa()
        { }
        #endregion

  }
}
