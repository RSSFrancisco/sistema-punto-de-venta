   M S B A M L   `   `   `  ����  Presentacion    Presentacion.wpfContacto   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ] YDivelements.SandRibbon, Version=2.0.1.2, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c38sr/http://schemas.divelements.co.uk/wpf/sandribbon  5      Imy@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   {   ?telerik1http://schemas.telerik.com/2008/xaml/presentation  6�   -   5          � Title$  Contacto��5   	   $	��600��6   $	��800��6'    � WindowStyle$ ThreeDBorderWindow=�63    � WindowStartupLocation$ CenterScreen=�6T    � ShowInTaskbar .  #��["��68  )  #Divelements.SandRibbon.RibbonWindow   
Appearance$ Office2010Blue=�6~   � 
ResizeMode$ NoResize=�6�   � Icon$L F/Presentacion;component/Images/1344565150_preferences-contact-list.png��6�     	StatusBar 5      &   Divelements.SandRibbon.StatusBar  5   
      ExtendedControl 5	      '  !Divelements.SandRibbon.StripPanel  5
      -   5        $��strPanel��5
       5      .@�5      �� -   5        $��
btnMensaje��5       $�� ��6   
���   �62   �� 5      -   5        $��lblTotal��5      $�� ��6   6   �� 5      5      	 � 	Resources	 5      
 �� MergedDictionaries �� Source�� 5   
   
 5      �� 5      $+ %/ReuxablesLegacy;component/candy.xaml?�6%   %    5      .��5      � #��["��6   $��0 0 0 0q�6[   .+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��ribbon1��5   2   $��Stretch=�6   $	��Top=�6A   $��0 0 0 0q�6Y   ���	#CAC7F4FB   ApplicationMenu 5      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5      ���	#FF1C9D6B8  2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$@ :/Presentacion;component/Images/1344565183_deliverables.png��6B    o� 
IsMainMenu .  .@�5       A  ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5          Name$ 	MenuItem1��5    S   $��17��63   $��Ayuda...��6A   6S     5!      -   5        $ rbInformacion��5!   b   $��18��63   $��Información del Sistema��6A   6b   5#      .@�5%      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $��Registro��6   .@�5&      3	  -Microsoft.Windows.Controls.Ribbon.RibbonGroup	  .@�5'      4
  .Microsoft.Windows.Controls.Ribbon.RibbonButton
  -   5        $��rbNuevo��5'   5    
  Label$ Nuevo��6&    
  LargeImageSource$@ :/Presentacion;component/Images/1344565422_document-new.png��6E    
  ToolTipFooterTitle$$ Presione F1 para obtener ayuda��6�    
  ToolTipTitle$ Genera un nuevo Registro��6�    
  ToolTipDescription$  Los registros se activan  ��6  5(      	  5)      .@�5*      
  -	   5        $��	rbGuardar��5*   �   $ Guardar��6&   $- '/Presentacion;component/Images/save.png��66   {�.  $$ Presione F1 para obtener ayuda��6�   $ Boton guardar ��6�   $9 3Agrega los registros que se ingresan en los campos ��6  5+      	  5,      .@�5-      
  -
   5        $��
rbEliminar��5-   7   $ Eliminar��6&   $A ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��6I   {�.  $$ Presione F1 para obtener ayuda��6�   $&  Para Eliminar presione (Delete) ��6�   $+ %Elimina los Registros seleccionados  ��6+  5.      	  5/      .@�50      
  -   5        $��rbActualizar��50   �   $ 
Actualizar��6&   $J D/Presentacion;component/Images/1344567350_system-software-update.png��69   {�.  $$ Presione F1 para obtener ayuda��6�   $" Para Actualizar presione F5 ��6  $, &Actualiza los registros seleccionados ��62  51      	  52      .@�53      
  -   5        $��
rbCancelar��53   8   $ Cancelar��6&   $? 9/Presentacion;component/Images/1344565469_Cancel__Red.png��6K   $$ Presione F1 para obtener ayuda��6�   $ Boton cancelar  ��6�   $ Cancela los Acciones  ��6�   6  54      	  55      .@�56      
  -   5        $��
rbReportes��56   >   $ Generar Reporte��6&   $B </Presentacion;component/Images/1344565499_custom-reports.png��6P   {�.  $$ Presione F1 para obtener ayuda��6�   $ Generar reportes ��6�   $O IGenera un reporte de los registros que se muestran en la ventana Contacto��6  6g  57      58      59      a� 5:   
   -   5        $��toolBarPanel1��5:   H   $��Stretch=�6   $��0,29,0,0q�66   $	��Top=�6]   �� 5;   
   -   5        $��
statusBar1��5;   N   $��28��6   $
��Left=�6    $��	0,833,0,0q�6;   $	��Top=�6`   $	��778��6x   �� 5<   
   -   5        $��	lblNombre��5<   \   $��Nombre��6   $��27��6!   $
��Left=�6-   $��
12,147,0,0q�6H   $	��Top=�6m   $��89��6�   �� 5=   
   -   5        $��lblApellidoPaterno��5=   _   $��	Apellidos��6   $��28��6$   $
��Left=�60   $��
12,202,0,0q�6K   $	��Top=�6y   $	��102��6�   �� 5>   
   -   5        $��label1��5>   _   $��
Dirección��6   $��32��6$   $
��Left=�60   $��
12,267,0,0q�6K   $	��Top=�6m   $	��106��6�   �� 5?   
   -   5        $��lblTelefono��5?   ^   $��	Teléfono��6   $��24��6#   $
��Left=�6/   $��
12,326,0,0q�6J   $	��Top=�6q   $��97��6�   �� 5@   
   -   5        $��lblExtension��5@   `   $��
Extensión��6   $��24��6$   $
��Left=�60   $��417,147,0,0q�6K   $	��Top=�6t   $��94��6�   �� 5A   
   -   5        $��	lblCorreo��5A   i   $��Correo Electrónico��6   $��28��6-   $
��Left=�69   $��417,202,0,0q�6T   $	��Top=�6z   $	��116��6�   �� 5B   
   -   5        $��	lblPuesto��5B   ]   $��Ciudad��6   $��28��6!   $
��Left=�6-   $��417,267,0,0q�6H   $	��Top=�6n   $��74��6�   �� 5C   
   -   5        $��
lblEmpresa��5C   ^   $��Empresa��6   $��25��6"   $
��Left=�6.   $��417,326,0,0q�6I   $	��Top=�6p   $��99��6�   �� 5D   
   -   5        $��	txtNombre��5D   Z   $��25��6   $��1��6   $
��Left=�6+   $��
12,171,0,0q�6F   $	��Top=�6k   $	��375��6�   {�.  6�   �� 5E   
   -   5        $��txtApellidoPaterno��5E   Z   $��25��6   $��2��6   $
��Left=�6+   $��
12,236,0,0q�6F   $	��Top=�6t   $	��375��6�   {�.  6�   �� 5F   
   -   5        $��txtApellidoMaterno��5F   Z   $��25��6   $��3��6   $
��Left=�6+   $��
12,296,0,0q�6F   $	��Top=�6t   $	��375��6�   {�.  6�   �� 5G   
   -   5        $��txtTelefono��5G   Z   $��25��6   $��4��6   $
��Left=�6+   $��
12,357,0,0q�6F   $	��Top=�6m   $	��236��6�    �� 	MaxLength$ 13��6�   {�.  6�   �� 5H   
   -   5        $��txtExtension��5H   \   $��25��6   $��5��6   $
��Left=�6,   $��417,171,0,0q�6G   $	��Top=�6p   $	��102��6�   $ 7��6�   {�.  6�   �� 5I   
   -   5        $��txtCorreoElectronico��5I   [   $��25��6   $��6��6   $
��Left=�6+   $��417,236,0,0q�6F   $	��Top=�6w   $	��345��6�   {�.  6�   �� 5J   
   -   5        $��	txtPuesto��5J   [   $��25��6   $��7��6   $
��Left=�6+   $��417,296,0,0q�6F   $	��Top=�6l   $	��345��6�   {�.  6�   �� 5K   
   -   5        $��
cmbEmpresa��5K   \   $��24��6   $��8��6   $
��Left=�6,   $��417,358,0,0q�6G   $	��Top=�6n   $	��236��6�   {�.  ��5L      �� 5M      .R�5N      ��  �� Orientation$ 
Horizontal=�6!   .+�5O      �� $	��200��6A   ��6$   ��  �� Path$ Siglas�6A   5P      5Q      5T      &   System.Windows.Controls.DataGrid  5U   
   -    5        $��dtgContacto��5U   �      AutoGenerateColumns .  $	��154��6/   $
��Left=�6a   $��	0,407,0,0q�6|   $	��Top=�6�   $	��778��6�      
IsReadOnly . {�.  ��6<   �� *misContactos+   Columns 5V      0  *System.Windows.Controls.DataGridTextColumn  5W      ,  &System.Windows.Controls.DataGridColumn   Header$ Clave��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 45 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Clave+6N     5X      $ Nombre��6%   $	 110 6P    65   �� *Nombre+6P     5Y      $ 	Apellidos��6%   $	 140 6\    68   �� *ApellidoPaterno+6\     5Z      $ 
Dirección��6%   $	 140 6\    68   �� *ApellidoMaterno+6\     5[      $ 	Teléfono��6%   $	 110 6T    67   �� *
Telefono+6T     5\      $ 
Extensión��6%   $ 90 6V    68   �� *	Extension+6V     5]      $ Correo��6%   $ * 6P    65   �� *Correo+6P   5`      �� 5a   
   -!   5        $��
btnEmpresa��5a   [   $	��...��6   $��25��6   $
��Left=�6+   $��659,357,0,0q�6F   $	��Top=�6m   $��45��6�   6�   5b      5c      