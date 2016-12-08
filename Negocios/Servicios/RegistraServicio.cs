using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Datos;

namespace Negocios
{
    public class RegistraServico : CollectionBase
    {
        #region Atributos
        clsServicio _oServicio = new clsServicio();
        #endregion

        #region Metodos de la coleccion base
        public int Add(Servicio NuevoServicio)
        {
            return (List.Add(NuevoServicio));
        }
        public int IndexOf(Servicio PosicionDelServicio)
        {
            return (List.IndexOf(PosicionDelServicio));
        }
        public void Insert(int Indice, Servicio InsertarServicio)
        {
            List.Insert(Indice, InsertarServicio);
        }
        #endregion

        public List<Servicio> Listar()
        {
            try
            {
                DataTable dt = _oServicio.Listar();
                if (dt != null)
                {
                    List<Servicio> misservicios = new List<Servicio>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Servicio c = new Servicio();
                        c.Clave = int.Parse(dr["idservicio"].ToString());
                        c.Nombre = dr["nombre"].ToString();
                        c.PrecioUnitario = decimal.Parse(dr["preciounitario"].ToString());
                        misservicios.Add(c);
                        c = null;
                    }
                    return misservicios;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Guardar()
        {
            if (this.Count == 0)
            {
                return false;
            }
            try
            {
                Hashtable[] Misservicio = new Hashtable[this.Count];
                int indice = 0;
                foreach (Servicio s in this)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("nombre", s.Nombre);
                    ht.Add("preciounitario", s.PrecioUnitario);
                    Misservicio[indice] = ht;
                    ht = null;
                    indice++;
                }
                return (_oServicio.Guardar(Misservicio));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Actualizar(Servicio s)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("nombre", s.Nombre);
                ht.Add("preciounitario", s.PrecioUnitario);
                _oServicio.Actualizar("idservicio", s.Clave, ht);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Eliminar(Servicio BajaServicio)
        {
            try
            {
                _oServicio.Eliminar(BajaServicio.Clave);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Servicio Buscar(int clave)
        {
            DataTable dt = _oServicio.Buscar(clave);
            if (dt.Rows.Count > 0)
            {
                Servicio abc = new Servicio();
                foreach (DataRow dr in dt.Rows)
                {
                    abc.Clave = int.Parse(dr["idservicio"].ToString());
                    abc.Nombre = dr["nombre"].ToString();                    
                    abc.PrecioUnitario = decimal.Parse( dr["preciounitario"].ToString());
                }
                return abc;
            }
            else
            {
                return null;
            }

        }
    }
}

