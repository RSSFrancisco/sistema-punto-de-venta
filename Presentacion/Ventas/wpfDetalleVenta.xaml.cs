using System.Collections.Generic;
using System.Windows;
using Negocios;
using System;

namespace Presentacion.Ventas
{
    /// <summary>
    /// Interaction logic for wpfDetalleVenta.xaml
    /// </summary>
    public partial class wpfDetalleVenta : Window
    {
        RegistroVenta _registroVenta = new RegistroVenta();
        List<Venta> misVentas = new List<Venta>();
     
        RegistrarProductosVenta _productosVenta = new RegistrarProductosVenta();
        List<ProductosVenta> misProductosventa = new List<ProductosVenta>();

        RegistrarEmpresa _empresa = new RegistrarEmpresa();
        List<Empresa> misEmpresas = null;

        RegistroEmpleado _empleado = new RegistroEmpleado();
        List<Empleado> misEmpleados = null;
      

        private string folioVenta;
        public wpfDetalleVenta(string numVenta)
        {
            InitializeComponent();
            
            misEmpresas = _empresa.Listar();
            cmbEmpresa.ItemsSource = misEmpresas;
            misEmpleados = _empleado.Listar();
            cmbEmpleado.ItemsSource = misEmpleados;

            folioVenta = numVenta;
           
            wTitulo.Title = "DETALLE DE LA VENTA NÚMERO " + folioVenta;

            misProductosventa = _productosVenta.ListarProductosVenta(int.Parse(folioVenta));
            dtgProductos.ItemsSource = misProductosventa;
            misVentas = _registroVenta.buscarVentaPorClave(int.Parse(folioVenta));
            foreach (var detalleVenta in misVentas)
            {
                txtFolio.Text = detalleVenta.IdVenta.ToString();
               
                foreach (Empresa p in misEmpresas)
                {
                    if (p.Clave == detalleVenta.IdCliente)
                    {
                        cmbEmpresa.SelectedItem = p;
                        break;
                    }
                }
                foreach (Empleado e in misEmpleados)
                {
                    if (e.Clave == detalleVenta.IdEmpleado)
                    {
                        cmbEmpleado.SelectedItem = e;
                        break;
                    }
                }
                dtFechaVenta.Text = detalleVenta.Fecha.ToShortDateString();
                txtImporte.Text = detalleVenta.Importe.ToString();
                txtCambio.Text = detalleVenta.Cambio.ToString();
                txtTotal.Text = detalleVenta.Total.ToString();
            }
            

        }
        // Fecha de creación: 15/11/2016
        // Autor: Ing.Francisco Reyes Sánchez
        // Metodo que cancela la venta
        private void rbCancelarVenta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar esta venta?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)

                    if (txtFolio.Text != "")
                    {

                        _registroVenta.Eliminar(int.Parse(txtFolio.Text));
                        Microsoft.Windows.Controls.MessageBox.Show("Se elimino correctamente la venta en el sistema", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                        Close();
                                         
                    }
                    else
                    {
                        Microsoft.Windows.Controls.MessageBox.Show("Esta venta ya fue eliminada del sistema, porfavor cierre la ventana y refresque el listado de ventas", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);


                    }
             

            }


            catch (Exception)
            {
                Microsoft.Windows.Controls.MessageBox.Show("Execucion interrumpida", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            
        }

       
        private void wTitulo_Closed(object sender, EventArgs e)
        {
            wpfListadoVentas listVentas = new wpfListadoVentas();
            listVentas.ShowDialog();
        }
    }
}
