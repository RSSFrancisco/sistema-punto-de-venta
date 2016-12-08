using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Negocios;
using System.Collections;

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for wpfHistorial.xaml
    /// </summary>
    public partial class wpfHistorial : Window
    {
        RegistrarHistorial _registroHistorial = new RegistrarHistorial();
        List<Historial> miHistorial = null;
        Helper _objHelper = new Helper();
        Paginas _objPagina =new Paginas();
        protected void paginador()
        {
           
            int numero = _objHelper.ObtenerNumeroFilas("idHistorial", "bitacora",_objPagina.Tamanio);
            _objPagina.NumeroPaginas = numero;
                for (int i = 0; i <= numero; i++)
                {
                    cmbNumeroPaginas.Items.Add("" + i + "");
                }
           cmbNumeroPaginas.SelectedIndex = 0;
          }
        protected void listarHistorial()
        {
            miHistorial = _registroHistorial.Listar(_objPagina.PaginaActual, _objPagina.Tamanio);
            dtgHistorial.ItemsSource = miHistorial;
        }
        public wpfHistorial()
        {
            InitializeComponent();
            listarHistorial();
            paginador();
          
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

        private void cmbNumeroPaginas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _objPagina.PaginaActual =int.Parse(cmbNumeroPaginas.SelectedValue.ToString()) * _objPagina.Tamanio;
            listarHistorial();


        }

        private void rbUltimasModificaciones_Click(object sender, RoutedEventArgs e)
        {
            _objPagina.PaginaActual = 0;
            listarHistorial();
        }
        private void btnPaginaSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (_objPagina.PaginaActual < _objPagina.NumeroPaginas * _objPagina.Tamanio)
            {
                _objPagina.PaginaActual += _objPagina.Tamanio;
                cmbNumeroPaginas.SelectedIndex =( _objPagina.PaginaActual /_objPagina.Tamanio);
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

       
    }
}
