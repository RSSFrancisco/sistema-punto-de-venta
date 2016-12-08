#region Referencias
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Negocios;
using System.Collections;

#endregion

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for wpfUsuario.xaml
    /// </summary>
    public partial class wpfUsuario : Divelements.SandRibbon.RibbonWindow
    {

        #region Variables Privadas
        RegistrarUsuario _registroUsuario = new RegistrarUsuario();
        List<Negocios.Usuario> misUsuarios = null;
        //Negocios.Usuario _UsuarioActual = null;

        RegistroEmpleado _registro = new RegistroEmpleado();
        List<Negocios.Empleado> misEmpleados = null;
        Negocios.Empleado _EmpleadoActual = null;
        #endregion
        public wpfUsuario()
        {
            InitializeComponent();

            lblFecha.Content = "Fecha:" + DateTime.Now.ToShortDateString();
            lblHora.Content = "Hora:" + DateTime.Now.ToShortTimeString();
            misEmpleados = _registro.ListarSinUsuario();
            misUsuarios= _registroUsuario.Listar();
            dtgUsuario.ItemsSource = misUsuarios;
            cmbEmpleado.ItemsSource = misEmpleados;
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
                MessageBoxResult x = MessageBox.Show("¿Desea cerrar la ventana Usuario?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
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
        public int enviaEstatus =0;
        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                string validaContrasenia = txtConfirmarContrasenia.Password;
                _EmpleadoActual = (Empleado)cmbEmpleado.SelectedItem;
                enviaEstatus = _EmpleadoActual.Clave;
                _EmpleadoActual.Nick = txtNick.Text;
                _EmpleadoActual.Contrasenia = txtcntrasenia.Password;

                if (txtcntrasenia.Password != validaContrasenia.ToString())
                {
                    Microsoft.Windows.Controls.MessageBox.Show("La contraseña no coincide con la confirmación", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtConfirmarContrasenia.Clear();
                   
                }
                else
                {
                    _registro.AgregarUsuario(_EmpleadoActual,enviaEstatus);
                  

                    MessageBox.Show("Sus datos han sido guardado correctamente", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtConfirmarContrasenia.Password = "";
                    txtcntrasenia.Password = "";
                    txtNick.Text = "";
                    misUsuarios = _registroUsuario.Listar();
                    misEmpleados = _registro.ListarSinUsuario();
                    dtgUsuario.ItemsSource = misUsuarios;
                    cmbEmpleado.ItemsSource = misEmpleados;
                    _registro.Clear();
                }

          
               
            }
            catch (Exception)
            {
                Microsoft.Windows.Controls.MessageBox.Show("A ocurrido una exepcion al tratar de guardar sus datos", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

      
        }

        private void rbNuevoRegistro_Click(object sender, RoutedEventArgs e)
        {
            txtcntrasenia.IsEnabled = true;
            txtConfirmarContrasenia.IsEnabled = true;
            txtNick.IsEnabled = true;
            cmbEmpleado.IsEnabled = true;
            dtgUsuario.IsEnabled = true;
            rbActualizar.IsEnabled = true;
            rbEliminar.IsEnabled = true;
        }

        private void rbCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtcntrasenia.Password = "";
            txtcntrasenia.Password = "";
            txtNick.Text = "";
            cmbEmpleado.SelectedIndex = -1;

        }

    }

}
