#region Refererencias
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Datos;
#endregion
namespace Negocios
{
 public class RegistroCategoria:CollectionBase
    {
        clsCategoria _oCategoria = new clsCategoria();

        public int Add(Categoria NuevaCategoria)
        {
            return (List.Add(NuevaCategoria));
        }
        public int IndexOf(Categoria PosicionDeLaCategoria)
        {
            return (List.IndexOf(PosicionDeLaCategoria));
        }
        public void Insert(int Indice, Categoria InsertarCategoria)
        {
            List.Insert(Indice, InsertarCategoria);
        }
        public bool GuardarCategoria()
        {
            if (Count == 0)
            {
                return false;
            }
            try
            {
                Hashtable[] MisCategorias = new Hashtable[Count];
                int indice = 0;
                foreach (Categoria e in this)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("nombre" ,e.Nombre);
                    ht.Add("descripcion", e.Descripcion);
                    MisCategorias[indice] = ht;
                    ht = null;
                    indice++;

                }
                return (_oCategoria.Guardar(MisCategorias));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            }
        public List<Categoria> Listar()
        {
            try
            {
                DataTable dt = _oCategoria.Listar();
                if (dt != null)
                {

                    List<Categoria> MisCategorias = new List<Categoria>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        Categoria e = new Categoria();
                        e.Clave = int.Parse(dr["idCategoria"].ToString());
                        e.Nombre = dr["nombre"].ToString();
                        e.Descripcion = dr["descripcion"].ToString();
                        MisCategorias.Add(e);
                        e = null;
                    }
                    return MisCategorias;
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
        public bool Actualizar(Categoria e)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("nombre", e.Nombre);
                ht.Add("descripcion", e.Descripcion);
                _oCategoria.Actualizar("idcategoria", e.Clave, ht);
                return true;
            }            
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool Eliminar(Categoria CategoriaAEliminar)
        {
            try
            {
                _oCategoria.eliminar(CategoriaAEliminar.Clave);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
    }
}
