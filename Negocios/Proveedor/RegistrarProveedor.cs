using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Datos;

namespace Negocios
{
    public class RegistrarProveedor : CollectionBase
    {
        #region Atributos
        clsProveedor _pro = new clsProveedor();
        #endregion

        #region Metodos
        public int Add(Proveedor NuevoProveedor)
        {
            return (List.Add(NuevoProveedor));
        }

        public int IndexOf(Proveedor Posicion)
        {
            return (List.IndexOf(Posicion));
        }

        public void Insert(int Indice, Proveedor InsertarProveedor) 
        {
            List.Insert(Indice, InsertarProveedor);
        }
        #endregion

        public bool Guardar()
        {
            if (Count == 0)
            {
                return false;
            }
            try
            {
                Hashtable[] MisProveedores = new Hashtable[this.Count];
                int indice = 0;
                foreach (Proveedor p in this)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("rfc", p.Rfc);
                    ht.Add("nombre", p.Nombre);
                    ht.Add("direccion", p.Direccion);
                    ht.Add("colonia", p.Colonia);
                    ht.Add("ciudad", p.Ciudad);
                    ht.Add("estado", p.Estado);
                    ht.Add("cp", p.Cp);
                    ht.Add("telefono", p.Telefono);
                    ht.Add("correo", p.Correo);
                    MisProveedores[indice] = ht;
                    ht = null;
                    indice++;
                }
                return (_pro.Guardar(MisProveedores));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Actualizar(Proveedor p)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("rfc", p.Rfc);
                ht.Add("nombre", p.Nombre);
                ht.Add("direccion", p.Direccion);
                ht.Add("colonia", p.Colonia);
                ht.Add("ciudad", p.Ciudad);
                ht.Add("estado", p.Estado);
                ht.Add("cp", p.Cp);
                ht.Add("telefono", p.Telefono);
                ht.Add("correo", p.Correo);
                _pro.Actualizar("idproveedor", p.Clave, ht);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Eliminar(Proveedor BajaProveedor)
        {
            try
            {
                _pro.Eliminar(BajaProveedor.Clave);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Proveedor> Listar()
        {
            try
            {
                DataTable dt = _pro.Listar();
                if (dt != null)
                {
                    List<Proveedor> misProveedores = new List<Proveedor>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Proveedor p = new Proveedor();
                        p.Clave = int.Parse(dr["idproveedor"].ToString());
                        p.Rfc = dr["rfc"].ToString();
                        p.Nombre = dr["nombre"].ToString();
                        p.Direccion = dr["direccion"].ToString();
                        p.Colonia = dr["colonia"].ToString();
                        p.Ciudad = dr["ciudad"].ToString();
                        p.Estado = dr["estado"].ToString();
                        p.Cp = int.Parse(dr["cp"].ToString());
                        p.Telefono = dr["telefono"].ToString();
                        p.Correo = dr["correo"].ToString();
                        misProveedores.Add(p);
                        p = null;
                    }
                    return misProveedores;
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