#region Regiones
using System.Collections.Generic;
using System.Windows;
using Negocios;
#endregion

namespace Presentacion.Consultas
{
    /// <summary>
    /// Interaction logic for empleadoEntre.xaml
    /// </summary>
    public partial class empleadoEntre : Window
    {
        #region Atributos

        RegistroEmpleado _registroEmpleado = new RegistroEmpleado();
        List<Empleado> misEmpleados = null;
        //Empleado _EmpleadoActual = null;
        #endregion
        public empleadoEntre()
        {
            InitializeComponent();
            misEmpleados = _registroEmpleado.Listar();
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {

            misEmpleados = _registroEmpleado.ListarDescendente();
            this.Close();
        }
    }
}
