   M S B A M L   `   `   `  ����  Presentacion    Presentacion.wpfProducto   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ] YDivelements.SandRibbon, Version=2.0.1.2, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c38sr/http://schemas.divelements.co.uk/wpf/sandribbon  5   	   Z VWPFToolkit.Extended, Version=1.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[
extToolkitJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended  5   	   Imy@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   }   ?telerik1http://schemas.telerik.com/2008/xaml/presentation  6�   -   5          � Title$  	PRODUCTOS��5   	   $	��700��6   $	��900��6(    � WindowStyle$ ThreeDBorderWindow=�64    � WindowStartupLocation$ CenterScreen=�6V    � ShowInTaskbar . 
������� � Icon$@ :/Presentacion;component/Images/1344565183_deliverables.png��6L  )  #Divelements.SandRibbon.RibbonWindow   
Appearance$ Office2010Blue=�6�  $��14(�6�   � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $+ %/ReuxablesLegacy;component/candy.xaml?�6%   %    5      .��5      � $��0 0 0 0q�6   ���	#FFFFFCFC.+�5   
   a� -   5        $��toolBarPanel1��5   G   $��Stretch=�6   $��0,0,0,0q�66   $	��Top=�6\   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  5   
   -   5        $��ribbon1��5   D   $��0 0 0 0q�6   $��Stretch=�6%   $	��Top=�6S   ���	#CAC7F4FB$��14(�6�   	   ApplicationMenu	 5      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5      ���	#FF1C9D6B8  2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton
   SmallImageSource$@
 :/Presentacion;component/Images/1344565183_deliverables.png��6B    o� 
IsMainMenu .  .@�5      A  ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5          Name$ 	MenuItem1��5   E   $��Ayuda...��63   6E     5      -   5        $ rbInformacion��5   T   $��Información del Sistema��63   6T   5      .@�5      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $��Registro��6   .@�5      3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  .@�5      4  .Microsoft.Windows.Controls.Ribbon.RibbonButton  -   5        $��rbNuevoRegistro��5   �      Label$ Nuevo��6&      LargeImageSource$@ :/Presentacion;component/Images/1344565422_document-new.png��67      ToolTipFooterTitle$$ Presione F1 para obtener ayuda��6�      ToolTipTitle$ Genera un nuevo Registro��6�      ToolTipDescription$  Los registros se activan  ��6�   $��14(�6G  5        5      .@�5        -   5        $��	rbGuardar��5   6   $ Guardar��6&   $- '/Presentacion;component/Images/save.png��6G   {�.  $$ Presione F1 para obtener ayuda��6�   $ Boton Guardar��6�   $= 7Guarda los registros que ingrese en las cajas de texto ��6   $��14(�6M  5        5       .@�5!        -   5        $��
rbEliminar��5!   �   $ Eliminar��6&   $A ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��67   {�.  $$ Presione F1 para obtener ayuda��6�   $&  Para Eliminar presione (Delete) ��6�   $+ %Elimina los Registros seleccionados  ��6(  $��14(�6c  5"        5#      .@�5$        -	   5        $��rbActualizar��5$   �   $ 
Actualizar��6&   $J D/Presentacion;component/Images/1344567350_system-software-update.png��69   {�.  $$ Presione F1 para obtener ayuda��6�   $" Para Actualizar presione F5 ��6  $, &Actualiza los registros seleccionados ��63  $��14(�6o  5%        5&      .@�5'        -
   5        $��
rbCancelar��5'   8   $ Cancelar��6&   $? 9/Presentacion;component/Images/1344565469_Cancel__Red.png��6K   $$ Presione F1 para obtener ayuda��6�   $ Boton cancelar  ��6�   $ Cancela los Acciones  ��6�   {�.  $��14(�6C  5(        5)      .@�5*        -   5        $��	rbLimpiar��5*   7   $ Limpiar��6&   $> 8/Presentacion;component/Images/1344567506_edit-clear.png��6I   $$ Presione F1 para obtener ayuda��6�   $ Limpia los registros  ��6�   $��14(�6  5+        5,      .@�5-        -   5        $��
rbReportes��5-   >   $ Generar Reporte��6&   $B </Presentacion;component/Images/1344565499_custom-reports.png��6P   {�.  $$ Presione F1 para obtener ayuda��6�   $ Generar reportes ��6�   $P JGenera un reporte de los registros que se muestran en la ventana Empleado ��6  $��14(�6�  5.      50      51      &	   System.Windows.Controls.DataGrid	  52   
   -   5        $��dtgProducto��52   �    	  AutoGenerateColumns .  $��Stretch=�6/   $��Stretch=�6q   $��
1,409,0,40q�6�    	  
IsReadOnly . {�.  $��14(�6
  ��6K   �� *misProductos+ 	  Columns 53      0
  *System.Windows.Controls.DataGridTextColumn
  55      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 6%      Header$ Nombre��62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Nombre+
  56      $	 125 6%   $ Marca��61    6@   �� *Marca+
  57      $	 200 6%   $ Descripción��61    6F   �� *Descripcion+
  58      $ Precio��6%    65   �� *PrecioUnitario+
  59      $	 150 6%   $ 	Proveedor��61    6D   �� *Idproveedor+
  5:      $ Fecha de compra��6%    6>   �� *FechaCompra+5<      �� 5=   
   -   5        $��stbBarraEstado��5=   O   $��40��6   $��Stretch=�6    $��0,0,0,0q�6>   $��Bottom=�6e   ���	#FFF4FFFE���	#FFAAA9A9.@�5>      �� -   5         ��Name$ btnPrimerPagina��5>   !   $��30��6   $��<<��6:   $��25��6M    J� RenderTransformOrigin$ 1.493,14.222&�6X   $
��Bold"�6~   $��Right=�6�   $��Center=�6�   $��17(�6�   �� 5?      -   5        $ btnPaginaAnterior��5?   !   $��30��6   $��<��6<   $��25��6K   $ 1.493,14.222&�6V   $
��Bold"�6|   $��Right=�6�   $��Center=�6�   $��17(�6�   �� 5@      -   5         ��Name$ cmbNumeroPaginas��5@   #   $��30��6   $��0,0,0,0q�6=   $��50��6O   $
��Bold"�6Z   $��Right=�6l   $��Center=�6�   6�   �� 5A      -   5        $ btnPaginaSiguiente��5A   !   $��30��6   $��>��6=   $��25��6L   $ 1.493,14.222&�6W   $
��Bold"�6}   $��Right=�6�   $��Center=�6�   $��17(�6�   �� 5B      -   5        $ btnUltimaPagina��5B   !   $��30��6   $��>>��6:   $��25��6M   $ 1.493,14.222&�6X   $
��Bold"�6~   $��Right=�6�   $��Center=�6�   $��17(�6�   �� 5C      -   5        $��
btnMensaje��5C   ,   $��30��6   $�� ��6!   ���	#FF2D8340$
��Bold"�6V   ���	#FFFDFDFD$��14(�6   �� 5D      -   5        $��lblTotal��5D   +   $��30��6   $�� ��6    6+   1  +Microsoft.Windows.Controls.WatermarkTextBox  5E      -   5        $��txtBuscarProducto��5E   ,      	Watermark$P JBUSCAR PRODUCTO POR CODIGO DE BARRAS, NOMBRE, MARCA, DESCRIPCIÓN O PRECIO��6E   $��Center=�6�   $��1��6�   $ 
1.25,0.708&�6�   $��14(�6  $	��571��6  5I      �� 5J   
   -   5        $��
lblMensaje��5J   U   $�� ��6   $��26��6   $
��Left=�6'   $��	1,836,0,0q�6B   $	��Top=�6g   $	��777��6   ���	#FF311E1E{�. ��5K      �� 5L       �� EndPoint$ 1,0.5&�6&    �� 
StartPoint$ 0,0.5&�67   .��5M      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5N      $ 	#FF81FFFF��6#   $ 1Q�65   5O      5Q      �� 5R   
   -   5        $��	groupBox1��5R   X   $�� ��6   $	��276��6   $
��Left=�6*   $��	1,128,0,0q�6E   $	��Top=�6i   $	��891��6�   
�������.��5S      � ���	#FFFCFCFC$��
-3,-11,1,0q�6*   .+�5T      �� -   5        $��	lblNombre��5T   b   $��Nombre��6   $��26��6)   $
��Left=�65   $��25,7,0,0q�6P   $	��Top=�6s   $��56��6�   �� 5U      -   5        $��lblMarca��5U   b   $��Marca��6   $��26��6(   $
��Left=�64   $��	25,58,0,0q�6O   $	��Top=�6r   $��56��6�   �� 5V      -   5        $��lblDescripcion��5V   j   $��Descripción��6   $��26��6/   $
��Left=�6;   $��
25,112,0,0q�6V   $	��Top=�6�   $��71��6�   �� 5W      -   5        $��label1��5W   f   $��	Proveedor��6   $��26��6,   $
��Left=�68   $��	435,7,0,0q�6S   $	��Top=�6t   $��71��6�   �� 5X      -   5        $��lblFechadecompra��5X   m   $��Fecha de compra��6   $��26��62   $
��Left=�6>   $��
435,58,0,0q�6Y   $	��Top=�6�   $	��120��6�   �� 5Y      -   5        $��	txtNombre��5Y   a   $��28��6   $��2��6&   $
��Left=�63   $��	25,26,0,0q�6N   $	��Top=�6r   $	��207��6�   {�.  6�   �� 5Z      -   5        $��txtMarca��5Z   a   $��28��6   $��3��6&   $
��Left=�63   $��	25,78,0,0q�6N   $	��Top=�6q   $	��207��6�   {�.  6�   �� 5[      -    5        $��txtDescripcion��5[   b   $��45��6   $��4��6&   $
��Left=�63   $��
25,136,0,0q�6N     �� TextAlignment$  Justify=�6x   &   System.Windows.Media.TextOptions!   TextFormattingMode$! Ideal=�6�   " �� TextWrapping$
" Wrap=�6�   $	��Top=�6�   $	��207��6�   {�.  6�   �� 5\      -!   5        $��cmbProveedor��5\   c   $��29��6   $��7��6'   $
��Left=�64   $��
435,25,0,0q�6O   $	��Top=�6w   $	��220��6�   {�.  ��5]      �� 5^      .R�5_      �� # �� Orientation$# 
Horizontal=�6)   .+�5`   "   �� $	��200��6I   ��6,   �� $ �� Path$$ Nombre�6I   5a      5b      5d      (  "System.Windows.Controls.DatePicker  5e      -"   5        $��dtFechaCompra��5e   e   $��28��6   $��8��6)   $
��Left=�66   $��
436,78,0,0q�6Q   $	��Top=�6z   $	��219��6�   {�.  6�   �� 5f      -#   5        $��cmbCategoria��5f   d   $��29��6   $��9��6'   $
��Left=�64   $��435,135,0,0q�6O   $	��Top=�6x   $	��220��6�   {�.  ��5g      �� 5h      .R�5i      �� $# 
Horizontal=�6)   .+�5j   "   �� $	��200��6I   ��6,   �� $$ Nombre�6I   5k      5l      5n      �� 5o      -$   5        $��lblCategoria��5o   h   $��
Categoría��6   $��21��6,   $
��Left=�68   $��435,112,0,0q�6S   $	��Top=�6|   $��71��6�   �� 5p      -%   5        $��label2��5p   d   $��Precio��6   $��26��6)   $
��Left=�65   $��
27,187,0,0q�6P   $	��Top=�6r   $��71��6�   �� 5q      -&   5        $��txtPreciounitario��5q   b   $��28��6   $��4��6&   $
��Left=�63   $��
25,209,0,0q�6N   $	��Top=�6{   $	��207��6�   {�.  6�   �� 5r      -'   5        $��btnCategorias��5r   v   $��Agregar otra categoría��6   $��28��6:   $
��Left=�6F   $��436,165,0,0q�6a   $	��Top=�6�   $	��219��6�   6�   �� 5s      -(   5        $ btnAgregarImagen��5s      $��6��63   $��Imagen ��6@   $
��Left=�6R   $��
250,26,0,0q�6m   $	��Top=�6�   $	��161��6�   $��28��6�   6�   �� 5t      -)   5        % ��Name$% imgImagenProducto��5t      $
��Left=�63   $	��143��6N   $��
250,59,0,0q�6[   $	��Top=�6o   $	��161��6�   $��Uniform=�6�   $%��Images/iconoProductoDefault.png��6�   & J� OpacityMask& 5u      �� 5v      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5w      � $ 	#FF839091��6+   $ 0Q�6=   � 5x      $ 	#FFAAD4E8��6+   $ 1Q�6=   � 5y      $ 	#FF90CEEC��6+   $	 0.9Q�6=   5z      5|      �� 5}      
���   �$��1q�6-   $
��Left=�6A   $	��143��6\   $��
250,59,0,0q�6i   $	��Top=�6}   $	��161��6�   �� 5~      -*   5        ' ��Name$' txtRutaImagen��5~      $
��Left=�61   $��28��6L   $��250,209,0,0q�6X   $
" Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��161��6�   {�.  6�   �� 5      -+   5        ( ��Name$( label��5      $��Stock Minimo��6'   $
��Left=�6>   $��436,192,0,0q�6Y   $	��Top=�6n   �� 5�      -,   5        $' txtStockMinimo��5�      $��10��62   $
��Left=�6@   $��27��6[   $��436,210,0,0q�6g   $
" Wrap=�6|   $	��Top=�6�   $	��219��6�   ) � ToolTip$<) 6Ingresa la cantidad minima que puede tener el producto��6�   �� 5�      --   5        $( label3��5�      $��Stock Maximo��6(   $
��Left=�6?   $��	674,7,0,0q�6Z   $	��Top=�6m   $	��107��6�   �� 5�      -.   5        $' txtStockMaximo��5�      $��11��62   $
��Left=�6@   $��26��6[   $��
674,28,0,0q�6g   $
" Wrap=�6{   $	��Top=�6�   $	��186��6�   $>) 8Ingresa la cantidad maxima que puede tener este producto��6�   �� 5�      -/   5        $' txtExistencia��5�      $��12��61   $
��Left=�6?   $��29��6Z   $��
675,77,0,0q�6f   $
" Wrap=�6z   $	��Top=�6�   $	��185��6�   �� 5�      -0   5        $( lblExistencia��5�      $��
Existencia��6/   $
��Left=�6D   $��
675,58,0,0q�6_   $	��Top=�6s   �� 5�      -1   5        $( lblCodigoBarras��5�      $��Codigo de Barras��61   $
��Left=�6L   $��675,112,0,0q�6g   $	��Top=�6|   $	��106��6�   �� 5�      -2   5        $' txtCodigoBarras��5�      $��13��63   $
��Left=�6A   $��29��6\   $��675,136,0,0q�6h   $
" Wrap=�6}   $�� ��6�   $	��Top=�6�   $	��185��6�   �� 5�      -3   5        $( lblValNombre��5�      $�� ��6.   $
��Left=�69   $��6,17,0,0q�6T   $	��Top=�6f   $��20��6~   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -4   5        $( lblValMarca��5�      $�� ��6-   $
��Left=�68   $��6,70,0,0q�6S   $	��Top=�6e   $��20��6}   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -5   5        $( lblValDescripcion��5�      $�� ��63   $
��Left=�6>   $��	6,136,0,0q�6Y   $	��Top=�6l   $��20��6�   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -6   5        $( lblValPrecio��5�      $�� ��6.   $
��Left=�69   $��	6,198,0,0q�6T   $	��Top=�6g   $��20��6   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -7   5        $( lblValCodigoBarras��5�      $�� ��64   $
��Left=�6?   $��658,130,0,0q�6Z   $	��Top=�6o   $��20��6�   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -8   5        $( lblValExistencia��5�      $�� ��62   $
��Left=�6=   $��
658,71,0,0q�6X   $	��Top=�6l   $��20��6�   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -9   5        $( lblValFecha��5�      $�� ��6-   $
��Left=�68   $��
416,71,0,0q�6S   $	��Top=�6g   $��20��6   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -:   5        $( lblValProveedor��5�      $�� ��61   $
��Left=�6<   $��
415,17,0,0q�6W   $	��Top=�6k   $��20��6�   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -;   5        $( lblValCategoria��5�      $�� ��61   $
��Left=�6<   $��416,130,0,0q�6W   $	��Top=�6l   $��20��6�   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -<   5        $( lblValStockMinimo��5�      $�� ��63   $
��Left=�6>   $��415,201,0,0q�6Y   $	��Top=�6n   $��20��6�   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      -=   5        $( lblValStockMaximo��5�      $�� ��63   $
��Left=�6>   $��
658,21,0,0q�6Y   $	��Top=�6m   $��20��6�   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   �� 5�      ->   5        $( lblValImagen��5�      $�� ��6.   $
��Left=�69   $��
234,17,0,0q�6T   $	��Top=�6h   $��20��6�   
����������	#FFFB1111$��40(�6�   $��37��6�   $ 	0.5,0.081&�6�   5�      5�      5�      5�      