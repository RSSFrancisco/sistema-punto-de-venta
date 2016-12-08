using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class Servicio
    {
        #region Atributos
        int _clave = -1;
        string _nombre = string.Empty;
        decimal _preciounitario = 0;
        int _cant = 0;
        #endregion

        #region Variables Publicas
        public int Cantidad {
            set { _cant = value; }
            get { return _cant; }
        }
        public int Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public decimal PrecioUnitario
        {
            get { return _preciounitario; }
            set { _preciounitario = value; }
        }
        #endregion

        #region Constructor
        public Servicio(int clave, string nombre,decimal preciounitario)
        {
            this._clave = clave;
            this._nombre = nombre;
            this._preciounitario = preciounitario;
        }
        public Servicio(string nombre,decimal preciounitario)
        {
            this._nombre = nombre;
            this._preciounitario = preciounitario;
        }
        public Servicio()
        {
        }
        #endregion
    }
}
