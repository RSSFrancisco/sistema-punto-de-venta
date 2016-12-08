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
    /// Interaction logic for wpfProveedor.xaml
    /// </summary>
    public partial class wpfProveedor : Divelements.SandRibbon.RibbonWindow
    {
        #region Instancias
        RegistrarProveedor _registroProveedor = new RegistrarProveedor();
        List<Proveedor> miProveedor = null;
        Proveedor _proveedorActual = null;
        #endregion
        public wpfProveedor()
        {
            InitializeComponent();


            #region Estados
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Aguascalientes");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Baja California");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Campeche");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Coahuila");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Colima");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Chiapas");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Chihuahua");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Distrito Federal");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Durango");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Guanajuato");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Guerrero");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Hidalgo");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Jalisco");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "México");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Michoacán");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Morelos");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Nayarit");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Nuevo León");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Oaxaca");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Puebla");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Querétaro");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Quintana Roo");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "San Luis Potosí");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Sinaloa");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Sonora");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Tabasco");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Tamaulipas");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Tlaxcala");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Veracruz");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Yucatán");
            cbestadopro.Items.Add(new ComboBoxItem().Content = "Zacatecas");
            #endregion
            #region Metodos
            miProveedor = _registroProveedor.Listar();
            dtgProveedor.ItemsSource = miProveedor;
            #endregion
        }
        #region Metodos Públicos

        private void dtgProveedor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgProveedor.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRows(dtgProveedor);
                foreach (DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encuentra = miProveedor.ElementAt(buscar);
                        _proveedorActual = (Proveedor)encuentra;
                        txtRFC.Text = _proveedorActual.Rfc.Trim();
                        txtNombre.Text = _proveedorActual.Nombre.Trim();
                        txtDireccion.Text = _proveedorActual.Direccion.Trim();
                        txtcolonia.Text = _proveedorActual.Colonia.Trim();
                        txtCiudad.Text = _proveedorActual.Ciudad.Trim();
                        cbestadopro.Text = _proveedorActual.Estado;
                        txtCodigoPostal.Text = _proveedorActual.Cp.ToString().Trim();
                        txtTelefono.Text = _proveedorActual.Telefono.Trim();
                        txtcorreo.Text = _proveedorActual.Correo.Trim();
                        rbNuevoRegistro.IsEnabled = false;
                        rbGuardar.IsEnabled = false;
                        rbActualizar.IsEnabled = true;
                        rbEliminar.IsEnabled = true;
                        rbCancelar.IsEnabled = true;
                        break;
                    }
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar la ventana Proveedor?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
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

        private void rbGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               // Fecha de modificación: 26/10/2016
               // Modifico: Ing.Francisco Reyes Sánchez
               // se removio la validación if(_proveedorActual==null)
                    _registroProveedor.Add(new Proveedor(txtRFC.Text.ToUpper(), txtNombre.Text, txtDireccion.Text, txtcolonia.Text, txtCiudad.Text, cbestadopro.Text, int.Parse(txtCodigoPostal.Text), txtTelefono.Text, txtcorreo.Text));
                    _registroProveedor.Guardar();
                    btnMensaje.Content = "El proveedor se guardo correctamente";
     
                miProveedor = _registroProveedor.Listar();
                dtgProveedor.ItemsSource = miProveedor;
                


            }
            catch (Exception)
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("Para poder guardar ingrese datos en los campos correspondientes", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }

            _registroProveedor.Clear();
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

        private void rbEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = MessageBox.Show("¿Desea eliminar el proveedor?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                {

                    {
                        _registroProveedor.Eliminar(_proveedorActual);
                        btnMensaje.Content = "El proveedor " + _proveedorActual.Nombre + " ha sido eliminado";
                    }
                }
                miProveedor = _registroProveedor.Listar();
                dtgProveedor.ItemsSource = miProveedor;
            }
            catch (Exception)
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("Ha ocurrido una exepción", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            txtRFC.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtcolonia.Clear();
            txtCiudad.Clear();
            cbestadopro.SelectedIndex = -1;
            txtCodigoPostal.Clear();
            txtcorreo.Clear();
            txtTelefono.Clear();
            _registroProveedor.Clear();
        }

        private void rbActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (x == MessageBoxResult.Yes)
                    if (_proveedorActual == null)
                    {
                        _registroProveedor.Add(new Proveedor(txtRFC.Text.Trim(), txtNombre.Text.Trim(), txtDireccion.Text.Trim(), txtcolonia.Text.Trim(), txtCiudad.Text.Trim(), cbestadopro.Text.Trim(), int.Parse(txtCodigoPostal.Text.Trim()), txtTelefono.Text.Trim(), txtcorreo.Text.Trim()));


                    }
                    else
                    {
                        _proveedorActual.Rfc = txtRFC.Text.Trim();
                        _proveedorActual.Nombre = txtNombre.Text.Trim();
                        _proveedorActual.Direccion = txtDireccion.Text.Trim();
                        _proveedorActual.Colonia = txtcolonia.Text.Trim();
                        _proveedorActual.Ciudad = txtCiudad.Text.Trim();
                        _proveedorActual.Estado = cbestadopro.Text;
                        _proveedorActual.Cp = int.Parse(txtCodigoPostal.Text.Trim());
                        _proveedorActual.Telefono = txtTelefono.Text.Trim();
                        _proveedorActual.Correo = txtcorreo.Text.Trim();
                        _registroProveedor.Actualizar(_proveedorActual);
                        btnMensaje.Content = "El proveedor " + _proveedorActual.Nombre + "  ha sido actualizado";
                    }
                miProveedor = _registroProveedor.Listar();
                dtgProveedor.ItemsSource = miProveedor;
            }
            catch (Exception)
            {
            }
            txtRFC.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtcolonia.Clear();
            txtCiudad.Clear();
            cbestadopro.SelectedIndex = -1;
            txtCodigoPostal.Clear();
            txtcorreo.Clear();
            txtTelefono.Clear();
            _registroProveedor.Clear();
        }

        private void rbCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtRFC.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtcolonia.Clear();
            txtCiudad.Clear();
            cbestadopro.SelectedIndex = -1;
            txtCodigoPostal.Clear();
            txtcorreo.Clear();
            txtTelefono.Clear();
            _registroProveedor.Clear();
            btnMensaje.Content = "Execución cancelada";
            rbNuevoRegistro.IsEnabled = true;
            rbActualizar.IsEnabled = false;
            rbEliminar.IsEnabled = false;

        }

        private void rbNuevoRegistro_Click(object sender, RoutedEventArgs e)
        {
            rbGuardar.IsEnabled = true;
            txtRFC.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtDireccion.IsEnabled = true;
            txtcolonia.IsEnabled = true;
            txtCiudad.IsEnabled = true;
            cbestadopro.IsEnabled = true;
            txtCodigoPostal.IsEnabled = true;
            txtcorreo.IsEnabled = true;
            txtTelefono.IsEnabled = true;
            dtgProveedor.IsEnabled = true;
            btnMensaje.Content = "Listo";

        #endregion
            #region Validación de cajas de texto
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCodigoPostal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtCiudad_KeyDown(object sender, KeyEventArgs e)
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

            #endregion

        private void RibbonWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                try
                {
                    MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (x == MessageBoxResult.Yes)
                        if (_proveedorActual == null)
                        {
                            _registroProveedor.Add(new Proveedor(txtRFC.Text.Trim(), txtNombre.Text.Trim(), txtDireccion.Text.Trim(), txtcolonia.Text.Trim(), txtCiudad.Text.Trim(), cbestadopro.Text.Trim(), int.Parse(txtCodigoPostal.Text.Trim()), txtTelefono.Text.Trim(), txtcorreo.Text.Trim()));


                        }
                        else
                        {
                            _proveedorActual.Rfc = txtRFC.Text.Trim();
                            _proveedorActual.Nombre = txtNombre.Text.Trim();
                            _proveedorActual.Direccion = txtDireccion.Text.Trim();
                            _proveedorActual.Colonia = txtcolonia.Text.Trim();
                            _proveedorActual.Ciudad = txtCiudad.Text.Trim();
                            _proveedorActual.Estado = cbestadopro.Text;
                            _proveedorActual.Cp = int.Parse(txtCodigoPostal.Text.Trim());
                            _proveedorActual.Telefono = txtTelefono.Text.Trim();
                            _proveedorActual.Correo = txtcorreo.Text.Trim();
                            _registroProveedor.Actualizar(_proveedorActual);
                            btnMensaje.Content = "El proveedor " + _proveedorActual.Nombre + "  ha sido actualizado";
                        }
                    miProveedor = _registroProveedor.Listar();
                    dtgProveedor.ItemsSource = miProveedor;
                }
                catch (Exception)
                {
                }
                txtRFC.Clear();
                txtNombre.Clear();
                txtDireccion.Clear();
                txtcolonia.Clear();
                txtCiudad.Clear();
                cbestadopro.SelectedIndex = -1;
                txtCodigoPostal.Clear();
                txtcorreo.Clear();
                txtTelefono.Clear();
                _registroProveedor.Clear();
            }

        }

        private void RibbonWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                try
                {
                    MessageBoxResult x = MessageBox.Show("¿Desea eliminar el proveedor?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (x == MessageBoxResult.Yes)
                    {

                        {
                            _registroProveedor.Eliminar(_proveedorActual);
                            btnMensaje.Content = "El proveedor " + _proveedorActual.Nombre + " ha sido eliminado";
                        }
                    }
                    miProveedor = _registroProveedor.Listar();
                    dtgProveedor.ItemsSource = miProveedor;
                }
                catch (Exception)
                {
                    MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("Ha ocurrido una exepción", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                txtRFC.Clear();
                txtNombre.Clear();
                txtDireccion.Clear();
                txtcolonia.Clear();
                txtCiudad.Clear();
                cbestadopro.SelectedIndex = -1;
                txtCodigoPostal.Clear();
                txtcorreo.Clear();
                txtTelefono.Clear();
                _registroProveedor.Clear();
            }

        }

        private void rbReportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes rep=new Reportes ();
            //rep.GenerandoProveedor(miProveedor);

        }

        private void RibbonWindow_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {

                wpfManualTecnico ve = new wpfManualTecnico();
                ve.Show();
            }


        }
    }
}