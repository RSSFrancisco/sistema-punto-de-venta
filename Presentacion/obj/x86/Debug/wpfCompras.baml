   M S B A M L   `   `   `  ����  Presentacion    Presentacion.wpfCompras   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Imy@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   	   ] YDivelements.SandRibbon, Version=2.0.1.2, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c38sr/http://schemas.divelements.co.uk/wpf/sandribbon  5      -   5          � Title$  COMPRAS��5   
   $	��698��6   $	��800��6'    � 
ResizeMode$ NoResize=�64   )  #Divelements.SandRibbon.RibbonWindow   
Appearance$ Office2010Blue=�6J    � Icon$5 //Presentacion;component/Images/1343953320_6.png��6�   $��14(�6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $+ %/ReuxablesLegacy;component/candy.xaml?�6%   %    5         	StatusBar 5      &   Divelements.SandRibbon.StatusBar  5   
      ExtendedControl 5      '  !Divelements.SandRibbon.StripPanel  5      -   5        $��strPanel��5       5      .@�5      �� -   5        $��
btnMensaje��5       $�� ��6   
�������
����  �6E   �� 5      -   5        $��lblTotal��5      $�� ��6   6   �� 5      5      .��5      � ���	#FFF8F8F8$��0 0 0 0q�6"   .+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��ribbon1��5   2   $��Stretch=�6   $	��Top=�6A   $��0 0 0 0q�6Y   $��14(�6j   ���	#FFE6FDFF.@�5      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $��Registro��6   .@�5      3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  .@�5       4  .Microsoft.Windows.Controls.Ribbon.RibbonButton  -   5        $��rbNuevoRegistro��5    �   	   Label$	 Nuevo��6&   
   LargeImageSource$@
 :/Presentacion;component/Images/1344565422_document-new.png��67      ToolTipFooterTitle$$ Presione F1 para obtener ayuda��6�      ToolTipTitle$ Genera un nuevo Registro��6�      ToolTipDescription$  Los registros se activan  ��6  5!        5"      .@�5#        -   5        $��rbCancelarProducto��5#   �   $	 Cancelar producto��6&   $A
 ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��6A   {�.  $$ Presione F1 para obtener ayuda��6�   $3 -Para Cancelar el producto presione tecla(F2) ��6�   $( "Cancela el producto seleccionado  ��6/  5$        5&      .@�5'        -   5        $��	rbGuardar��5'      $	 Guardar��6&   $8
 2/Presentacion;component/Images/1344565565_Save.png��66   {�.  $$ Presione F1 para obtener ayuda��6�   $ Boton Guardar��6�   $= 7Guarda los registros que ingrese en las cajas de texto ��6  5(      5)      5*      �� 5+   
   -	   5        $��tabControl1��5+   Q   $	��175��6   $
��Left=�6"   $��
11,398,0,0q�6=   $	��Top=�6d   $	��737��6|   .@�5,      �� -
   5        $��	Productos��5,   (   $��Produtos��6   .��5-      � $	��155��6   .+�5.      &   System.Windows.Controls.DataGrid  -   5        $��dtgProductos��5.   �      HorizontalGridLinesBrush
 � � �   VerticalGridLinesBrush
 �  ��   AutoGenerateColumns .     
IsReadOnly . $	��146��6�   $
��Left=�6�   $	��Top=�6�   $	��727��6�   ��6�   �� *
miProducto+   Columns 5/      0	  *System.Windows.Controls.DataGridTextColumn	  50      ,
  &System.Windows.Controls.DataGridColumn 
  Header$ Cant.��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *
Cantidad+	  51      $ Clave��61    
  Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6Z    6@   �� *Clave+6Z   	  52      $ Producto��61   $	 300 6c    6C   �� *Descripcion+6c   	  53      $ 
P.Unitario��61   $	 100 6h    6E   �� *PrecioUnitario+6h   	  54      $ Importe��61   $	 100 6^    6B   �� *	Importe+6^   56      57      59      5:      �� 5;   
   -   5        $��	groupBox1��5;   O   $	��235��6   $
��Left=�6    $��
11,143,0,0q�6;   $	��Top=�6`   $	��747��6x   .��5<      � .+�5=      �� -   5        $��txtClave��5=   U   $��25��6   $
��Left=�6&   $��
119,79,0,0q�6A   $	��Top=�6e   $	��139��6}   {�.  6�   �� 5>      -   5        $��label3��5>   g   $��
Proveedor:��6   $��28��6-   $
��Left=�69   $��	10,44,0,0q�6T   $	��Top=�6u   �� 5?      -   5        $��cmbProveedor��5?   W   $��23��6   $��Right=�6'   $��
0,44,113,0q�6C   $	��Top=�6k   $	��542��6�   {�.  ��5@      �� 5A      .R�5B      ��  �� Orientation$ 
Horizontal=�6)   .+�5C   "   �� $	��200��6I   ��6,   ��  �� Path$ Nombre�6I   5D      5E      5G      �� 5H      -   5        $��label2��5H   n   $��Codigo de Barras:��6   $��28��64   $
��Left=�6@   $��	10,80,0,0q�6[   $	��Top=�6|   �� 5I      -   5        $��lblFolio��5I   c   $��Folio:��6   $��28��6)   $
��Left=�65   $��	12,10,0,0q�6P   $	��Top=�6s   �� 5J      -   5        $��txtFolio��5J   T   $��23��6   $
��Left=�6&   $��	80,15,0,0q�6A   $	��Top=�6d   $	��120��6|   �� 5K      -   5        $��label1��5K   j   $��Descripción:��6   $��28��6/   $
��Left=�6;   $��
10,112,0,0q�6V   $	��Top=�6x   �� 5L      -   5        $��txtDescripcion��5L   U   $��23��6   $
��Left=�6&   $��
80,114,0,0q�6A    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��649��6�   {�.  6�   �� 5M      -   5        $��label4��5M   f   $��Precio:��6   $��28��6*   $
��Left=�66   $��235,191,0,0q�6Q   $	��Top=�6t   �� 5N      -   5        $��txtPrecioUnitario��5N   W   $��23��6   $��Right=�6&   $��0,191,370,0q�6B   $
 Wrap=�6p   $	��Top=�6�   $��77��6�   {�.  6�   �� 5O      -   5        $��label5��5O   f   $��Total:��6   $��28��6)   $��Right=�65   $��0,191,280,0q�6Q   $	��Top=�6t   �� 5P      -   5        $��txtTotal��5P   V   $��23��6   $
��Left=�6&   $��471,191,0,0q�6A   $	��Top=�6f   $	��139��6~   {�.  6�   �� 5Q      -   5        $��label7��5Q   g   $��	Cantidad:��6   $��28��6,   $
��Left=�68   $��
12,191,0,0q�6S   $	��Top=�6u   �� 5R      -   5        $��txtCantidad��5R   U   $��23��6   $
��Left=�6&   $��
80,191,0,0q�6A   $	��Top=�6h   $	��139��6�   {�.  6�   �� 5S      -   5        $��
btnAgregar��5S   g   $��Agregar��6   $��23��6+   $
��Left=�67   $��636,191,0,0q�6R   $	��Top=�6y   $��89��6�   {�.  6�   (  "System.Windows.Controls.DatePicker  5T      -   5        $��dtFechaCompra��5T   Y   $��25��6   $��Right=�6)   $��
0,11,279,0q�6E   $	��Top=�6n   $	��119��6�   {�.  6�   �� 5U      -   5        $��label8��5U   n   $��Fecha de compra:��6   $��28��63   $
��Left=�6?   $��
219,10,0,0q�6Z   $	��Top=�6|   $	��116��6�   5V      5W      �� 5X   
   -   5         ��Name$ label��5X      $��Existencia:��6   $
��Left=�65   $��
42,291,0,0q�6P   $	��Top=�6d   �� 5Y   
   -   5         ��Name$ txtExistencia��5Y      $
��Left=�6)   $��23��6D   $��104,288,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   {�.  6�   �� 5Z   
   -    5        $ label9��5Z      $��Defectuoso:��6    $
��Left=�66   $��312,288,0,0q�6Q   $	��Top=�6f   �� 5[   
   -!   5        $ txtDefectuoso��5[      $
��Left=�6)   $��23��6D   $��389,288,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   {�.  6�   �� 5\   
   -"   5        $ label10��5\      $��Total a Pagar:��6#   $
��Left=�6<   $��296,574,0,0q�6W   $	��Top=�6l   $��30��6�   $	��114��6�   $��18(�6�   $
��Bold"�6�   ���	#FFCB1010���	#FFD82020{�.  6�   �� 5]   
   -#   5        $ txtPagar��5]      $
��Left=�6$   $��31��6?   $��431,573,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   ���	#FF47BB24$
��Bold"�6�   $��18(�6�   {�.  6�   �� 5^   
   -$   5        $ label11��5^      $	��MXN��6!   $
��Left=�6/   $��407,334,0,0q�6J   $	��Top=�6_   5`      5a      