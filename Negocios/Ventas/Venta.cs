#region leeme
/*
 *  Autor: Ing.Francisco Reyes Sánchez
 *  Fecha de creación: 23/09/2016
 *  Fecha de modificación:
 *  Capa: Negocios.Ventas
 *  Clase: Venta
 *  
 */
#endregion
#region Librerías
using System;
#endregion

namespace Negocios
{
   public class Venta
    {
        #region Atributos
        int _IdVenta = -1;
        //int _NumVenta = -1;
        int _IdCliente = -1;
        DateTime _Fecha = DateTime.Today; 
        int _IdEmpleado = -1;
        // se cambio el tipo de conversion de double a "decimal" por cuestiones de compatibiidad en el gestor de base de datos de sqlite
        decimal _Importe = -1;
        decimal _Cambio = -1;
        decimal _Total = -1;
        //
        #endregion
        #region Atributos extras
        string _cliente = string.Empty;
        string _atendio = string.Empty;
        #endregion

        #region Propiedades Públicas
        public string Cliente
        {
            set { _cliente = value; }
            get { return _cliente; }
        }
        public string Atendio
        {
            set { _atendio = value; }
            get { return _atendio; }
        }
        public int IdVenta
        {
            set { _IdVenta = value; }
            get { return _IdVenta; }
        }
        //public int NumVenta
        //{
        //    set { _NumVenta = value; }
        //    get { return _NumVenta; }
        //}
        public int IdCliente
        {
            set { _IdCliente = value; }
            get { return _IdCliente; }
        }
        public DateTime Fecha
        {
            set { _Fecha = value; }
            get { return _Fecha; }
        }
        public int IdEmpleado
        {
            set { _IdEmpleado = value; }
            get { return _IdEmpleado; }
        }
        // se cambio el tipo de conversion de double a "decimal" por cuestiones de compatibiidad en el gestor de base de datos de sqlite
        public decimal Importe
        {
            set { _Importe = value; }
            get { return _Importe; }
        }
        public decimal Cambio
        {
            set { _Cambio = value; }
            get { return _Cambio; }
        }
        public decimal Total
        {
            set { _Total = value; }
            get { return _Total; }
        }
        //
        #endregion
        #region Constructor
        public Venta(int idVenta/*,int numVenta*/,int idCliente/*,DateTime fecha*/,int idempleado, decimal importe, decimal cambio, decimal total)
        {
            _IdVenta = idVenta;
            //this._NumVenta = numVenta;
            _IdCliente = idCliente;
            //this._Fecha = fecha;
            _IdEmpleado = idempleado;
            _Importe = importe;
            _Cambio = cambio;
            _Total = total;
        }
        public Venta( int idCliente/*, DateTime fecha*/, int idempleado, decimal importe, decimal cambio, decimal total)
        {
           
            //this._NumVenta = numVenta;
            _IdCliente = idCliente;
            //this._Fecha = fecha;
            _IdEmpleado = idempleado;
            _Importe = importe;
            _Cambio = cambio;
            _Total = total;
        }
        // constructor para mostrar el listado de las ventas 
        // Fecha de creación: 27/09/2016
        public Venta(string cliente,string atendio, decimal importe, decimal cambio, decimal total)
        {

            //this._NumVenta = numVenta;
           _cliente = cliente;
            //this._Fecha = fecha;
           _atendio = atendio;
           _Importe = importe;
           _Cambio = cambio;
           _Total = total;
        }
        public Venta()
        { }
        #endregion
    }
}
