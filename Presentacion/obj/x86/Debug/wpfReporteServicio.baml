   M S B A M L   `   `   `  ����  Presentacion%    Presentacion.wpfReporteServicio   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ] YDivelements.SandRibbon, Version=2.0.1.2, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c38sr/http://schemas.divelements.co.uk/wpf/sandribbon  5      Z VWPFToolkit.Extended, Version=1.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[
extToolkitJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended  5   	   Imy@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   �   ?telerik1http://schemas.telerik.com/2008/xaml/presentation  6  -   5          � Title$  Reparación PC��5   	   $	��630��6   $	��800��6,    � 
ResizeMode$ CanMinimize=�68    � WindowStyle$ ThreeDBorderWindow=�6p    � WindowStartupLocation$ CenterScreen=�6�    � ShowInTaskbar . #��["��6Z   � AllowsTransparency .   � Icon$< 6/Presentacion;component/Images/1344553792_button_2.ico��6�  )  #Divelements.SandRibbon.RibbonWindow   
Appearance$ Office2010Blue=�6�   � 	Resources 5      	 �� MergedDictionaries
 �� Source�� 5   
   	 5	      �� 5
      $+
 %/ReuxablesLegacy;component/candy.xaml?�6%   %    5         	StatusBar 5      &   Divelements.SandRibbon.StatusBar  5   
      ExtendedControl 5      '  !Divelements.SandRibbon.StripPanel  5      -   5        $��strPanel��5       5      .@�5      �� -   5        $��
btnMensaje��5       $�� ��6   $
��Bold"�63   
���   ����	#FFF5F2F2��5      �� 5       �� EndPoint$ 1,0.5&�6*    �� 
StartPoint$ 0,0.5&�6;   .��5      �  � Color$ 	#FF9DC7D6��6'    � Offset$ 0Q�69   � 5      $ White��6'   $ 1Q�65   5      5      �� 5      -   5        $��lblTotal��5      $�� ��6   6   �� 5      5       .��5#      � $��0 0 0 0q�6   ���	#FFF8F8F8.+�5$   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��
ribbonMenu��5$   P   $��Stretch=�6      CheckedBackground �	#FFCE6A6A$	��Top=�6b   $	��118��6{   ���	#FFC4DECF���	#CAC7F4FB$��14(�6�      ApplicationMenu 5%      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5&      ���	#FF1C9D6B8  2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$@ :/Presentacion;component/Images/1344565183_deliverables.png��6B    o� 
IsMainMenu .  .@�5'      A  ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5          Name$ 	MenuItem1��5'   E   $��Ayuda...��63   6  0Microsoft.Windows.Controls.Ribbon.RibbonMenuItem   ImageSource$7 1/Presentacion;component/Images/Folder-Info256.png��6p     5(      -   5        $ rbInformacion��5(   T   $��Información del Sistema��63   $4 ./Presentacion;component/1343952252_Network.ico��6�   6�     5)      -   5        $ rbLimpiarPapelera��5)   L   $��Vaciar papelera��63    � ToolTip$/ )Vaciar papelera de registros de servicios��6g   $> 8/Presentacion;component/Images/1344567506_edit-clear.png��6�   6  5*      .@�5-      1	  +Microsoft.Windows.Controls.Ribbon.RibbonTab	  -	   5        $��menuRegistro��5-   -   $��Registro��6   .@�5/      3
  -Microsoft.Windows.Controls.Ribbon.RibbonGroup
  .@�50      4  .Microsoft.Windows.Controls.Ribbon.RibbonButton  -
   5        $��rbNuevoRegistro��50   �      Label$ Nuevo��6&      LargeImageSource$@ :/Presentacion;component/Images/1344565422_document-new.png��6T      ToolTipFooterTitle$$ Presione F1 para obtener ayuda��6�      ToolTipTitle$ Genera un nuevo Registro��6�      ToolTipDescription$  Los registros se activan  ��6  52      53      
  54      .@�55        -   5        $��	rbGuardar��55   �   $ Guardar��6&   $- '/Presentacion;component/Images/save.png��6N   {�. $$ Presione F1 para obtener ayuda��6�   $ Boton Guardar��6�   $= 7Guarda los registros que ingrese en las cajas de texto ��6�   56      
  57      .@�58        -   5        $��
rbeliminar��58   �   $ Eliminar��6&   {�.  $A ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��6I   $$ Presione F1 para obtener ayuda��6�   $&  Para Eliminar presione (Delete) ��6�   $+ %Elimina los Registros seleccionados  ��6  6L  59      
  5:      .@�5;        -   5        $��rbActualizar��5;   �   $ 
Actualizar��6&   {�.  $J D/Presentacion;component/Images/1344567350_system-software-update.png��6K   $$ Presione F1 para obtener ayuda��6�   $" Para Actualizar presione F5 ��6�   $+ %Actualiza los reportes seleccionados ��6  6S  5<      
  5>      .@�5?        -   5        $��
rbCancelar��5?   �   $ Cancelar��6&   {�. $? 9/Presentacion;component/Images/1344565469_Cancel__Red.png��6H   $$ Presione F1 para obtener ayuda��6�   $ Cancelar las acciones ��6�   $) #Cancela los reportes seleccionados ��6  6;  5@      
  5A      .@�5B        -   5        $��rbBorrarPermanente��5B   �   $ Borrado Permanente��6&   {�. $9 3/Presentacion;component/Images/Folder-Delete256.png��6R   $$ Presione F1 para obtener ayuda��6�   $6 0Borrar permanentemente el Registro Seleccionado ��6�   $ Eliminación Permanente ��6(  6U  5C      5D      	  5E      -   5        $��menuFiltros��5E   ,   $��FILTROS��6   .@�5F      
  .@�5G        -   5        $��rbFiltrAscendente��5G   9   $ 
Ascendente��6&   $��13(�6S   $= 7/Presentacion;component/Images/filtro-icono-5680-64.png��6b   6�     5H      -   5        $��rbDescendente��5H   H   $ Descendente��6&   $��13(�6:   $= 7/Presentacion;component/Images/filtro-icono-5680-64.png��6^   6�     5I      -   5        $��
rbAntiguos��5I   7   $ Antiguos��6&   $6 0/Presentacion;component/Images/InvoiceSearch.png��6J   6�     5J      -   5        $��rbRecientes��5J   8   $ 	Recientes��6&   $7 1/Presentacion;component/Images/InvoiceSearch1.png��6L   6�     5K      -   5        $��rbEliminado��5K   D   $ Papelera de reciclaje��6&   $9 3/Presentacion;component/Images/23-Full%20Trash1.png��6X   6�     5L      -   5        $��rbBuscarPorCliente��5L   <   $ Mostrar Todos��6&   $> 8/Presentacion;component/Images/addressbook-search128.png��6W   6�   1  +Microsoft.Windows.Controls.WatermarkTextBox  5M      -   5        $��txtBuscarPorCliente��5M   2   $	��150��6N      	Watermark$ Buscar Por Cliente��6Z   6y     5N      -   5        $��txtBuscarPorEmpleado��5N   2   $	��150��6O   $ Buscar Por Quien Atendio��6[   6�   5P      5R      	  5S      $��REPORTES��6   $��14(�6-   $��Arial)�6;   .@�5T      
  .@�5U        -   5        $��rbReportess��5U   >   $ Generar Reporte��6&   $B </Presentacion;component/Images/1344565499_custom-reports.png��6Q   {�. $$ Presione F1 para obtener ayuda��6�   $ Generar reportes ��6�   $X RGenera un reporte de los registros que se muestran en la ventana Reporte Servicio ��6  6p  �� 5V      -   5        $��
lblNombrer��5V      $�� ��6.   �� 5W      -   5        $��txtNombreReporte��5W      $	��150��66   �� 5X      -   5        $��lblNombrereport��5X      $��     Nombre del Reporte��63   5Y      5Z      5[      �� 5\   
   -   5        $��
tabControl��5\   D   $
��Left=�6   $��	0,114,0,0q�61   $	��Top=�6V   $	��560��6n   .@�5]      �� -   5        $��tabRegistrar��5]   )   $��	Registrar��6   {�. .��5^      � $��0,0,0,0q�6   .+�5_      �� -   5        $��	groupBox3��5_   c   $�� ��6   $	��448��6)   $
��Left=�66   $��1,79,0,0q�6Q   $	��Top=�6t   $	��860��6�   .��5`      � .+�5a      �� -    5        $��chkEntradaEquipo��5a   |   $��Entrada de Equipo��6'   $��16��6C   $
��Left=�6O   $��11,9,0,0q�6j   $��6��6�   $	��Top=�6�   $	��123��6�   {�. 6�   �� 5b      -!   5        $��chkSalidaEquipo��5b   ~   $��Salida de Equipo��6'   $��16��6B   $��Right=�6N   $��
0,37,730,0q�6j   $��7��6�   $	��Top=�6�   {�. 6�   �� 5c      -"   5        $��label1��5c   d   $��Servicio a domicilio��6$   $��28��6C   $��502,6,244,0q�6O   $	��Top=�6r   �� 5d      -#   5        $��	groupBox4��5d   �   $��Descripción del equipo��6'   $��59��6G   $
��Left=�6S   $��	-1,61,0,0q�6n   $	��Top=�6�   $	��755��6�   .��5e   "   � .+�5f   &   �� -$   5        $��label2��5f   w   $��Nombre ��6,   $��28��6>   $
��Left=�6J   $��6,10,0,0q�6e   $	��Top=�6�   �� 5g   &   -%   5        $��	txtNombre��5g   h   $��23��6.   $
��Left=�6:   $��59,7,0,0q�6V   $��13��6y    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��130��6�   {�.  �� 	MaxLength$ 35��6�   �� 5h   &   -&   5        $��label3��5h   w   $��Marca��6,   $��28��6<   $
��Left=�6H   $��
195,10,0,0q�6c   $	��Top=�6�   �� 5i   &   -'   5        $��txtMarca��5i   h   $��26��6.   $
��Left=�6:   $��	234,4,0,0q�6U   $
 Wrap=�6x   $	��Top=�6�   $	��138��6�   {�. $ 35��6�   �� 5j   &   -(   5        $��label4��5j   x   $��Modelo��6,   $��28��6=   $
��Left=�6I   $��
383,11,0,0q�6d   $	��Top=�6�   �� 5k   &   -)   5        $��	txtModelo��5k   h   $��26��6.   $
��Left=�6:   $��	430,3,0,0q�6U   $
 Wrap=�6y   $	��Top=�6�   $	��108��6�   {�. $ 35��6�   �� 5l   &   -*   5        $��label5��5l   ~   $��No. de serie��6,   $��28��6C   $
��Left=�6O   $��
544,10,0,0q�6j   $	��Top=�6�   �� 5m   &   -+   5        $��
txtNoSerie��5m   x   $��25��6.   $
��Left=�6:   $��	610,6,0,0q�6V   $ 25��6i   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   {�. 6�   5n   #   5o      �� 5p      -,   5        $��	groupBox5��5p   �   $,��&Condiciones en que se recibe el equipo��6'   $��58��6W   $
��Left=�6c   $��
-1,116,0,0q�6~   $	��Top=�6�   $	��760��6�   .��5q   "   � .+�5r   &   �� --   5        $��txtCondiciones��5r   f   $��35��6.   $
��Left=�6:   $��2,0,0,0q�6U   $	��Top=�6|   $	��746��6�   {�. $	 156��6�   $
 Wrap=�6�   5s   #   5t      �� 5u      -.   5        $��	groupBox6��5u   z   $��Falla Reportada��6'   $��59��6@   $
��Left=�6L   $��	3,171,0,0q�6g   $	��Top=�6�   $	��209��6�   .��5v   "   � .+�5w   &   �� -/   5        $��txtFallaReportada��5w   h   $��37��6.   $
��Left=�6:   $��	-4,-1,0,0q�6U   $	��Top=�6�   $	��201��6�   {�. $	 156��6�   $
 Wrap=�6�   5x   #   5y      �� 5z      -0   5        $��	groupBox7��5z   �   $��Reporte de ingenieria ��6'   $��60��6G   $
��Left=�6S   $��215,170,0,0q�6n   $	��Top=�6�   $	��545��6�   .��5{   "   � .+�5|   &   �� -1   5        $��txtReporteIngenieria��5|   U   $��37��6.   $
��Left=�6:   $
 Wrap=�6q   $	��Top=�6�   $	��533��6�   {�. $	 156��6�   5}   #   5~      �� 5      -2   5        $��	groupBox8��5   x   $��Observaciones��6'   $��52��6>   $
��Left=�6J   $��	2,225,0,0q�6e   $	��Top=�6�   $	��757��6�   .��5�   "   � .+�5�   &   �� -3   5        $��txtObservaciones��5�   g   $��30��6.   $
��Left=�6:   $��-1,1,0,0q�6U   $
 Wrap=�6   $	��Top=�6�   $	��746��6�   {�. $	 156��6�   5�   #   5�      �� 5�      -4   5        $��label7��5�   x   $��Mano de Obra ��6$   $��28��6<   $
��Left=�6H   $��365,284,0,0q�6c   $	��Top=�6�   �� 5�      -5   5        $��txtManoObra��5�   G   $��23��6&   $��446,280,0,0q�62   $	��Top=�6�   {�. $
��Left=�6�   $��66��6�   $ 8��6�   �� 5�      -6   5        $��label8��5�   v   $��Refacciones��6$   $��28��6:   $
��Left=�6F   $��517,284,0,0q�6a   $	��Top=�6�   �� 5�      -7   5        $��txtRefacciones��5�   I   $��23��6&   $��585,280,199,0q�62   $	��Top=�6�   {�. $ 8��6�   �� 5�      -8   5        $��label9��5�   p   $��Total��6$   $��28��64   $
��Left=�6@   $��660,284,0,0q�6[   $	��Top=�6~   �� 5�      -9   5        $��lblHoraEntrada��5�   x   $��Hora de entrada��6$   $��28��6>   $
��Left=�6J   $��	210,9,0,0q�6e   $	��Top=�6�   �� 5�      -:   5        $��label10��5�   x   $��Hora de salida��6$   $��28��6=   $
��Left=�6I   $��
218,38,0,0q�6d   $	��Top=�6�   �� 5�      -;   5        $��lblTot��5�   �   $��Arial)�6'   $��12(�6:   $��Normal&�6H   $��Normal$�6]   $��Normal"�6p   ���	#FF2A4B2A$��23��6�   $
��Left=�6�   $��690,280,0,0q�6�   $	��Top=�6�   $��66��6�   {�. $ 9��6  6'  �� 5�      -<   5        $��cmbHoraEntrada��5�   a   $��23��6'   $
��Left=�63   $��	303,6,0,0q�6N   $	��Top=�6w   $	��126��6�     �� 
IsEditable  . 6�   �� 5�      -=   5        $��cmbHoraSalida��5�   b   $��23��6'   $
��Left=�63   $��
303,37,0,0q�6N   $	��Top=�6w   $	��126��6�     . 6�   �� 5�      ->   5        $
��rbSi��5�   o   $��SI��6'   $��16��64   $
��Left=�6@   $��
502,34,0,0q�6[   $	��Top=�6{   �� 5�      -?   5        $
��rbNo��5�   o   $��NO��6'   $��16��64   $
��Left=�6@   $��
543,34,0,0q�6[   $	��Top=�6{   5�      5�      �� 5�      -@   5        $��lblFecha��5�   f   $��Fecha��6   $��28��6,   $
��Left=�68   $��	199,7,0,0q�6S   $	��Top=�6v   (  "System.Windows.Controls.DatePicker  5�      -A   5        $��dtFecha��5�   l   $��25��6!   $
��Left=�6-   {�. $��	236,3,0,0q�6Y   $��2��6{   $	��Top=�6�   $	��188��6�   �� 5�      -B   5        $��label11��5�   i   $��
Dirección��6   $��28��60   $
��Left=�6<   $��3,61,0,0q�6W   $	��Top=�6x   �� 5�      -C   5        $��txtDireccion��5�   X   $��23��6   $
��Left=�6*   $��	55,59,0,0q�6E   $	��Top=�6l   $	��353��6�   $	 100��6�   �� 5�      -D   5        $��label12��5�   f   $��Ciudad��6   $��28��6-   $
��Left=�69   $��9,35,0,0q�6T   $	��Top=�6u   �� 5�      -E   5        $��	txtCiudad��5�   X   $��23��6   $
��Left=�6*   $��	55,33,0,0q�6E   $	��Top=�6i   $	��158��6�   $ 80��6�   �� 5�      -F   5        $��label13��5�   j   $��Telefono��6   $��28��6/   $
��Left=�6;   $��
228,35,0,0q�6V   $	��Top=�6y   �� 5�      -G   5        $��txtTelefono��5�   Y   $��23��6   $
��Left=�6*   $��
280,31,0,0q�6E   $	��Top=�6l   $	��172��6�   $ 18��6�   �� 5�      -H   5        $��label14��5�   i   $��Atendio��6   $��28��6.   $
��Left=�6:   $��
459,35,0,0q�6U   $	��Top=�6x   �� 5�      -I   5        $��
txtAtendio��5�   Y   $��23��6   $
��Left=�6*   $��
509,31,0,0q�6E   $	��Top=�6k   $	��251��6�   $ 39��6�   �� 5�      -J   5        $��lblServicio��5�   r   $��Tipo de Servicio��6   $��28��67   $
��Left=�6C   $��
414,62,0,0q�6^   $	��Top=�6�   �� 5�      -K   5        $��cmbServicio��5�   Z   $��25��6   $
��Left=�6+   $��
509,59,0,0q�6F   $��5��6m   $	��Top=�6z   $	��251��6�   {�.   . 6�   o� 5�      -L   5        $��menu1��5�   :   $��23��6   $��	442,4,0,0q�6'   $	��Top=�6G   $	��150��6_   $
��Left=�6k   .@�5�      m� $��	  Cliente��6#   ! m� Icon! 5�      �� 5�   "   $H��B/Presentacion;component/Images/1344552397_user_accounts_config.png��6(   .@�5�      �� -M   5        $��
txtCliente��5�   C   $
��Left=�6'     .  $	��Top=�6�   ��5�   "   �� 5�   &   .R�5�   *   �� " �� Orientation$" 
Horizontal=�65   .+�5�   .   �� ��68   �� # �� Path$# Nombre�5�   +   5�   '   5�      �� 5�      -N   5        $��txtNuevoCliente��5�   &   6=   5�      5�      �� 5�      -O   5        $��lblMCliente��5�   b   $�� ��6   $��18��6'   $��Right=�63   $��	0,7,141,0q�6O   $	��Top=�6u   $��30��6�   ���	#FFF51616$��Italic$�6�   $��Normal"�6�   $��9(�6�   �� 5�      -P   5        $��lblFolio��5�   e   $��Folio��6   $��28��6,   $
��Left=�68   $��10,9,0,0q�6S   $	��Top=�6u   �� 5�      -Q   5        $��txtFolio��5�   W   $��23��6   $
��Left=�6*   $��55,4,0,0q�6E   $	��Top=�6g   $	��138��6   5�      5�      �� 5�      -R   5        $��tabTabla��5�   2   $��Lista de Servicios��6   {�. .��5�      � $	��539��6   .+�5�      &   System.Windows.Controls.DataGrid  -S   5        $��dtgReporteServicio��5�   �   $   AutoGenerateColumns$ .  $��Stretch=�6a   $��0,0,0,0q�6   $	��Top=�6�   %   
IsReadOnly% . {�. $	��389��6  $��14(�6*  ��6;   �� *miRequisicion+&   Columns& 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn'   Header$' Folio��61   (   Width5  /System.Windows.Controls.DataGridLengthConverter$	( 120 6@   1  +System.Windows.Controls.DataGridBoundColumn)   Binding) 6L   �� *
TotalFilas+  5�      $' Fecha��61   $	( 100 6@   ) 6L   �� *Fecha+  5�      $' Cliente��61   $	( 100 6B   ) 6N   �� *	Cliente+  5�      $' 	Direccion��61   $	( 100 6D   ) 6P   �� *	Direccion+  5�      $' Ciudad��61   $	( 100 6A   ) 6M   �� *Ciudad+  5�      $' Telefono��61   $	( 100 6C   ) 6O   �� *
Telefono+  5�      $' Empleado��61   $	( 100 6C   ) 6O   �� *
Empleado+  5�      $' Tipo Servicio��61   $	( 100 6H   ) 6T   �� *TipoServicio+  5�      $' Entrada��61   $	( 100 6B   ) 6N   �� *	Entrada+  5�      $' Salida��61   $	( 100 6A   ) 6M   �� *Salida+  5�      $' Servicio A Domicilio��61   $	( 100 6O   ) 6[   �� *ServicioADomicilio+  5�      $' Hora de Entrada��61   $	( 100 6J   ) 6V   �� *HoraEntrada+  5�      $' Hora de Salida��61   $	( 100 6I   ) 6U   �� *
HoraSalida+  5�      $' Nombre��61   $	( 100 6A   ) 6M   �� *Nombre+  5�      $' Marca��61   $	( 100 6@   ) 6L   �� *Marca+  5�      $' Modelo��61   $	( 100 6A   ) 6M   �� *Modelo+  5�      $' 
Num. Serie��61   $	( 100 6E   ) 6Q   �� *
NumSerie+  5�      $' Condicion Equipo��61   $	( 100 6K   ) 6W   �� *CondicionEquipo+  5�      $' Falla Reportada��61   $	( 100 6J   ) 6V   �� *FallaReportada+  5�      $' Reporte Ing.��61   $	( 100 6G   ) 6S   �� *
ReporteIng+  5�      $' Observaciones��61   $	( 100 6H   ) 6T   �� *Observaciones+  5�      $' Mano de Obra��61   $	( 100 6G   ) 6S   �� *
ManoDeObra+  5�      $' Costo Refacción��61   $	( 100 6J   ) 6V   �� *CostoRefaccion+  5�      $' Total��61   $	( 100 6@   ) 6L   �� *Total+5�      5�      5�      5�      5�      5�      