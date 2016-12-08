#region Regiones
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
    /// Interaction logic for wpfEmpleado.xaml
    /// </summary>
    public partial class wpfEmpleado : Divelements.SandRibbon.RibbonWindow
    {
        #region Atributos

        RegistroEmpleado _registroEmpleado = new RegistroEmpleado();
        List<Empleado> misEmpleados = null;
        Empleado _EmpleadoActual = null;
      
        #endregion
        public wpfEmpleado()
        {
            InitializeComponent();


            #region Estados
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Aguascalientes");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Baja California");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Campeche");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Coahuila");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Colima");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Chiapas");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Chihuahua");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Distrito Federal");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Durango");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Guanajuato");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Guerrero");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Hidalgo");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Jalisco");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "México");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Michoacán");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Morelos");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Nayarit");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Nuevo León");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Oaxaca");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Puebla");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Querétaro");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Quintana Roo");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "San Luis Potosí");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Sinaloa");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Sonora");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Tabasco");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Tamaulipas");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Tlaxcala");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Veracruz");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Yucatán");
            cmbEstado.Items.Add(new ComboBoxItem().Content = "Zacatecas");
            #endregion
            #region Escolaridad
            cmbNivelescolar.Items.Add(new ComboBoxItem().Content = "Primaria");
            cmbNivelescolar.Items.Add(new ComboBoxItem().Content = "Secundaria");
            cmbNivelescolar.Items.Add(new ComboBoxItem().Content = "Bachillerato");
            cmbNivelescolar.Items.Add(new ComboBoxItem().Content = "TSU");
            cmbNivelescolar.Items.Add(new ComboBoxItem().Content = "Pasante");
            cmbNivelescolar.Items.Add(new ComboBoxItem().Content = "Licenciatura");
            cmbNivelescolar.Items.Add(new ComboBoxItem().Content = "Ingeniería");
            cmbNivelescolar.Items.Add(new ComboBoxItem().Content = "Maestría");




            #endregion
            #region Metodos Privados

            misEmpleados = _registroEmpleado.Listar();
            dtgEmpleado.ItemsSource = misEmpleados;
            lblTotal.Content = "Total: " + dtgEmpleado.Items.Count.ToString();


        }

        /// <summary>
        /// evento que guarda los registros que se insertan el las cajas de texto de la ventana Empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                    
                    if (dtfecha.Text != DateTime.Now.ToShortDateString())
                      

                    {
                        _registroEmpleado.Add(new Empleado(txtnombre.Text, txtapellidoPaterno.Text, txtapellidomaterno.Text, txtnoAfiliacion.Text, DateTime.Parse(dtfecha.Text), txtdirección.Text, txtcolonia.Text, txtCiudad.Text, cmbEstado.Text.Trim(), int.Parse(txtCp.Text), txtTelefono.Text, txtCorreo.Text, cmbNivelescolar.Text, txtEspecialidad.Text));
                        _registroEmpleado.Guardar();
                        btnMensaje.Content = "El contacto se guardo correctamente";

                        misEmpleados = _registroEmpleado.Listar();
                        dtgEmpleado.ItemsSource = misEmpleados;
                        lblTotal.Content = "Total: " + dtgEmpleado.Items.Count.ToString();
                        txtapellidomaterno.Text = "";
                        txtapellidoPaterno.Text = "";
                        txtCiudad.Text = "";
                        txtcolonia.Text = "";
                        txtCorreo.Text = "";
                        txtCp.Text = "";
                        txtdirección.Text = "";
                        txtEspecialidad.Text = "";
                        cmbEstado.SelectedIndex = -1;
                        txtnoAfiliacion.Text = "";
                        txtnombre.Text = "";
                        txtTelefono.Text = "";
                        cmbNivelescolar.SelectedIndex = -1;
                        dtfecha.Text = "";

                    }
                    else
                    {
                       Microsoft.Windows.Controls.MessageBox.Show("La fecha de nacimiento "+dtfecha.Text+" no es valida\n Vuelve a intentarlo","Seguridad del sistema",MessageBoxButton.OK,MessageBoxImage.Stop);
                        dtfecha.Text = "";
                    }

             

               

            }


            catch (Exception)
            {

                btnMensaje.Content = "Es necesario que inserte su informacion completa en los campos de texto";
                Microsoft.Windows.Controls.MessageBox.Show("Es necesario que inserte su informaciòn completa en los campos de texto","Seguridad del sistema",MessageBoxButton.OK,MessageBoxImage.Stop);

            }



            _registroEmpleado.Clear();
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
        /// <summary>
        /// evento encargado de eliminar los registros seleccionados en el datagrid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibbonButton_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar el proveedor?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                {


                    _registroEmpleado.Eliminar(_EmpleadoActual);
                    btnMensaje.Content = "El proveedor: " + _EmpleadoActual.Nombre + " se elimino correctamente";

                }
                else
                {
                    btnMensaje.Content = "Execución cancelada";
                }
                misEmpleados = _registroEmpleado.Listar();
                dtgEmpleado.ItemsSource = misEmpleados;
                lblTotal.Content = "Total: " + dtgEmpleado.Items.Count.ToString();
                rbeliminar.IsEnabled = false;

                rbActualizar.IsEnabled = false;
                rbNuevoRegistro.IsEnabled = true;




            }

            catch (Exception)
            {
                btnMensaje.Content = "Ha ocurrido una excepción vuelva a intentarlo";
            }
            txtapellidomaterno.Text = "";
            txtapellidoPaterno.Text = "";
            txtCiudad.Text = "";
            txtcolonia.Text = "";
            txtCorreo.Text = "";
            txtCp.Text = "";
            txtdirección.Text = "";
            txtEspecialidad.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtnoAfiliacion.Text = "";
            txtnombre.Text = "";
            txtTelefono.Text = "";
            cmbNivelescolar.SelectedIndex = -1;
            dtfecha.Text = "";
            _registroEmpleado.Clear();

        }


        /// <summary>
        /// evento que selecciona los registros que se encuentran el la base de datos que estan contenidos dentro de un datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgEmpleado_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dtgEmpleado.Items.Count > 0)
            {
                int buscar = 0;
                var row_list = GetDataGridRows(dtgEmpleado);
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
                        this.cmbEstado.Text = _EmpleadoActual.Estado;
                        this.txtCp.Text = _EmpleadoActual.CP.ToString();
                        this.txtTelefono.Text = _EmpleadoActual.Telefono;
                        this.txtCorreo.Text = _EmpleadoActual.Correo;
                        this.cmbNivelescolar.Text = _EmpleadoActual.NivelEscolar;
                        this.txtEspecialidad.Text = _EmpleadoActual.Especialidad;


                        menuRegistro.IsSelected = true;
                        rbeliminar.IsEnabled = true;
                        rbActualizar.IsEnabled = true;
                        rbGuardar.IsEnabled = false;
                        rbNuevoRegistro.IsEnabled = false;
                        rbCancelar.IsEnabled = true;
                        

                        break;
                    }
                }
            }
        }

        private void RibbonButton_Click_2(object sender, RoutedEventArgs e)
        {
            
                string nombreReport = txtNombreReporte.Text;
                if (nombreReport != "")
                {
                    ReporteEmpleado report = new ReporteEmpleado();
                    report.Generando(misEmpleados, nombreReport);
                }
                else
                {
                    MessageBox.Show("Ingresa el nombre que le quieres asignar a tu reporte", "Seguridad del Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            
            
            //string nombre = txtnombre.Text;
            //Reporteador rep = new Reporteador();
            //rep.generar(nombre,misEmpleados);
            //Reporteador re = new Reporteador();
            //re.generar(misEmpleados);
        }
        /// <summary>
        /// evento para modificar  los registros de la clase Empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibbonButton_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.Yes)
                    if (_EmpleadoActual == null)
                    {
                        _registroEmpleado.Add(new Empleado(txtnombre.Text, txtapellidoPaterno.Text, txtapellidomaterno.Text, txtnoAfiliacion.Text, DateTime.Parse(dtfecha.Text), txtdirección.Text, txtcolonia.Text, txtCiudad.Text, cmbEstado.Text, int.Parse(txtCp.Text), txtTelefono.Text, txtCorreo.Text, cmbNivelescolar.Text, txtEspecialidad.Text));
                    }
                    else
                    {

                        _EmpleadoActual.Nombre = txtnombre.Text;
                        _EmpleadoActual.ApPaterno = txtapellidoPaterno.Text;
                        _EmpleadoActual.ApMaterno = txtapellidomaterno.Text;
                        _EmpleadoActual.NSS = txtnoAfiliacion.Text;
                        _EmpleadoActual.FechaNacimiento = DateTime.Parse(dtfecha.Text);
                        _EmpleadoActual.Direccion = txtdirección.Text;
                        _EmpleadoActual.Colonia = txtcolonia.Text;
                        _EmpleadoActual.Ciudad = txtCiudad.Text;
                        _EmpleadoActual.Estado = cmbEstado.Text;
                        _EmpleadoActual.CP = int.Parse(txtCp.Text);
                        _EmpleadoActual.Telefono = txtTelefono.Text;
                        _EmpleadoActual.Correo = txtCorreo.Text;
                        _EmpleadoActual.NivelEscolar = cmbNivelescolar.Text;
                        _EmpleadoActual.Especialidad = txtEspecialidad.Text;
                        _registroEmpleado.Actualizar(_EmpleadoActual);
                        btnMensaje.Content = "El empleado: " + _EmpleadoActual.Nombre + " ha sido actualizado correctamente";
                    }
                else
                {

                    btnMensaje.Content = "Ejecución cancelada";
                }

                misEmpleados = _registroEmpleado.Listar();
                dtgEmpleado.ItemsSource = misEmpleados;
                lblTotal.Content = "Total: " + dtgEmpleado.Items.Count.ToString();
                rbeliminar.IsEnabled = false;
                rbActualizar.IsEnabled = false;
                rbNuevoRegistro.IsEnabled = true;


            }
            catch (Exception)
            {

            }
            txtapellidomaterno.Text = "";
            txtapellidoPaterno.Text = "";
            txtCiudad.Text = "";
            txtcolonia.Text = "";
            txtCorreo.Text = "";
            txtCp.Text = "";
            txtdirección.Text = "";
            txtEspecialidad.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtnoAfiliacion.Text = "";
            txtnombre.Text = "";
            txtTelefono.Text = "";
            cmbNivelescolar.SelectedIndex = -1;
            dtfecha.Text = "";
            _registroEmpleado.Clear();
        }


            #endregion
        #region Validacion de ventana
        /// <summary>
        /// Este evento es el encargado de validar el cierre de la ventana wpfEmpleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea cerrar la ventana Empleado?", "Seguridad del sistema", MessageBoxButton.YesNo, MessageBoxImage.Warning);
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





        #endregion
        #region Inhabilitar
        /// <summary>
        /// este evento es el encargado de habilitar las cajas de texto de la ventana wpfEmpleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbNuevoRegistro_Click(object sender, RoutedEventArgs e)
        {
            rbCancelar.IsEnabled = true;
            txtnombre.IsEnabled = true;
            txtapellidoPaterno.IsEnabled = true;
            txtapellidomaterno.IsEnabled = true;
            txtnoAfiliacion.IsEnabled = true;
            dtfecha.IsEnabled = true;
            txtdirección.IsEnabled = true;
            txtcolonia.IsEnabled = true;
            txtCiudad.IsEnabled = true;
            cmbEstado.IsEnabled = true;
            txtCp.IsEnabled = true;
            txtTelefono.IsEnabled = true;
            txtCorreo.IsEnabled = true;
            cmbNivelescolar.IsEnabled = true;
            txtEspecialidad.IsEnabled = true;
            dtgEmpleado.IsEnabled = true;
            rbGuardar.IsEnabled = true;
            rbReportes.IsEnabled = true;
            btnMensaje.Content = "Listo";
        }

        #endregion

        #region Atajos
        /// <summary>
        /// metodo encargado de actualizar los registros de la ventana wpfEmpleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (_EmpleadoActual != null)
            {
                if (e.Key == Key.F5)
                {
                    try
                    {
                        MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea modificar este registro?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        if (x == MessageBoxResult.Yes)
                            if (_EmpleadoActual == null)
                            {
                                _registroEmpleado.Add(new Empleado(txtnombre.Text.Trim(), txtapellidoPaterno.Text.Trim(), txtapellidomaterno.Text.Trim(), txtnoAfiliacion.Text.Trim(), DateTime.Parse(dtfecha.Text.Trim()), txtdirección.Text.Trim(), txtcolonia.Text, txtCiudad.Text.Trim(), cmbEstado.Text.Trim(), int.Parse(txtCp.Text.Trim()), txtTelefono.Text.Trim(), txtCorreo.Text.Trim(), cmbNivelescolar.Text.Trim(), txtEspecialidad.Text.Trim()));
                            }
                            else
                            {

                                _EmpleadoActual.Nombre = txtnombre.Text;
                                _EmpleadoActual.ApPaterno = txtapellidoPaterno.Text;
                                _EmpleadoActual.ApMaterno = txtapellidomaterno.Text;
                                _EmpleadoActual.NSS = txtnoAfiliacion.Text;
                                _EmpleadoActual.FechaNacimiento = DateTime.Parse(dtfecha.Text);
                                _EmpleadoActual.Direccion = txtdirección.Text;
                                _EmpleadoActual.Colonia = txtcolonia.Text;
                                _EmpleadoActual.Ciudad = txtCiudad.Text;
                                _EmpleadoActual.Estado = cmbEstado.Text;
                                _EmpleadoActual.CP = int.Parse(txtCp.Text);
                                _EmpleadoActual.Telefono = txtTelefono.Text;
                                _EmpleadoActual.Correo = txtCorreo.Text;
                                _EmpleadoActual.NivelEscolar = cmbNivelescolar.Text;
                                _EmpleadoActual.Especialidad = txtEspecialidad.Text;
                                _registroEmpleado.Actualizar(_EmpleadoActual);
                                btnMensaje.Content = "El empleado: " + _EmpleadoActual.Nombre + " ha sido actualizado correctamente";



                            }
                        misEmpleados = _registroEmpleado.Listar();
                        dtgEmpleado.ItemsSource = misEmpleados;
                        rbeliminar.IsEnabled = false;

                        rbActualizar.IsEnabled = false;
                        rbNuevoRegistro.IsEnabled = true;




                    }
                    catch (Exception)
                    {

                    }
                    txtapellidomaterno.Text = "";
                    txtapellidoPaterno.Text = "";
                    txtCiudad.Text = "";
                    txtcolonia.Text = "";
                    txtCorreo.Text = "";
                    txtCp.Text = "";
                    txtdirección.Text = "";
                    txtEspecialidad.Text = "";
                    cmbEstado.SelectedIndex = -1;
                    txtnoAfiliacion.Text = "";
                    txtnombre.Text = "";
                    txtTelefono.Text = "";
                    cmbNivelescolar.SelectedIndex = -1;
                    dtfecha.Text = "";
                    _registroEmpleado.Clear();

                }


            }
        }
        #endregion
        /// <summary>
        /// teclas de acceso rapido para eliminar empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Window_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (_EmpleadoActual != null)
            {

                if (e.Key == Key.Delete)
                {
                    try
                    {
                        MessageBoxResult x = Microsoft.Windows.Controls.MessageBox.Show("¿Desea eliminar el proveedor?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        if (x == MessageBoxResult.Yes)
                        {


                            _registroEmpleado.Eliminar(_EmpleadoActual);
                            
                            btnMensaje.Content = "El proveedor: " + _EmpleadoActual.Nombre + " se elimino correctamente";
                           
                        }
                        misEmpleados = _registroEmpleado.Listar();
                        dtgEmpleado.ItemsSource = misEmpleados;
                        rbeliminar.IsEnabled = false;

                        rbActualizar.IsEnabled = false;
                        rbNuevoRegistro.IsEnabled = true;


                    }



                    catch (Exception)
                    {

                    }
                    txtapellidomaterno.Text = "";
                    txtapellidoPaterno.Text = "";
                    txtCiudad.Text = "";
                    txtcolonia.Text = "";
                    txtCorreo.Text = "";
                    txtCp.Text = "";
                    txtdirección.Text = "";
                    txtEspecialidad.Text = "";
                    cmbEstado.SelectedIndex = -1;
                    txtnoAfiliacion.Text = "";
                    txtnombre.Text = "";
                    txtTelefono.Text = "";
                    cmbNivelescolar.SelectedIndex = -1;
                    dtfecha.Text = "";
                    _registroEmpleado.Clear();
                   

                }




            }
        }

        private void rbCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtapellidomaterno.Text = "";
            txtapellidoPaterno.Text = "";
            txtCiudad.Text = "";
            txtcolonia.Text = "";
            txtCorreo.Text = "";
            txtCp.Text = "";
            txtdirección.Text = "";
            txtEspecialidad.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtnoAfiliacion.Text = "";
            txtnombre.Text = "";
            txtTelefono.Text = "";
            cmbNivelescolar.SelectedIndex = -1;
            dtfecha.Text = "";
            _registroEmpleado.Clear();
            rbActualizar.IsEnabled = false;
            rbeliminar.IsEnabled = false;
            rbNuevoRegistro.IsEnabled = true;
            btnMensaje.Content = "Registro Cancelado";





        }
        #region Validacion de cajas de texto


        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {

            String Aceptados = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + Convert.ToChar(8);
            {
                if (Aceptados.Contains("" + e.Key))
                {
                    e.Handled = false;

                }

                else e.Handled = true;



            }

        }

        private void txtapellidoPaterno_KeyDown(object sender, KeyEventArgs e)
        {
            
            String Aceptados = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + Convert.ToChar(8);
            {
                if (Aceptados.Contains("" + e.Key))
                {
                    e.Handled = false;

                }

                else e.Handled = true;

          

            }

        }

        private void txtapellidomaterno_KeyDown(object sender, KeyEventArgs e)
        {

            String Aceptados = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + Convert.ToChar(8);
            {
                if (Aceptados.Contains("" + e.Key))
                {
                    e.Handled = false;

                }

                else e.Handled = true;
            }

        }

        private void txtnoAfiliacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }



        private void txtcolonia_KeyDown(object sender, KeyEventArgs e)
        {
            String Aceptados = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + Convert.ToChar(8);
            {
                if (Aceptados.Contains("" + e.Key))
                {
                    e.Handled = false;
                }
                else e.Handled = true;
            }
        }

        private void txtCiudad_KeyDown(object sender, KeyEventArgs e)
        {
            String Aceptados = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + Convert.ToChar(8);
            {
                if (Aceptados.Contains("" + e.Key))
                {
                    e.Handled = false;
                }
                else e.Handled = true;
            }
        }

        private void txtCp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtEspecialidad_KeyDown(object sender, KeyEventArgs e)
        {
            String Aceptados = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm" + Convert.ToChar(8);
            {
                if (Aceptados.Contains("" + e.Key))
                {
                    e.Handled = false;
                }
                else e.Handled = true;
            }
        }

   

        //private void rbLimpiar_Click(object sender, RoutedEventArgs e)
        //{
        //    txtapellidomaterno.Text = "";
        //    txtapellidoPaterno.Text = "";
        //    txtCiudad.Text = "";
        //    txtcolonia.Text = "";
        //    txtCorreo.Text = "";
        //    txtCp.Text = "";
        //    txtdirección.Text = "";
        //    txtEspecialidad.Text = "";
        //    cmbEstado.SelectedIndex = -1;
        //    txtnoAfiliacion.Text = "";
        //    txtnombre.Text = "";
        //    txtTelefono.Text = "";
        //    cmbNivelescolar.SelectedIndex = -1;
        //    dtfecha.Text = "";
        //    txtBuscar.Clear();
        //    _registroEmpleado.Clear();
        //    btnMensaje.Content = "Registro limpiado";
        //}


        private void RibbonWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {

                wpfManualTecnico ve = new wpfManualTecnico();
                ve.Show();
            }


        }
       
       private string Busqueda="";
        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)

            //la referencia al metodo que esta abajo es para la consulta de algun registro parecido a lo que se le introduzca en la caja de texto
        //   dtgEmpleado.DataContext = Empleado.getdatos("select * from Empleado where nombre like '" + txtBuscar.Text + "%'");
        {
            
            
                try
                {
                    Busqueda = txtBuscar.Text;
                    if (Busqueda=="")
                    {
                        misEmpleados = _registroEmpleado.Listar();
                        dtgEmpleado.ItemsSource = misEmpleados;
                    }
                    else
                    {
                       
                        misEmpleados = _registroEmpleado.ListarNombre(Busqueda);
                        dtgEmpleado.ItemsSource = misEmpleados;

                    }
              



                }

                catch (Exception ex)
                {
                    btnMensaje.Content = ex.Message;
                }

            

        }
     
        private void rbAscendente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                misEmpleados = _registroEmpleado.ListarAscendente();
                dtgEmpleado.ItemsSource = misEmpleados;
                if (misEmpleados == null)
                {
                    misEmpleados = _registroEmpleado.Listar();
                    dtgEmpleado.ItemsSource = misEmpleados;
                }
            }
            catch (Exception ex)
            {

                btnMensaje.Content = ex.Message;
            }
         
            
        }

        private void rbDescendente_Click(object sender, RoutedEventArgs e)
        {
            misEmpleados = _registroEmpleado.ListarDescendente();
            dtgEmpleado.ItemsSource = misEmpleados;
        }
        
        private void rbApellido_Click(object sender, RoutedEventArgs e)
        {
            misEmpleados = _registroEmpleado.ListarApellidoPaterno("");
            dtgEmpleado.ItemsSource = misEmpleados;
        }

        private void rbEntre_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxtMin.Text == "")
                   
                    {
                        Microsoft.Windows.Controls.MessageBox.Show("La caja de texto del rango minimo esta vacia", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                else if (TxtMax.Text == "")
                {

                    Microsoft.Windows.Controls.MessageBox.Show("Las caja de texto del rango maximo esta vacia", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    string minimo = TxtMin.Text;
                    string maximo = TxtMax.Text;
                    misEmpleados = _registroEmpleado.ListarEntre(minimo, maximo);
                    dtgEmpleado.ItemsSource = misEmpleados;
                }
             
                //Microsoft.Windows.Controls.MessageBox.Show("El rango que ingreso no es valido\n Ingrese un Rango valido", "Seguridad del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("A ocurrido una exepcion al tratar de ingresar sus datos\n intente mas tarde");
              
               
            }
          
           
        }
    }
        #endregion

        }
    
