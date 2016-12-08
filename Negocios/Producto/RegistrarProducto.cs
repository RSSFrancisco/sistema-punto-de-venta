using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Datos;

namespace Negocios 
{

 public   class RegistrarProducto:CollectionBase
 {
     #region Atributos
     clsProducto _oProducto = new clsProducto();// se declara un objeto _oProducto del tipo clsProducto 
     #endregion

     #region Metodos
     public int Add(Producto NuevoProducto)//publica el metodo add del tipo entero que 
     {
         return (List.Add(NuevoProducto));//retorna lo que trae de la lista que se agrego a Producto
     }
     public int IndexOf(Producto PosicionDelProducto)//publica el metodo IndexOf del tipo entero y la posición del producto en la lista 
     {
         return (List.IndexOf(PosicionDelProducto));//retorna lo que trae IndexOf de la lista y la pocision del producto
     }
     public void Insert(int Indice, Producto InsertarProducto) //public el metodo Insert del tipo Void que trae Indice y el metodo InsertarProducto
     {
         List.Insert(Indice, InsertarProducto);//lista lo que inserto apartir de su indice 
     }
     #endregion

     public Producto BuscarPorNombre(string nombre)//publica el metodo Buscar del tipo Producto que lleva la variable clave de tipo entero
     {
         DataTable dt = _oProducto.BuscarPorNombre(nombre);//se declara la tabla dt y se le asigna lo que trae el objeto _oProducto por el metodo buscar(clave)
         if (dt.Rows.Count > 0)//si dt tiene en sus filas mas de 0 entonces 
         {
             Producto abc = new Producto();//se crea un objeto abc del tipo Producto 
             foreach (DataRow dr in dt.Rows)//se hace un foreach a los datos de la tabla que estan en dt 
             {
                 abc.Clave = int.Parse(dr["idproducto"].ToString());//al objeto abc se le asigna clave la cual trae idproducto de la BD 
                 abc.Nombre = dr["nombre"].ToString();//al objeto abc se le asigna Nombre la cual trae nombre de la BD
                 abc.Marca = dr["marca"].ToString();//al objeto abc se le asigna Marca la cual trae marca de la BD 
                 abc.Descripcion = dr["descripcion"].ToString();//al objeto abc se le asigna Descripcion la cual trae descripcion de la BD 
                 abc.Idproveedor = int.Parse(dr["idproveedor"].ToString());//al objeto abc se le asigna Idproveedor la cual trae idproveedor de la BD 
                 abc.FechaCompra = DateTime.Parse(dr["fechacompra"].ToString());//al objeto abc se le asigna FechaCompra la cual trae fechacompra de la BD 
                 abc.Cantidad = 1;//al objeto abc.Cantidad se inicializa como 1
                 abc.PrecioUnitario = double.Parse(dr["preciounitario"].ToString());//al objeto abc.PrecioUnitario  se le asigna lo que trae preciounitario
                 abc.StockMaximo = int.Parse(dr["stockMax"].ToString());//al objeto abc.StockMaximo se le asigna lo que trae stockmax 
                 abc.Importe = decimal.Parse(dr["preciounitario"].ToString());//al objeto abc.Importe se le asigna lo que trae preciounitario
                 abc.Categoria = int.Parse(dr["idCategoria"].ToString());//al objeto abc.Categoria se le asigna lo que trae categoria 
                 abc.Imagen = dr["imagen"].ToString();
             }
             return abc;//retorna lo que trae abc
         }
         else
         {//si no 
             return null;//retorna nullo
         }

     }
            
     public Producto Buscar(int clave)//publica el metodo Buscar del tipo Producto que lleva la variable clave de tipo entero
     {
         DataTable dt = _oProducto.Buscar(clave);//se declara la tabla dt y se le asigna lo que trae el objeto _oProducto por el metodo buscar(clave)
         if (dt.Rows.Count > 0)//si dt tiene en sus filas mas de 0 entonces 
         {
             Producto abc = new Producto();//se crea un objeto abc del tipo Producto 
             foreach (DataRow dr in dt.Rows)//se hace un foreach a los datos de la tabla que estan en dt 
             {
                 abc.Clave = int.Parse(dr["idproducto"].ToString());//al objeto abc se le asigna clave la cual trae idproducto de la BD 
                 abc.Nombre = dr["nombre"].ToString();//al objeto abc se le asigna Nombre la cual trae nombre de la BD
                 abc.Marca = dr["marca"].ToString();//al objeto abc se le asigna Marca la cual trae marca de la BD 
                 abc.Descripcion = dr["descripcion"].ToString();//al objeto abc se le asigna Descripcion la cual trae descripcion de la BD 
                 abc.Idproveedor = int.Parse(dr["idproveedor"].ToString());//al objeto abc se le asigna Idproveedor la cual trae idproveedor de la BD 
                 abc.FechaCompra = DateTime.Parse(dr["fechacompra"].ToString());//al objeto abc se le asigna FechaCompra la cual trae fechacompra de la BD 
                 abc.Cantidad = 1;//al objeto abc.Cantidad se inicializa como 1
                 abc.PrecioUnitario = double.Parse(dr["preciounitario"].ToString());//al objeto abc.PrecioUnitario  se le asigna lo que trae preciounitario
                 abc.StockMaximo = int.Parse(dr["stockMax"].ToString());//al objeto abc.StockMaximo se le asigna lo que trae stockmax 
                 abc.Importe = decimal.Parse(dr["preciounitario"].ToString());//al objeto abc.Importe se le asigna lo que trae preciounitario
                 abc.Categoria =int.Parse(dr["idCategoria"].ToString());//al objeto abc.Categoria se le asigna lo que trae categoria 
                 abc.Imagen = dr["imagen"].ToString();
             }
             return abc;//retorna lo que trae abc
         }
         else {//si no 
             return null;//retorna nullo
         }
         
     }
        public Producto BuscarBarcodeProducto(string barcode)//publica el metodo Buscar del tipo Producto que lleva la variable clave de tipo entero
        {
            DataTable dt = _oProducto.BuscarBarcodeProducto(barcode);//se declara la tabla dt y se le asigna lo que trae el objeto _oProducto por el metodo buscar(clave)
            if (dt.Rows.Count > 0)//si dt tiene en sus filas mas de 0 entonces 
            {
                Producto abc = new Producto();//se crea un objeto abc del tipo Producto 
                foreach (DataRow dr in dt.Rows)//se hace un foreach a los datos de la tabla que estan en dt 
                {
                    abc.Clave = int.Parse(dr["idproducto"].ToString());//al objeto abc se le asigna clave la cual trae idproducto de la BD 
                    abc.Nombre = dr["nombre"].ToString();//al objeto abc se le asigna Nombre la cual trae nombre de la BD
                    abc.Marca = dr["marca"].ToString();//al objeto abc se le asigna Marca la cual trae marca de la BD 
                    abc.Descripcion = dr["descripcion"].ToString();//al objeto abc se le asigna Descripcion la cual trae descripcion de la BD 
                    abc.Idproveedor = int.Parse(dr["idproveedor"].ToString());//al objeto abc se le asigna Idproveedor la cual trae idproveedor de la BD 
                    abc.FechaCompra = DateTime.Parse(dr["fechacompra"].ToString());//al objeto abc se le asigna FechaCompra la cual trae fechacompra de la BD 
                    abc.Cantidad = 1;//al objeto abc.Cantidad se inicializa como 1
                    abc.PrecioUnitario = double.Parse(dr["preciounitario"].ToString());//al objeto abc.PrecioUnitario  se le asigna lo que trae preciounitario
                    abc.StockMaximo = int.Parse(dr["stockMax"].ToString());//al objeto abc.StockMaximo se le asigna lo que trae stockmax 
                    abc.Importe = decimal.Parse(dr["preciounitario"].ToString());//al objeto abc.Importe se le asigna lo que trae preciounitario
                    abc.Categoria = int.Parse(dr["idCategoria"].ToString());//al objeto abc.Categoria se le asigna lo que trae categoria 
                    abc.Imagen = dr["imagen"].ToString();
                    abc.CodigoBarras = dr["codigoBarras"].ToString();
                }
                return abc;//retorna lo que trae abc
            }
            else
            {
                return null;
            }

        }

        public bool Guardar()//se publica el metodo boolenano Guardar
     {
         if (this.Count == 0)//si esto esta vacio entonces 
         {
             return false;//retorna un false  
         }
         try//inicia el bloque try-catch 
         {
             Hashtable[] MisProductos = new Hashtable[this.Count];//se crea la tabla Hastable MisProductos 
             int indice = 0;//se inicializa indice en 0 
             foreach (Producto pr in this)//se hace un foreach sobre la variable pr del tipo Producto
             {
                 Hashtable ht = new Hashtable();//se inicializa la variable ht que trae Hashtable 
                 ht.Add("nombre", pr.Nombre);//se le agrega a ht lo que trae pr.Nombre 
                 ht.Add("marca", pr.Marca);//se le agrega a ht lo que trae pr.Marca 
                 ht.Add("descripcion", pr.Descripcion);//se le agrega a ht lo que trae pr.Descripcion  
                 ht.Add("idproveedor", pr.Idproveedor);//se le agrega a ht lo que trae pr.Idproveedor 
                 ht.Add("fechacompra", pr.FechaCompra.ToString("yyyy/MM/dd hh:mm:ss"));//se le agrega a ht lo que trae pr.FechaCompra 
                 ht.Add("preciounitario", pr.PrecioUnitario);//se le agrega a ht lo que trae pr.PrecioUnitario
                 ht.Add("idCategoria", pr.Categoria);//se le asigna a ht lo que trae pr.Categoria 
                 ht.Add("imagen", pr.Imagen);
                 ht.Add("stockMax", pr.StockMaximo);
                 ht.Add("stockMin", pr.StockMinimo);
                 ht.Add("existencia", pr.Existencia);
                 ht.Add("codigoBarras", pr.CodigoBarras); // Fecha de creación: 27/09/2016
                 MisProductos[indice] = ht;//se le agrega un indice a ht 
                 ht = null;// se inicializa a ht como vacio 
                 indice++;//se incrementa en uno el indice 
             }
             return (_oProducto.Guardar(MisProductos));//retorna lo que trae el objeto _oProducto de tipo MisProductos 
         }
         catch (Exception)//atrapa la exepcion en ejecucion 
         {
             return false;//retorna false 
         }
     }
        public List<Producto> ListarBusqueda(string datos)//publica una lista del tipo Producto con el Nombre de Listar 
        {
            try//inicia el bloque try-catch
            {
                DataTable dt = _oProducto.ListarBusqueda(datos.ToString());//se crea la tabla dt y se le asigna lo que trae _oProducto.Listar()
                if (dt != null)//si dt es diferente de vacio entonces  
                {
                    List<Producto> misProductos = new List<Producto>();// se crea una lista del tipo Producto 
                    foreach (DataRow dr in dt.Rows)// se hace un foreach sobre las filas de la tabla dt 
                    {
                        Producto p = new Producto();// se crea el objeto p del tipo Producto 
                        p.Clave = int.Parse(dr["idproducto"].ToString());//al objeto p.Clave se le asigna lo que trae idproducto de la BD 
                        p.Nombre = dr["nombre"].ToString();//al objeto p.Nombre se le asigna lo que trae nombre de la BD 
                        p.Marca = dr["marca"].ToString();//al objeto p.Marca se le asigna lo que trae marca de la BD 
                        p.Descripcion = dr["descripcion"].ToString();//al objeto p.Descripcion se le asigna lo que trae descripcion de la BD 
                        p.Idproveedor = int.Parse(dr["idproveedor"].ToString());//al objeto p.Idproveedor se le asigna lo que trae idproveedor de la BD
                        p.FechaCompra = DateTime.Parse(dr["fechacompra"].ToString());//al objeto p.FechaCompra se le asigna lo que trae fechacompra de la BD
                        p.PrecioUnitario = double.Parse(dr["preciounitario"].ToString());//al objeto p.PrecioUnitario se le asigna lo que trae preciounitario de la BD
                        p.Categoria = int.Parse(dr["idCategoria"].ToString());//al objeto p.Categoria se le asigna lo que trae categoria de la BD 
                        p.Imagen = dr["imagen"].ToString();
                        p.StockMinimo = int.Parse(dr["stockMin"].ToString());
                        p.StockMaximo = int.Parse(dr["stockMax"].ToString());
                        p.Existencia = int.Parse(dr["existencia"].ToString());
                        p.CodigoBarras = dr["codigoBarras"].ToString();
                        misProductos.Add(p);// se agrega misProductos a el objeto p 
                        p = null;//se inicializa a p como vacio 
                    }
                    return misProductos;// retorna lo que trae misProductos 
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
        public List<Producto> Listar( int paginaInicial, int tamanio)//publica una lista del tipo Producto con el Nombre de Listar 
     {
         try//inicia el bloque try-catch
         {
             DataTable dt = _oProducto.Listar(paginaInicial,tamanio);//se crea la tabla dt y se le asigna lo que trae _oProducto.Listar()
             if (dt != null)//si dt es diferente de vacio entonces  
             {
                 List<Producto> misProductos = new List<Producto>();// se crea una lista del tipo Producto 
                 foreach (DataRow dr in dt.Rows)// se hace un foreach sobre las filas de la tabla dt 
                 {
                     Producto p = new Producto();// se crea el objeto p del tipo Producto 
                     p.Clave = int.Parse(dr["idproducto"].ToString());//al objeto p.Clave se le asigna lo que trae idproducto de la BD 
                     p.Nombre = dr["nombre"].ToString();//al objeto p.Nombre se le asigna lo que trae nombre de la BD 
                     p.Marca = dr["marca"].ToString();//al objeto p.Marca se le asigna lo que trae marca de la BD 
                     p.Descripcion = dr["descripcion"].ToString();//al objeto p.Descripcion se le asigna lo que trae descripcion de la BD 
                     p.Idproveedor = int.Parse(dr["idproveedor"].ToString());//al objeto p.Idproveedor se le asigna lo que trae idproveedor de la BD
                     p.FechaCompra = DateTime.Parse(dr["fechacompra"].ToString());//al objeto p.FechaCompra se le asigna lo que trae fechacompra de la BD
                     p.PrecioUnitario = double.Parse(dr["preciounitario"].ToString());//al objeto p.PrecioUnitario se le asigna lo que trae preciounitario de la BD
                     p.Categoria =int.Parse(dr["idCategoria"].ToString());//al objeto p.Categoria se le asigna lo que trae categoria de la BD 
                     p.Imagen = dr["imagen"].ToString();
                        p.StockMinimo =int.Parse(dr["stockMin"].ToString());
                        p.StockMaximo = int.Parse(dr["stockMax"].ToString());
                        p.Existencia = int.Parse(dr["existencia"].ToString());
                        p.CodigoBarras = dr["codigoBarras"].ToString();
                     misProductos.Add(p);// se agrega misProductos a el objeto p 
                     p = null;//se inicializa a p como vacio 
                 }
                 return misProductos;// retorna lo que trae misProductos 
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
        //public List<Producto> ListarBarcode(string barcode)//publica una lista del tipo Producto con el Nombre de Listar 
        //{
        //    try//inicia el bloque try-catch
        //    {
        //        DataTable dt = _oProducto.ListarPorCodigoBarras(barcode);//se crea la tabla dt y se le asigna lo que trae _oProducto.Listar()
        //        if (dt != null)//si dt es diferente de vacio entonces  
        //        {
        //            List<Producto> misProductos = new List<Producto>();// se crea una lista del tipo Producto 
        //            foreach (DataRow dr in dt.Rows)// se hace un foreach sobre las filas de la tabla dt 
        //            {
        //                Producto p = new Producto();// se crea el objeto p del tipo Producto 
        //                p.Clave = int.Parse(dr["idproducto"].ToString());//al objeto p.Clave se le asigna lo que trae idproducto de la BD 
        //                p.Nombre = dr["nombre"].ToString();//al objeto p.Nombre se le asigna lo que trae nombre de la BD 
        //                p.Marca = dr["marca"].ToString();//al objeto p.Marca se le asigna lo que trae marca de la BD 
        //                p.Descripcion = dr["descripcion"].ToString();//al objeto p.Descripcion se le asigna lo que trae descripcion de la BD 
        //                p.Idproveedor = int.Parse(dr["idproveedor"].ToString());//al objeto p.Idproveedor se le asigna lo que trae idproveedor de la BD
        //                p.FechaCompra = DateTime.Parse(dr["fechacompra"].ToString());//al objeto p.FechaCompra se le asigna lo que trae fechacompra de la BD
        //                p.PrecioUnitario = double.Parse(dr["preciounitario"].ToString());//al objeto p.PrecioUnitario se le asigna lo que trae preciounitario de la BD
        //                p.Categoria = int.Parse(dr["idCategoria"].ToString());//al objeto p.Categoria se le asigna lo que trae categoria de la BD 
        //                p.Imagen = dr["imagen"].ToString();
        //                p.StockMinimo = int.Parse(dr["stockMin"].ToString());
        //                p.StockMaximo = int.Parse(dr["stockMax"].ToString());
        //                p.Existencia = int.Parse(dr["existencia"].ToString());
        //                misProductos.Add(p);// se agrega misProductos a el objeto p 
        //                p = null;//se inicializa a p como vacio 
        //            }
        //            return misProductos;// retorna lo que trae misProductos 
        //        }
        //        else// si no se cumple la condicion anterior 
        //        {
        //            return null;//retorna vacio 
        //        }
        //    }
        //    catch (Exception ex)//si ocurre una expcion se manda a la variable ex 
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public bool Eliminar(Producto BajaProducto)//se publica el metodo booleano Eliminar 
     {
         try//inicia el bloque try-catch
         {
             _oProducto.Eliminar(BajaProducto.Clave);//al objeto _oProducto se le asigna el valor que trae Eliminar 
             return true;//retorna verdadero si se cumple la instruccion anterior 
         }
         catch (Exception ex)//atrapa la exepcion y la manda ala variable ex 
         {
             throw new Exception(ex.Message);//en caso de ocurra una exepción se manda un mensaje dependiendo de lo que lleve la variable ex
         }
     }

     public bool Actualizar(Producto p)// se crea el metodo booleano Actualizar 
     {
         try//inicia el bloque try-catch
         {
             Hashtable ht = new Hashtable();//se inicializa el Hastable ht 
             ht.Add("nombre", p.Nombre);//se le agrega a ht lo que trae p.Nombre 
             ht.Add("marca", p.Marca);//se le agrega a ht lo que trae p.Marca 
             ht.Add("descripcion", p.Descripcion);//se le agrega a ht lo que trae p.Descripcion 
             ht.Add("idproveedor", p.Idproveedor);//se le agrega a ht lo que trae p.IdProveedor 
             ht.Add("fechacompra", p.FechaCompra.ToString("yyyy/MM/dd hh:mm:ss"));//se le agrega a ht lo que trae p.FechaCompra 
             ht.Add("preciounitario", p.PrecioUnitario.ToString());//se le agrega a ht lo que trae p.PrecioUnitario
             ht.Add("idCategoria", p.Categoria.ToString());//se le agrega a ht lo que trae p.Categoria 
             ht.Add("imagen", p.Imagen.ToString());
             ht.Add("stockMax", p.StockMaximo);
             ht.Add("stockMin", p.StockMinimo);
             ht.Add("existencia", p.Existencia);
             ht.Add("codigoBarras", p.CodigoBarras);// Fecha de creación: 27/09/2016
                _oProducto.Actualizar("idproducto", p.Clave, ht);//al objeto _oProducto hace referncia al metodo actualizar por medio de p.Clave 
             return true;//si se cumple la instruccion anterior retorna el valo como verdadero 
         }
         catch (Exception ex)//en caso de que ocurra una exepción en tiempo de ejecución se envia lo que encuentra a la variable ex 
         {
             throw new Exception(ex.Message);//manda el mensaje de error el cual cacho la variable ex 
         }
     }
                       
                        

               
 }
}
