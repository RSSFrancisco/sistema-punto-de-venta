   M S B A M L   `   `   `  ����  Presentacion    Presentacion.wpfProveedor   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ] YDivelements.SandRibbon, Version=2.0.1.2, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c38sr/http://schemas.divelements.co.uk/wpf/sandribbon  5      Imy@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   �   -   5          � Title$  
PROVEDORES��5   	   $	��600��6   $	��800��6)    � WindowStyle$ ThreeDBorderWindow=�65    � WindowStartupLocation$ CenterScreen=�6V    � ShowInTaskbar . #��["��6�    � Icon$> 8/Presentacion;component/Images/1344565107_LorryGreen.png��6F  $��14(�6�   � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $+ %/ReuxablesLegacy;component/candy.xaml?�6%   %    5      )  #Divelements.SandRibbon.RibbonWindow   	StatusBar 5      &   Divelements.SandRibbon.StatusBar  5   
   	   ExtendedControl	 5      '  !Divelements.SandRibbon.StripPanel  5      -   5        $��strPanel��5       5      .@�5      �� -   5        $��
btnMensaje��5       $�� ��6   ���	#FF2D8340$
��Bold"�6J   �� 5      �� 5      -   5        $��lblTotal��5      $�� ��6   6   5      .��5      � ���	#FFF8F8F8$��0 0 0 0q�6"   .+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��ribbon1��5   P   $��Stretch=�6   
   CheckedBackground
 �	#FFCE6A6A$	��Top=�6_   $��118.5��6x   ���	#CAC7F4FB   ApplicationMenu 5      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5      ���	#FF1C9D6B8  2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$@ :/Presentacion;component/Images/1344565183_deliverables.png��6B    o� 
IsMainMenu .  .@�5       A  ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5          Name$ 	MenuItem1��5    E   $��Ayuda...��63   6E     5!      -   5        $ rbInformacion��5!   T   $��Información del Sistema��63   6T   5#      .@�5&      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $��Registro��6   $��14(�6-   .@�5'      3	  -Microsoft.Windows.Controls.Ribbon.RibbonGroup	  .@�5(      4
  .Microsoft.Windows.Controls.Ribbon.RibbonButton
  -   5        $��rbNuevoRegistro��5(   �    
  Label$ Nuevo��6&    
  LargeImageSource$@ :/Presentacion;component/Images/1344565422_document-new.png��67    
  ToolTipFooterTitle$$ Presione F1 para obtener ayuda��6�    
  ToolTipTitle$ Genera un nuevo Registro��6�    
  ToolTipDescription$  Los registros se activan  ��6  5)      	  5*      .@�5+      
  -	   5        $��	rbGuardar��5+   }   $ Guardar��6&   $8 2/Presentacion;component/Images/1344565565_Save.png��66   {�.  $$ Presione F1 para obtener ayuda��6�   $ Boton Guardar��6�   $= 7Guarda los registros que ingrese en las cajas de texto ��6
  5,      	  5-      .@�5.      
  -
   5        $��
rbEliminar��5.   �   $ Eliminar��6&   $A ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��67   {�.  $$ Presione F1 para obtener ayuda��6�   $&  Para Eliminar presione (Delete) ��6�   $+ %Elimina los Registros seleccionados  ��6(  5/      	  50      .@�51      
  -   5        $��rbActualizar��51   �   $ 
Actualizar��6&   $J D/Presentacion;component/Images/1344567350_system-software-update.png��69   {�.  $$ Presione F1 para obtener ayuda��6�   $" Para Actualizar presione F5 ��6  $, &Actualiza los registros seleccionados ��64  52      	  53      .@�54      
  -   5        $��
rbCancelar��54   8   $ Cancelar��6&   $? 9/Presentacion;component/Images/1344565469_Cancel__Red.png��6K   $$ Presione F1 para obtener ayuda��6�   $ Boton cancelar  ��6�   $ Cancela los Acciones  ��6�   {�.  62  55      	  56      .@�57      
  -   5        $��
rbReportes��57   >   $ Generar Reporte��6&   $B </Presentacion;component/Images/1344565499_custom-reports.png��6P   $$ Presione F1 para obtener ayuda��6�   $* $Para Generar un reporte presione F6 ��6�   $G AGenera un reporte de los registros que se muestran en el datgrid ��6  6_  58      59      5:      a� 5;   
   -   5        $��toolBarPanel1��5;   H   $��Stretch=�6   $��0,29,0,0q�66   $	��Top=�6]   �� 5<   
   -   5        $��lblRFC��5<   \   $��R.F.C.��6   $��27��6!   $
��Left=�6-   $��
12,130,0,0q�6H   $	��Top=�6j   $��89��6�   $��Normal"�6�   $��13(�6�   $��Normal&�6�   �� 5=   
   -   5        $��	lblNombre��5=   \   $��Nombre��6   $��28��6!   $
��Left=�6-   $��
14,194,0,0q�6H   $	��Top=�6m   $	��102��6�   $��Normal"�6�   $��13(�6�   $��Normal&�6�   �� 5>   
   -   5        $��lblTelefono��5>   ]   $��Colonia��6   $��24��6"   $
��Left=�6.   $��
14,330,0,0q�6I   $	��Top=�6p   $��97��6�   $��Normal"�6�   $��13(�6�   $��Normal&�6�   �� 5?   
   -   5        $��lblExtension��5?   \   $��Ciudad��6   $��24��6!   $
��Left=�6-   $��
14,400,0,0q�6H   $	��Top=�6p   $��94��6�   $��Normal"�6�   $��13(�6�   $��Normal&�6�   �� 5@   
   -   5        $��	lblCorreo��5@   ]   $��Estado��6   $��28��6!   $
��Left=�6-   $��358,130,0,0q�6H   $	��Top=�6n   $	��116��6�   $��Normal"�6�   $��13(�6�   $��Normal&�6�   �� 5A   
   -   5        $��	lblPuesto��5A   [   $
��C.P.��6   $��28��6   $
��Left=�6+   $��358,194,0,0q�6F   $	��Top=�6l   $	��102��6�   $��Normal"�6�   $��13(�6�   $��Normal&�6�   �� 5B   
   -   5        $��
lblEmpresa��5B   _   $��	Teléfono��6   $��25��6#   $
��Left=�6/   $��358,267,0,0q�6J   $	��Top=�6q   $��99��6�   $��Normal"�6�   $��13(�6�   $��Normal&�6�   �� 5C   
   -   5        $��lblCorre��5C   j   $��Correo Electrónico:��6   $��25��6.   $
��Left=�6:   $��362,330,0,0q�6U   $	��Top=�6z   $	��122��6�   $��Normal"�6�   $��13(�6�   $��Normal&�6�   �� 5E   
   -   5        $��txtRFC��5E   Z   $��25��6   $��1��6   $
��Left=�6+   $��
12,161,0,0q�6F   $	��Top=�6h   $	��220��6�    � ToolTip$ Rfc del proveedor��6�   {�.  6�   �� 5F   
   -   5        $��	txtNombre��5F   Z   $��25��6   $��2��6   $
��Left=�6+   $��
14,228,0,0q�6F   $	��Top=�6k   $	��220��6�   $# Nombre completo del proveedor��6�   {�.  6�   �� 5G   
   -   5        $��txtDireccion��5G   Z   $��25��6   $��3��6   $
��Left=�6+   $��
14,291,0,0q�6F   $	��Top=�6n   $	��220��6�   $$ Direccion actual del proveedor��6�   {�.  6�   �� 5H   
   -   5        $��
txtcolonia��5H   Z   $��25��6   $��4��6   $
��Left=�6+   $��
14,360,0,0q�6F   $	��Top=�6l   $	��220��6�   $- 'Colonia donde se encuentra el proveedor��6�   {�.  6�   �� 5I   
   -   5        $��	txtCiudad��5I   Z   $��25��6   $��5��6   $
��Left=�6+   $��
12,430,0,0q�6F   $	��Top=�6k   $	��220��6�   $+ %Ciudad donde se encuenta el proveedor��6�   {�.  6�   �� 5J   
   -   5        $��txtCodigoPostal��5J   [   $��25��6   $��7��6   $
��Left=�6+   $��362,228,0,0q�6F   $	��Top=�6r   $	��222��6�    �� 	MaxLength$ 5��6�   $! Codigo postal del proveedor��6�   {�.  6�   �� 5K   
   -   5        $��txtTelefono��5K   [   $��25��6   $��8��6   $
��Left=�6+   $��362,291,0,0q�6F   $	��Top=�6n   $	��220��6�   $ 15��6�   $% Numero telefonico del proveedor��6�   {�.  6�   �� 5L   
   -   5        $��	txtcorreo��5L   [   $��25��6   $��9��6   $
��Left=�6+   $��362,360,0,0q�6F   $	��Top=�6l   $	��220��6�   $&  Correo electronico del proveedor��6�   {�.  6�   �� 5N   
   -   5        $��cbestadopro��5N   \   $��23��6   $��6��6   $
��Left=�6,   $��362,161,0,0q�6G   $	��Top=�6o   $	��220��6�   $&  Estado donde habita el proveedor��6�   {�.  6�   &   System.Windows.Controls.DataGrid  5P   
   -    5        $��dtgProveedor��5P   �      AutoGenerateColumns .     CanUserAddRows .  $��
0,472,-1,0q�6m   $��Stretch=�6�      
IsReadOnly . $��14(�6�   $��Normal&�6  $ Datos del proveedor��6  {�.  ��6/   �� *misProveedores+   Columns 5Q      0  *System.Windows.Controls.DataGridTextColumn  5R      ,  &System.Windows.Controls.DataGridColumn   Header$ Clave��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 55 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Clave+6N     5S      $ R.F.C.��6%   $	 120 6M    65   �� *Rfc+6M     5T      $ Nombre��6%   $	 130 6P    65   �� *Nombre+6P     5U      $ Ciudad��6%   $	 130 6P    65   �� *Ciudad+6P     5V      $ 	Teléfono��6%   $	 130 6T    67   �� *
Telefono+6T     5W      $ Correo��6%   $ * 6P    65   �� *Correo+6P   5Y      �� 5Z   
   -!   5        $��label2��5Z   �   $��
Dirección��6   $��13(�6$   $��Normal&�62   $��Normal"�6G   $��28��6[   $
��Left=�6g   $��
14,264,0,0q�6�   $	��Top=�6�   $	��102��6�   5[      5\      