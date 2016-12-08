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
using System.IO;
using Microsoft.Win32;

namespace Presentacion.SistemaSeguridad
{
    /// <summary>
    /// Interaction logic for wpfRestaurar.xaml
    /// </summary>
    public partial class wpfRestaurar : Window
    {
        RegistroRespaldo _registroRespaldo = new RegistroRespaldo(); 
        public wpfRestaurar()
        {
            InitializeComponent();
            #region dispositivos
            cmbUnidad.Items.Add(new ComboBoxItem().Content = "C");
            cmbUnidad.Items.Add(new ComboBoxItem().Content = "E");
            cmbUnidad.Items.Add(new ComboBoxItem().Content = "F");
            cmbUnidad.Items.Add(new ComboBoxItem().Content = "G");
            cmbUnidad.Items.Add(new ComboBoxItem().Content = "H");
            cmbUnidad.Items.Add(new ComboBoxItem().Content = "D");
            cmbUnidad.Items.Add(new ComboBoxItem().Content = "Z");

            #endregion
        }
        private string archivo = "";
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea respaldar la base de datos existente?", "Seguridad del sistema", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                if (x == MessageBoxResult.OK)
                {


                    _registroRespaldo.restaurar(txtArchivo.Text, cmbUnidad.Text.Trim(), txtCarpeta.Text);
                    Microsoft.Windows.Controls.MessageBox.Show("La restauracion se realizo con exito");
                    this.Close();
                }
                else
                {
                    MessageBoxResult y = Microsoft.Windows.Controls.MessageBox.Show("La restauracion ha sido cancelada", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtArchivo.Text = "";
                    txtCarpeta.Text = "";
                    cmbUnidad.Text = "";
                }
            }
            catch (System.Exception)
            {

                Microsoft.Windows.Controls.MessageBox.Show("A ocurrido una exepcion al tratar de restaurar sus datos", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnArchivo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            BitmapImage b = new BitmapImage();
            openFile.Title = "Seleccione el archivo a Mostrar";
            openFile.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp";
            if (openFile.ShowDialog() == true)
            {
               archivo = openFile.SafeFileName;
            }
            else
            {
                archivo = "";
            }

            if (archivo != "")
            {
              
                txtArchivo.Text = archivo;

            }
        


        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
