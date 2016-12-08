using System;
using System.Windows;
using Negocios;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Collections;
using System.Linq;

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables Privadas
        RegistroEmpleado _registroEmpleado = new RegistroEmpleado();
        List<Empleado> misEmpleados = null;
        Empleado _EmpleadoActual = null;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            misEmpleados = _registroEmpleado.Listar();
            dtgEmpleado.ItemsSource = misEmpleados;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_EmpleadoActual == null)
                {
                    _registroEmpleado.Add(new Empleado(txtnombre.Text, txtapellidoPaterno.Text, txtapellidomaterno.Text, txtnoAfiliacion.Text, DateTime.Parse(dtfecha.Text), txtdirección.Text, txtcolonia.Text, txtCiudad.Text, txtEstado.Text, int.Parse(txtCp.Text), txtTelefono.Text, txtCorreo.Text, txtNivelEscolar.Text, txtEspecialidad.Text));
                    _registroEmpleado.Guardar();
                }
                else {
                    _EmpleadoActual.ApPaterno = txtapellidoPaterno.Text;
                    _EmpleadoActual.ApMaterno = txtapellidomaterno.Text;
                    _EmpleadoActual.Ciudad = txtCiudad.Text;
                    _EmpleadoActual.CP = int.Parse(txtCp.Text);
                    //txtCp.Text = _EmpleadoActual.CP.ToString();

                 //   _registroEmpleado.Actualizar(_EmpleadoActual);
                }
                
                
                MessageBox.Show("Sus datos han sido guardado correctamente", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                _registroEmpleado.Clear();
            }
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
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_EmpleadoActual != null)
                {
                    _registroEmpleado.Eliminar(_EmpleadoActual);
                    MessageBox.Show("El Contacto se ha eliminado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                    //bloque controles

                }
            }
            catch (Exception ex){

            }
        }
       
        private IEnumerable<DataGridRow> GetDataGridRow(DataGrid grid)
        {
            var ItemSource = grid.ItemsSource as IEnumerable; //variable itemsource
            if (null == ItemSource) yield return null;
            foreach (var item in ItemSource) // item de elemento
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow; //genera y devuelve una fila 
                if (null != row) yield return row;
            }
        }

        private void dtgEmpleado_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dtgEmpleado.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRow(dtgEmpleado);
                foreach (DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encontrar = misEmpleados.ElementAt(buscar);
                        _EmpleadoActual = (Empleado)encontrar;

                        this.txtnombre.Text = _EmpleadoActual.Nombre;
                        this.txtapellidoPaterno.Text = _EmpleadoActual.ApPaterno;
                        this.txtapellidomaterno.Text = _EmpleadoActual.ApMaterno;
                        this.txtnoAfiliacion.Text = _EmpleadoActual.NSS;
                        this.dtfecha.Text = _EmpleadoActual.FechaNacimiento.ToShortDateString();
                        this.txtdirección.Text = _EmpleadoActual.Direccion;
                        this.txtcolonia.Text = _EmpleadoActual.Colonia;
                        this.txtCiudad.Text = _EmpleadoActual.Ciudad;
                        this.txtEstado.Text = _EmpleadoActual.Estado;
                       this.txtCp.Text = _EmpleadoActual.CP.ToString();
                        this.txtTelefono.Text = _EmpleadoActual.Telefono;
                        this.txtCorreo.Text = _EmpleadoActual.Correo;
                        this.txtNivelEscolar.Text = _EmpleadoActual.NivelEscolar;
                        this.txtEspecialidad.Text = _EmpleadoActual.Especialidad;
                        



                        break;
                    }
                }
            }
        }       
    }
}


