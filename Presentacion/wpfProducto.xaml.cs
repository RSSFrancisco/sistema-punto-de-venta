#region Referencias
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Negocios;
using System.Linq;
using System.Collections;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.IO;
#endregion

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for wpfProducto.xaml
    /// </summary>
    public partial class wpfProducto : Divelements.SandRibbon.RibbonWindow
    {
        #region Variables Privadas
        RegistrarProducto _registro = new RegistrarProducto();
        List<Producto> miProducto = null;
        Producto _productoActual = null;

        RegistrarProveedor _proveedor = new RegistrarProveedor();
        List<Proveedor> misProveedores = null;
        Proveedor _proveedorActual = null;

        RegistroCategoria _categorias = new RegistroCategoria();
        List<Categoria> misCategorias = null;
        Categoria _categoriaActual = null;
        Helper _objHelper = new Helper();
        Paginas _objPagina = new Paginas();
        protected void paginador()
        {

            int numero = _objHelper.ObtenerNumeroFilas("idproducto", "producto", _objPagina.Tamanio);
            _objPagina.NumeroPaginas = numero;
            for (int i = 0; i <= numero; i++)
            {
                cmbNumeroPaginas.Items.Add("" + i + "");
            }
            cmbNumeroPaginas.SelectedIndex = 0;
        }
        protected void listarProductos()
        {
            miProducto = _registro.Listar(_objPagina.PaginaActual, _objPagina.Tamanio);
            dtgProducto.ItemsSource = miProducto;
        }
        private void limpiarContenido()
        {
            dtgProducto.IsEnabled = true;
            rbNuevoRegistro.IsEnabled = true;
            rbActualizar.IsEnabled = false;
            rbEliminar.IsEnabled = false;
            rbCancelar.IsEnabled = false;
            txtNombre.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
            cmbProveedor.SelectedIndex = -1;
            dtFechaCompra.Text = "";
            cmbCategoria.SelectedIndex = -1;
            imgImagenProducto.Source = null;
            txtRutaImagen.Clear();
            txtStockMaximo.Clear();
            txtStockMinimo.Clear();
            txtExistencia.Clear();
            txtCodigoBarras.Clear();
            txtPreciounitario.Clear();
            imgImagenProducto.Source = null;
            btnAgregarImagen.Content = "Agregar Imagen";
            lblValCategoria.Content = "";
            lblValDescripcion.Content = "";
            lblValExistencia.Content = "";
            lblValFecha.Content = "";
            lblValImagen.Content = "";
            lblValMarca.Content = "";
            lblValNombre.Content = "";
            lblValPrecio.Content = "";
            lblValProveedor.Content = "";
            lblValStockMaximo.Content = "";
            lblValStockMinimo.Content = "";
            lblValCodigoBarras.Content = "";
            rbGuardar.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtMarca.IsEnabled = true;
            txtDescripcion.IsEnabled = true;
            txtPreciounitario.IsEnabled = true;
            cmbProveedor.IsEnabled = true;
            cmbCategoria.IsEnabled = true;
            dtFechaCompra.IsEnabled = true;
            _registro.Clear();
        }
        protected void validarCampos()
        {
            string x = "*";
            string y = "NA";
            string z = "0";
            if (txtNombre.Text == "") { lblValNombre.Content = x; }
            if (txtMarca.Text =="") { txtMarca.Text = y; lblValMarca.Content =x; }
            if (txtDescripcion.Text == "") { txtDescripcion.Text = y; lblValDescripcion.Content = x; }
            if (txtPreciounitario.Text == "") { txtPreciounitario.Text = z; lblValPrecio.Content = x; }
            if (cmbProveedor.Text == "") { lblValProveedor.Content = x; }
            if (dtFechaCompra.Text == "") { dtFechaCompra.Text = DateTime.Now.ToString("yyyy/MM/dd"); lblValFecha.Content = x; }
            if (cmbCategoria.Text == "") { lblValCategoria.Content = x; }
            if (txtStockMinimo.Text == "") { txtStockMinimo.Text = z; lblValStockMinimo.Content = x; }
            if (txtStockMaximo.Text == "") { txtStockMaximo.Text = z; lblValStockMaximo.Content = x; }
            if (txtExistencia.Text == "") {  lblValExistencia.Content = x; }
            if (txtCodigoBarras.Text == "") { lblValCodigoBarras.Content = x; }
        }

        #endregion
        public wpfProducto()
        {
            InitializeComponent();
            #region Métodos
            misCategorias = _categorias.Listar();
            misProveedores = _proveedor.Listar();
            cmbProveedor.ItemsSource = misProveedores;
            cmbCategoria.ItemsSource = misCategorias;
            listarProductos();
            paginador();
            #endregion
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                {
                    validarCampos();
                    int claveProveedor = 0;
                    _proveedorActual = (Proveedor)cmbProveedor.SelectedItem;
                    claveProveedor = _proveedorActual.Clave;
                    int claveCategoria = 0;
                    _categoriaActual = (Categoria)cmbCategoria.SelectedItem;
                    claveCategoria = _categoriaActual.Clave;
                    // componer estas instrucciones del codigo para que se ejecute más rapido la ventana productos 
                    if (claveProveedor != 0 && claveCategoria != 0 && txtNombre.Text != "")
                    {
                        string rutaOrigen = txtRutaImagen.Text;
                        string nombreImagen = "iconoProductoDefault.png";
                        if (rutaOrigen != "")
                        {
                            nombreImagen = rutaOrigen.Substring(rutaOrigen.LastIndexOf("\\") + 1);
                            string rutaDestino = "C:\\Reportes\\imgProductos\\" + nombreImagen;
                            File.Copy(rutaOrigen, rutaDestino);
                        }
                        _registro.Add(new Producto(txtNombre.Text, txtMarca.Text, txtDescripcion.Text, claveProveedor, DateTime.Parse(dtFechaCompra.Text), double.Parse(txtPreciounitario.Text), claveCategoria, nombreImagen, int.Parse(txtStockMaximo.Text), int.Parse(txtStockMinimo.Text), int.Parse(txtExistencia.Text), txtCodigoBarras.Text));
                        _registro.Guardar();
                        btnMensaje.Content = "Listo: sus datos han sido guardados correctamente";

                        Microsoft.Windows.Controls.MessageBox.Show("Sus datos han sido guardados correctamente", "Seguridad del sistema", MessageBoxButton.OK);
                        listarProductos();
                        limpiarContenido();
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese los datos necesarios para el registro", "Mensaje del sistema");
                    }

                }

            }
            catch (Exception)
            {
            }

            _registro.Clear();
        }
        private IEnumerable<DataGridRow> GetDataGridRows(DataGrid Grid)
        {
            var ItemsSource = Grid.ItemsSource as IEnumerable;
            if (null == ItemsSource) yield return null;
            foreach (var item in ItemsSource)
            {
                var row = Grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar la ventana Producto?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            finally { }
        }

        private void rbEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar el producto?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)

                    if (_productoActual != null)
                    {


                        _registro.Eliminar(_productoActual);
                        btnMensaje.Content = "Listo: El producto " + _productoActual.Nombre + " ha sido dado de baja";
                    }
                    else
                    {
                        Microsoft.Windows.Controls.MessageBox.Show("Execucion interrumpida", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);


                    }
                listarProductos();

            }


            catch (Exception)
            {
                Microsoft.Windows.Controls.MessageBox.Show("Execucion interrumpida", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            limpiarContenido();
        }

        private void dtgProducto_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {


                if (dtgProducto.Items.Count > 0)
                {
                    int buscar = 0;
                    var row_list = GetDataGridRows(dtgProducto);
                    foreach (DataGridRow myrow in row_list)
                    {
                        if (myrow.IsSelected)
                        {
                            rbCancelar.IsEnabled = true;
                            rbEliminar.IsEnabled = true;
                            rbActualizar.IsEnabled = true;
                            rbGuardar.IsEnabled = false;
                            rbNuevoRegistro.IsEnabled = false;
                            buscar = myrow.GetIndex();
                            var encontrar = miProducto.ElementAt(buscar);
                            _productoActual =encontrar;
                            txtNombre.Text = _productoActual.Nombre;
                            txtMarca.Text = _productoActual.Marca;
                            txtDescripcion.Text = _productoActual.Descripcion;
                            cmbCategoria.Text = _productoActual.Categoria.ToString();
                            txtPreciounitario.Text = _productoActual.PrecioUnitario.ToString();
                            txtRutaImagen.Text = _productoActual.Imagen.ToString();
                            txtStockMinimo.Text = _productoActual.StockMinimo.ToString();
                            txtStockMaximo.Text = _productoActual.StockMaximo.ToString();
                            txtExistencia.Text = _productoActual.Existencia.ToString();
                            txtCodigoBarras.Text = _productoActual.CodigoBarras.ToString();// Fecha de creación: 27/09/2016
                            
                            dtFechaCompra.Text = _productoActual.FechaCompra.ToShortDateString();
                            int a = _productoActual.Idproveedor;
                            int b = _productoActual.Categoria;
                            foreach (Categoria c in misCategorias)
                            {
                                if (c.Clave == _productoActual.Categoria)
                                {
                                    cmbCategoria.SelectedItem = c;
                                    break;

                                }
                            }
                            foreach (Proveedor p in misProveedores)
                            {
                                if (p.Clave == _productoActual.Idproveedor)
                                {
                                    cmbProveedor.SelectedItem = p;
                                    
                                    break;

                                }
                            }
                            BitmapImage bi = new BitmapImage();
                            bi.BeginInit();
                            bi.UriSource = new Uri(@"C:\\Reportes\\imgProductos\\" + _productoActual.Imagen.ToString() + "", UriKind.RelativeOrAbsolute);
                            bi.EndInit();
                            imgImagenProducto.Stretch = Stretch.Fill;
                            if (bi != null)
                            {
                                imgImagenProducto.Source = bi;
                            }
                          
                        }
                    }
                }
            }
            catch (Exception)
            {


            }
        }

        private void rbCancelar_Click(object sender, RoutedEventArgs e)
        {
            limpiarContenido();
         
        }
        // Fecha de modificación:17/10/2016
        // Modificado por : Ing.Francisco Reyes Sánchez
        // Hora de Modificación: 15:57 PM
        private void rbActualizar_Click(object sender, RoutedEventArgs e)

        {

            try
            {

                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                    if (_productoActual == null)
                    {

                    }
                    else
                    {
                        _productoActual.Nombre = txtNombre.Text;
                        _productoActual.Marca = txtMarca.Text;
                        _productoActual.Descripcion = txtDescripcion.Text;
                        _proveedorActual = (Proveedor)cmbProveedor.SelectedItem;
                        _categoriaActual = (Categoria)cmbCategoria.SelectedItem;
                        _productoActual.Idproveedor = _proveedorActual.Clave;
                        _productoActual.FechaCompra = DateTime.Parse(dtFechaCompra.Text);
                        _productoActual.Categoria = _categoriaActual.Clave;
                        _productoActual.PrecioUnitario = double.Parse(txtPreciounitario.Text);
                        _productoActual.CodigoBarras = txtCodigoBarras.Text;// Fecha de creación: 27/09/2016
                        _productoActual.Existencia = int.Parse(txtExistencia.Text);

                        if (txtRutaImagen.Text == "")
                        {
                            Microsoft.Windows.Controls.MessageBox.Show("Seleccione una imagen", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Asterisk);


                        }
                        else if (txtRutaImagen.Text != _productoActual.Imagen)
                        {
                            string rutaOrigen = txtRutaImagen.Text;

                            string nombreImagen = rutaOrigen.Substring(rutaOrigen.LastIndexOf("\\") + 1);
                            string rutaDestino = "C:\\Reportes\\imgProductos\\" + nombreImagen;
                            // se verifica que la imagen actual de producto no sea por default 
                            if(_productoActual.Imagen== "iconoProductoDefault.png")
                            {
                                File.Copy(rutaOrigen, rutaDestino);
                            }else // en caso de que no sea por default entonces se elimina la que ya trae el producto y se copia la nueva 
                            {
                                File.Delete("C:\\Reportes\\imgProductos\\" + _productoActual.Imagen);
                                File.Copy(rutaOrigen, rutaDestino);
                            }
                            // por ultimo se le asigna a _productoActual el nombreImagen 
                        _productoActual.Imagen = nombreImagen;
                        }
                        else
                        {
                            _productoActual.Imagen = txtRutaImagen.Text;
                        }
                        _productoActual.StockMinimo = int.Parse(txtStockMinimo.Text);
                        _productoActual.StockMaximo = int.Parse(txtStockMaximo.Text);
                        _registro.Actualizar(_productoActual);

                        btnMensaje.Content = "Listo:el producto " + _productoActual.Nombre + " ha sido actualizado";


                    }
                listarProductos();
                limpiarContenido();
            }
            catch (Exception)
            {
             
                Microsoft.Windows.Controls.MessageBox.Show("Seleccione el registro que quiere modificar", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Asterisk);

            }

            _registro.Clear();
        }

        private void rbNuevoRegistro_Click(object sender, RoutedEventArgs e)
        {
            limpiarContenido();


        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {

            /* Se modifico la validación para que acepte números y letras el campo de texto Nombre*/
            //String Aceptados = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + Convert.ToChar(8);
            //{
            //    if (Aceptados.Contains("" + e.Key))
            //    {
            //        e.Handled = false;

            //    }

            //    else e.Handled = true;
            //}

        }

        private void txtPreciounitario_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           
        }
        private void rbLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiarContenido();
            _registro.Clear();
               
        }
        private void rbReportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes re = new Reportes();
            // re.GenerandoProducto(miProducto);
        }

        private void RibbonWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {

                wpfManualTecnico ve = new wpfManualTecnico();
                ve.Show();
            }


        }

        private void btnCategorias_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfCategorias categ = new wpfCategorias();
                categ.ShowDialog();
            }
            catch (Exception)
            {

                Microsoft.Windows.Controls.MessageBox.Show("En este momento no esta disponible esta opcion\n Intentalo más tarde", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }

        }
        private void btnAgregarImagen_Click(object sender, RoutedEventArgs e)
        {
            if (imgImagenProducto.Source == null)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                BitmapImage b = new BitmapImage();
                openFile.Title = "Seleccione la Imagen";
                openFile.Filter = "Todos(*.*) | *.*| Imagenes | *.jpg; *.gif; *.png; *.bmp";
                if (openFile.ShowDialog() == true)
                {

                    string rutaOrigen = openFile.FileName.ToString();
                    string nombreImagen = rutaOrigen.Substring(rutaOrigen.LastIndexOf("\\") + 1);
                    string rutaDestino = "C:\\Reportes\\imgProductos\\" + nombreImagen;
                    if (File.Exists(rutaDestino))
                    {

                        Microsoft.Windows.Controls.MessageBox.Show("La imagen que selecciono ya existe en los productos, seleccione otra imagen diferente", "Seguridad del sistema", MessageBoxButton.OK);

                    }
                    else
                    {
                        b.BeginInit();
                        b.UriSource = new Uri(openFile.FileName);
                        b.EndInit();
                        imgImagenProducto.Stretch = Stretch.Fill;
                        imgImagenProducto.Source = b;
                        txtRutaImagen.Text = openFile.FileName.ToString();
                        btnAgregarImagen.Content = "Quitar Imagen";
                    }
                }
            }
            else
            {
                imgImagenProducto.Source = null;
                txtRutaImagen.Text = "";
                btnAgregarImagen.Content = "Agregar Imagen";
            }


        }
        private string Busqueda = "";
        private void buscarProducto(object sender, TextChangedEventArgs e)
        {
            try
            {
                Busqueda = txtBuscarProducto.Text;
                if (Busqueda == "")
                {
                    listarProductos();
                }
                else
                {
                    miProducto = _registro.ListarBusqueda(Busqueda);
                    dtgProducto.ItemsSource = miProducto;

                }

            }

            catch (Exception)
            {

            }
        }

        private void btnPaginaSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (_objPagina.PaginaActual < _objPagina.NumeroPaginas * _objPagina.Tamanio)
            {
                _objPagina.PaginaActual += _objPagina.Tamanio;
                cmbNumeroPaginas.SelectedIndex = (_objPagina.PaginaActual / _objPagina.Tamanio);
            }
        }
        private void btnPaginaAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (_objPagina.PaginaActual > 0)
            {
                _objPagina.PaginaActual -= _objPagina.Tamanio;
                cmbNumeroPaginas.SelectedIndex = (_objPagina.PaginaActual / _objPagina.Tamanio);
            }
        }
        private void btnUltimaPagina_Click(object sender, RoutedEventArgs e)
        {
            cmbNumeroPaginas.SelectedIndex = _objPagina.NumeroPaginas;
        }

        private void btnPrimerPagina_Click(object sender, RoutedEventArgs e)
        {
            cmbNumeroPaginas.SelectedIndex = 0;
        }

        private void cmbNumeroPaginas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _objPagina.PaginaActual = int.Parse(cmbNumeroPaginas.SelectedValue.ToString()) * _objPagina.Tamanio;
            listarProductos();
        }
    }
}

