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
    /// Interaction logic for wpfContacto.xaml
    /// </summary>
    public partial class wpfContacto : Divelements.SandRibbon.RibbonWindow
    {
        #region Atributos
        RegistrarContacto _registro = new RegistrarContacto();
        List<Contacto> miContacto = null;
        Contacto _contactoActual = null;

        RegistrarEmpresa _empresa = new RegistrarEmpresa();
        List<Empresa> misEmpresas = null;
        Empresa _empresaActual = null;
        #endregion
        public wpfContacto()
        {
            InitializeComponent();


            #region Métodos
            miContacto = _registro.Listar();
            misEmpresas = _empresa.Listar();
            dtgContacto.ItemsSource = miContacto;
            cmbEmpresa.ItemsSource = misEmpresas;

            lblTotal.Content = "Total: " + dtgContacto.Items.Count.ToString();





            #endregion
        }
        #region metodos Privados
        /// <summary>
        /// metodo que se encarga de guardar los registros de la ventana wpfContacto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                {
                    int claveEmpresa = 0;
                    _empresaActual = (Empresa)cmbEmpresa.SelectedItem;
                    claveEmpresa = _empresaActual.Clave;
                    _registro.Add(new Contacto(txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtTelefono.Text, txtExtension.Text, txtCorreoElectronico.Text, txtPuesto.Text, claveEmpresa));
                    _registro.Guardar();

                    btnMensaje.Content = "Su registro ha sido guardado correctamente";
                }


                miContacto = _registro.Listar();
                dtgContacto.ItemsSource = miContacto;
                lblTotal.Content = "Total: " + dtgContacto.Items.Count.ToString();
                txtNombre.Text = "";
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                txtCorreoElectronico.Text = "";
                txtExtension.Text = "";
                txtPuesto.Text = "";
                txtTelefono.Text = "";
                cmbEmpresa.SelectedIndex = -1;
            }
            catch (Exception)
            {
                Microsoft.Windows.Controls.MessageBox.Show("Algunos campos estan  vacios revise que sus datos que esten completos", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);

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

        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }
        /// <summary>
        /// metodo encargado de eliminar los registros de la ventana wpfContacto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibbonButton_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar este Contacto?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                {
                    {
                        _registro.Eliminar(_contactoActual);
                        btnMensaje.Content = "El Contacto: " + _contactoActual.Nombre + " ha sido eliminado";
                    }
                }
                miContacto = _registro.Listar();
                dtgContacto.ItemsSource = miContacto;
                lblTotal.Content = "Total: " + dtgContacto.Items.Count.ToString();
                rbEliminar.IsEnabled = false;
                rbActualizar.IsEnabled = false;
                rbNuevo.IsEnabled = true;

            }
            catch (Exception)
            {
                btnMensaje.Content = "Ejecucion cancelada";
            }
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCorreoElectronico.Clear();
            txtExtension.Clear();
            txtPuesto.Clear();
            txtTelefono.Clear();
            cmbEmpresa.SelectedIndex = -1;

        }
        private IEnumerable<DataGridRow> GetDataGridRow(DataGrid grid)
        {
            var ItemSource = grid.ItemsSource as IEnumerable; //variable itemsource
            if (null == ItemSource) yield return null;
            foreach (var item in ItemSource) // item de elemento
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow; //genera y devuelve una fila 
                if (null != row) yield return row;
            }
        }

        private void dtgContacto_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dtgContacto.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRows(dtgContacto);
                foreach (DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encuentra = miContacto.ElementAt(buscar);
                        _contactoActual = (Contacto)encuentra;
                        this.txtNombre.Text = _contactoActual.Nombre.Trim();
                        this.txtApellidoPaterno.Text = _contactoActual.ApellidoPaterno.Trim();
                        this.txtApellidoMaterno.Text = _contactoActual.ApellidoMaterno.Trim();
                        this.txtTelefono.Text = _contactoActual.Telefono.Trim();
                        this.txtExtension.Text = _contactoActual.Extension.Trim();
                        this.txtCorreoElectronico.Text = _contactoActual.Correo.Trim();
                        this.txtPuesto.Text = _contactoActual.Puesto.Trim();
                        int a = _contactoActual.Idempresa;
                        foreach (Empresa emp in misEmpresas)
                        {
                            if (emp.Clave == _contactoActual.Idempresa)
                            {
                                this.cmbEmpresa.SelectedItem = emp;

                            }
                        }
                        rbEliminar.IsEnabled = true;
                        rbActualizar.IsEnabled = true;

                        rbNuevo.IsEnabled = false;
                        rbGuardar.IsEnabled = false;

                        break;
                    }

                }
                #endregion
            }
        }
        #region Validacion Ventana
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar la ventana Contacto?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
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




        #endregion

        private void rbActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                {

                    if (_contactoActual != null)
                    {
                        _contactoActual.Nombre = txtNombre.Text;
                        _contactoActual.ApellidoPaterno = txtApellidoPaterno.Text;
                        _contactoActual.ApellidoMaterno = txtApellidoMaterno.Text;
                        _contactoActual.Telefono = txtTelefono.Text;
                        _contactoActual.Extension = txtExtension.Text;
                        _contactoActual.Correo = txtCorreoElectronico.Text;
                        _contactoActual.Puesto = txtPuesto.Text;
                        _empresaActual = (Empresa)cmbEmpresa.SelectedItem;
                        _contactoActual.Idempresa = _empresaActual.Clave;
                        _registro.Actualizar(_contactoActual);

                        btnMensaje.Content = "El contacto " + _contactoActual.Nombre + " ha sido actualizado";

                    }
                    else
                    {
                        Microsoft.Windows.Controls.MessageBox.Show("Pulse doble clic sobre un contacto.", "Informacion", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    }


                }
                miContacto = _registro.Listar();
                dtgContacto.ItemsSource = miContacto;
                lblTotal.Content = "Total: " + dtgContacto.Items.Count.ToString();
                rbNuevo.IsEnabled = true;
                rbEliminar.IsEnabled = false;
                rbActualizar.IsEnabled = false;


            }
            catch (Exception ex)
            {
                Microsoft.Windows.Controls.MessageBox.Show(ex.Message, "Seguridad del sistema.", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefono.Text = "";
            txtExtension.Text = "";
            txtCorreoElectronico.Text = "";
            txtPuesto.Text = "";
            cmbEmpresa.SelectedIndex = -1;
            _registro.Clear();
        }

        private void rbNuevo_Click(object sender, RoutedEventArgs e)
        {
            rbGuardar.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtApellidoPaterno.IsEnabled = true;
            txtApellidoMaterno.IsEnabled = true;
            txtTelefono.IsEnabled = true;
            txtExtension.IsEnabled = true;
            txtCorreoElectronico.IsEnabled = true;
            txtPuesto.IsEnabled = true;
            cmbEmpresa.IsEnabled = true;
            dtgContacto.IsEnabled = true;
            rbReportes.IsEnabled = true;
            btnMensaje.Content = "Listo";


        }
        #region Validación de cajas de texto
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

        private void txtApellidoPaterno_KeyDown(object sender, KeyEventArgs e)
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

        private void txtApellidoMaterno_KeyDown(object sender, KeyEventArgs e)
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

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtExtension_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtPuesto_KeyDown(object sender, KeyEventArgs e)
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

        private void rbCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefono.Text = "";
            txtExtension.Text = "";
            txtCorreoElectronico.Text = "";
            txtPuesto.Text = "";
            cmbEmpresa.SelectedIndex = -1;
            _registro.Clear();
            rbActualizar.IsEnabled = false;
            rbEliminar.IsEnabled = false;
            rbNuevo.IsEnabled = true;
            btnMensaje.Content = "Sus datos han sido cancelados";


        }

        private void RibbonWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                try
                {
                    MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (x == MessageBoxResult.Yes)
                    {

                        if (_contactoActual != null)
                        {
                            _contactoActual.Nombre = txtNombre.Text;
                            _contactoActual.ApellidoPaterno = txtApellidoPaterno.Text;
                            _contactoActual.ApellidoMaterno = txtApellidoMaterno.Text;
                            _contactoActual.Telefono = txtTelefono.Text;
                            _contactoActual.Extension = txtExtension.Text;
                            _contactoActual.Correo = txtCorreoElectronico.Text;
                            _contactoActual.Puesto = txtPuesto.Text;
                            _empresaActual = (Empresa)cmbEmpresa.SelectedItem;
                            _contactoActual.Idempresa = _empresaActual.Clave;
                            _registro.Actualizar(_contactoActual);

                            btnMensaje.Content = "El contacto " + _contactoActual.Nombre + " ha sido actualizado";

                        }
                        else
                        {
                            Microsoft.Windows.Controls.MessageBox.Show("Pulse doble clic sobre un contacto.", "Informacion", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        }


                    }
                    miContacto = _registro.Listar();
                    dtgContacto.ItemsSource = miContacto;
                    lblTotal.Content = "Total: " + dtgContacto.Items.Count.ToString();
                    rbNuevo.IsEnabled = true;
                    rbEliminar.IsEnabled = false;
                    rbActualizar.IsEnabled = false;


                }
                catch (Exception ex)
                {
                    Microsoft.Windows.Controls.MessageBox.Show(ex.Message, "Seguridad del sistema.", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                txtNombre.Text = "";
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                txtTelefono.Text = "";
                txtExtension.Text = "";
                txtCorreoElectronico.Text = "";
                txtPuesto.Text = "";
                cmbEmpresa.SelectedIndex = -1;
                _registro.Clear();
            }


        }

        private void RibbonWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                try
                {
                    MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar este Contacto?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (x == MessageBoxResult.Yes)
                    {
                        {
                            _registro.Eliminar(_contactoActual);
                            btnMensaje.Content = "El Contacto: " + _contactoActual.Nombre + " ha sido eliminado";
                        }
                    }
                    miContacto = _registro.Listar();
                    dtgContacto.ItemsSource = miContacto;
                    lblTotal.Content = "Total: " + dtgContacto.Items.Count.ToString();
                    rbEliminar.IsEnabled = false;
                    rbActualizar.IsEnabled = false;
                    rbNuevo.IsEnabled = true;

                }
                catch (Exception)
                {
                    btnMensaje.Content = "Ejecucion cancelada";
                }
                txtNombre.Clear();
                txtApellidoPaterno.Clear();
                txtApellidoMaterno.Clear();
                txtCorreoElectronico.Clear();
                txtExtension.Clear();
                txtPuesto.Clear();
                txtTelefono.Clear();
                cmbEmpresa.SelectedIndex = -1;


            }
        }

        private void rbReportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes re = new Reportes();
            //re.GenerandoContacto(miContacto);
        }


        private void RibbonWindow_KeyDown_2(object sender, KeyEventArgs e)

        {
            if (e.Key == Key.F1)
            {

                wpfManualTecnico ve = new wpfManualTecnico();
                ve.Show();
            }


        }

        private void btnEmpresa_Click(object sender, RoutedEventArgs e)
        {
            wpfEmpresa empr = new wpfEmpresa();
            empr.ShowDialog();
        }

    }
}