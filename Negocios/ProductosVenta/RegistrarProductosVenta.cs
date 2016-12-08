#region Librerias
using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Datos;
#endregion

namespace Negocios
{
    public class RegistrarProductosVenta : CollectionBase
    {
        #region Instancias
        clsProductosVenta _oProductosVenta = new clsProductosVenta();
        #endregion

        #region Metodos
        public int Add(ProductosVenta NuevoProductosVenta)
        {
            return (List.Add(NuevoProductosVenta));
        }
        public int IndexOf(ProductosVenta PosicionDelProductosVenta)
        {
            return (List.IndexOf(PosicionDelProductosVenta));
        }
        public void Insert(int Indice, ProductosVenta InsertarProductosVenta)
        {
            List.Insert(Indice, InsertarProductosVenta);
        }

        public ProductosVenta Buscar(int numVenta)
        {
            DataTable dt = _oProductosVenta.ListarProductosVenta(numVenta);
            if (dt.Rows.Count > 0)
            {
                ProductosVenta abc = new ProductosVenta();
                foreach (DataRow dr in dt.Rows)
                {
                    abc.IdProductosVenta = int.Parse(dr["idProductosVenta"].ToString());
                    abc.IdProducto = int.Parse(dr["idProducto"].ToString());
                    abc.NumVenta = int.Parse(dr["idVenta"].ToString());
                    abc.Cantidad = int.Parse(dr["cantidad"].ToString());
                    abc.SubTotal = double.Parse(dr["subtotal"].ToString());
                }
                return abc;
            }
            else
            {
                return null;
            }

        }
        public ProductosVenta verificarProductoVenta(int idProducto, int num_venta)
        {
            DataTable dt = _oProductosVenta.verificarProductoVenta(idProducto, num_venta);
            if (dt.Rows.Count > 0)
            {
                ProductosVenta abc = new ProductosVenta();
                foreach (DataRow dr in dt.Rows)
                {
                    abc.IdProductosVenta = int.Parse(dr["idProductosVenta"].ToString());

                }
                return abc;
            }
            else
            {
                return null;
            }
        }
        //public ProductosVenta calcularTotalVenta(int numVenta)
        //{
        //    DataTable dt = _oProductosVenta.calcularTotalVenta(numVenta);
        //    if (dt.Rows.Count > 0)
        //    {
        //        ProductosVenta abc = new ProductosVenta();
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            abc.Total = double.Parse(dr["total"].ToString());

        //        }
        //        return abc;
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //}
        public bool Guardar()
        {
            if (this.Count == 0)
            {
                return false;
            }
            try
            {
                Hashtable[] MisProductosVenta = new Hashtable[this.Count];
                int indice = 0;
                foreach (ProductosVenta pr in this)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("idproducto", pr.IdProducto);
                    ht.Add("idVenta", pr.NumVenta);
                    //ht.Add("fecha", pr.Fecha);
                    ht.Add("cantidad", pr.Cantidad);
                    ht.Add("subtotal", pr.SubTotal);
                    MisProductosVenta[indice] = ht;
                    ht = null;
                    indice++;
                }
                return (_oProductosVenta.Guardar(MisProductosVenta));
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Actualizar(ProductosVenta pv)// se crea el metodo booleano Actualizar 
        {
            try//inicia el bloque try-catch
            {
                Hashtable ht = new Hashtable();
                ht.Add("idproducto", pv.IdProducto);
                ht.Add("idVenta", pv.NumVenta);
                ht.Add("cantidad", pv.Cantidad);
                ht.Add("subtotal", pv.SubTotal);

                _oProductosVenta.Actualizar("idProductosVenta", pv.IdProductosVenta, ht);//al objeto _oProducto hace referncia al metodo actualizar por medio de p.Clave 
                return true;//si se cumple la instruccion anterior retorna el valo como verdadero 
            }
            catch (Exception ex)//en caso de que ocurra una exepción en tiempo de ejecución se envia lo que encuentra a la variable ex 
            {
                throw new Exception(ex.Message);//manda el mensaje de error el cual cacho la variable ex 
            }
        }

        public List<ProductosVenta> ListarProductosVenta(int numVenta)//publica una lista del tipo Producto con el Nombre de Listar 
        {
            try//inicia el bloque try-catch
            {
                DataTable dt = _oProductosVenta.ListarProductosVenta(numVenta);//se crea la tabla dt y se le asigna lo que trae _oProducto.Listar()
                if (dt != null)//si dt es diferente de vacio entonces  
                {
                    List<ProductosVenta> misProductosVentas = new List<ProductosVenta>();// se crea una lista del tipo Producto 
                    foreach (DataRow dr in dt.Rows)// se hace un foreach sobre las filas de la tabla dt 
                    {
                        ProductosVenta pv = new ProductosVenta();// se crea el objeto p del tipo Producto

                        pv.IdProductosVenta = int.Parse(dr["idProductosVenta"].ToString());
                        pv.IdProducto = int.Parse(dr["idproducto"].ToString());
                        pv.CodigoBarras = dr["codigoBarras"].ToString();
                        pv.NumVenta = int.Parse(dr["idVenta"].ToString());
                        pv.NombrePV = dr["nombre"].ToString();
                        pv.DescripcionPV = dr["descripcion"].ToString();
                        pv.PrecioUnitarioPV = double.Parse(dr["preciounitario"].ToString());
                        pv.Cantidad = int.Parse(dr["cantidad"].ToString());
                        pv.SubTotal = double.Parse(dr["subtotal"].ToString());

                        misProductosVentas.Add(pv);// se agrega misProductos a el objeto p 
                        pv = null;//se inicializa a p como vacio 
                    }
                    return misProductosVentas;// retorna lo que trae misProductos 
                }
                else// si no se cumple la condicion anterior 
                {
                    return null;//retorna vacio 
                }
            }
            catch (Exception ex)//si ocurre una expcion se manda a la variable ex 
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Eliminar(ProductosVenta Clave)//se publica el metodo booleano Eliminar 
        {
            try//inicia el bloque try-catch
            {
                _oProductosVenta.Eliminar(Clave.IdProductosVenta);//al objeto _oProducto se le asigna el valor que trae Eliminar 
                return true;//retorna verdadero si se cumple la instruccion anterior 
            }
            catch (Exception ex)//atrapa la exepcion y la manda ala variable ex 
            {
                throw new Exception(ex.Message);//en caso de ocurra una exepción se manda un mensaje dependiendo de lo que lleve la variable ex
            }
        }
        #endregion

    }
}
