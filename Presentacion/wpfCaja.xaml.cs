#region Referencias
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Negocios;
using System.Linq;
using System.Collections;
#endregion
namespace Presentacion
{
    /// <summary>
    /// Interaction logic for wpfVentas.xaml
    /// </summary>
    public partial class wpfCaja :Window
    {
        RegistroVenta _venta = new RegistroVenta();
        List<Venta> misVentas = new List<Venta>();

        RegistrarProductosVenta _productosVenta = new RegistrarProductosVenta();
        List<ProductosVenta> misProductosventa = new List<ProductosVenta>();
        ProductosVenta _productoVentaActual = null;

        RegistrarProducto _producto = new RegistrarProducto();
        List<Producto> misProductos = new List<Producto>();

        Producto _productoActual = null;

        RegistrarEmpresa _empresa = new RegistrarEmpresa();
        List<Empresa> misEmpresas = null;
        Empresa _empresaActual = null;
        
        RegistroEmpleado _empleado = new RegistroEmpleado();
        List<Empleado> misEmpleados = null;
        Empleado _empleadoActual = null;
        Helper _objHelper = new Helper();
      
        protected void obtenerFolio()
        {
            int contador = _venta.ObtenerFolio(); 
            txtNumVenta.Text = contador.ToString();
           
        }
        protected void calcularCambioDeTotal()
        {
            try
            {
                if (txtImporte.Text != "")
                {
                    txtCambioVenta.Text = Convert.ToString(double.Parse(txtImporte.Text) - double.Parse(txtTotalAPagar.Text));
                }
                else
                {
                    txtImporte.Text = "";
                    txtCambioVenta.Text = "";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor ingrese un número valido");
                txtImporte.Text = "";
                txtCambioVenta.Text = "";
            }
        }
        
        public wpfCaja()
        {
            InitializeComponent();

            misEmpresas = _empresa.Listar();
            misEmpleados = _empleado.Listar();

            cmbEmpresa.ItemsSource = misEmpresas;
            cmbEmpleado.ItemsSource = misEmpleados;
            obtenerFolio();
            txtClave.Focusable = true;
            txtClave.Focus();
            txtCantidadProducto.Text = "0";

        }
        protected void guardarVenta()
        {
            try
            {

                if (cmbEmpleado.Text != "" && cmbEmpresa.Text != "" && txtImporte.Text != "" && txtTotalAPagar.Text != "")
                {
                    if (double.Parse(txtCambioVenta.Text) < 0)
                    {
                        MessageBox.Show("Dinero insuficiente para que se pueda realizar la venta", "Información del sistema");
                    }
                    else if (txtTotalAPagar.Text == "0")
                    {
                        MessageBox.Show("Usted no ha agregado ningún producto a la venta", "Información del sistema");
                    }
                    else
                    {
                        int claveEmpresa = 0;
                        _empresaActual = (Empresa)cmbEmpresa.SelectedItem;
                        claveEmpresa = _empresaActual.Clave;
                        int claveEmpleado = 0;
                        _empleadoActual = (Empleado)cmbEmpleado.SelectedItem;
                        claveEmpleado = _empleadoActual.Clave;
                        _venta.Add(new Venta(claveEmpresa, claveEmpleado, decimal.Parse(txtImporte.Text), decimal.Parse(txtCambioVenta.Text), decimal.Parse(txtTotalAPagar.Text)));
                        _venta.Guardar();
                        //btnMensaje.Content = "Listo: su venta se guardo correctamente en el sistema";

                        Microsoft.Windows.Controls.MessageBox.Show("Su venta se guardo correctamente en el sistema", "Seguridad del sistema", MessageBoxButton.OK);
                        txtImporte.Text = "";
                        txtCambioVenta.Text = "";
                        txtTotalAPagar.Text = "";
                        txtBarcode.Text = "";
                        txtNombreProducto.Text = "";
                        txtPrecioProducto.Text = "";
                        imgProducto.Source = null;
                        dtgProductos.ItemsSource = null;
                        txtCantidadProducto.Text = "0";
                        obtenerFolio();
                        _venta.Clear();
                        txtClave.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete los campos necesarios para poder realizar la Venta");
                }

            }
            catch (Exception)
            {

            }
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


        private void rbNuevoRegistro_Click(object sender, RoutedEventArgs e)
        {
            rbGuardar.IsEnabled = true;
        }

        private void dtgProductos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgProductos.Items.Count > 0)
            {
                rbCancelarProducto.IsEnabled = true;
                int buscar = 0;
                var row_list = GetDataGridRows(dtgProductos);
                foreach (DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encontrar = misProductosventa.ElementAt(buscar);
                        _productoVentaActual = encontrar;
                        txtCantidadProducto.Text = _productoVentaActual.Cantidad.ToString();
                        txtNombreProducto.Text = _productoVentaActual.NombrePV.ToString();
                        txtPrecioProducto.Text = "$" + _productoVentaActual.PrecioUnitarioPV.ToString() + " MNX";
                        txtBarcode.Text = _productoVentaActual.CodigoBarras.ToString();
                        MessageBox.Show("Se selecciono el producto " + _productoVentaActual.NombrePV + "", "Información del sistema");

                        break;
                    }
                }

            }
        }
        private void rbGuardar_Click(object sender, RoutedEventArgs e)
        {
            guardarVenta();     
        }
        private void RibbonWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (txtTotalAPagar.Text == "" || txtTotalAPagar.Text=="0")
                {
                    e.Cancel = false;
                   
                }else
                {
                    e.Cancel = true;
                    MessageBox.Show("Existe una venta en transacción, porfavor cancele el o los productos para poder salir de esta ventana", "Mensaje del sistema");
                }
                
            }
            finally { }
        }
        
        private void RibbonWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.RightShift)
            {
                guardarVenta();
            }
        }
        private void agregarProducto(object sender, TextChangedEventArgs e)
        {
            try
            {
                string clave = txtClave.Text;
                _productoActual = _producto.BuscarBarcodeProducto(clave);
                if (_productoActual != null)
                {
                    misProductos.Add(_productoActual);
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.UriSource = new Uri(@"C:\\Reportes\\imgProductos\\" + _productoActual.Imagen.ToString() + "", UriKind.RelativeOrAbsolute);
                    bi.EndInit();
                    imgProducto.Stretch = Stretch.Fill;
                    imgProducto.Source = bi;
                    txtBarcode.Text = _productoActual.CodigoBarras.ToString();
                    txtNombreProducto.Text = "Nombre: " + _productoActual.Nombre.ToString();
                    txtPrecioProducto.Text = "$" + _productoActual.PrecioUnitario.ToString() + " MNX";
                    
                    _productoVentaActual = _productosVenta.verificarProductoVenta(_productoActual.Clave, int.Parse(txtNumVenta.Text));
                    if (_productoVentaActual == null)
                    {
                        txtCantidadProducto.Text = "1";
                        _productosVenta.Add(new ProductosVenta(_productoActual.Clave, int.Parse(txtNumVenta.Text), int.Parse(txtCantidadProducto.Text), _productoActual.PrecioUnitario));
                        _productosVenta.Guardar();
                    }
                    else
                    {
                        _productoVentaActual.IdProducto = _productoActual.Clave;
                        _productoVentaActual.NumVenta = int.Parse(txtNumVenta.Text);                 
                        int cantidadActual = int.Parse(txtCantidadProducto.Text) + 1;
                        _productoVentaActual.Cantidad = cantidadActual;
                        _productoVentaActual.PrecioUnitarioPV = _productoActual.PrecioUnitario;
                        _productoVentaActual.SubTotal = cantidadActual * _productoActual.PrecioUnitario;
                        _productosVenta.Actualizar(_productoVentaActual);
                        txtCantidadProducto.Text = cantidadActual.ToString();
                        //_objHelper.actualizar_existencia_producto(_productoVentaActual.IdProducto.ToString(), "Insertar", _productoVentaActual.Cantidad, 0);
                    }
                    txtClave.Text = "";
                    misProductosventa = _productosVenta.ListarProductosVenta(int.Parse(txtNumVenta.Text));
                    dtgProductos.ItemsSource = misProductosventa;
                    double totalVenta = misProductosventa.Sum(p => p.SubTotal); // se obtiene el total de la suma de la coleccion misProductosVenta con la funcion Sum

                    txtTotalAPagar.Text = totalVenta.ToString();
                    calcularCambioDeTotal();
                    _productosVenta.Clear();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ups ha ocurrido un error por favor intentelo más tarde");
            }

        }

        private void txtClave_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            double val;

            if (!double.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtCantidadProducto_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            double val;

            if (!double.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtImporte_TextChanged(object sender, TextChangedEventArgs e)
        {
            calcularCambioDeTotal();
        }

        protected void cancelarProducto(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar el producto?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)

                    if (_productoVentaActual != null)
                    {


                        _productosVenta.Eliminar(_productoVentaActual);
                        //btnMensaje.Content = "Listo: El producto " + _productoVentaActual.NombrePV + " ha sido cancelado";
                        rbCancelarProducto.IsEnabled = false;

                        misProductosventa = _productosVenta.ListarProductosVenta(_productoVentaActual.NumVenta);
                        dtgProductos.ItemsSource = misProductosventa;
                        double totalVenta = misProductosventa.Sum(p => p.SubTotal); // se obtiene el total de la suma de la coleccion misProductosVenta con la funcion Sum
                        txtTotalAPagar.Text = totalVenta.ToString();
                        calcularCambioDeTotal();
                    }
                    else
                    {
                        Microsoft.Windows.Controls.MessageBox.Show("Execucion interrumpida", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
            }
            catch
            {

            }
        }

        private void rbDevoluciones_Click(object sender, RoutedEventArgs e)
        {
            wpfListadoVentas listadoVentas = new wpfListadoVentas();
            listadoVentas.ShowDialog();
        }

        
    }
}


