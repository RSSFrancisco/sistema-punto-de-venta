#region Librerias
using System;

#endregion

namespace Negocios
{
 public class Producto
    {
      #region Atributos
      int _IdProducto = -1;//variable entera _IdProducto se inicializa como -1
      string _nombre = string.Empty;//variable string _nombre se le asigna como vacia 
      string _marca = string.Empty;//variable string _marca se le asigna como vacia
      string _descripcion = string.Empty;//variable string _descripcion se le asigna como vacia 
      int _idproveedor=-1;//variable entera _idproveedor se inicializa como -1
      DateTime _fechacompra = DateTime.Today;//variable tipo DateTime que se le asigna los datos de la fecha actual
      double _precioUnitario = -1;//variable _precioUnitario del tipo decimal la cual se inicializa como -1
      int _cantidad = 0;//variable entera _cantidad la cual se inicializa como 0
      int _smax = 0;//variable entera _smax la cual se inicializa como 0 
      int _smin = 0;//variable entera _smin la cual se inicializa como 0
      decimal _importe = 0;//variable _importe del tipo decimal la cual se inicializa como 0
      int _categoria =-1;//variable _categoria del tipo string la cual se inicializa como vacia 
      string _imagen = string.Empty;// variable _imagen del tipo string la cual guarda la url de la localizacion de la imagen 12/09/2016
      int _existencia = 0; // variable _existencia del tipo integer la cual guarda la cantidad de productos que hay en el stock
      string _codigoBarras = string.Empty;// Fecha creación: 27/09/2016
      #endregion

      #region Propiedades Pùblicas
    public int Existencia // metodo publico del tipo int 15/09/2016
        {
            set { _existencia = value; }
            get { return _existencia; }
        }
      public string Imagen // metodo publico del tipo string 12/09/2016
        {
            set { _imagen = value; }
            get { return _imagen; }
        }
      public int Categoria//se publica el metodo string Categoria 
      {
          set { _categoria = value; }//se envia lo que trae _categoria 
          get { return _categoria; }//retorna lo que trae _categoria 
      }
      public decimal Importe {//se publica el metodo Importe del tipo decimal 
          set { _importe = value; }//se envia lo que trae _importe 
          get { return _importe; }//retorna lo que trae _importe 
      }

      public int StockMinimo {//se publica el metodo StockMinimo de tipo entero
          set { _smin = value; }//se envia lo que trae _smin
          get { return _smin; }//retorna lo que trae _smin
      }

      public int StockMaximo {//se publica el metodo StockMaximo de tipo entero
          set { _smax = value; }//se envia lo que trae _smax
          get { return _smax; }//retorna lo que trae _smax
      }

      public int Cantidad {//se publica el metodo Cantidad del tipo entero
          set { _cantidad = value; }//se envia lo que trae _cantidad        
          get { return _cantidad; }//retorna lo que trae _cantidad
      }

      public double PrecioUnitario {//se publica el metodo PrecioUnitario del tipo decimal 
          set { _precioUnitario = value; }//se envia lo que trae _precioUnitario 
          get { return _precioUnitario; }//retorna lo que trae _precioUnitario
      }


     /// <summary>
     /// Clave del producto
     /// </summary>
      public int Clave//metodo int clave
      {
          set { _IdProducto = value; }//se envia lo que trae _IdProducto
          get { return _IdProducto; }//retorna lo que trae _IdProducto
      }
     /// <summary>
     /// Nombre del producto
     /// </summary>
     public string Nombre//funcion Nombre de tipo Cadena
     {
         set{_nombre=value;}//se envia lo que trae _nombre 
         get{return _nombre;}//retorna lo que trae _nombre 
     }
     /// <summary>
     /// Marca del producto
     /// </summary>
     public string Marca
     {
         set{_marca=value;}//se envia lo que trae _marca 
         get{return _marca;}//retorna lo que trae _marca 
     }
     /// <summary>
     /// Descripcion del Producto
     /// </summary>
     public string Descripcion
     {
         set{_descripcion =value;}//se envia lo que trae _descripcion
         get{return _descripcion;}//retorna lo que trae _descripcion 
     }
     /// <summary>
     /// Clave del proveedor del producto
     /// </summary>
     public int Idproveedor
     {
         set{_idproveedor =value;}//se envia lo que trae _idproveedor 
         get{return _idproveedor;}//retorna lo que trae _idproveedor 
     }
     /// <summary>
     /// Fecha del producto
     /// </summary>
     public DateTime FechaCompra
     {
         set { _fechacompra = value; }//se envia lo que trae _fechacompra 
         get { return _fechacompra; }//retorna lo que trae _fechacompra 
     }
     public string CodigoBarras 
        {
            set { _codigoBarras = value; }
            get { return _codigoBarras; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Inicialización de las clases de producto
        /// </summary>
        /// <param name="idproducto">Clave del producto</param>
        /// <param name="nombre">variable nombre del tipo string </param>
        /// <param name="marca">variable marca del tipo string </param>
        /// <param name="descripcion">variable descripcion del tipo string </param>
        /// <param name="idproveedor">variable idproveedor del tipo entero</param>
        /// <param name="fechacompra">variable fechacompra del tipo DateTime </param>
        public Producto(int idproducto,string nombre,string marca,string descripcion,int idproveedor,DateTime fechacompra,double preciounitario,int categoria,string imagen, int stockMaximo,int stockMinimo,int existencia,string codigoBarras)
      {
          _IdProducto=idproducto;                //se le asigna el valor que trae idproducto a _IdProducto
          _nombre = nombre;                      //se le asigna el valor que trae nombre a _nombre
          _marca = marca;                        //se le asigna el valor que trae marca a _marca 
          _descripcion = descripcion;            //se le asigna el valor que trae descripcion a _descripcion
          _idproveedor = idproveedor;            //se le asigna el valor que trae idproveedor a _idproveedor
          _fechacompra = fechacompra;            //se le asigna el valor que trae fechacompra a _fechacompra 
          _precioUnitario = preciounitario;      //se le asigna el valor que trae preciounitario a _preciounitario
          _categoria = categoria;                //se le asigna el valor que trae categoria a _categoria 
          _imagen = imagen;
          _smax = stockMaximo;
          _smin = stockMinimo;
          _existencia = existencia;
          _codigoBarras = codigoBarras;          // Fecha de creación: 27/09/2016
      }
      /// <summary>
      /// Inicialización de las clases de producto
      /// </summary>
      /// <param name="idproducto">Clave del producto</param>
      /// <param name="nombre">variable nombre del tipo string </param>
      /// <param name="marca">variable marca del tipo string </param>
      /// <param name="descripcion">variable descripcion del tipo string </param>
      /// <param name="idproveedor">variable idproveedor del tipo entero</param>
      /// <param name="fechacompra">variable fechacompra del tipo DateTime </param>
      public Producto( string nombre, string marca, string descripcion, int idproveedor, DateTime fechacompra,double preciounitario,int categoria,string imagen, int stockMaximo, int stockMinimo,int existencia,string codigoBarras)
      {
          _nombre = nombre;                  //se le asigna el valor que trae nombre a _nombre  
          _marca = marca;                    //se le asigna el valor que trae marca a _marca 
          _descripcion = descripcion;        //se le asigna el valor que trae descripcion a _descripcion
          _idproveedor = idproveedor;        //se le asigna el valor que trae idproveedor a _idproveedor
          _fechacompra = fechacompra;        //se le asigna el valor que trae fechacompra a _fechacompra 
          _precioUnitario = preciounitario;  //se le asigna el valor que trae preciounitario a _preciounitario
          _categoria = categoria;            //se le asigna el valor que trae categoria a _categoria 
          _imagen = imagen;
          _smax = stockMaximo;
          _smin = stockMinimo;
          _existencia = existencia;
          _codigoBarras = codigoBarras;    // Fecha de creación: 27/09/2016
        }
        public Producto()//declaracion de el contructor de la clase Producto en vacio
        { }
        #endregion

  }
}
