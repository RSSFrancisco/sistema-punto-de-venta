using System;
using System.Collections.Generic;

namespace Negocios
{
    public class Proveedor
    {
        #region Atributos
        int _clave = 0;
        string _rfc = "";
        string _nombre = "";
        string _direccion = "";
        string _colonia = "";
        string _ciudad = "";
        string _estado = "";
        int _cp = 0;
        string _telefono = "";
        string _correo = "";
        #endregion

        #region Variables Públicas
        /// <summary>
        /// Clave del proveedor
        /// </summary>
        public int Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
        /// <summary>
        /// Rfc del proveedor
        /// </summary>
        public string Rfc
        {
            set { _rfc = value; }
            get { return _rfc; }
        }
        /// <summary>
        /// Nombre completo del proveedor
        /// </summary>
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }
        /// <summary>
        /// Direccion actual donde habita el proveedor
        /// </summary>
        public string Direccion
        {
            set { _direccion = value; }
            get { return _direccion; }
        }
        /// <summary>
        /// Colonia donde habita el proveedor
        /// </summary>
        public string Colonia
        {
            set { _colonia = value; }
            get { return _colonia; }
        }
        /// <summary>
        /// Ciudad donde se encuentra el proveedor
        /// </summary>
        public string Ciudad
        {
            set { _ciudad = value; }
            get { return _ciudad; }
        }
        /// <summary>
        /// Estado donde se encuentra el proveedor
        /// </summary>
        public string Estado
        {
            set { _estado = value; }
            get { return _estado; }
        }
        /// <summary>
        /// Codigo postal del proveedor
        /// </summary>
        public int Cp
        {
            set { _cp = value; }
            get { return _cp; }
        }
        /// <summary>
        /// Numero telefonico del proveedor
        /// </summary>
        public string Telefono
        {
            set { _telefono = value; }
            get { return _telefono; }
        }
        /// <summary>
        /// Correo electronico del proveedor
        /// </summary>
        public string Correo
        {
            set { _correo = value; }
            get { return _correo; }
        }
        #endregion

        #region Constructor
        public Proveedor(int clave, string rfc, string nombre, string direccion, string colonia, string ciudad, string estado, int cp, string telefono, string correo)
        {
            this._clave = clave;
            this._rfc = rfc;
            this._nombre = nombre;
            this._direccion = direccion;
            this._colonia = colonia;
            this._ciudad = ciudad;
            this._estado = estado;
            this._cp = cp;
            this._telefono = telefono;
            this._correo = correo;
        }
        public Proveedor(string rfc, string nombre, string direccion, string colonia, string ciudad, string estado, int cp, string telefono, string correo)
        {
            this._rfc = rfc;
            this._nombre = nombre;
            this._direccion = direccion;
            this._colonia = colonia;
            this._ciudad = ciudad;
            this._estado = estado;
            this._cp = cp;
            this._telefono = telefono;
            this._correo = correo;
        }
        public Proveedor()
        {
        }
        #endregion
    }
}
