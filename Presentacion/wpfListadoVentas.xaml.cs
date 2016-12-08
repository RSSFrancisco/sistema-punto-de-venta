using System.Collections.Generic;
using System.Windows;
using Negocios;
using System.Windows.Controls;
using System.Collections;
using System.Linq;
namespace Presentacion
{
    /// <summary>
    /// Interaction logic for wpfListadoVentas.xaml
    /// </summary>
    public partial class wpfListadoVentas : Window
    {
        #region Instancias
        RegistroVenta _registroVenta = new RegistroVenta();
        List<Venta> misVentas = new List<Venta>();
        Venta _ventaActual = null;
        Helper _objHelper = new Helper();
        Paginas _objPagina = new Paginas();
        protected void paginador()
        {

            int numero = _objHelper.ObtenerNumeroFilas("idproducto", "producto", _objPagina.Tamanio);
            _objPagina.NumeroPaginas = numero;
            for (int i = 0; i <= numero; i++)
            {
                cmbNumeroPaginas.Items.Add("" + i + "");
            }
            cmbNumeroPaginas.SelectedIndex = 0;
        }
        protected void listarVentaActual()
        {
            misVentas = _registroVenta.Listar(_objPagina.PaginaActual,_objPagina.Tamanio);
            dtgListadoVentas.ItemsSource = misVentas;
        }
        #endregion
        public wpfListadoVentas()
        {
            InitializeComponent();
            listarVentaActual();
            paginador();
        }
        #region eventos
        private void btnBuscarVenta_Click(object sender, RoutedEventArgs e)
        {
            
                string buscar = txtBuscarVenta.Text.ToString();
                if (buscar != "")
                {
                    misVentas=_registroVenta.buscarVenta(buscar);
                    dtgListadoVentas.ItemsSource = misVentas;
                    
                }else
                {
                MessageBox.Show("Por favor ingrese información en el cuadro de busqueda del sistema","Mensaje del sistema");
                listarVentaActual();
            }
            }
        private void buscarVentaHoy(object sender, RoutedEventArgs e)
        {
            misVentas = _registroVenta.buscarVentoHoy();
            dtgListadoVentas.ItemsSource = misVentas;
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
        #endregion
     
        private void dtgListadoVentas_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(dtgListadoVentas.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRows(dtgListadoVentas);
                foreach(DataGridRow myrow in row_list)
                {
                    if (myrow.IsSelected)
                    {
                        buscar = myrow.GetIndex();
                        var encontrar = misVentas.ElementAt(buscar);
                        _ventaActual = encontrar;
                        string folioVenta = _ventaActual.IdVenta.ToString();
                        Ventas.wpfDetalleVenta detalleVenta = new Ventas.wpfDetalleVenta(folioVenta);
                        Close();
                        detalleVenta.ShowDialog();
                       

                        break;
                    }
                }
            }
        }

        private void btnPaginaSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (_objPagina.PaginaActual < _objPagina.NumeroPaginas * _objPagina.Tamanio)
            {
                _objPagina.PaginaActual += _objPagina.Tamanio;
                cmbNumeroPaginas.SelectedIndex = (_objPagina.PaginaActual / _objPagina.Tamanio);
            }
        }
        private void btnPaginaAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (_objPagina.PaginaActual > 0)
            {
                _objPagina.PaginaActual -= _objPagina.Tamanio;
                cmbNumeroPaginas.SelectedIndex = (_objPagina.PaginaActual / _objPagina.Tamanio);
            }
        }
        private void btnUltimaPagina_Click(object sender, RoutedEventArgs e)
        {
            cmbNumeroPaginas.SelectedIndex = _objPagina.NumeroPaginas;
        }

        private void btnPrimerPagina_Click(object sender, RoutedEventArgs e)
        {
            cmbNumeroPaginas.SelectedIndex = 0;
        }

        private void cmbNumeroPaginas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _objPagina.PaginaActual = int.Parse(cmbNumeroPaginas.SelectedValue.ToString()) * _objPagina.Tamanio;
            listarVentaActual();
        }

        
    }

}

