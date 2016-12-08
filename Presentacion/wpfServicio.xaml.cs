using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Negocios;
using System.Collections;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para wpfServicio.xaml
    /// </summary>
    public partial class wpfServicio : Divelements.SandRibbon.RibbonWindow
    {
        RegistraServico _registroServicio = new RegistraServico();
        List<Servicio> miservicio = null;
        Servicio _servicioActual = null;
        public wpfServicio()
        {
            InitializeComponent();
            miservicio = _registroServicio.Listar();
            dtgServicio.ItemsSource = miservicio;
        }

        private void rbGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                {
                    _registroServicio.Add(new Servicio(txtNombre.Text.Trim(), decimal.Parse(txtPrecio.Text)));
                    _registroServicio.Guardar();
                    btnMensaje.Content = "El registro se guardo correctamente";

                }
                miservicio = _registroServicio.Listar();
                dtgServicio.ItemsSource = miservicio;
                txtNombre.Clear();
                txtPrecio.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido una excepción", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            _registroServicio.Clear();

        }

        private void rbElminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = MessageBox.Show("¿Desea eliminar el servicio?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                {
                    if (_servicioActual != null)
                    {
                        _registroServicio.Eliminar(_servicioActual);
                        btnMensaje.Content = "El servicio " + _servicioActual.Nombre + " ha sido eliminado";
                    }
                }
                miservicio = _registroServicio.Listar();
                dtgServicio.ItemsSource = miservicio;
            }
            catch (Exception)
            {
                throw;
            }
            _registroServicio.Clear();
            txtNombre.Clear();
        }

        private void rbActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _servicioActual.Nombre = txtNombre.Text.Trim();
                _servicioActual.PrecioUnitario = decimal.Parse(txtPrecio.Text);
                _registroServicio.Actualizar(_servicioActual);
                btnMensaje.Content = "El servicio" + _servicioActual.Nombre + " ha sido actualizado";
                miservicio = _registroServicio.Listar();
                dtgServicio.ItemsSource = miservicio;
            }
            catch (Exception)
            {

            }
            _registroServicio.Clear();
            txtNombre.Clear();
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

        private void dtgServicio_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgServicio.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRows(dtgServicio);
                foreach (DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encuentra = miservicio.ElementAt(buscar);
                        _servicioActual = (Servicio)encuentra;
                        this.txtNombre.Text = _servicioActual.Nombre.Trim();
                        this.txtPrecio.Text = _servicioActual.PrecioUnitario.ToString();
                        rbNuevoRegistro.IsEnabled = false;
                        rbGuardar.IsEnabled = false;
                        rbElminar.IsEnabled = true;
                        rbActualizar.IsEnabled = true;
                        btnMensaje.Content = "El registro " + _servicioActual.Nombre + " se esta editando";
                        break;
                    }
                }
            }
        }
        #region valicaión de cajas de texto
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
        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        #endregion

        private void rbNuevoRegistro_Click(object sender, RoutedEventArgs e)
        {
            rbGuardar.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtPrecio.IsEnabled = true;
            dtgServicio.IsEnabled = true;
            btnMensaje.Content = "Listo";


        }

        private void rbCancelar_Click(object sender, RoutedEventArgs e)
        {
            rbNuevoRegistro.IsEnabled = true;
            rbActualizar.IsEnabled = false;
            rbElminar.IsEnabled = false;
            btnMensaje.Content = "Ejecución cancelada";


        }

        private void RibbonWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar la ventana servicio?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Question);
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
            if (e.Key == Key.F5)
            {
                try
                {
                    _servicioActual.Nombre = txtNombre.Text.Trim();
                    _servicioActual.PrecioUnitario = decimal.Parse(txtPrecio.Text);
                    _registroServicio.Actualizar(_servicioActual);
                    btnMensaje.Content = "El servicio" + _servicioActual.Nombre + " ha sido actualizado";
                    miservicio = _registroServicio.Listar();
                    dtgServicio.ItemsSource = miservicio;
                }
                catch (Exception)
                {

                }
                txtNombre.Clear();
                txtPrecio.Clear();
                _registroServicio.Clear();
                txtNombre.Clear();
            }

        }

        private void RibbonWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                try
                {
                    MessageBoxResult x = MessageBox.Show("¿Desea eliminar el servicio?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (x == MessageBoxResult.Yes)
                    {
                        if (_servicioActual != null)
                        {
                            _registroServicio.Eliminar(_servicioActual);
                            btnMensaje.Content = "El servicio " + _servicioActual.Nombre + " ha sido eliminado";
                        }
                    }
                    miservicio = _registroServicio.Listar();
                    dtgServicio.ItemsSource = miservicio;
                    txtPrecio.Clear();
                    txtNombre.Clear();
                }
                catch (Exception)
                {
                    throw;
                }
                _registroServicio.Clear();
                txtNombre.Clear();
            }

        }

        private void rbReportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes rep = new Reportes();
            //rep.GenerandoServicio(miservicio);
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
