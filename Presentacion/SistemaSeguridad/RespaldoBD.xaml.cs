
#region Regiones
using System;
using System.Collections.Generic;
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
using System.Data;
using System.Linq;
using System.Collections;

using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
#endregion


namespace Presentacion.SistemaSeguridad
{
    /// <summary>
    /// Interaction logic for RespaldoBD.xaml
    /// </summary>
    public partial class RespaldoBD : Window
    {
       RegistroRespaldo _registroRespaldo = new RegistroRespaldo();
        public RespaldoBD()
        {
            InitializeComponent();
            #region dispositivos
            cmbDispositivo.Items.Add(new ComboBoxItem().Content = "C");
            cmbDispositivo.Items.Add(new ComboBoxItem().Content = "E");
            cmbDispositivo.Items.Add(new ComboBoxItem().Content = "F");
            cmbDispositivo.Items.Add(new ComboBoxItem().Content = "G");
            cmbDispositivo.Items.Add(new ComboBoxItem().Content = "H");
            cmbDispositivo.Items.Add(new ComboBoxItem().Content = "D");
            cmbDispositivo.Items.Add(new ComboBoxItem().Content = "Z");

            #endregion
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea respaldar la base de datos existente?", "Seguridad del sistema", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                if (x == MessageBoxResult.OK)
                {


                    _registroRespaldo.respaldar(txtNombre.Text, cmbDispositivo.Text.Trim(), DateTime.Parse(dtFecha.Text), txtCarpeta.Text);
                    Microsoft.Windows.Controls.MessageBox.Show("el respaldo se realizo con exito");
                    this.Close();
                }
                else
                {
                    MessageBoxResult y = Microsoft.Windows.Controls.MessageBox.Show("El respaldo ha sido cancelado", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtNombre.Clear();
                    txtCarpeta.Clear();
                    dtFecha.Text = "";
                    cmbDispositivo.Text = "";
                }
            }
            catch (Exception)
            {

                Microsoft.Windows.Controls.MessageBox.Show("A ocurrido una exepcion al tratar de respaldar sus datos", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        
        }
       
      

       
        }
        

    }

