#region Librerias
using System;
#endregion
namespace Negocios
{
   public class ProductosVenta
    {
        #region Atributos
        int _IdProductosVenta = 0;
        int _idproducto = 0;
        int _numVenta =0;
        int _cantidad = 0;
        double _subtotal = 0;
        //DateTime _fecha = DateTime.Today;
        #endregion
        #region Atributos Union Tablas ProductoVenta/Producto
        string _codigoBarras="";
        string _nombre = "";
        string _descripcion = "";
        double _precioUnitario = 0;
        double _total=0;
        #endregion
        #region Propiedades Públicas de ProductoVenta/Producto
        public string CodigoBarras
        {
            set { _codigoBarras = value; }
            get { return _codigoBarras; }
        }
        public double Total
        {
            set { _total = value; }
            get { return _total; }
        }
        public string NombrePV
        {
            set { _nombre = value; }
            get { return _nombre; }
        }
        public string DescripcionPV
        {
            set { _descripcion = value; }
            get { return _descripcion; }
        }
        public double PrecioUnitarioPV
        {
            set { _precioUnitario = value; }
            get { return _precioUnitario; }
        }
        #endregion
        #region Propiedades Públicas
        public int IdProductosVenta
        {
            set { _IdProductosVenta = value; }
            get { return _IdProductosVenta; }
        }
        public int IdProducto
        {
            set { _idproducto = value; }
            get { return _idproducto; }
        }
        public int NumVenta
        {
            set { _numVenta = value; }
            get { return _numVenta; }
        }
        public int Cantidad
        {
            set { _cantidad = value; }
            get { return _cantidad; }
        }
        public double SubTotal
        {
            set { _subtotal = value; }
            get { return _subtotal; }
        }
        //public DateTime Fecha
        //{
        //    set { _fecha = value; }
        //    get { return _fecha; }
        //}
        #endregion
        #region Constructores de la clase 
        public ProductosVenta(int idProductosVenta,int idProducto,int numVenta,int cantidad,double subTotal)
        {
            this._IdProductosVenta = idProductosVenta;
            this._idproducto = idProducto;
            this._numVenta = numVenta;
            this._cantidad = cantidad;
            this._subtotal = subTotal;
           
        }
        public ProductosVenta(int idProducto, int numVenta, int cantidad, double subTotal)
        {
            this._idproducto = idProducto;
            this._numVenta = numVenta;
            this._cantidad = cantidad;
            this._subtotal = subTotal;
           
        }
     
        public ProductosVenta(int idProducto,string codigoBarras,string nombre,string descripcion,double precioUnitario,int cantidad,double subtotal)
        {
            this._idproducto = idProducto;
            this._codigoBarras = codigoBarras;
            this._nombre = nombre;
            this._descripcion = descripcion;
            this._precioUnitario = precioUnitario;
            this._cantidad = cantidad;
            this._subtotal = subtotal;
        }
        public ProductosVenta()
        {

        }
        #endregion
    }
}
