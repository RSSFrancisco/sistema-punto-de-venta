using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using Datos;

namespace Negocios.Compras
{
    public class Compras
    {
        long _folio = 0;
        DateTime _fechaCompra = DateTime.Today;
        Proveedor _proveedor = null;
        List<Producto> _detalle;
        Datos.Compras.clsCompras _compra = new Datos.Compras.clsCompras();

        public long Folio
        {
            set { _folio = value; }
            get { return _folio; }
        }
        public DateTime FechaCompra
        {
            set { _fechaCompra = value; }
            get { return _fechaCompra; }
        }
        public Proveedor ProveedorActual
        {
            set { _proveedor = value; }
            get { return _proveedor; }
        }

        public List<Producto> DetalleCompra {
            set { _detalle = value; }
            get { return _detalle; }
        }

        public Compras(long folio, DateTime fechacompra, Proveedor proveedor, List<Producto> detalle)
        {
            this._folio = folio;
            this._fechaCompra = fechacompra;
            this._proveedor = proveedor;
            this._detalle = detalle;
        }

        public Compras() {
 
        }

        public bool Guardar()
        {
            try
            {
                Hashtable[] MisProductos = new Hashtable[this._detalle.Count];
                int indice = 0;
                foreach (Producto p in _detalle )
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("idproducto", p.Clave);
                    ht.Add("idcompra", this._folio);
                    ht.Add("cantidad", p.Cantidad);
                    ht.Add("preciounitario", p.PrecioUnitario);                  
                    MisProductos[indice] = ht;
                    ht = null;
                    indice++;
                }
                _compra.Guardar(this._folio, this._fechaCompra, ProveedorActual.Clave, MisProductos);
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

    }
}
