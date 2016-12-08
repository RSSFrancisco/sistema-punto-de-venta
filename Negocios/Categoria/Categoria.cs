using System;


namespace Negocios
{
  public  class Categoria
    {
      int _clave = -1;
      string _nombre = string.Empty;
      string _descripcion = string.Empty;

      public int Clave
      {
          set { _clave = value; }
          get { return _clave; }
      }
      public string Nombre
      {
          set { _nombre = value; }
          get { return _nombre; }
      }
      public string Descripcion
      {
          set { _descripcion = value; }
          get { return _descripcion; }
      }
      public Categoria(int clave, string nombre, string descripcion)
      {
          this._clave = clave;
          this._nombre = nombre;
          this._descripcion = descripcion;

      }
      public Categoria(string nombre, string descripcion)
      {
          
          this._nombre = nombre;
          this._descripcion = descripcion;

      }
      public Categoria()
      {

      }

    }
}
