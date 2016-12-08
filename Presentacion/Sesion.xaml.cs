using System;
using System.Windows;
using System.Windows.Input;
using Negocios;

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for Sesion.xaml
    /// </summary>
    public partial class Sesion : Divelements.SandRibbon.RibbonWindow
    {

        Usuario miusuario = new Usuario();
        

        public Sesion()
        {
            InitializeComponent();
           
        }
       
        private bool _iniciar = false;

        public bool Continuar
        {

            get { return _iniciar; }
            set { _iniciar = value; }

        }
      
        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool falso=false;
                bool continuar = false;


                if (txtUsuario.Text != "" & txtContraseña.Password != "")
                {
                    falso = true;
                }
                if (!falso)
                {
                    lblMensaje.Content = "Debes de ingresar tu contraseña y usuario correctos";
                }
                else { 
                    continuar = miusuario.ingresar(txtUsuario.Text.Trim(), txtContraseña.Password.Trim());
                   _iniciar = continuar;
                }
                if (continuar)
                {
                    Microsoft.Windows.Controls.MessageBox.Show("Bienvenido(a) " + txtUsuario.Text + " al sistema  ", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                else
                {
                  
                    lblMensaje.Content = "Nombre de usuario o contraseña invalidos";
                }
            
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo establecer la conexión a la Base de datos del sistema","Seguridad del sistema");
            }
           
        }
        
        private void txtUsuario_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            decimal val;

            if (!decimal.TryParse(e.Text, out val))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                lblMensaje.Content = "Este campo solo acepta Texto";
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
               try
                {
                    bool falso = false;
                    bool continuar = false;


                    if (txtUsuario.Text != "" & txtContraseña.Password != "")
                    {
                        falso = true;
                    }
                    if (!falso)
                    {
                        lblMensaje.Content = "Debes de ingresar tu contraseña y usuario correctos";
                    }
                    else
                    {
                        continuar = miusuario.ingresar(txtUsuario.Text.Trim(), txtContraseña.Password.Trim());
                        _iniciar = continuar;
                    }
                    if (continuar)
                    {
                        Microsoft.Windows.Controls.MessageBox.Show("Bienvenido(a) " + txtUsuario.Text + " al sistema  ", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                        Close();
                    }
                    else
                    {

                        lblMensaje.Content = "Nombre de usuario o contraseña invalidos";
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("No se pudo establecer la conexión a la Base de datos del sistema", "Seguridad del sistema");
                

                }
       

        }
        }



    }
}



