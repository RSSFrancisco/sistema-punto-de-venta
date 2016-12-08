#region Referencias
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Datos;
#endregion

namespace Negocios
{
  public  class RegistrarEmpresa:CollectionBase
  {
      #region Atributos
      clsEmpresa _oEmpresa = new clsEmpresa();
      #endregion
      #region Metodos de la colecciòn base
      public int Add(Empresa NuevaEmpresa)
      {
          return (List.Add(NuevaEmpresa));
      }
      public int IndexOf(Empresa PosicionDeLaEmpresa)
      {
          return (List.IndexOf(PosicionDeLaEmpresa));
      }
      public void Insert(int Indice,Empresa InsertarEmpresa)
      {
          List.Insert(Indice, InsertarEmpresa);
      }
#endregion

     
      public bool Guardar()
      {
          if (this.Count == 0)
          {
              return false;
          }
          try
          {
              Hashtable[] MiEmpresa = new Hashtable[this.Count];
              int indice = 0;
              foreach (Empresa e in this)
              {
                  Hashtable HT = new Hashtable();
                  HT.Add("rfc", e.Rfc);
                  HT.Add("siglas", e.Siglas);
                  HT.Add("nombre", e.Nombre);
                  HT.Add("giro", e.Giro);
                  HT.Add("direccion", e.Direccion);
                  HT.Add("colonia", e.Colonia);
                  HT.Add("ciudad", e.Ciudad);
                  HT.Add("estado", e.Estado);
                  HT.Add("cp", e.Cp);
                  HT.Add("telefono", e.Telefono);
                  MiEmpresa[indice] = HT;
                  HT = null;
                  indice++;
              }
              return (_oEmpresa.Guardar(MiEmpresa));
          }
          catch (Exception)
          {
              return false;
          }


      }
      public bool Actualizar(Empresa e) 
      {
          try
          {
              Hashtable ht = new Hashtable();
              ht.Add("rfc", e.Rfc);
              ht.Add("siglas", e.Siglas);
              ht.Add("nombre", e.Nombre);
              ht.Add("giro", e.Giro);
              ht.Add("direccion", e.Direccion);
              ht.Add("colonia", e.Colonia);
              ht.Add("ciudad", e.Ciudad);
              ht.Add("estado", e.Estado);
              ht.Add("cp", e.Cp);
              ht.Add("telefono", e.Telefono);
             _oEmpresa.Actualizar("idempresa", e.Clave, ht);
              return true;
          }
          catch (Exception ex)
          {
              throw new Exception(ex.Message);
          }
      }

      public bool Eliminar(Empresa EmpresaAEliminar)
      {
          try
          {
              _oEmpresa.Eliminar(EmpresaAEliminar.Clave);
              return true;
          }
          catch (Exception ex)
          {
              throw new Exception(ex.Message);
          }
      }

      public List<Empresa>Listar()
      {
          try
          {
              DataTable dt = _oEmpresa.Listar();
              if (dt != null)
              {
                  List<Empresa> miEmpresa = new List<Empresa>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Empresa e = new Empresa();
                      e.Rfc = dr["rfc"].ToString();
                      e.Siglas = dr["siglas"].ToString();
                      e.Nombre = dr["nombre"].ToString();
                      e.Giro = dr["giro"].ToString();
                      e.Direccion = dr["direccion"].ToString();
                      e.Colonia = dr["colonia"].ToString();
                      e.Ciudad = dr["ciudad"].ToString();
                      e.Estado = dr["estado"].ToString();
                      e.Cp = int.Parse(dr["cp"].ToString());
                      e.Telefono = dr["telefono"].ToString();
                      e.Clave = int.Parse(dr["idempresa"].ToString());
                      miEmpresa.Add(e);
                      e = null;
                  }
                  return miEmpresa;
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