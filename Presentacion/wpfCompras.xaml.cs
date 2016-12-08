#region Referencias
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Negocios;
using System.Linq;
using System.Collections;

#endregion
namespace Presentacion
{
    /// <summary>
    /// Interaction logic for wpfCompras.xaml
    /// </summary>
    public partial class wpfCompras : Divelements.SandRibbon.RibbonWindow
    {


        RegistrarProducto _producto = new RegistrarProducto();
        List<Producto> misProductos = new List<Producto>();
        //Producto _productoActual2 = null;
        decimal importe;
        double totalPagar = 0;//Variable para almacenar los  valorees de la  sauma de los  productos comprados

        #region Variables privadas
        RegistrarProducto _registro = new RegistrarProducto();
        List<Producto> miProducto = null;
        Producto _productoActual = null;

        RegistrarProveedor _proveedor = new RegistrarProveedor();
        List<Proveedor> misProveedores = null;
        //Proveedor _proveedorActual = null;
        #endregion
        public wpfCompras()
        {
            InitializeComponent();

            dtgProductos.ItemsSource = miProducto;
            #region Metodos

            misProveedores = _proveedor.Listar();
            cmbProveedor.ItemsSource = misProveedores;
            dtgProductos.ItemsSource = miProducto;
            #endregion


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



        private void dtgProductos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgProductos.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRows(dtgProductos);
                foreach (DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encontrar = miProducto.ElementAt(buscar);
                        _productoActual = (Producto)encontrar;
                        this.txtDescripcion.Text = _productoActual.Descripcion;
                        this.txtPrecioUnitario.Text ="$"+ _productoActual.PrecioUnitario.ToString()+ "MXN";
                        this.txtCantidad.Text = _productoActual.Cantidad.ToString();
                        MessageBox.Show("Se selecciono el producto " + _productoActual.Nombre + "", "Información del sistema");
                        break;
                    }
                }
            }
        }



        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                _productoActual.Cantidad = int.Parse(txtCantidad.Text);
                _productoActual.PrecioUnitario = float.Parse((_productoActual.PrecioUnitario.ToString()));
                _productoActual.Importe = decimal.Parse(txtTotal.Text);
                _productoActual.Descripcion = _productoActual.Nombre;
                importe = _productoActual.Importe;
                totalPagar = totalPagar + (double)importe;
                txtPagar.Text = "$  " + totalPagar;
                if (miProducto == null) miProducto = new List<Producto>();
                miProducto.Add(_productoActual);
                dtgProductos.ItemsSource = null;
                dtgProductos.ItemsSource = miProducto;
                _productoActual = null;
                txtCantidad.Clear();
                txtPrecioUnitario.Clear();
                txtTotal.Clear();
                txtDescripcion.Clear();
                txtClave.Clear();

                // btnMensaje.Content = "El producto: " + _productoActual.Nombre + " ha sido seleccionado";



            }
            catch (Exception)
            {

                MessageBox.Show("El producto no pudo registrarse a causa de que no ingreso sus datos");
            }
        }

        private void calcular()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCantidad.Text)) return;
                if (string.IsNullOrEmpty(txtPrecioUnitario.Text)) return;

                decimal miCantidad = decimal.Parse(txtCantidad.Text);
                decimal miPrecioUnitario = decimal.Parse(_productoActual.PrecioUnitario.ToString());
                decimal resultado = miCantidad * miPrecioUnitario;
                txtTotal.Text = resultado.ToString();


            }
            catch (Exception)
            {

                throw;
            }
        }


        private void txtCantidad_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                calcular();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rbGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Negocios.Compras.Compras oCompra = new Negocios.Compras.Compras();
                oCompra.Folio = long.Parse(txtFolio.Text);
                oCompra.FechaCompra = Convert.ToDateTime(dtFechaCompra.Text);
                oCompra.ProveedorActual = (Proveedor)cmbProveedor.SelectedItem;
                oCompra.DetalleCompra = miProducto;
                oCompra.Guardar();
                btnMensaje.Content = "El registro se guardo correctamente";

            }
            catch (Exception )
            {

            }
            txtFolio.Text = "";
            txtPrecioUnitario.Text = "";
            txtTotal.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtClave.Text = "";
            dtFechaCompra.Text = "";
            cmbProveedor.SelectedIndex = -1;

        }

        private void rbNuevoRegistro_Click(object sender, RoutedEventArgs e)
        {
            rbGuardar.IsEnabled = true;
            txtFolio.IsEnabled = true;
            txtPrecioUnitario.IsEnabled = true;
            txtDescripcion.IsEnabled = true;
            txtCantidad.IsEnabled = true;
            txtClave.IsEnabled = true;
            dtFechaCompra.IsEnabled = true;
            cmbProveedor.IsEnabled = true;
            btnAgregar.IsEnabled = true;

        }



        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {

            String Aceptados = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + Convert.ToChar(8);
            {
                if (Aceptados.Contains("" + e.Key))
                {
                    e.Handled = false;

                }

                else e.Handled = true;



            }

        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtPrecioUnitario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void RibbonWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar la ventana Compras?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Question);
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

        private void RibbonWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {

                wpfManualTecnico ve = new wpfManualTecnico();
                ve.Show();
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

        private void BuscarProducto(object sender, TextChangedEventArgs e)
        {
            try
            {

                string clave = txtClave.Text;
                _productoActual = _producto.BuscarBarcodeProducto(clave);
                if (_productoActual == null)
                {
                    //btnMensaje.Content = "El producto no existe en el stock del sistema";
                }
                else
                {
                    String cadena = "";
                    cadena = _productoActual.Nombre.ToString() + ",  ";
                    cadena += _productoActual.Descripcion.ToString();
                    txtDescripcion.Text = cadena;
                    int existencia = Convert.ToInt32(_productoActual.Existencia.ToString());
                    txtExistencia.Text = " " + existencia;
                    float precio = float.Parse(_productoActual.PrecioUnitario.ToString());
                    txtPrecioUnitario.Text = "$" + precio + " MNX";



                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ups ha ocurrido un error por favor intentelo más tarde");
            }

        }

        private IEnumerable<DataGridRow> wpfComprasGetDataGridRows(DataGrid Grid)
        {
            var ItemsSource = Grid.ItemsSource as IEnumerable;
            if (null == ItemsSource) yield return null;
            foreach (var item in ItemsSource)
            {
                var row = Grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }


        private void txtPagar_TextChanged(object sender, TextChangedEventArgs e)
        {

            // rbCancelarProducto.IsEnabled = true;
            // int buscar = 0;
            // int columna = 4;

            /* var row_list = wpfComprasGetDataGridRows(dtgProductos);
                 foreach (DataGridRow myrow in row_list)
                 {
                 totalPagar += (int)myrow.DataContext;
                     txtPagar.Text = "$  " + totalPagar;

                 }*/

        }
    }
}


