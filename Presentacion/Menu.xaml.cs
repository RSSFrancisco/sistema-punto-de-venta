using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Negocios;
using Microsoft.Win32;

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu:Window
    {
 
        RegistroRespaldo _registroRespaldo = new RegistroRespaldo();
        public Menu()

        {
            InitializeComponent();   
        }

      
        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rbProveedor_Click(object sender, RoutedEventArgs e)
        {
            wpfProveedor prov = new wpfProveedor();
            prov.Show();
        }

        private void rbUsuario_Click(object sender, RoutedEventArgs e)
        {
            wpfUsuario us = new wpfUsuario();
            us.Show();

        }

        private void rbContactos_Click_1(object sender, RoutedEventArgs e)
        {
            wpfEmpresa emp = new wpfEmpresa();
            emp.Show();
        }

        private void rbProductos_Click(object sender, RoutedEventArgs e)
        {
            wpfProducto produ = new wpfProducto();
            // se modifico el evento ShowDialog por "Show" para que se puedan abrir varias ventanas de producto
            produ.Show();
        }

        private void rbEmpleados_Click(object sender, RoutedEventArgs e)
        {
            wpfEmpleado empl = new wpfEmpleado();
            empl.Show();
        }

        //private void rbCompras_Click(object sender, RoutedEventArgs e)
        //{
        //    if(e.Source!=null)
        //    {
        //        wpfCompras com = new wpfCompras();
        //        com.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Esta opcion no esta disponible por el momento\n Intentelo mas tarde");
        //    }
            
            
        //}

        private void rbInformacion_Click(object sender, RoutedEventArgs e)
        {
            wpfInformacion inf = new wpfInformacion();
            inf.ShowDialog();
        }

        private void rbServicios_Click(object sender, RoutedEventArgs e)
        {
            //wpfReporteServicio ser = new wpfReporteServicio();
            //ser.ShowDialog();

             
        }

        private void rbSesion_Click(object sender, RoutedEventArgs e)
        {
            Sesion se = new Sesion();
            se.ShowDialog();
        }

        private void Mnsesion_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Sesion se = new Sesion();
                se.ShowDialog();
                bool continuar = se.Continuar;
                if (continuar)
                {
                    tbRG.IsEnabled = true;
                    //rbempresa.IsEnabled = true;
                    
                    //Mnsesion.IsEnabled = false;
                }
                se = null;
            }
            catch (Exception)
            {

                throw;
            }
        }

      
        private void btnSesion_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Sesion se = new Sesion();
                se.ShowDialog();
                bool continuar = se.Continuar;
                if (continuar)
                {
                    
                    rbmenu.IsEnabled = true;
                    tbRG.IsEnabled = true;
                    //rbempresa.IsEnabled = true;
                    btnSesion.IsEnabled = false;
                    btnCerrar.IsEnabled = true;
                    btnHistorial.IsEnabled = true;
                    btnAcercaDE.IsEnabled = true;
                    btnAyuda.IsEnabled = true;
                   
                    
                    //Mnsesion.IsEnabled = false;
                }
                se = null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
           
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar esta sesion?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                {
                    rbmenu.IsEnabled = false;
                    btnSesion.IsEnabled = true;
                    btnCerrar.IsEnabled = false;
                    btnHistorial.IsEnabled = false;
                }
                else
                {

                }
        }

        //private void btnEmpresa_Click(object sender, RoutedEventArgs e)
        //{
        //    wpfManualTecnico manual = new wpfManualTecnico();
        //    manual.ShowDialog();
        //}

        private void btnEmpleado_Click(object sender, RoutedEventArgs e)
        {
            wpfInformacion inf = new wpfInformacion();
            inf.ShowDialog();
        }

  

        private void rbVentass_Click(object sender, RoutedEventArgs e)
        {
            if(e.Source==null)
            {
                wpfMenuVentas serv = new wpfMenuVentas();
                serv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Esta opción no esta disponible por el momento\n Vuelve a intentarlo mas tarde");
                
            }
           
        }

        private void btnHistorial_Click(object sender, RoutedEventArgs e)
        {
            wpfHistorial his = new wpfHistorial();
            his.Show();
        }

        private string archivo = "";
        private void rbRespaldar_Click(object sender, RoutedEventArgs e)
         {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea respaldar la base de datos existente?", "Seguridad del sistema", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                if (x == MessageBoxResult.OK)
                {

                    SaveFileDialog saveFile = new SaveFileDialog();
                    BitmapImage b = new BitmapImage();
                    saveFile.Title = "Seleccione la carpeta ";
                    saveFile.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp";
                    if (saveFile.ShowDialog() == true)
                    {
                        archivo = saveFile.FileName;
                    }
                    else
                    {
                        archivo = "";
                    }

                    if (archivo != "")
                    {
                        _registroRespaldo.respaldarRapido(/*archivo.ToString()*/);
                        Microsoft.Windows.Controls.MessageBox.Show("Se respaldo correctamente la Base de datos", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBoxResult y = Microsoft.Windows.Controls.MessageBox.Show("El respaldo ha sido cancelado", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBoxResult y = Microsoft.Windows.Controls.MessageBox.Show("El respaldo ha sido cancelado", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                 
                }
            }
            catch (System.Exception)
            {

                MessageBox.Show("Ups ha ocurrido un error al hacer su respaldo, intentelo más tarde");
            }
        
        }
       
          /*  if (e != null)---esto era el evento que respaldaba la BD desde el CMD
            {
                ProcessStartInfo info2 = new System.Diagnostics.ProcessStartInfo("CMD.EXE", " /C sqlcmd –E –S localhost\\RFCASSETMGR –Q “BACKUP DATABASE [baseRG] TO DISK=’c:\\sqlback.bak'");
                Process.Start(info2);
                if (info2 != null)
                {
                   
                }

            }


            else
            {
               
            }*/

        

      
        private void rbRestaurar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            BitmapImage b = new BitmapImage();
            openFile.Title = "Seleccione el Archivo de respaldo ";
            openFile.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp";
            if (openFile.ShowDialog() == true)
            {
                archivo = openFile.FileName;
            }
            else
            {
                archivo = "";
            }

            if (archivo != "")
            {



                _registroRespaldo.restaurarRapido(archivo.ToString());
                Microsoft.Windows.Controls.MessageBox.Show("Se restauro correctamente la Base de datos", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                Microsoft.Windows.Controls.MessageBox.Show("La restauracion ha sido cancelada", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        

            

        }

        private void rbRestauracionAvanza_Click(object sender, RoutedEventArgs e)
        {
            SistemaSeguridad.wpfRestaurar restaura = new SistemaSeguridad.wpfRestaurar();
            restaura.ShowDialog();
        }

        private void rbRespaldoAvanzado_Click_1(object sender, RoutedEventArgs e)
        {
            SistemaSeguridad.RespaldoBD ventanaResp = new SistemaSeguridad.RespaldoBD();
            ventanaResp.ShowDialog();
        }

        private void RGSystem_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar esta ventana?", "Seguridad del sistema", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (x == MessageBoxResult.OK)
                {
                    e.Cancel = false;


                }
                else
                {
                    e.Cancel = true;

                }
          
        }

        private void RGSystem_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.Key == Key.Escape)
            {

                Close();
                

            }

        }

        private void RGSystem_KeyUp(object sender, KeyEventArgs e)
          {
            if (e.Key == Key.F1)
            {
                wpfEmpleado em = new wpfEmpleado();
                em.ShowDialog();


            }
        }

        private void RGSystem_KeyDown_1(object sender, KeyEventArgs e)
          {
            if (e.Key == Key.F2)
            {
                wpfEmpresa emp = new wpfEmpresa();
                emp.ShowDialog();


            }
        }

        private void RGSystem_KeyUp_1(object sender, KeyEventArgs e)
       {
            if (e.Key == Key.F3)
            {
                wpfProveedor prod = new wpfProveedor();
                prod.ShowDialog();
            }


        }

        private void rbCategorias_Click(object sender, RoutedEventArgs e)
        {
            wpfCategorias cate = new wpfCategorias();
            cate.ShowDialog();
        }

        private void btnAyuda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //wpfManualTecnico manual = new wpfManualTecnico();
                //manual.ShowDialog();
            }
            catch
            {

            }
        }

        private void ventanaVentas(object sender, RoutedEventArgs e)
        {
            wpfMenuVentas venta = new wpfMenuVentas();
            venta.ShowDialog();
        }
        // Fecha de creacion: 3  de Otubre 2016
        //Sabino Alberto Galicia Moreno
        private void rbCompras_Click(object sender, RoutedEventArgs e)
        {
            wpfCompras compras = new wpfCompras();
            compras.Show();
        }

        private void ventanaInventario(object sender, RoutedEventArgs e)
        {
           
                Inventario.wpfInventario inv = new Inventario.wpfInventario();
                inv.Show();
          
           
        }
    }
}
