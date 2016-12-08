#region Referencias
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Negocios;
using System.Linq;
using System.Collections;
#endregion

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for wpfCategorias.xaml
    /// </summary>
    public partial class wpfCategorias : Window
    {
        RegistroCategoria _registro = new RegistroCategoria();
        List<Categoria> _misCategorias = null;
        Categoria _categoriaActual = null;
       
        public wpfCategorias()
        {
            InitializeComponent();
            _misCategorias = _registro.Listar();
            dtgCategorias.ItemsSource = _misCategorias;


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
        protected void guardarCategoria()
        {
            try
            {
                if (txtNombre.Text != "" && txtDescripcion.Text != "")
                {

                    _registro.Add(new Categoria(txtNombre.Text.Trim(), txtDescripcion.Text.Trim()));
                    _registro.GuardarCategoria();
                    Microsoft.Windows.Controls.MessageBox.Show("Sus datos han sido guardados correctamente", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);


                    _misCategorias = _registro.Listar();
                    dtgCategorias.ItemsSource = _misCategorias;
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                }
                else
                {
                    Microsoft.Windows.Controls.MessageBox.Show("Ingrese información en los campos de texto del formulario", "Información del sistema", MessageBoxButton.OK, MessageBoxImage.Stop);
                }

            }
            catch (Exception)
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("Para poder Guardar ingrese datos en los campos correspondientes", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            _registro.Clear();
        }
        private void rbGuardar_Click(object sender, RoutedEventArgs e)
        {
            guardarCategoria();
        }

        private void rbNuevoRegistro_Click(object sender, RoutedEventArgs e)
        {
            rbGuardar.IsEnabled = true;
            rbActualizar.IsEnabled = false;
            rbEliminar.IsEnabled = false;
            txtNombre.IsEnabled = true;
            txtDescripcion.IsEnabled = true;
            dtgCategorias.IsEnabled = true;
            txtNombre.Clear();
            txtDescripcion.Clear();
          
        }
        protected void eliminarCategoria()
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar esta Categoria?", "Seguridad del Sistema", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (x == MessageBoxResult.OK)
                {
                    _registro.Eliminar(_categoriaActual);
                    Microsoft.Windows.Controls.MessageBox.Show("La Categoria: " + _categoriaActual.Nombre + " se elimino correctamente", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    Microsoft.Windows.Controls.MessageBox.Show("Execución cancelada", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                    _registro.Clear();
                }
                _misCategorias = _registro.Listar();
                dtgCategorias.ItemsSource = _misCategorias;
                rbEliminar.IsEnabled = false;
                rbActualizar.IsEnabled = false;

            }
            catch (Exception)
            {

                Microsoft.Windows.Controls.MessageBox.Show("Ocurrio una exepcion al tratar de eliminar", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            _registro.Clear();
        }
        private void rbEliminar_Click(object sender, RoutedEventArgs e)
        {
            eliminarCategoria();
        }

        private void dtgCategorias_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgCategorias.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRows(dtgCategorias);
                foreach (DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encontrar = _misCategorias.ElementAt(buscar);
                        _categoriaActual = encontrar;
                        txtNombre.Text = _categoriaActual.Nombre;
                        txtDescripcion.Text = _categoriaActual.Descripcion;

                        rbEliminar.IsEnabled = true;
                        rbActualizar.IsEnabled = true;
                        rbGuardar.IsEnabled = false;
                        break;
                    }

                }

            }
        }
        protected void actualizarCategoria()
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if(x == MessageBoxResult.Yes)
                {
                    if (_categoriaActual == null)
                    {
                        Microsoft.Windows.Controls.MessageBox.Show("No existe alguna categoría que modificar","Información del sistema",MessageBoxButton.OK, MessageBoxImage.Information);
                    }else
                    {
                        _categoriaActual.Nombre = txtNombre.Text;
                        _categoriaActual.Descripcion = txtDescripcion.Text;
                        _registro.Actualizar(_categoriaActual);
                        Microsoft.Windows.Controls.MessageBox.Show("Se actualizo correctamente la categoría", "Información del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                        rbActualizar.IsEnabled = false;
                        rbEliminar.IsEnabled = false;
                        _misCategorias = _registro.Listar();
                        dtgCategorias.ItemsSource = _misCategorias;
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        rbGuardar.IsEnabled = true;
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void rbActualizar_Click(object sender, RoutedEventArgs e)
        {
            actualizarCategoria();
        }
        // eventos keyDown de los cuales se ejecutan diferentes acciones depediendo la tecla presionada en la ventana
        // Fecha de creación: 02/12/2016
        // Creado por: Ing.Francisco Reyes Sánchez
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F5:
                    actualizarCategoria();
                    break;
                case Key.F6:
                    eliminarCategoria();
                    break;
                case Key.F4:
                    guardarCategoria();
                    break;
                
            }
            
        }
    }
}
