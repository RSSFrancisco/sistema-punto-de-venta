using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Negocios
{
   public class Requisicion
    {
        #region Atributos
       /// <summary>
       /// atributos de requisicion de servicios
       /// </summary>
       /// 
       string _totalFilas = string.Empty;
        int _folio = -1; 
       DateTime _fecha = DateTime.Now;
       string _cliente = string.Empty;
       string _direccion = string.Empty;
       string _ciudad = string.Empty;
       string _telefono = string.Empty;
       string _empleado = string.Empty;
       string _tipoServicio = string.Empty;
       string _entrada = string.Empty;
        string _salida = string.Empty; 
       string _servicioDomicilio = string.Empty; 
       string _horaEntrada = string.Empty;
        string _horaSalida = string.Empty; 
       string _nombre = string.Empty; 
       string _marca = string.Empty;
        string _modelo = string.Empty; 
       string _numSerie = string.Empty; 
       string _condicionEquipo = string.Empty;
        string _fallaReportada = string.Empty;
       string _reporteIng = string.Empty; 
       string _observaciones = string.Empty;
        decimal _manoDeObra = -1; 
       decimal _costoRefaccion = -1; 
       decimal _total = -1;
       //aqui tienes que poner los atributos que faltan la cual tiene la tabla requisicion de la base de datos baseRG2
        #endregion 

        #region Encapsulacion de Atributos 
       public string TotalFilas { set { _totalFilas = value; } get { return _totalFilas; } }
        public int Folio { set { _folio = value; } get { return _folio; } }
        public DateTime Fecha { set { _fecha = value; } get { return _fecha; } }
        public string Cliente { set { _cliente = value; } get { return _cliente; } }
        public string Direccion { set { _direccion = value; } get { return _direccion; } }
        public string Ciudad { set { _ciudad = value; } get { return _ciudad; } }
        public string Telefono { set { _telefono = value; } get { return _telefono; } }
        public string Empleado { set { _empleado = value; } get { return _empleado; } }
        public string TipoServicio { set { _tipoServicio = value; } get { return _tipoServicio; } }
        public string Entrada { set { _entrada = value; } get { return _entrada; } }
        public string Salida { set { _salida = value; } get { return _salida; } }
        public string ServicioADomicilio { set { _servicioDomicilio = value; } get { return _servicioDomicilio; } }
        public string HoraEntrada { set { _horaEntrada = value; } get { return _horaEntrada; } }
        public string HoraSalida { set { _horaSalida = value; } get { return _horaSalida; } }
        public string Nombre { set { _nombre = value; } get { return _nombre; } }
        public string Marca { set { _marca = value; } get { return _marca; } }
        public string Modelo { set { _modelo = value; } get { return _modelo; } }
        public string NumSerie { set { _numSerie = value; } get { return _numSerie; } }
        public string CondicionEquipo { set { _condicionEquipo = value; } get { return _condicionEquipo; } }
        public string FallaReportada { set { _fallaReportada = value; } get { return _fallaReportada; } }
        public string ReporteIng { set { _reporteIng = value; } get { return _reporteIng; } }
        public string Observaciones { set { _observaciones = value; } get { return _observaciones; } }
        //public int IdProducto { set { _idProducto = value; } get { return _idProducto; } }
        public decimal ManoDeObra { set { _manoDeObra = value; } get { return _manoDeObra; } }
        public decimal CostoRefaccion { set { _costoRefaccion = value; } get { return _costoRefaccion; } }
        public decimal Total { set { _total = value; } get { return _total; } }
        #endregion

        #region Constructores de la clase Requisicion
       /// <summary>
       /// 
       /// </summary>
       /// <param name="folio"></param>
       /// <param name="fecha"></param>
       /// <param name="idempresa"></param>
       /// <param name="idempleado"></param>
       /// <param name="tiposervicio"></param>
       /// <param name="entrada"></param>
       /// <param name="salida"></param>
       /// <param name="servicioADomicilio"></param>
       /// <param name="horaDeEntrada"></param>
       /// <param name="horaDeSalida"></param>
       /// <param name="nombre"></param>
       /// <param name="marca"></param>
        ///   string _cliente = string.Empty;
        ///   string _direccion = string.Empty;<param name="modelo"></param>
        ///   string _ciudad = string.Empty;<param name="numSerie"></param>
        ///   string _telefono = string.Empty;<param name="condicionEquipo"></param>
        ///   string _empleado = string.Empty;<param name="fallaReportada"></param>
       /// <param name="reporteIng"></param>
       /// <param name="observaciones"></param>
       /// <param name="idProducto"></param>
       /// <param name="manoDeObra"></param>
       /// <param name="costoRefaccion"></param>
       /// <param name="total"></param>
        public Requisicion(int folio,string totalFilas,DateTime fecha,string cliente,string direccion,string ciudad,string telefono,string empleado, string tiposervicio,string entrada,string salida,string servicioADomicilio,
            string horaDeEntrada,string horaDeSalida,string nombre,string marca,string modelo,string numSerie,string condicionEquipo,string fallaReportada,
            string reporteIng,string observaciones,/*int idProducto,*/decimal manoDeObra,decimal costoRefaccion,decimal total)
        {
            this._folio = folio;
            this._totalFilas = totalFilas;
            this._fecha = fecha;
            this._cliente = cliente;
            this._direccion = direccion;
            this._ciudad = ciudad;
            this._telefono = telefono;
            this._empleado = empleado;
            this._tipoServicio = tiposervicio;
            this._entrada = entrada;
            this._salida = salida;
            this._servicioDomicilio = servicioADomicilio;
            this._horaEntrada = horaDeEntrada;
            this._horaSalida = horaDeSalida;
            this._nombre = nombre;
            this._marca = marca;
            this._modelo = modelo;
            this._numSerie = numSerie;
            this._condicionEquipo = condicionEquipo;
            this._fallaReportada = fallaReportada;
            this._reporteIng = reporteIng;
            this._observaciones = observaciones;
            this._manoDeObra = manoDeObra;
            this._costoRefaccion = costoRefaccion;
            this._total = total;

        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="fecha"></param>
       /// <param name="idempresa"></param>
       /// <param name="idempleado"></param>
       /// <param name="tiposervicio"></param>
       /// <param name="entrada"></param>
       /// <param name="salida"></param>
       /// <param name="servicioADomicilio"></param>
       /// <param name="horaDeEntrada"></param>
       /// <param name="horaDeSalida"></param>
       /// <param name="nombre"></param>
       /// <param name="marca"></param>
       /// <param name="modelo"></param>
       /// <param name="numSerie"></param>
       /// <param name="condicionEquipo"></param>
       /// <param name="fallaReportada"></param>
       /// <param name="reporteIng"></param>
       /// <param name="observaciones"></param>
       /// <param name="idProducto"></param>
       /// <param name="manoDeObra"></param>
       /// <param name="costoRefaccion"></param>
       /// <param name="total"></param>
        public Requisicion( string totalFilas, DateTime fecha, string cliente, string direccion, string ciudad, string telefono, string empleado, string tiposervicio, string entrada, string salida, string servicioADomicilio,
            string horaDeEntrada, string horaDeSalida, string nombre, string marca, string modelo, string numSerie, string condicionEquipo, string fallaReportada,
            string reporteIng, string observaciones,/*int idProducto,*/decimal manoDeObra, decimal costoRefaccion, decimal total)
        {
          
            this._totalFilas = totalFilas;
            this._fecha = fecha;
            this._cliente = cliente;
            this._direccion = direccion;
            this._ciudad = ciudad;
            this._telefono = telefono;
            this._empleado = empleado;
            this._tipoServicio = tiposervicio;
            this._entrada = entrada;
            this._salida = salida;
            this._servicioDomicilio = servicioADomicilio;
            this._horaEntrada = horaDeEntrada;
            this._horaSalida = horaDeSalida;
            this._nombre = nombre;
            this._marca = marca;
            this._modelo = modelo;
            this._numSerie = numSerie;
            this._condicionEquipo = condicionEquipo;
            this._fallaReportada = fallaReportada;
            this._reporteIng = reporteIng;
            this._observaciones = observaciones;
            this._manoDeObra = manoDeObra;
            this._costoRefaccion = costoRefaccion;
            this._total = total;

        }
       /// <summary>
       /// 
       /// </summary>
        public Requisicion()
        { }
        #endregion
    }
        
}

