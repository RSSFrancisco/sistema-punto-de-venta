#region Librerias
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
    /// Interaction logic for wpfReporteServicio.xaml
    /// </summary>
    public partial class wpfReporteServicio : Divelements.SandRibbon.RibbonWindow
        
    {
        RegistroRequisicion _registroRequisicion = new RegistroRequisicion();
        List<Requisicion> miRequisicion = null;
        List<Requisicion> miRequisicionTodo = null;
        Requisicion _requisicionActual = null;

        RegistrarEmpresa _registrarContacto = new RegistrarEmpresa();
        List<Empresa> misContactos = null;
        Empresa _contactoActual = null;

        //RegistrarProducto _registroProducto = new RegistrarProducto();
        //List<Producto> miProducto = null;
        //Producto _productoActual = null;



        public void obtenerFolio()
        {
            miRequisicionTodo = _registroRequisicion.ListarTodo();
            int contador = miRequisicionTodo.Count;
            contador++;
            txtFolio.Text = contador.ToString();
        
        }

        
        public wpfReporteServicio()
        {
            InitializeComponent();
            miRequisicion = _registroRequisicion.Listar();
            dtgReporteServicio.ItemsSource = miRequisicion;

            misContactos = _registrarContacto.Listar();
            txtCliente.ItemsSource = misContactos;
            obtenerFolio();
           

            #region combobox Servicios
            cmbServicio.Items.Add(new ComboBoxItem().Content = "MP(Mantto.Preventivo)");
            cmbServicio.Items.Add(new ComboBoxItem().Content = "MC(Mantto.Correctivo/Revisión)");
            cmbServicio.Items.Add(new ComboBoxItem().Content = "GA(Garantía)");
            cmbServicio.Items.Add(new ComboBoxItem().Content = "RD(Red)");
            cmbServicio.Items.Add(new ComboBoxItem().Content = "SO(Software)");
            cmbServicio.Items.Add(new ComboBoxItem().Content = "VP(Visita Preventiva/Varios)");

            #endregion
            #region combobox Hora de Entrada
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "01:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "02:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "03:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "04:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "05:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "06:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "07:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "08:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "09:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "10:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "11:00 AM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "12:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "01:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "02:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "03:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "04:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "05:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "06:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "07:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "08:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "09:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "10:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "11:00 PM");
            cmbHoraEntrada.Items.Add(new ComboBoxItem().Content = "12:00 AM");
            
            #endregion
            #region combobox Hora de Salida
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "01:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "02:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "03:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "04:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "05:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "06:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "07:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "08:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "09:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "10:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "11:00 AM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "12:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "01:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "02:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "03:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "04:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "05:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "06:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "07:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "08:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "09:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "10:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "11:00 PM");
            cmbHoraSalida.Items.Add(new ComboBoxItem().Content = "12:00 AM");
            #endregion
       
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
     
       
        #region Validacion de cajas de texto
        private void txtNoSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        #endregion
        private void RibbonWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar la ventana Reporte Servicio?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            finally { }
        }
        private void calcularTotal()
        {
            try
            {
                
              
                    if (string.IsNullOrEmpty(txtManoObra.Text)) return;
                    if (string.IsNullOrEmpty(txtRefacciones.Text)) return;
                    decimal miManoObra = decimal.Parse(txtManoObra.Text);
                    decimal miRefaccion = decimal.Parse(txtRefacciones.Text);
                    decimal resultado = miManoObra + miRefaccion;
                    lblTot.Text = resultado.ToString();
              

            }
            catch (Exception)
            {

                throw;
            }
        }
      
        private void txtManoObra_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                calcularTotal();
            }
            catch (Exception)
            {

                MessageBox.Show("A ocurrido una exepción al tratar de calcular el valor de este campo", "Seguridad de Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void txtRefacciones_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                calcularTotal();
            }
            catch (Exception)
            {

                MessageBox.Show("A ocurrido una exepción al tratar de calcular el valor de este campo", "Seguridad de Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void btnNuevoCliente_Click(object sender, RoutedEventArgs e)
        {
            wpfContacto contac = new wpfContacto();
            contac.ShowDialog();
        }
        string DirecionContacto = string.Empty;
        public void MostrarDireccion()

        {
            _contactoActual = (Empresa)txtCliente.SelectedItem;
            DirecionContacto = _contactoActual.Direccion;
        txtDireccion.Text = DirecionContacto;
        }
        string CiudadContacto = string.Empty;
        public void MostrarCiudad()
        {
            _contactoActual = (Empresa)txtCliente.SelectedItem;
            CiudadContacto = _contactoActual.Ciudad;
            txtCiudad.Text = CiudadContacto;
        }
        string TelefonoContacto = string.Empty;
        public void MostrarTelefono()
        {
            _contactoActual = (Empresa)txtCliente.SelectedItem;
            TelefonoContacto = _contactoActual.Telefono;
            txtTelefono.Text = TelefonoContacto;
        }
        string NombreContacto = string.Empty;

        #region Atributos por Default de Empresas
        string _rfc ="Sin Asignar";
        string _siglas = "Sin Asignar";
        string _nombre = string.Empty;
        string _giro = "Sin Asignar";
        string _direccion = string.Empty;
        string _colonia = "Sin Asignar";
        string _ciudad = string.Empty;
        string _estado = "Veracruz";
        int _cp = 0000;
        string _telefono =string.Empty;
        #endregion
        #region Atributos por default del Registro de Requisicion
        
        DateTime _fechaR = DateTime.Today;
        //string _clienteR = "Sin Especificar";
        string _direccionR ="---";
        string _ciudadR = "----";
        string _telefonoR = "S/N";
        string _empleadoR = "---";
        string _tipoServicioR ="---";
        string _horaEntradaR ="---";
        string _horaSalidaR ="---";
        string _nombreR ="---";
        string _marcaR = "---";
        string _modeloR ="---";
        string _numSerieR ="000000";
        string _condicionEquipoR ="---";
        string _fallaReportadaR ="---";
        string _reporteIngR = "---";
        string _observacionesR ="---";
        decimal _manoDeObraR =0;
        decimal _costoRefaccionR =0;
      
        #endregion
        //validacion de las cajas de texto=>(solo numeros o solo letras)
        #region Validacion De Cajas de Texto 

        #endregion
        private void rbGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                //int claveProducto = 0;
                //_productoActual = (Producto)cmbRefaccion.SelectedItem;
                //claveProducto = _productoActual.Clave;

                #region validacion de campos de texto en caso de que esten vacios
                if (dtFecha.Text == "") { dtFecha.Text = _fechaR.ToShortDateString(); }
                if (txtCliente.Text == "") { lblMCliente.Content = "*Falta"; }
                else { lblMCliente.Content = ""; }
                if (txtDireccion.Text == "") { txtDireccion.Text = _direccionR; }
                if (txtCiudad.Text == "") { txtCiudad.Text = _ciudadR; }
                if (txtTelefono.Text == "") { txtTelefono.Text = _telefonoR; }
                if (txtAtendio.Text == "") { txtAtendio.Text = _empleadoR; }
                if (cmbServicio.Text == "") { cmbServicio.Text = _tipoServicioR; }
                if (cmbHoraEntrada.Text == "") { cmbHoraEntrada.Text = _horaEntradaR; }
                if (cmbHoraSalida.Text == "") { cmbHoraSalida.Text = _horaSalidaR; }
                if (txtNombre.Text == "") { txtNombre.Text = _nombreR; }
                if (txtMarca.Text == "") { txtMarca.Text = _marcaR; }
                if (txtModelo.Text == "") { txtModelo.Text = _modeloR; }
                if (txtNoSerie.Text == "") { txtNoSerie.Text = _numSerieR; }
                if (txtCondiciones.Text == "") { txtCondiciones.Text = _condicionEquipoR; }
                if (txtFallaReportada.Text == "") { txtFallaReportada.Text = _fallaReportadaR; }
                if (txtReporteIngenieria.Text == "") { txtReporteIngenieria.Text = _reporteIngR; }
                if (txtObservaciones.Text == "") { txtObservaciones.Text = _observacionesR; }
                if (txtManoObra.Text == "") { txtManoObra.Text = _manoDeObraR.ToString(); }
                if (txtRefacciones.Text == "") { txtRefacciones.Text = _costoRefaccionR.ToString(); }
                if (txtFolio.Text == "") { MessageBox.Show("Porfavor ingrese el numero de folio","Seguridad del Sistema",MessageBoxButton.OK,MessageBoxImage.Information); }
                #endregion


                if (NombreContacto.Length == 0)
                {
                    NombreContacto = txtNuevoCliente.Text;
                }
                if (txtNuevoCliente.Text.Length == 0)
                {
                    _contactoActual = (Empresa)txtCliente.SelectedItem;
                    NombreContacto = _contactoActual.Nombre;
                }
                string entrada = string.Empty;
                string salida = string.Empty;
                if (chkEntradaEquipo.IsChecked == true)
                {
                    entrada = "X";
                }
                else
                {
                    entrada = "";
                }
                if (chkSalidaEquipo.IsChecked == true)
                {
                    salida = "X";
                }
                else
                {
                    salida = "";
                }
                string servicioDomicilio = string.Empty;
                if (rbSi.IsChecked == true)
                {
                    servicioDomicilio = "X  SI";
                }
                else
                {
                    servicioDomicilio = "";
                }
                if (rbNo.IsChecked == true)
                {
                    servicioDomicilio = "X  NO";
                }
                else
                {
                    servicioDomicilio = "";
                }

                decimal total = 0;
                total = decimal.Parse(lblTot.Text);

                decimal refaccion = 0;
                refaccion = decimal.Parse(txtRefacciones.Text);

                decimal manoDeObra = 0;
                manoDeObra = decimal.Parse(txtManoObra.Text);
                if (txtNuevoCliente.Text !="")
                {
                    _registrarContacto.Add(new Empresa(_rfc.ToUpper(), _siglas, NombreContacto, _giro, txtDireccion.Text, _colonia, txtCiudad.Text, _estado, _cp, txtTelefono.Text));

                    _registrarContacto.Guardar();
                    misContactos = _registrarContacto.Listar();
                    txtCliente.ItemsSource = misContactos;
                }
                
                    _registroRequisicion.Add(new Requisicion(txtFolio.Text,DateTime.Parse(dtFecha.Text), NombreContacto, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, txtAtendio.Text, cmbServicio.Text, entrada, salida, servicioDomicilio, cmbHoraEntrada.Text, cmbHoraSalida.Text, txtNombre.Text, txtMarca.Text, txtModelo.Text, txtNoSerie.Text, txtCondiciones.Text, txtFallaReportada.Text, txtReporteIngenieria.Text, txtObservaciones.Text, manoDeObra, refaccion, total));
                    _registroRequisicion.Guardar();

                   
                    MessageBox.Show("El Servicio se guardo con exito", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

                    //int contadorReport =dtgReporteServicio.Items.Count;
                    //contadorReport++;
                   
                    if (miRequisicion != null)
                    {
                        miRequisicion = _registroRequisicion.ListarPorTop();
                        dtgReporteServicio.ItemsSource = miRequisicion;
                        
                     
                        ReportePrincipal rep = new ReportePrincipal();
                        rep.GenerandoReporte(miRequisicion,txtFolio.Text);

                    }
                    txtNuevoCliente.Text = "";
                    dtFecha.Text = "";
                    txtCliente.Text = "";
                    txtDireccion.Text = "";
                    txtCiudad.Text = "";
                    txtTelefono.Text = "";
                    txtAtendio.Text = "";
                    cmbServicio.Text = "";
                    chkEntradaEquipo.IsChecked = false;
                    chkSalidaEquipo.IsChecked = false;
                    rbSi.IsChecked = false;
                    rbNo.IsChecked = false;
                    cmbHoraEntrada.Text = "";
                    cmbHoraSalida.Text = "";
                    txtNombre.Text = "";
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtNoSerie.Text = "";
                    txtCondiciones.Text = "";
                    txtFallaReportada.Text = "";
                    txtReporteIngenieria.Text = "";
                    txtObservaciones.Text = "";
                    //cmbRefaccion.Text = "";
                    txtManoObra.Text = "";
                    txtRefacciones.Text = "";
                    lblTot.Text = "";
                    _registrarContacto.Clear();
                    _registroRequisicion.Clear();
                    miRequisicion = _registroRequisicion.Listar();
                    dtgReporteServicio.ItemsSource = miRequisicion;
                    obtenerFolio();
                  
              
            }
            catch (Exception)
            {
                //throw new Exception(ex.Message);
                MessageBox.Show("Usted no ha llenado los campos necesarios para registrar el reporte\n Vuelva a intentarlo", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        #region boton nuevo Registro
        private void rbNuevoRegistro_Click(object sender, RoutedEventArgs e)
        {
            //menuFiltros.IsSelected = true;
            #region Habilitar
            rbNuevoRegistro.IsEnabled = true;
            rbGuardar.IsEnabled = true;
            tabRegistrar.IsSelected = true;
            dtgReporteServicio.IsEnabled = true;
            tabRegistrar.IsEnabled = true;
            tabTabla.IsEnabled = true;
            dtFecha.IsEnabled = true;
            cmbServicio.IsEnabled = true;
            chkEntradaEquipo.IsEnabled = true;
            chkSalidaEquipo.IsEnabled = true;
            rbSi.IsEnabled = true;
            rbNo.IsEnabled = true;
            cmbHoraEntrada.IsEnabled = true;
            cmbHoraSalida.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtMarca.IsEnabled = true;
            txtModelo.IsEnabled = true;
            txtNoSerie.IsEnabled = true;
            txtCondiciones.IsEnabled = true;
            txtObservaciones.IsEnabled = true;
            txtFallaReportada.IsEnabled = true;
            txtReporteIngenieria.IsEnabled = true;
            //cmbRefaccion.IsEnabled = true;
            txtManoObra.IsEnabled = true;
            txtRefacciones.IsEnabled = true;
            lblTot.IsEnabled = true;
            rbReportess.IsEnabled = true;
            obtenerFolio();
          
            #endregion
            #region Limpiar
            dtFecha.Text = "";
          
            cmbServicio.Text = "";
            chkEntradaEquipo.IsChecked = false;
            chkSalidaEquipo.IsChecked = false;
            rbSi.IsChecked = false;
            rbNo.IsChecked = false;
            cmbHoraEntrada.Text = "";
            cmbHoraSalida.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtNoSerie.Text = "";
            txtCondiciones.Text = "";
            txtFallaReportada.Text = "";
            txtReporteIngenieria.Text = "";
            txtObservaciones.Text = "";
            //cmbRefaccion.Text = "";
            txtManoObra.Text = "";
            txtRefacciones.Text = "";
            lblTot.Text = "";
            txtCliente.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtAtendio.Text = "";
            txtNuevoCliente.IsEnabled = true;
            txtNuevoCliente.Text = "";
            txtCliente.Text = "";
            #endregion
            
        }
        #endregion
        #region funcion privada que instancia el reporte para la lista de requisiciones
        private void rbReportess_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string nombreReport = txtNombreReporte.Text;
                ReportePersonalizado reportPrincipal = new ReportePersonalizado();
                reportPrincipal.GenerandoReporte(miRequisicion,txtNombreReporte.Text);
                obtenerFolio();
            }

            catch
            {
                MessageBox.Show("A ocurrido una exepción al tratar de efectuar esta acción", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            
        }
        #endregion
        #region funciones del datagrid y el boton de eliminar
        private void dtgReporteServicio_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            try
            {
                
                if (dtgReporteServicio.Items.Count > 0)
                {
                    int buscar =0;
                    var fila_lista = GetDataGridRows(dtgReporteServicio);
                    foreach (DataGridRow miFila in fila_lista)
                    {
                        if (miFila.IsSelected)
                        {

                            buscar = miFila.GetIndex();
                            var encontrar = miRequisicion.ElementAt(buscar);
                            _requisicionActual = (Requisicion)encontrar;
                            //modificado Por: Ing. Francisco Reyes Sanchez
                            //Cuestion de cambio: Mostrar el Cliente que se seleciono del DataGrid
                            //fecha:El dia Viernes del 26 de Julio del 2013

                            //var encontrarC = misContactos.ElementAt(buscar);
                            //_contactoActual = (Empresa)encontrarC;

                            //this.txtCliente.Text = _contactoActual.Nombre.ToString();

                            this.dtFecha.Text = _requisicionActual.Fecha.ToShortDateString();
                        
                            this.cmbServicio.Text = _requisicionActual.TipoServicio.ToString();
                            this.cmbHoraEntrada.Text = _requisicionActual.HoraEntrada;
                            this.cmbHoraSalida.Text = _requisicionActual.HoraSalida;

                            /*
                            variables para validar la entrada o salida de equipo
                           */
                            string entradaEquipo = string.Empty;
                            string salidaEquipo = string.Empty;
                            entradaEquipo = _requisicionActual.Entrada;
                            salidaEquipo = _requisicionActual.Salida;
                            /*
                             * variables para validar el servicio a domicilio
                            */
                            string servicioADomicilioSI = string.Empty;
                            string servicioADomicilioNO = string.Empty;
                            servicioADomicilioSI = _requisicionActual.ServicioADomicilio;
                            servicioADomicilioNO = _requisicionActual.ServicioADomicilio;
                            this.txtFolio.Text = _requisicionActual.TotalFilas;
                            this.txtDireccion.Text = _requisicionActual.Direccion;
                            this.txtCiudad.Text = _requisicionActual.Ciudad;
                            this.txtTelefono.Text = _requisicionActual.Telefono;
                            this.txtAtendio.Text = _requisicionActual.Empleado;
                            this.txtNombre.Text = _requisicionActual.Nombre;
                            this.txtMarca.Text = _requisicionActual.Marca;
                            this.txtModelo.Text = _requisicionActual.Modelo;
                            this.txtNoSerie.Text = _requisicionActual.NumSerie;
                            this.txtCondiciones.Text = _requisicionActual.CondicionEquipo;
                            this.txtFallaReportada.Text = _requisicionActual.FallaReportada;
                            this.txtReporteIngenieria.Text = _requisicionActual.ReporteIng;
                            this.txtObservaciones.Text = _requisicionActual.Observaciones;
                            this.txtManoObra.Text = _requisicionActual.ManoDeObra.ToString();
                            this.txtRefacciones.Text = _requisicionActual.CostoRefaccion.ToString();
                            this.lblTot.Text = _requisicionActual.Total.ToString();
                            //Modificado Por: Ing. Francisco Reyes Sánchez
                            //fecha:El dia Viernes del 26 de Julio del 2013
                            txtNuevoCliente.IsEnabled = false;
                            rbNuevoRegistro.IsEnabled = false;
                            rbGuardar.IsEnabled = false;
                            rbActualizar.IsEnabled = true;
                            rbeliminar.IsEnabled = true;

                            foreach (Empresa emp in misContactos)
                            {
                                if (emp.Nombre ==_requisicionActual.Cliente)
                                {
                                    this.txtCliente.SelectedItem = emp;
                                }

                            }
                            if (entradaEquipo == "X")
                            {
                                this.chkEntradaEquipo.IsChecked = true;
                            }
                            else
                            {
                                this.chkEntradaEquipo.IsChecked = false;
                            }

                            if (salidaEquipo == "X")
                            {

                                this.chkSalidaEquipo.IsChecked = true;
                            }
                            else
                            {
                                this.chkSalidaEquipo.IsChecked = false;
                            }

                            if (servicioADomicilioSI == "X  SI")
                            {
                                this.rbSi.IsChecked = true;

                            }
                            else
                            {
                                this.rbSi.IsChecked = false;
                            }
                            if (servicioADomicilioNO == "X  NO")
                            {
                                this.rbNo.IsChecked = true;

                            }
                            else
                            {
                                this.rbNo.IsChecked = false;
                            }
                          
                         
                        
                                MessageBox.Show("Se seleciono el registro con el numero de folio" + _requisicionActual.TotalFilas, "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                               break;

                            }
                        
                          

                        }
                    }
                }
         
            catch (Exception)
            {

                MessageBox.Show("A ocurrido una exepción al tratar de efectuar esta acción", "Seguridad del Sistema",MessageBoxButton.OK,MessageBoxImage.Information);

            }




        }

        private void rbeliminar_Click(object sender, RoutedEventArgs e)//evento click del boton eliminar 
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar este Reporte de servicios?", "Seguridad del Sistema", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (x == MessageBoxResult.Yes)
                {
                    _registroRequisicion.Eliminar(_requisicionActual);
                    btnMensaje.Content = "El registro con Folio numero: " + _requisicionActual.Folio + " Se elmino exitosamente";
                    Microsoft.Windows.Controls.MessageBox.Show("El registro con Folio numero: " + _requisicionActual.TotalFilas + " se elimino exitosamente", "Seguridad dek Sistema", MessageBoxButton.OK, MessageBoxImage.Information);


                }
                else
                {
                    btnMensaje.Content = "Execución Cancelada";
                    Microsoft.Windows.Controls.MessageBox.Show("Execución Cancelada", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                miRequisicion = _registroRequisicion.Listar();
                dtgReporteServicio.ItemsSource=miRequisicion;
                lblTotal.Content="Total: "+dtgReporteServicio.Items.Count.ToString();

            }
            catch (Exception)
            {

                btnMensaje.Content = "Ha ocurrido una excepción vuelva a intentarlo";
            }
            dtFecha.Text = "";

            dtFecha.Text = "";
            txtCliente.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtAtendio.Text = "";
            cmbServicio.Text = "";
            chkEntradaEquipo.IsChecked = false;
            chkSalidaEquipo.IsChecked = false;
            rbSi.IsChecked = false;
            rbNo.IsChecked = false;
            cmbHoraEntrada.Text = "";
            cmbHoraSalida.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtNoSerie.Text = "";
            txtCondiciones.Text = "";
            txtFallaReportada.Text = "";
            txtReporteIngenieria.Text = "";
            txtObservaciones.Text = "";
            //cmbRefaccion.Text = "";
            txtManoObra.Text = "";
            txtRefacciones.Text = "";
            lblTot.Text = "";
            _registroRequisicion.Clear();
            obtenerFolio();
          
        }
        #endregion
        /*se debe de modificar esta funcion -- ya que no actualiza el cliente que se selecciona */
        /*nota: solo se debe de copiar las condiciones que se inplementaron en el evento click del boton Guardar*/
        private void rbActualizar_Click(object sender, RoutedEventArgs e)//evento click del boton actualizar
        {
            try
            {
                  MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                  if (x == MessageBoxResult.Yes)
                      if (_requisicionActual == null)
                      {


                          if (txtFolio.Text == "") { MessageBox.Show("Favor de Ingresar el numero de folio","Seguridad del Sistema",MessageBoxButton.OK,MessageBoxImage.Information); }
                         
                          string entrada = string.Empty;
                          string salida = string.Empty;
                          if (chkEntradaEquipo.IsChecked == true)
                          {
                              entrada = "X";
                          }
                          else
                          {
                              entrada = "";
                          }
                          if (chkSalidaEquipo.IsChecked == true)
                          {
                              salida = "X";
                          }
                          else
                          {
                              salida = "";
                          }
                          string servicioDomicilio = string.Empty;
                          if (rbSi.IsChecked == true)
                          {
                              servicioDomicilio = "X  SI";
                          }
                          else
                          {
                              servicioDomicilio = "";
                          }
                          if (rbNo.IsChecked == true)
                          {
                              servicioDomicilio = "X  NO";
                          }
                          else
                          {
                              servicioDomicilio = "";
                          }

                          decimal total = 0;
                          total = decimal.Parse(lblTot.Text);

                          decimal refaccion = 0;
                          refaccion = decimal.Parse(txtRefacciones.Text);

                          decimal manoDeObra = 0;
                          manoDeObra = decimal.Parse(txtManoObra.Text);

                          _registroRequisicion.Add(new Requisicion(txtFolio.Text,DateTime.Parse(dtFecha.Text), NombreContacto, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, txtAtendio.Text, cmbServicio.Text, entrada, salida, servicioDomicilio, cmbHoraEntrada.Text, cmbHoraSalida.Text, txtNombre.Text, txtMarca.Text, txtModelo.Text, txtNoSerie.Text, txtCondiciones.Text, txtFallaReportada.Text, txtReporteIngenieria.Text, txtObservaciones.Text, manoDeObra, refaccion, total));


                      }
                      else
                      {
                          string entrada = string.Empty;
                          string salida = string.Empty;
                          if (chkEntradaEquipo.IsChecked == true)
                          {
                              entrada = "X";
                          }
                          else
                          {
                              entrada = "";
                          }
                          if (chkSalidaEquipo.IsChecked == true)
                          {
                              salida = "X";
                          }
                          else
                          {
                              salida = "";
                          }
                          string servicioDomicilio = string.Empty;
                          if (rbSi.IsChecked == true)
                          {
                              servicioDomicilio = "X  SI";
                          }

                          if (rbNo.IsChecked == true)
                          {
                              servicioDomicilio = "X  NO";
                          }

                          decimal total = 0;
                          total = decimal.Parse(lblTot.Text);

                          decimal refaccion = 0;
                          refaccion = decimal.Parse(txtRefacciones.Text);

                          decimal manoDeObra = 0;
                          manoDeObra = decimal.Parse(txtManoObra.Text);

                          _contactoActual = (Empresa)txtCliente.SelectedItem;
                          NombreContacto = _contactoActual.Nombre;
                          _requisicionActual.TotalFilas = txtFolio.Text;
                          _requisicionActual.Fecha = DateTime.Parse(dtFecha.Text);
                          _requisicionActual.Cliente =NombreContacto;
                          _requisicionActual.Direccion = txtDireccion.Text;
                          _requisicionActual.Ciudad = txtCiudad.Text;
                          _requisicionActual.Telefono = txtTelefono.Text;
                          _requisicionActual.Empleado = txtAtendio.Text;
                          _requisicionActual.TipoServicio = cmbServicio.Text;
                          _requisicionActual.Entrada = entrada;
                          _requisicionActual.Salida = salida;
                          _requisicionActual.ServicioADomicilio = servicioDomicilio;
                          _requisicionActual.HoraEntrada = cmbHoraEntrada.Text;
                          _requisicionActual.HoraSalida = cmbHoraSalida.Text;
                          _requisicionActual.Nombre = txtNombre.Text;
                          _requisicionActual.Marca = txtMarca.Text;
                          _requisicionActual.Modelo = txtModelo.Text;
                          _requisicionActual.NumSerie = txtNoSerie.Text;
                          _requisicionActual.CondicionEquipo = txtCondiciones.Text;
                          _requisicionActual.FallaReportada = txtFallaReportada.Text;
                          _requisicionActual.ReporteIng = txtReporteIngenieria.Text;
                          _requisicionActual.Observaciones = txtObservaciones.Text;
                          _requisicionActual.ManoDeObra =decimal.Parse(txtManoObra.Text);
                          _requisicionActual.CostoRefaccion =decimal.Parse(txtRefacciones.Text);
                          _requisicionActual.Total = decimal.Parse(lblTot.Text);
                          _registroRequisicion.Actualizar(_requisicionActual);
                          btnMensaje.Content="El registro con folio: "+_requisicionActual.TotalFilas +" Ha sido Modificado Exitosamente";


                      }
                  else
                  {
                      btnMensaje.Content = "Execución Cancelada";
                      MessageBox.Show("Execución Cancelada", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                  }
                  miRequisicion = _registroRequisicion.Listar();
                  dtgReporteServicio.ItemsSource = miRequisicion;
                  lblTotal.Content = "Total: " + dtgReporteServicio.Items.Count.ToString();

                  dtFecha.Text = "";

                  dtFecha.Text = "";
                  txtCliente.Text = "";
                  txtDireccion.Text = "";
                  txtCiudad.Text = "";
                  txtTelefono.Text = "";
                  txtAtendio.Text = "";
                  cmbServicio.Text = "";
                  chkEntradaEquipo.IsChecked = false;
                  chkSalidaEquipo.IsChecked = false;
                  rbSi.IsChecked = false;
                  rbNo.IsChecked = false;
                  cmbHoraEntrada.Text = "";
                  cmbHoraSalida.Text = "";
                  txtNombre.Text = "";
                  txtMarca.Text = "";
                  txtModelo.Text = "";
                  txtNoSerie.Text = "";
                  txtCondiciones.Text = "";
                  txtFallaReportada.Text = "";
                  txtReporteIngenieria.Text = "";
                  txtObservaciones.Text = "";
                  //cmbRefaccion.Text = "";
                  txtManoObra.Text = "";
                  txtRefacciones.Text = "";
                  lblTot.Text = "";
                  txtNuevoCliente.IsEnabled = true;
                  _registroRequisicion.Clear();
                  obtenerFolio();

            }
            catch (Exception)
            {

                btnMensaje.Content = "A ocurrido una Exepción al tratar de modificar este registro  porfavor vuelva a intentarlo mas tarde ";
            }
        }

        private void txtCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
               
            
                
                    MostrarDireccion();
                    MostrarCiudad();
                    MostrarTelefono();
                    txtNuevoCliente.Text = "";
                   
                
            }
            catch
            {
                //MessageBox.Show("No hay Clientes Registrados");
              
            }
        }

  

        private void rbFiltrAscendente_Click(object sender, RoutedEventArgs e)//evento del boton de filtros de forma ascendente
        {
            try
            {
                miRequisicion = _registroRequisicion.ListarAscendente();
                dtgReporteServicio.ItemsSource = miRequisicion;


                if (miRequisicion == null)
                {
                    miRequisicion = _registroRequisicion.Listar();
                    dtgReporteServicio.ItemsSource = miRequisicion;
                }
            }
            catch (Exception ex)
            {

                btnMensaje.Content = ex.Message;
            }
          
        }

        private void txtNuevoCliente_TextChanged(object sender, TextChangedEventArgs e)//evento de tipo text change para el campo txtNuevoCliente
        {
            try
            {
                if (txtNuevoCliente.Text != "")
                {
              
                    txtCliente.Text = "";
                    txtDireccion.Text = "";
                    txtCiudad.Text = "";
                    txtTelefono.Text = "";
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("A ocurrido una exepción al tratar de efectuar esta acción", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void rbDescendente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                miRequisicion = _registroRequisicion.ListarDescendente();
                dtgReporteServicio.ItemsSource = miRequisicion;


                if (miRequisicion == null)
                {
                    miRequisicion = _registroRequisicion.Listar();
                    dtgReporteServicio.ItemsSource = miRequisicion;
                }
            }
            catch (Exception ex)
            {

                btnMensaje.Content = ex.Message;
            }
        }

        private void rbCancelar_Click(object sender, RoutedEventArgs e)
        {
            //menuFiltros.IsSelected = true;
            #region Habilitar
            rbNuevoRegistro.IsEnabled = true;
            rbGuardar.IsEnabled = true;
            rbeliminar.IsEnabled = false;
            rbActualizar.IsEnabled = false;
            tabRegistrar.IsSelected = true;
            dtgReporteServicio.IsEnabled = true;
            tabRegistrar.IsEnabled = true;
            tabTabla.IsEnabled = true;
            dtFecha.IsEnabled = true;
            cmbServicio.IsEnabled = true;
            chkEntradaEquipo.IsEnabled = true;
            chkSalidaEquipo.IsEnabled = true;
            rbSi.IsEnabled = true;
            rbNo.IsEnabled = true;
            cmbHoraEntrada.IsEnabled = true;
            cmbHoraSalida.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtMarca.IsEnabled = true;
            txtModelo.IsEnabled = true;
            txtNoSerie.IsEnabled = true;
            txtCondiciones.IsEnabled = true;
            txtObservaciones.IsEnabled = true;
            txtFallaReportada.IsEnabled = true;
            txtReporteIngenieria.IsEnabled = true;
            //cmbRefaccion.IsEnabled = true;
            txtManoObra.IsEnabled = true;
            txtRefacciones.IsEnabled = true;
            lblTot.IsEnabled = true;
            rbReportess.IsEnabled = true;
            obtenerFolio();
            #endregion
            #region Limpiar
            dtFecha.Text = "";

            cmbServicio.Text = "";
            chkEntradaEquipo.IsChecked = false;
            chkSalidaEquipo.IsChecked = false;
            rbSi.IsChecked = false;
            rbNo.IsChecked = false;
            cmbHoraEntrada.Text = "";
            cmbHoraSalida.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtNoSerie.Text = "";
            txtCondiciones.Text = "";
            txtFallaReportada.Text = "";
            txtReporteIngenieria.Text = "";
            txtObservaciones.Text = "";
            //cmbRefaccion.Text = "";
            txtManoObra.Text = "";
            txtRefacciones.Text = "";
            lblTot.Text = "";
            txtCliente.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtAtendio.Text = "";
            txtNuevoCliente.IsEnabled = true;
            txtNuevoCliente.Text = "";
            txtCliente.Text = "";
            #endregion
            
        }
        /// <summary>
        /// validacion de el campo de texto txtTelefono
        /// para que solo acepte numeros enteros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               //manda vacio a la propiedad de la etiqueta lblMNumControl
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }

            catch
            {

            }
        }

        private void txtManoObra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //manda vacio a la propiedad de la etiqueta lblMNumControl
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }

            catch
            {

            }
        }

        private void txtRefacciones_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //manda vacio a la propiedad de la etiqueta lblMNumControl
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }

            catch
            {

            }
        }

        private void rbAntiguos_Click(object sender, RoutedEventArgs e)//listar antiguos de la lista de registros 
        {
            try
            {
                miRequisicion = _registroRequisicion.ListarAntiguos();
                dtgReporteServicio.ItemsSource = miRequisicion;
                
            }
            catch (Exception)
            {
                
          
            }
           
        }

        private void rbRecientes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                miRequisicion=_registroRequisicion.ListarRecientes();
                dtgReporteServicio.ItemsSource = miRequisicion;
            }
            catch (Exception)
            {
                
   
            }
        }

        private void rbEliminado_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                miRequisicion=_registroRequisicion.ListarEliminados();
                dtgReporteServicio.ItemsSource = miRequisicion;
            }
            catch (Exception)
            {
                
             
            }
        }

        private void txtBuscarPorCliente_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string clienteListado = txtBuscarPorCliente.Text;
                miRequisicion = _registroRequisicion.ListarPorCliente(clienteListado);
                dtgReporteServicio.ItemsSource = miRequisicion;
            }
            catch (Exception)
            {
                
        
            }
        }

        private void rbBuscarPorCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string clienteListado = txtBuscarPorCliente.Text;
                miRequisicion = _registroRequisicion.ListarPorCliente(clienteListado);
                dtgReporteServicio.ItemsSource = miRequisicion;
            }
            catch (Exception)
            {
                
               
            }
        }

        private void rbInformacion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfInformacion info = new wpfInformacion();
                info.ShowDialog();
            }
            catch (Exception)
            {
                
          
            }
        }

        private void txtBuscarPorEmpleado_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string clienteListado = txtBuscarPorEmpleado.Text;
                miRequisicion = _registroRequisicion.ListarPorEmpleado(clienteListado);
                dtgReporteServicio.ItemsSource = miRequisicion;
            }
            catch (Exception)
            {

              
            }
        }

        private void MenuItem1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfManualTecnico manua = new wpfManualTecnico();
                manua.ShowDialog();
            }
            catch (Exception)
            {
                
                
            }
        }

        private void rbBorrarPermanente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea Eliminar Permanentemente este Reporte de servicios?", "Seguridad del Sistema", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (x == MessageBoxResult.Yes)
                {
                    _registroRequisicion.BorrarPermanente(_requisicionActual);
                    btnMensaje.Content = "El registro con Folio numero: " + _requisicionActual.Folio + " Se elmino exitosamente";
                    Microsoft.Windows.Controls.MessageBox.Show("El registro con Folio numero: " + _requisicionActual.TotalFilas + " se elimino exitosamente", "Seguridad dek Sistema", MessageBoxButton.OK, MessageBoxImage.Information);


                }
                else
                {
                    btnMensaje.Content = "Execución Cancelada";
                    Microsoft.Windows.Controls.MessageBox.Show("Execución Cancelada", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                miRequisicion = _registroRequisicion.Listar();
                dtgReporteServicio.ItemsSource = miRequisicion;
                lblTotal.Content = "Total: " + dtgReporteServicio.Items.Count.ToString();

            }
            catch (Exception)
            {

                btnMensaje.Content = "Ha ocurrido una excepción vuelva a intentarlo";
            }
            dtFecha.Text = "";

            dtFecha.Text = "";
            txtCliente.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtAtendio.Text = "";
            cmbServicio.Text = "";
            chkEntradaEquipo.IsChecked = false;
            chkSalidaEquipo.IsChecked = false;
            rbSi.IsChecked = false;
            rbNo.IsChecked = false;
            cmbHoraEntrada.Text = "";
            cmbHoraSalida.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtNoSerie.Text = "";
            txtCondiciones.Text = "";
            txtFallaReportada.Text = "";
            txtReporteIngenieria.Text = "";
            txtObservaciones.Text = "";
            //cmbRefaccion.Text = "";
            txtManoObra.Text = "";
            txtRefacciones.Text = "";
            lblTot.Text = "";
            _registroRequisicion.Clear();
            obtenerFolio();
        }

        private void rbLimpiarPapelera_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea Limpiar la papelera de registros de la ventana Reporte de servicios?", "Seguridad del Sistema", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (x == MessageBoxResult.Yes)
                {
                    _registroRequisicion.LimpiarPapelera(_requisicionActual);
                    btnMensaje.Content = "La papelera de reciclaje ha sido limpiada exitosamente";
                    Microsoft.Windows.Controls.MessageBox.Show("La papelera de reciclaje ha sido limpiada exitosamente", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);


                }
                else
                {
                    btnMensaje.Content = "Execución Cancelada";
                    Microsoft.Windows.Controls.MessageBox.Show("Execución Cancelada", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                miRequisicion = _registroRequisicion.Listar();
                dtgReporteServicio.ItemsSource = miRequisicion;
                lblTotal.Content = "Total: " + dtgReporteServicio.Items.Count.ToString();

            }
            catch (Exception)
            {

                btnMensaje.Content = "Ha ocurrido una excepción vuelva a intentarlo";
            }
            dtFecha.Text = "";

            dtFecha.Text = "";
            txtCliente.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtAtendio.Text = "";
            cmbServicio.Text = "";
            chkEntradaEquipo.IsChecked = false;
            chkSalidaEquipo.IsChecked = false;
            rbSi.IsChecked = false;
            rbNo.IsChecked = false;
            cmbHoraEntrada.Text = "";
            cmbHoraSalida.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtNoSerie.Text = "";
            txtCondiciones.Text = "";
            txtFallaReportada.Text = "";
            txtReporteIngenieria.Text = "";
            txtObservaciones.Text = "";
            //cmbRefaccion.Text = "";
            txtManoObra.Text = "";
            txtRefacciones.Text = "";
            lblTot.Text = "";
            _registroRequisicion.Clear();
            obtenerFolio();
        }

        


    }
}
