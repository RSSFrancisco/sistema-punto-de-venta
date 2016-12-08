using System.Windows;
using System.Windows.Input;

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for wpfMenuVentas.xaml
    /// </summary>
    public partial class wpfMenuVentas : Window
    {
        public wpfMenuVentas()
        {
            InitializeComponent();
        }


        private void imgCaja_MouseUp(object sender, MouseButtonEventArgs e)
        {
            wpfCaja caja = new wpfCaja();
            Close();
            caja.Show();
        }

        private void image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            wpfListadoVentas listadoVentas = new wpfListadoVentas();
            Close();
            listadoVentas.Show();
        }
    }
}
