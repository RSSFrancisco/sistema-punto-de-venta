using System;
using System.Collections.Generic;
using Datos;
using System.Data;
using System.Collections;

namespace Negocios
{
 public class RegistrarHistorial:CollectionBase
    {
     clsHistorial _oHistorial = new clsHistorial();

     public int Add(Historial NuevoHistorial)
     {
         return (List.Add(NuevoHistorial));
     }
     public int IndexOf(Historial PosicionDelHistorial)
     {
         return (List.IndexOf(PosicionDelHistorial));
     }
     public void Insert(int Indice, Historial InsertaHistorial)
     {
         List.Insert(Indice, InsertaHistorial);
     }

     public bool Eliminar(Historial HistorialAEliminar)
     {
         try
         {
             _oHistorial.Eliminar(HistorialAEliminar.Clave);
             return true;
         }
         catch (Exception ex)
         {
             
             throw new Exception(ex.Message);
         }

     }
     public List<Historial> Listar(int paginaInicial,int tamanio)
     {
         try
         {
             DataTable dt = _oHistorial.Listar(paginaInicial,tamanio);
             if (dt != null)
             {
                 List<Historial> miHistorial = new List<Historial>();
                 foreach (DataRow dr in dt.Rows)
                 {
                     Historial e = new Historial();
                     e.FechaHora = dr["fechahora"].ToString();
                     e.Comentario = dr["comentario"].ToString();
                     e.Tabla = dr["tabla"].ToString();
                     e.Clave = int.Parse(dr["idHistorial"].ToString());
                     miHistorial.Add(e);
                     e = null;
                 }
                 return miHistorial;
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
