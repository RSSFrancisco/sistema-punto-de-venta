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


namespace Presentacion
{
    /// <summary>
    /// Interaction logic for wpfManualTecnico.xaml
    /// </summary>
    public partial class wpfManualTecnico : Window
    {
        public wpfManualTecnico()
        {
            InitializeComponent();
          
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
      
    }
}
