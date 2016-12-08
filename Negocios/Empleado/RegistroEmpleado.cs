using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Datos;

namespace Negocios
{
  public  class RegistroEmpleado:CollectionBase
    {
        #region Atributos
        clsEmpleado _oEmpleado = new clsEmpleado();
        #endregion

        #region Métodos de la colección base.
        public int Add(Empleado NuevoEmpleado)
        {
            return (List.Add(NuevoEmpleado));
        }
        public int IndexOf(Empleado PosicionDelEmpleado)
        {
            return (List.IndexOf(PosicionDelEmpleado));
        }
        public void Insert(int Indice, Empleado InsertaeEmpleado)
        {
            List.Insert(Indice, InsertaeEmpleado);
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
                Hashtable[] MisEmpleados = new Hashtable[this.Count];
                int indice = 0;
                foreach (Empleado e in this)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("nombre", e.Nombre);
                    ht.Add("appaterno", e.ApPaterno);
                    ht.Add("apmaterno", e.ApMaterno);
                    ht.Add("nss", e.NSS);
                    ht.Add("fechanacimiento", e.FechaNacimiento.ToString("yyyy/MM/dd hh:mm:ss"));
                    ht.Add("direccion", e.Direccion);
                    ht.Add("colonia", e.Colonia);
                    ht.Add("ciudad", e.Ciudad);
                    ht.Add("estado", e.Estado);
                    ht.Add("cp", e.CP);
                    ht.Add("telefono", e.Telefono);
                    ht.Add("correo", e.Correo);
                    ht.Add("nivelescolar", e.NivelEscolar);
                    ht.Add("especialidad", e.Especialidad);
                   
                    MisEmpleados[indice] = ht;
                    ht = null;
                    indice++;
                }
                return (_oEmpleado.Guardar(MisEmpleados));
            }
            catch (Exception)
            {
                return false;
            }
        }
      /// <summary>
      /// Metodo encargado de actualizar los datos que recibe de la capa de negocios 
      /// </summary>
      /// <param name="e"> objeto que se encarga de contener los datos que se ingresan temporalmente</param>
      /// <returns></returns>
      public bool Actualizar(Empleado e)
      {
          try
          {
              Hashtable ht = new Hashtable();
              ht.Add("nombre", e.Nombre);
              ht.Add("appaterno", e.ApPaterno);
              ht.Add("apmaterno", e.ApMaterno);
              ht.Add("nss", e.NSS);
              ht.Add("fechanacimiento", e.FechaNacimiento.ToString("yyyy/MM/dd hh:mm:ss"));
              ht.Add("direccion", e.Direccion);
              ht.Add("colonia", e.Colonia);
              ht.Add("ciudad", e.Ciudad);
              ht.Add("estado", e.Estado);
              ht.Add("cp", e.CP);
              ht.Add("telefono", e.Telefono);
              ht.Add("correo", e.Correo);
              ht.Add("nivelescolar", e.NivelEscolar);
              ht.Add("especialidad", e.Especialidad);
              _oEmpleado.Actualizar("idempleado", e.Clave, ht);
              return true;
          }
          catch (Exception ex)
          {
              throw new Exception(ex.Message);
          }
      }
      

      /// <summary>
      /// Metodo encargado de eliminar el registro seleccionado en la capa de negocios
      /// </summary>
      /// <param name="EmpleadoAEliminar"></param>
      /// <returns></returns>

        public bool Eliminar(Empleado EmpleadoAEliminar)
        {
            try
            {
                _oEmpleado.Eliminar(EmpleadoAEliminar.Clave);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Empleado BuscarPorNombre(string nombre)//publica el metodo Buscar del tipo Producto que lleva la variable clave de tipo entero
        {
            DataTable dt = _oEmpleado.BuscarPorNombre(nombre);//se declara la tabla dt y se le asigna lo que trae el objeto _oProducto por el metodo buscar(clave)
            if (dt.Rows.Count > 0)//si dt tiene en sus filas mas de 0 entonces 
            {
                Empleado abc = new Empleado();//se crea un objeto abc del tipo Producto 
                foreach (DataRow dr in dt.Rows)//se hace un foreach a los datos de la tabla que estan en dt 
                {
                    abc.Clave = int.Parse(dr["idempleado"].ToString());//al objeto abc se le asigna clave la cual trae idEmpleado de la BD 
                    abc.Nombre = dr["nombre"].ToString();//al objeto abc se le asigna Nombre la cual trae nombre de la BD
                    abc.ApPaterno= dr["appaterno"].ToString();//al objeto abc se le asigna ApPaterno la cual trae appaterno de la BD
                    abc.ApMaterno = dr["apmaterno"].ToString();//al objeto abc se le asigna ApMaterno la cual trae apmaterno de la BD
                    abc.NSS = dr["nss"].ToString();//al objeto abc se le asigna NSS la cual trae nss de la BD
                    abc.FechaNacimiento = DateTime.Parse(dr["fechanacimiento"].ToString());//al objeto abc se le asigna FechaNacimiento el cual trae fechanacimiento de la BD
                    abc.Direccion = dr["direccion"].ToString();//al objeto abc se le asigna Direccion el cual trae direccion de la BD
                    abc.Colonia = dr["colonia"].ToString();//al objeto abc se le asigna Colonia el cual trae colonia de la BD
                    abc.Ciudad = dr["ciudad"].ToString();//al objeto abc se le asigna Ciudad el cual trae ciudad de la BD
                    abc.Estado= dr["estado"].ToString();//al objeto abc se le asigna Estado el cual trae estado de la BD
                    abc.CP = int.Parse(dr["cp"].ToString());//al objeto abc se le asigna CP el cual trae cp de la BD
                    abc.Telefono = dr["telefono"].ToString();//al objeto abc se le asigna Telefono el cual trae telefono de la BD
                    abc.Correo=dr["correo"].ToString();//al objeto abc se le asigna Correo el cual trae telefono de la BD
                    abc.NivelEscolar = dr["nivelescolar"].ToString();//al objeto abc se le asigna NivelEscolar el cual trae nivelescolar de la BD
                    abc.Especialidad = dr["especialidad"].ToString();//al objeto abc se le asigna Especialidad el cual trae especialidad de la BD


                }
                return abc;//retorna lo que trae abc
            }
            else
            {//si no 
                return null;//retorna nullo
            }

        }
   
        
      /// <summary>
      /// Enlista los datos de la tabla Empleado
      /// </summary>
      /// <returns></returns>
        public List<Empleado>Listar()
        {
            try
            {
                DataTable dt=_oEmpleado.Listar();
                if (dt != null)
                {
                    List<Empleado> misEmpleados = new List<Empleado>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Empleado e = new Empleado();
                        e.Nombre = dr["nombre"].ToString();
                        e.ApPaterno = dr["appaterno"].ToString();
                        e.ApMaterno = dr["apmaterno"].ToString();
                        e.NSS = dr["nss"].ToString();
                        e.FechaNacimiento = DateTime.Parse(dr["fechanacimiento"].ToString());
                        e.Direccion = dr["direccion"].ToString();
                        e.Colonia = dr["colonia"].ToString();
                        e.Ciudad = dr["ciudad"].ToString();
                        e.Estado = dr["estado"].ToString();
                        e.CP = int.Parse(dr["cp"].ToString());
                        e.Telefono = dr["telefono"].ToString();
                        e.Correo = dr["correo"].ToString();
                        e.NivelEscolar = dr["nivelescolar"].ToString();
                        e.Especialidad = dr["especialidad"].ToString();
                        e.Clave = int.Parse(dr["idempleado"].ToString());
                        misEmpleados.Add(e);
                        e = null;
                    }
                    return misEmpleados;
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
        public List<Empleado> ListarAscendente()
        {
            try
            {
                DataTable dt = _oEmpleado.ListarAscendente();
              
                if (dt != null)
                {
                    List<Empleado> misEmpleados = new List<Empleado>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Empleado e = new Empleado();
                        e.Nombre = dr["nombre"].ToString();
                        e.ApPaterno = dr["appaterno"].ToString();
                        e.ApMaterno = dr["apmaterno"].ToString();
                        e.NSS = dr["nss"].ToString();
                        e.FechaNacimiento = DateTime.Parse(dr["fechanacimiento"].ToString());
                        e.Direccion = dr["direccion"].ToString();
                        e.Colonia = dr["colonia"].ToString();
                        e.Ciudad = dr["ciudad"].ToString();
                        e.Estado = dr["estado"].ToString();
                        e.CP = int.Parse(dr["cp"].ToString());
                        e.Telefono = dr["telefono"].ToString();
                        e.Correo = dr["correo"].ToString();
                        e.NivelEscolar = dr["nivelescolar"].ToString();
                        e.Especialidad = dr["especialidad"].ToString();
                        e.Clave = int.Parse(dr["idempleado"].ToString());
                        misEmpleados.Add(e);
                        e = null;
                    }
                    return misEmpleados;
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
        public List<Empleado> ListarDescendente()
        {
            try
            {
                DataTable dt = _oEmpleado.ListarDescendente();

                if (dt != null)
                {
                    List<Empleado> misEmpleados = new List<Empleado>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Empleado e = new Empleado();
                        e.Nombre = dr["nombre"].ToString();
                        e.ApPaterno = dr["appaterno"].ToString();
                        e.ApMaterno = dr["apmaterno"].ToString();
                        e.NSS = dr["nss"].ToString();
                        e.FechaNacimiento = DateTime.Parse(dr["fechanacimiento"].ToString());
                        e.Direccion = dr["direccion"].ToString();
                        e.Colonia = dr["colonia"].ToString();
                        e.Ciudad = dr["ciudad"].ToString();
                        e.Estado = dr["estado"].ToString();
                        e.CP = int.Parse(dr["cp"].ToString());
                        e.Telefono = dr["telefono"].ToString();
                        e.Correo = dr["correo"].ToString();
                        e.NivelEscolar = dr["nivelescolar"].ToString();
                        e.Especialidad = dr["especialidad"].ToString();
                        e.Clave = int.Parse(dr["idempleado"].ToString());
                        misEmpleados.Add(e);
                        e = null;
                    }
                    return misEmpleados;
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
      
        public List<Empleado> ListarApellidoPaterno(string appaterno)
        {
            try
            {
                DataTable dt = _oEmpleado.ListarApellidoPaterno(appaterno.ToString());

                if (dt != null)
                {
                    List<Empleado> misEmpleados = new List<Empleado>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Empleado e = new Empleado();
                        e.Nombre = dr["nombre"].ToString();
                        e.ApPaterno = dr["appaterno"].ToString();
                        e.ApMaterno = dr["apmaterno"].ToString();
                        e.NSS = dr["nss"].ToString();
                        e.FechaNacimiento = DateTime.Parse(dr["fechanacimiento"].ToString());
                        e.Direccion = dr["direccion"].ToString();
                        e.Colonia = dr["colonia"].ToString();
                        e.Ciudad = dr["ciudad"].ToString();
                        e.Estado = dr["estado"].ToString();
                        e.CP = int.Parse(dr["cp"].ToString());
                        e.Telefono = dr["telefono"].ToString();
                        e.Correo = dr["correo"].ToString();
                        e.NivelEscolar = dr["nivelescolar"].ToString();
                        e.Especialidad = dr["especialidad"].ToString();
                        e.Clave = int.Parse(dr["idempleado"].ToString());
                        misEmpleados.Add(e);
                        e = null;
                    }
                    return misEmpleados;
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
        public List<Empleado> ListarEntre(string minimo, string maximo)
        {
            try
            {
                DataTable dt = _oEmpleado.ListarEntre(minimo,maximo);

                if (dt != null)
                {
                    List<Empleado> misEmpleados = new List<Empleado>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Empleado e = new Empleado();
                        e.Nombre = dr["nombre"].ToString();
                        e.ApPaterno = dr["appaterno"].ToString();
                        e.ApMaterno = dr["apmaterno"].ToString();
                        e.NSS = dr["nss"].ToString();
                        e.FechaNacimiento = DateTime.Parse(dr["fechanacimiento"].ToString());
                        e.Direccion = dr["direccion"].ToString();
                        e.Colonia = dr["colonia"].ToString();
                        e.Ciudad = dr["ciudad"].ToString();
                        e.Estado = dr["estado"].ToString();
                        e.CP = int.Parse(dr["cp"].ToString());
                        e.Telefono = dr["telefono"].ToString();
                        e.Correo = dr["correo"].ToString();
                        e.NivelEscolar = dr["nivelescolar"].ToString();
                        e.Especialidad = dr["especialidad"].ToString();
                        e.Clave = int.Parse(dr["idempleado"].ToString());
                        misEmpleados.Add(e);
                        e = null;
                    }
                    return misEmpleados;
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
        public List<Empleado> ListarNombre(string nombre)
        {
            try
            {
                DataTable dt = _oEmpleado.ListarNombre(nombre.ToString());

                if (dt != null)
                {
                    List<Empleado> misEmpleados = new List<Empleado>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Empleado e = new Empleado();
                        e.Nombre = dr["nombre"].ToString();
                        e.ApPaterno = dr["appaterno"].ToString();
                        e.ApMaterno = dr["apmaterno"].ToString();
                        e.NSS = dr["nss"].ToString();
                        e.FechaNacimiento = DateTime.Parse(dr["fechanacimiento"].ToString());
                        e.Direccion = dr["direccion"].ToString();
                        e.Colonia = dr["colonia"].ToString();
                        e.Ciudad = dr["ciudad"].ToString();
                        e.Estado = dr["estado"].ToString();
                        e.CP = int.Parse(dr["cp"].ToString());
                        e.Telefono = dr["telefono"].ToString();
                        e.Correo = dr["correo"].ToString();
                        e.NivelEscolar = dr["nivelescolar"].ToString();
                        e.Especialidad = dr["especialidad"].ToString();
                        e.Clave = int.Parse(dr["idempleado"].ToString());
                        misEmpleados.Add(e);
                        e = null;
                    }
                    return misEmpleados;
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
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <returns></returns>
        public bool AgregarUsuario(Empleado x,int estatus)
        {
            try
            {
                Hashtable[] MisEmpleados = new Hashtable[1];
                 
                    Hashtable ht = new Hashtable();
                    ht.Add("nick", x.Nick);
                    ht.Add("contrasenia", x.Contrasenia);
                    ht.Add("idempleado", x.Clave);
                    MisEmpleados[0] = ht;
                    ht = null;
                    _oEmpleado.AgregarUsuario(MisEmpleados,estatus);
                  
                
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
        public List<Empleado> ListarSinUsuario()
        {
            try
            {
                DataTable dt = _oEmpleado.sinUsuario();
                if (dt != null)
                {
                    List<Empleado> misEmpleados = new List<Empleado>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Empleado e = new Empleado();
                        e.Nombre = dr["nombre"].ToString();
                        e.ApPaterno = dr["appaterno"].ToString();
                        e.ApMaterno = dr["apmaterno"].ToString();
                        e.NSS = dr["nss"].ToString();
                        e.FechaNacimiento = DateTime.Parse(dr["fechanacimiento"].ToString());
                        e.Direccion = dr["direccion"].ToString();
                        e.Colonia = dr["colonia"].ToString();
                        e.Ciudad = dr["ciudad"].ToString();
                        e.Estado = dr["estado"].ToString();
                        e.CP = int.Parse(dr["cp"].ToString());
                        e.Telefono = dr["telefono"].ToString();
                        e.Correo = dr["correo"].ToString();
                        e.NivelEscolar = dr["nivelescolar"].ToString();
                        e.Especialidad = dr["especialidad"].ToString();
                        e.Clave = int.Parse(dr["idempleado"].ToString());
                        misEmpleados.Add(e);
                        e = null;
                    }
                    return misEmpleados;
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
