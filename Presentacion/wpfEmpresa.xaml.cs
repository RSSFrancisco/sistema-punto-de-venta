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
    /// Interaction logic for wpfEmpresa.xaml
    /// </summary>
    public partial class wpfEmpresa : Divelements.SandRibbon.RibbonWindow
    {
        #region Variables Privadas
        RegistrarEmpresa _registro = new RegistrarEmpresa();
        List<Empresa> miEmpresa = null;
        Empresa _EmpresaActual = null;
        #endregion
        public wpfEmpresa()
        {
            InitializeComponent();



            #region Estados
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Aguascalientes");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Baja California");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Campeche");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Coahuila");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Colima");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Chiapas");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Chihuahua");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Distrito Federal");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Durango");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Guanajuato");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Guerrero");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Hidalgo");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Jalisco");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "México");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Michoacán");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Morelos");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Nayarit");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Nuevo León");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Oaxaca");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Puebla");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Querétaro");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Quintana Roo");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "San Luis Potosí");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Sinaloa");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Sonora");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Tabasco");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Tamaulipas");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Tlaxcala");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Veracruz");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Yucatán");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Zacatecas");
            #endregion


            miEmpresa = _registro.Listar();
            dtgEmpresa.ItemsSource = miEmpresa;
            lblTotal.Content = "Total: " + dtgEmpresa.Items.Count.ToString();


        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                {
                    _registro.Add(new Empresa(txtrfc.Text.ToUpper(), txtSiglas.Text, txtNombre.Text, txtGiro.Text, txtDireccion.Text, txtColonia.Text, txtCiudad.Text, cmbEstado.Text, int.Parse(txtCodigoPostal.Text), txtTelefono.Text));

                    _registro.Guardar();
                    MessageBox.Show("Sus datos han sido guardados correctamente","Información del sistema");
                    btnMensaje.Content = "sus datos han sido guardados correctamente";



                }

                miEmpresa = _registro.Listar();
                dtgEmpresa.ItemsSource = miEmpresa;
                lblTotal.Content = "Total: " + dtgEmpresa.Items.Count.ToString();
                txtCiudad.Text = "";
                txtCodigoPostal.Text = "";
                txtColonia.Text = "";
                txtSiglas.Text = "";
                txtNombre.Text = "";
                txtGiro.Text = "";
                txtDireccion.Text = "";
                txtrfc.Text = "";
                cmbEstado.SelectedIndex = -1;
                txtCodigoPostal.Text = "";
                txtTelefono.Text = "";


            }
            catch (Exception)
            {

                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("Para poder Guardar ingrese datos en los campos correspondientes", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);

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

        private void RibbonButton_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar el proveedor?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                {

                    _registro.Eliminar(_EmpresaActual);
                    btnMensaje.Content = "La empresa: " + _EmpresaActual.Nombre + " se elimino correctamente";
                    //bloque controles



                }
                else
                {

                    btnMensaje.Content = "Execucion cancelada";
                    _registro.Clear();

                }

                miEmpresa = _registro.Listar();
                dtgEmpresa.ItemsSource = miEmpresa;
                lblTotal.Content = "Total: " + dtgEmpresa.Items.Count.ToString();
                rbActualizar.IsEnabled = false;
                rbEliminar.IsEnabled = false;
                rbNuevo.IsEnabled = true;

            }
            catch (Exception)
            {

            }

            txtCiudad.Text = "";
            txtCodigoPostal.Text = "";
            txtColonia.Text = "";
            txtSiglas.Text = "";
            txtNombre.Text = "";
            txtGiro.Text = "";
            txtDireccion.Text = "";
            txtrfc.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtCodigoPostal.Text = "";
            txtTelefono.Text = "";
            _registro.Clear();
        }

        private void dtgEmpresa_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (dtgEmpresa.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRows(dtgEmpresa);
                foreach (DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encontrar = miEmpresa.ElementAt(buscar);
                        _EmpresaActual = (Empresa)encontrar;

                        this.txtrfc.Text = _EmpresaActual.Rfc;
                        this.txtSiglas.Text = _EmpresaActual.Siglas;
                        this.txtNombre.Text = _EmpresaActual.Nombre;
                        this.txtGiro.Text = _EmpresaActual.Giro;
                        this.txtDireccion.Text = _EmpresaActual.Direccion;
                        this.txtColonia.Text = _EmpresaActual.Colonia;
                        this.txtCiudad.Text = _EmpresaActual.Ciudad;
                        this.cmbEstado.Text = _EmpresaActual.Estado;
                        this.txtCodigoPostal.Text = _EmpresaActual.Cp.ToString().Trim();
                        this.txtTelefono.Text = _EmpresaActual.Telefono;

                        rbNuevo.IsEnabled = false;
                        rbGuardar.IsEnabled = false;
                        rbActualizar.IsEnabled = true;
                        rbEliminar.IsEnabled = true;

                        break;
                    }
                }
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                try
                {
                    MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (x == MessageBoxResult.Yes)
                        if (_EmpresaActual == null)
                        {
                            _registro.Add(new Empresa(txtrfc.Text.Trim(), txtSiglas.Text.Trim(), txtNombre.Text.Trim(), txtGiro.Text.Trim(), txtDireccion.Text.Trim(), txtColonia.Text.Trim(), txtCiudad.Text.Trim(), cmbEstado.Text.Trim(), int.Parse(txtCodigoPostal.Text), txtTelefono.Text));


                        }
                        else
                        {
                            _EmpresaActual.Rfc = txtrfc.Text;
                            _EmpresaActual.Siglas = txtSiglas.Text;
                            _EmpresaActual.Nombre = txtNombre.Text;
                            _EmpresaActual.Giro = txtGiro.Text;
                            _EmpresaActual.Direccion = txtDireccion.Text;
                            _EmpresaActual.Colonia = txtColonia.Text;
                            _EmpresaActual.Ciudad = txtCiudad.Text;
                            _EmpresaActual.Estado = cmbEstado.Text;
                            _EmpresaActual.Cp = int.Parse(txtCodigoPostal.Text);
                            _EmpresaActual.Telefono = txtTelefono.Text;
                            _registro.Actualizar(_EmpresaActual);
                            btnMensaje.Content = "Se actualizo correctamente la empresa " + _EmpresaActual.Siglas;


                        }
                    miEmpresa = _registro.Listar();
                    dtgEmpresa.ItemsSource = miEmpresa;


                }
                catch (Exception)
                { }
                txtCiudad.Text = "";
                txtCodigoPostal.Text = "";
                txtColonia.Text = "";
                txtSiglas.Text = "";
                txtNombre.Text = "";
                txtGiro.Text = "";
                txtDireccion.Text = "";
                txtrfc.Text = "";
                cmbEstado.SelectedIndex = -1;
                txtCodigoPostal.Text = "";
                txtTelefono.Text = "";
                _registro.Clear();

            }




        }

        private void RibbonButton_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                    if (_EmpresaActual == null)
                    {
                        _registro.Add(new Empresa(txtrfc.Text.Trim(), txtSiglas.Text.Trim(), txtNombre.Text.Trim(), txtGiro.Text.Trim(), txtDireccion.Text.Trim(), txtColonia.Text.Trim(), txtCiudad.Text.Trim(), cmbEstado.Text.Trim(), int.Parse(txtCodigoPostal.Text), txtTelefono.Text));



                    }
                    else
                    {
                        _EmpresaActual.Rfc = txtrfc.Text;
                        _EmpresaActual.Siglas = txtSiglas.Text;
                        _EmpresaActual.Nombre = txtNombre.Text;
                        _EmpresaActual.Giro = txtGiro.Text;
                        _EmpresaActual.Direccion = txtDireccion.Text;
                        _EmpresaActual.Colonia = txtColonia.Text;
                        _EmpresaActual.Ciudad = txtCiudad.Text;
                        _EmpresaActual.Estado = cmbEstado.Text;
                        _EmpresaActual.Cp = int.Parse(txtCodigoPostal.Text);
                        _EmpresaActual.Telefono = txtTelefono.Text;
                        _registro.Actualizar(_EmpresaActual);
                        btnMensaje.Content = "Se actualizo correctamente la empresa " + _EmpresaActual.Siglas;

                    }
                lblTotal.Content = "Total: " + dtgEmpresa.Items.Count.ToString();
                miEmpresa = _registro.Listar();
                dtgEmpresa.ItemsSource = miEmpresa;
                rbActualizar.IsEnabled = false;
                rbEliminar.IsEnabled = false;
                rbNuevo.IsEnabled = true;

            }
            catch (Exception)
            { }
            txtCiudad.Text = "";
            txtCodigoPostal.Text = "";
            txtColonia.Text = "";
            txtSiglas.Text = "";
            txtNombre.Text = "";
            txtGiro.Text = "";
            txtDireccion.Text = "";
            txtrfc.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtCodigoPostal.Text = "";
            txtTelefono.Text = "";
            _registro.Clear();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar la ventana Empresa?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
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



        private void rbNuevo_Click(object sender, RoutedEventArgs e)
        {
            rbGuardar.IsEnabled = true;
            dtgEmpresa.IsEnabled = true;
            txtrfc.IsEnabled = true;
            txtSiglas.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtGiro.IsEnabled = true;
            txtDireccion.IsEnabled = true;
            txtColonia.IsEnabled = true;
            txtCiudad.IsEnabled = true;
            cmbEstado.IsEnabled = true;
            txtCodigoPostal.IsEnabled = true;
            txtTelefono.IsEnabled = true;
            dtgEmpresa.IsEnabled = true;
            btnMensaje.Content = "Listo";

        }

        private void rbCancelar_Click(object sender, RoutedEventArgs e)
        {
            rbNuevo.IsEnabled = true;
            txtrfc.Clear();
            txtSiglas.Clear();
            txtNombre.Clear();
            txtGiro.Clear();
            txtDireccion.Clear();
            txtColonia.Clear();
            txtCiudad.Clear();
            cmbEstado.SelectedIndex = -1;
            txtCodigoPostal.Clear();
            txtGiro.Clear();


            txtTelefono.Clear();
            rbActualizar.IsEnabled = false;
            rbEliminar.IsEnabled = false;
        }
        #region Validaciones


        private void txtSiglas_KeyDown(object sender, KeyEventArgs e)
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

        private void txtGiro_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCiudad_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void rbReportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes re = new Reportes();
            //re.GenerandoEmpresa(miEmpresa);
        }

        private void RibbonWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                try
                {
                    MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (x == MessageBoxResult.Yes)
                        if (_EmpresaActual == null)
                        {
                            _registro.Add(new Empresa(txtrfc.Text.Trim(), txtSiglas.Text.Trim(), txtNombre.Text.Trim(), txtGiro.Text.Trim(), txtDireccion.Text.Trim(), txtColonia.Text.Trim(), txtCiudad.Text.Trim(), cmbEstado.Text.Trim(), int.Parse(txtCodigoPostal.Text), txtTelefono.Text));



                        }
                        else
                        {
                            _EmpresaActual.Rfc = txtrfc.Text;
                            _EmpresaActual.Siglas = txtSiglas.Text;
                            _EmpresaActual.Nombre = txtNombre.Text;
                            _EmpresaActual.Giro = txtGiro.Text;
                            _EmpresaActual.Direccion = txtDireccion.Text;
                            _EmpresaActual.Colonia = txtColonia.Text;
                            _EmpresaActual.Ciudad = txtCiudad.Text;
                            _EmpresaActual.Estado = cmbEstado.Text;
                            _EmpresaActual.Cp = int.Parse(txtCodigoPostal.Text);
                            _EmpresaActual.Telefono = txtTelefono.Text;
                            _registro.Actualizar(_EmpresaActual);
                            btnMensaje.Content = "Se actualizo correctamente la empresa " + _EmpresaActual.Siglas;

                        }
                    lblTotal.Content = "Total: " + dtgEmpresa.Items.Count.ToString();
                    miEmpresa = _registro.Listar();
                    dtgEmpresa.ItemsSource = miEmpresa;
                    rbActualizar.IsEnabled = false;
                    rbEliminar.IsEnabled = false;
                    rbNuevo.IsEnabled = true;

                }
                catch (Exception)
                { }
                txtCiudad.Text = "";
                txtCodigoPostal.Text = "";
                txtColonia.Text = "";
                txtSiglas.Text = "";
                txtNombre.Text = "";
                txtGiro.Text = "";
                txtDireccion.Text = "";
                txtrfc.Text = "";
                cmbEstado.SelectedIndex = -1;
                txtCodigoPostal.Text = "";
                txtTelefono.Text = "";
                _registro.Clear();
            }




        }
        #endregion

        private void RibbonWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                try
                {
                    MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar el proveedor?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (x == MessageBoxResult.Yes)
                    {

                        _registro.Eliminar(_EmpresaActual);
                        btnMensaje.Content = "La empresa: " + _EmpresaActual.Nombre + " se elimino correctamente";
                        //bloque controles



                    }
                    else
                    {

                        btnMensaje.Content = "Execucion cancelada";
                        _registro.Clear();

                    }

                    miEmpresa = _registro.Listar();
                    dtgEmpresa.ItemsSource = miEmpresa;
                    lblTotal.Content = "Total: " + dtgEmpresa.Items.Count.ToString();
                    rbActualizar.IsEnabled = false;
                    rbEliminar.IsEnabled = false;
                    rbNuevo.IsEnabled = true;

                }
                catch (Exception)
                {

                }

                txtCiudad.Text = "";
                txtCodigoPostal.Text = "";
                txtColonia.Text = "";
                txtSiglas.Text = "";
                txtNombre.Text = "";
                txtGiro.Text = "";
                txtDireccion.Text = "";
                txtrfc.Text = "";
                cmbEstado.SelectedIndex = -1;
                txtCodigoPostal.Text = "";
                txtTelefono.Text = "";
                _registro.Clear();
            }

        }

     
        private void RibbonWindow_KeyDown_2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {

                wpfManualTecnico ve = new wpfManualTecnico();
                ve.Show();
            }


        }
    }
}