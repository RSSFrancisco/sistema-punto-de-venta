using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Negocios;
using Presentacion;
using System.Linq;
using System.Collections;
using System.Windows.Controls;
namespace Presentacion
{
    /// <summary>
    /// Interaction logic for Empresa.xaml
    /// </summary>
    public partial class Empresa : Window
    {
        #region Variables Privadas
        RegistrarEmpresa _registro = new RegistrarEmpresa();
        List<Negocios.Empresa> miEmpresa = null;
        Negocios.Empresa _EmpresaActual = null;
        #endregion
        public Empresa()
        {
            InitializeComponent();
            miEmpresa = _registro.Listar();
            dtgEmpresa.ItemsSource = miEmpresa;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _registro.Add(new Negocios.Empresa(txtrfc.Text.Trim(),txtSiglas.Text.Trim(),txtNombre.Text.Trim(),txtGiro.Text.Trim(),txtDireccion.Text.Trim(),txtColonia.Text.Trim(),txtCiudad.Text.Trim(),txtEstado.Text.Trim(),int.Parse(txtCodigoPostal.Text),txtTelefono.Text));

                _registro.Guardar();
                MessageBox.Show("Sus datos han sido guardado correctamente", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                _registro.Clear();
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
                if (_EmpresaActual != null)
                {
                    _registro.Eliminar(_EmpresaActual);
                    MessageBox.Show("El Contacto se ha eliminado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                    //bloque controles

                }
            }
            catch (Exception ex)
            {

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

        private void dtgEmpresa_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgEmpresa.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRow(dtgEmpresa);
                foreach (DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encontrar = miEmpresa.ElementAt(buscar);
                        _EmpresaActual = (Negocios.Empresa)encontrar;

                        this.txtrfc.Text = _EmpresaActual.Rfc;
                        this.txtSiglas.Text = _EmpresaActual.Siglas;
                        this.txtNombre.Text = _EmpresaActual.Nombre;
                        this.txtGiro.Text = _EmpresaActual.Giro;
                        this.txtDireccion.Text = _EmpresaActual.Direccion;
                        this.txtColonia.Text = _EmpresaActual.Colonia;
                        this.txtCiudad.Text = _EmpresaActual.Ciudad;
                        this.txtEstado.Text = _EmpresaActual.Estado;
                        //this.txtCodigoPostal.Text = _EmpresaActual.Cp;
                        this.txtTelefono.Text = _EmpresaActual.Telefono;

                        break;
                    }
                }
            }
        }       
    }
}
