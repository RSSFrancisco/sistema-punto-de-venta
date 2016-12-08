using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Datos;

namespace Negocios
{
    public class RegistroVenta : CollectionBase
    {
        #region Instancias
        clsVentas _oVenta = new clsVentas();
        #endregion
        #region Metodos
        public int Add(Venta NuevoVenta)
        {
            return (List.Add(NuevoVenta));
        }
        public int IndexOf(Venta PosicionDelaVenta)
        {
            return (List.IndexOf(PosicionDelaVenta));
        }
        public void Insert(int Indice, Venta InsertarVenta) 
        {
            List.Insert(Indice, InsertarVenta);
        }
        #endregion
        #region Metodos Públicos
        public bool Eliminar(int clave)//se publica el metodo booleano Eliminar 
        {
            try//inicia el bloque try-catch
            {
                _oVenta.Eliminar(clave);
                return true;//retorna verdadero si se cumple la instruccion anterior 
            }
            catch (Exception ex)//atrapa la exepcion y la manda ala variable ex 
            {
                throw new Exception(ex.Message);//en caso de ocurra una exepción se manda un mensaje dependiendo de lo que lleve la variable ex
            }
        }
        public bool Guardar()//se publica el metodo boolenano Guardar
        {
            if (Count == 0)//si esto esta vacio entonces 
            {
                return false;//retorna un false  
            }
            try//inicia el bloque try-catch 
            {
                Hashtable[] MisVentas = new Hashtable[Count];//se crea la tabla Hastable MisProductos 
                int indice = 0;//se inicializa indice en 0 
                foreach (Venta pr in this)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("idCliente", pr.IdCliente);
                    ht.Add("fecha", pr.Fecha);
                    ht.Add("idEmpleado", pr.IdEmpleado);
                    ht.Add("importe", pr.Importe);
                    ht.Add("cambio", pr.Cambio);
                    ht.Add("total", pr.Total);
                    MisVentas[indice] = ht;
                    ht = null;
                    indice++;
                }
                return (_oVenta.Guardar(MisVentas));
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Venta> buscarVenta(string buscar)
        {
            try
            {
                 DataTable dt = _oVenta.BuscarVenta(buscar);
                if (dt != null)
                {
                    List<Venta> misVentas = new List<Venta>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Venta v = new Venta();
                        v.IdVenta = int.Parse(dr["idVenta"].ToString());
                        v.Cliente = dr["cliente"].ToString();
                        v.Fecha = DateTime.Parse(dr["fecha"].ToString());
                        v.Atendio = dr["atendio"].ToString();
                        v.Importe = decimal.Parse(dr["importe"].ToString());
                        v.Cambio = decimal.Parse(dr["cambio"].ToString());
                        v.Total = decimal.Parse(dr["total"].ToString());
                        misVentas.Add(v);
                        v = null;
                    }
                    return misVentas;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Fecha de creación: 08/10/2016
        // Ing.Francisco Reyes Sánchez
        public List<Venta> buscarVentaPorClave(int clave)
        {
            try
            {
                DataTable dt = _oVenta.BuscarVentaPorClave(clave);
                if (dt != null)
                {
                    List<Venta> misVentas = new List<Venta>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Venta v = new Venta();
                        v.IdVenta = int.Parse(dr["idVenta"].ToString());
                        v.IdCliente =int.Parse(dr["idempresa"].ToString());
                        v.Fecha = DateTime.Parse(dr["fecha"].ToString());
                        v.IdEmpleado = int.Parse(dr["idempleado"].ToString());
                        v.Importe = decimal.Parse(dr["importe"].ToString());
                        v.Cambio = decimal.Parse(dr["cambio"].ToString());
                        v.Total = decimal.Parse(dr["total"].ToString());
                        misVentas.Add(v);
                        v = null;
                    }
                    return misVentas;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Venta> buscarVentoHoy()
        {
            try
            {
                DataTable dt = _oVenta.BuscarVentaHoy();
                if (dt != null)
                {
                    List<Venta> misVentas = new List<Venta>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Venta v = new Venta();
                        v.IdVenta = int.Parse(dr["idVenta"].ToString());
                        v.Cliente = dr["cliente"].ToString();
                        v.Fecha = DateTime.Parse(dr["fecha"].ToString());
                        v.Atendio = dr["atendio"].ToString();
                        v.Importe = decimal.Parse(dr["importe"].ToString());
                        v.Cambio = decimal.Parse(dr["cambio"].ToString());
                        v.Total = decimal.Parse(dr["total"].ToString());
                        misVentas.Add(v);
                        v = null;
                    }
                    return misVentas;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Venta> Listar(int numeroPagina, int tamanio)
        {
            try
            {
                DataTable dt = _oVenta.Listar(numeroPagina, tamanio);
                if (dt != null)
                {
                    List<Venta> misVentas = new List<Venta>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Venta v = new Venta();
                        v.IdVenta = int.Parse(dr["idVenta"].ToString());
                        v.Cliente = dr["cliente"].ToString();
                        v.Fecha = DateTime.Parse(dr["fecha"].ToString());
                        v.Atendio = dr["atendio"].ToString();
                        v.Importe = decimal.Parse(dr["importe"].ToString());
                        v.Cambio = decimal.Parse(dr["cambio"].ToString());
                        v.Total = decimal.Parse(dr["total"].ToString());
                        misVentas.Add(v);
                        v = null;
                    }
                    return misVentas;
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
        public int ObtenerFolio()
        {
            return _oVenta.ObtenerFolio();
        }
        #endregion


    }
}
