using System;
using System.Collections.Generic;
using System.Data;
using Datos;

namespace Negocios
{
  public class RegistroInventario:RegistroVenta
    {
        clsInventario _oInventario = new clsInventario();
        public List<Venta> ListarInventario(int numeroPagina, int tamanio)
        {
            try
            {
                DataTable dt = _oInventario.ListarInventario(numeroPagina, tamanio);
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
                        // se cambio el tipo de conversion de "double" a decimal por razzones de compatibilidad con el gestor de base de datos SQLite
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
    }
}
