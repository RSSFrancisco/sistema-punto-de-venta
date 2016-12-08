#region Librerias
using System;//libreria que hace uso de la interfaz de sistema 
using System.Collections.Generic;
using System.Collections;//libreria que hace uso de la coleccion de datos del sistema
using System.Data;
using Datos;
#endregion

namespace Negocios
{
  public  class RegistroRequisicion:CollectionBase
    {
      clsRequisicion objRequisicion = new clsRequisicion();

      #region Métodos de la colección base.
      public int Add(Requisicion NuevoRequisicion)
      {
          return (List.Add(NuevoRequisicion));
      }
      public int IndexOf(Requisicion PosicionDelaRequisicion)
      {
          return (List.IndexOf(PosicionDelaRequisicion));
      }
      public void Insert(int Indice, Requisicion InsertaRequisicion)
      {
          List.Insert(Indice, InsertaRequisicion);
      }
      #endregion
    
      public List<Requisicion> Listar()
      {

          try
          {
              DataTable dt = objRequisicion.Listar();
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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
      public List<Requisicion> ListarTodo()
      {

          try
          {
              DataTable dt = objRequisicion.ListarTodo();
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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
      public List<Requisicion> ListarPorTop()
      {

          try
          {
              DataTable dt = objRequisicion.ListarPorTopUltimo();
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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
      public List<Requisicion> ListarEliminados()
      {

          try
          {
              DataTable dt = objRequisicion.ListarEliminados();
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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

      public List<Requisicion> ListarAscendente()
      {

          try
          {
              DataTable dt = objRequisicion.ListarAscendente();
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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
      public List<Requisicion> ListarDescendente()
      {

          try
          {
              DataTable dt = objRequisicion.ListarDecendente();
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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
      public List<Requisicion> ListarRecientes()
      {

          try
          {
              DataTable dt = objRequisicion.ListarRecientes();
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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
      public List<Requisicion> ListarAntiguos()
      {

          try
          {
              DataTable dt = objRequisicion.ListarAntiguos();
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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
      public List<Requisicion> ListarPorCliente(string cliente)
      {

          try
          {
              DataTable dt = objRequisicion.ListarPorCliente(cliente);
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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
      public List<Requisicion> ListarPorEmpleado(string empleado)
      {

          try
          {
              DataTable dt = objRequisicion.ListarPorEmpleado(empleado);
              if (dt != null)
              {
                  List<Requisicion> misRequisiciones = new List<Requisicion>();
                  foreach (DataRow dr in dt.Rows)
                  {
                      Requisicion r = new Requisicion();
                      r.Folio = int.Parse(dr["folio"].ToString());
                      r.TotalFilas = dr["numreporte"].ToString();
                      r.Fecha = DateTime.Parse(dr["fecha"].ToString());
                      r.Cliente = dr["cliente"].ToString();
                      r.Direccion = dr["direccion"].ToString();
                      r.Ciudad = dr["ciudad"].ToString();
                      r.Telefono = dr["telefono"].ToString();
                      r.Empleado = dr["empleado"].ToString();
                      r.TipoServicio = dr["tiposervicio"].ToString();
                      r.Entrada = dr["entrada"].ToString();
                      r.Salida = dr["salida"].ToString();
                      r.ServicioADomicilio = dr["serviciodomicilio"].ToString();
                      r.HoraEntrada = dr["horaentrada"].ToString();
                      r.HoraSalida = dr["horasalida"].ToString();
                      r.Nombre = dr["nombre"].ToString();
                      r.Marca = dr["marca"].ToString();
                      r.Modelo = dr["modelo"].ToString();
                      r.NumSerie = dr["numserie"].ToString();
                      r.CondicionEquipo = dr["condicionequipo"].ToString();
                      r.FallaReportada = dr["fallareportada"].ToString();
                      r.ReporteIng = dr["reporteing"].ToString();
                      r.Observaciones = dr["observaciones"].ToString();
                      //r.IdProducto = int.Parse(dr["idproducto"].ToString());
                      r.ManoDeObra = decimal.Parse(dr["manode_obra"].ToString());
                      r.CostoRefaccion = decimal.Parse(dr["costorefaccion"].ToString());
                      r.Total = decimal.Parse(dr["total"].ToString());
                      misRequisiciones.Add(r);
                      r = null;

                  }
                  return misRequisiciones;
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
      public bool Actualizar(Requisicion r)
      {
          try
          {
              Hashtable ht = new Hashtable();
              ht.Add("numreporte", r.TotalFilas);
              ht.Add("fecha", r.Fecha.ToString("yyyy/MM/dd"));
              ht.Add("cliente", r.Cliente);
              ht.Add("direccion", r.Direccion);
              ht.Add("ciudad", r.Ciudad);
              ht.Add("telefono", r.Telefono);
              ht.Add("empleado", r.Empleado);
              ht.Add("tiposervicio", r.TipoServicio);
              ht.Add("entrada", r.Entrada);
              ht.Add("salida", r.Salida);
              ht.Add("serviciodomicilio", r.ServicioADomicilio);
              ht.Add("horaentrada", r.HoraEntrada);
              ht.Add("horasalida", r.HoraSalida);
              ht.Add("nombre", r.Nombre);
              ht.Add("marca", r.Marca);
              ht.Add("modelo", r.Modelo);
              ht.Add("numserie", r.NumSerie);
              ht.Add("condicionequipo", r.CondicionEquipo);
              ht.Add("fallareportada", r.FallaReportada);
              ht.Add("reporteing", r.ReporteIng);
              ht.Add("observaciones", r.Observaciones);
              //ht.Add("idproducto", r.IdProducto);
              ht.Add("manode_obra", r.ManoDeObra);
              ht.Add("costorefaccion", r.CostoRefaccion);
              ht.Add("total", r.Total);
              objRequisicion.Actualizar("folio", r.Folio, ht);
              return true;
          }
          catch (Exception ex)
          {
              
              throw new Exception(ex.Message);
          }

      }
      public bool Eliminar(Requisicion BajaRequisicion)
      {
          try
          {
              objRequisicion.Eliminar(BajaRequisicion.Folio);
              
              return true;
          }
          catch (Exception ex)
          {
              
              throw new Exception(ex.Message);
          }
      }
    
     
      public bool BorrarPermanente(Requisicion BorraRequisicion)
      {
          try
          {
              objRequisicion.BorraPermanente(BorraRequisicion.Folio);
              return true;
          }
          catch (Exception ex)
          {

              throw new Exception(ex.Message);
          }
      }
      public bool LimpiarPapelera(Requisicion BorraRequisicion)
      {
          try
          {
              objRequisicion.LimpiarPapelera();
              return true;
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
              Hashtable[] MisRequisiciones = new Hashtable[this.Count];
              int indice = 0;
              foreach (Requisicion r in this)
              {
                  Hashtable ht = new Hashtable();
                  ht.Add("numreporte",r.TotalFilas);
                  ht.Add("fecha", r.Fecha.ToString("yyyy/MM/dd"));
                  ht.Add("cliente", r.Cliente);
                  ht.Add("direccion", r.Direccion);
                  ht.Add("ciudad", r.Ciudad);
                  ht.Add("telefono", r.Telefono);
                  ht.Add("empleado", r.Empleado);
                  ht.Add("tiposervicio", r.TipoServicio);
                  ht.Add("entrada", r.Entrada);
                  ht.Add("salida", r.Salida);
                  ht.Add("serviciodomicilio", r.ServicioADomicilio);
                  ht.Add("horaentrada", r.HoraEntrada);
                  ht.Add("horasalida", r.HoraSalida);
                  ht.Add("nombre", r.Nombre);
                  ht.Add("marca", r.Marca);
                  ht.Add("modelo", r.Modelo);
                  ht.Add("numserie", r.NumSerie);
                  ht.Add("condicionequipo", r.CondicionEquipo);
                  ht.Add("fallareportada", r.FallaReportada);
                  ht.Add("reporteing", r.ReporteIng);
                  ht.Add("observaciones", r.Observaciones);
                  //ht.Add("idproducto", r.IdProducto);
                  ht.Add("manode_obra", r.ManoDeObra);
                  ht.Add("costorefaccion", r.CostoRefaccion);
                  ht.Add("total", r.Total);
                  MisRequisiciones[indice] = ht;
                  ht = null;
                  indice++;
              }
              return (objRequisicion.GuardarRequisicion(MisRequisiciones));
          }
          catch (Exception )
          {

              return false;
          }

      }
      //List<Producto> misProductos;
      //List<Servicio> misServicios;

      //public List<Servicio> Servicios
      //{
      //    set { misServicios = value; }
      //    get { return misServicios; }
      //}

      //public List<Producto> Productos
      //{
      //    set { misProductos = value; }
      //    get { return misProductos; }
      //}

      //public long ObtenerFolio()
      //{
      //    return cl.ObtenerFolio();
      //}


      //public bool Guardar() {
      //    try
      //    {
              //if ((misProductos.Count == 0) && (misServicios.Count == 0)) return false;
              //Hashtable Datos = new Hashtable();
              //long folioActual = 0;
              //foreach (Requisicion r in this)
              //{
              //    Datos.Add("folio", r.Folio.ToString());
              //    Datos.Add("lugar", r.Lugar);
              //    Datos.Add("idempresa", r.Idempresa.ToString());
              //    Datos.Add("idempleado", r.IdEmpleado.ToString());
              //    Datos.Add("fecha", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
              //    folioActual = r.Folio;
              //}
              //Hashtable [] ArregloProducto =new Hashtable[misProductos.Count];
              //int indice = 0;
              //foreach (Producto p in misProductos) {
              //    Hashtable ht = new Hashtable();
              //    ht.Add("folio", folioActual);
              //    ht.Add("idproducto", p.Clave.ToString());
              //    ht.Add("precio", p.PrecioUnitario.ToString());
              //    ArregloProducto[indice]=ht;
              //    ht=null;
              //    indice++;
              //}
              //indice = 0;
              //Hashtable[] ArregloServicios = new Hashtable[misServicios.Count];
              //foreach (Servicio s in misServicios) {
              //    Hashtable ht = new Hashtable();
              //    ht.Add("folio", folioActual);
              //    ht.Add("idservicio", s.Clave.ToString());
              //    ht.Add("preciounitario",  s.PrecioUnitario.ToString());
              //    ht.Add("cantidad", s.Cantidad.ToString());
              //    ArregloServicios[indice] = ht;
              //    ht = null;
              //    indice++;
              }
          //    cl.Guardar(Datos,ArregloProducto,ArregloServicios);
          //    return true;
          //}
          //catch (Exception ex)
          //{             
          //    throw new Exception(ex.Message);
          //}
      //}


    }
