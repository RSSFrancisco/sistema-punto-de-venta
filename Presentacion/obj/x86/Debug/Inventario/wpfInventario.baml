   M S B A M L   `   `   `  ����`  \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon  5   
   G CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentacion.InventarioPresentacion.Inventario 5   	   +   %Presentacion.Inventario.wpfInventario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   aribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     5   
   7local%clr-namespace:Presentacion.Inventario     5   	   -   5          � Title$  
INVENTARIO��5	   	   $	��650��6    � WindowStartupLocation$ CenterScreen=�6)    � ShowInTaskbar . $	��800��6c   $��14(�6�    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $+ %/ReuxablesLegacy;component/candy.xaml?�6%   %    5      .��5      � $��0,0,0,1q�6   .+�5   
   .   (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��ribbon1��5      $��Stretch=�6'      CheckedBackground �	#FFCE6A6A$��0 0 0 0q�6d   $	��Top=�6w   ���	#CAC7F4FB���	#FFC5C5C5$��13(�6�   .@�5      1   +Microsoft.Windows.Controls.Ribbon.RibbonTab  $��Registro��6   .@�5      3   -Microsoft.Windows.Controls.Ribbon.RibbonGroup  .@�5      4   .Microsoft.Windows.Controls.Ribbon.RibbonButton  -   5        $��	rbGuardar��5   w      Label$ Guardar��6*      LargeImageSource$- '/Presentacion;component/Images/save.png��6:   	   ToolTipFooterTitle$$	 Presione F1 para obtener ayuda��6�   
   ToolTipTitle$1
 +Para Guardar presione la tecla(RightShift) ��6�      ToolTipDescription$= 7Guarda los registros que ingrese en las cajas de texto ��6  $��13(�6]  5        5      .@�5        -   5        $��rbCancelarProducto��5   �   $ Cancelar producto��6*   $A ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��6]   {�.  $$	 Presione F1 para obtener ayuda��6�   $3
 -Para Cancelar el producto presione tecla(F2) ��6  $( "Cancela el producto seleccionado  ��6K  $��13(�6�  5      5      5      �� 5    
   -   5        $��txtClave��5    N   $��35��6   $
��Left=�6   $��
13,222,0,0q�6:   $	��Top=�6^   $	��205��6v   
����������	#FF34200F$��16(�6�   $
��Bold"�6�   
 � Tag$ 1��6�   $��Segoe UI Symbol)�6�   6�   �� 5!   
   -   5        $��cmbEmpleado��5!   O   $��23��6   $
��Left=�6   $��418,167,0,0q�6:   $	��Top=�6b   $	��222��6z   $��Segoe UI Symbol)�6�   $��14(�6�   $
��Bold"�6�   ��5"      �� 5#      .R�5$      ��  �� Orientation$ 
Horizontal=�6!   .+�5%      �� $	��200��6A   ��6$   ��  �� Path$ Nombre�6A   5&      5'      5)      �� 5*   
   -   5        $��	groupBox1��5*   i   $��Datos de cliente��6   $��57��6-   $
��Left=�69   $��212,143,0,0q�6T   $	��Top=�6z   $	��189��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   .��5+      � .+�5-      �� -   5        $��
cmbEmpresa��5-   S   $��23��6   $
��Left=�6'   $��9,5,0,0q�6B   $	��Top=�6e   $	��161��6}   ��5.      �� 5/      .R�50      �� $ 
Horizontal=�6)   .+�52   "   �� $	��200��6I   ��6,   �� $ Nombre�6I   53      54      56      57      58      �� 59   
   -	   5        $��label2��59   e   $��Buscar Producto��6   $��28��6*   $
��Left=�66   $��
13,203,0,0q�6Q   $	��Top=�6s   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   �� 5:   
   -
   5        $��	groupBox2��5:   `   $��	N° Venta��6   $��57��6%   $
��Left=�61   $��
13,143,0,0q�6L   $	��Top=�6q   $	��194��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   .��5;      �  � ColumnDefinitions 5<      �� 5=      $��2* �6'   �� 5>      $��7* �6'   .+�5@      �� -   5        $��txtNumVenta��5@   A   $��27��6   $
��Left=�6&   $	��Top=�6T   $	��172��6l   {�.  $��0,3,0,0q�6�   $��2��6�   5A      5B      �� 5C   
   -   5         ��Name$ 
grBAtendio��5C   `   $��Atendio��6   $��57��6$   $
��Left=�60   $��406,142,0,0q�6K   $	��Top=�6t   $	��367��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   .��5D      � 5E      �� 5F   
   -   5         ��Name$ lblCantidadProductos��5F      $��Cantidad producto��6.   $
��Left=�6J   $��
13,268,0,0q�6e   $	��Top=�6y   $	��133��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   �� 5G   
   -   5         ��Name$ txtCantidadProducto��5G      $
��Left=�6/   $��35��6J   $��
13,287,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $�� ��6   $	��Top=�6�   $	��205��6�   $��Segoe UI Symbol)�6�   $
��Bold"�6   $��20(�6  �� 5H   
   -   5        $ grbDetallaProducto��5H   n   $��Detalle del producto��6   $	��174��61   $
��Left=�6>   $��478,202,0,0q�6Y   $	��Top=�6�   $	��291��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Semibold)�6�   .��5I      �� 
���   �$��1q�6)   $
��Left=�6=   $	��141��6X   $��10,4,0,0q�6e   $	��Top=�6w   $	��132��6�   ._�5J      �� -   5         ��Name$ imgProducto��5J      5K      5L      �� 5M   
   -   5        $ 
txtBarcode��5M      $
��Left=�6&   $��23��6A   $��632,231,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��126��6�   {�.  6�   �� 5N   
   -   5        $ txtNombreProducto��5N      $
��Left=�6-   $��23��6H   $��632,259,0,0q�6T   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��126��6�   {�.  6�   �� 5O   
   -   5        $ txtPrecioProducto��5O      $
��Left=�6-   $��23��6H   $��632,287,0,0q�6T   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��126��6�   {�.  6�   &   System.Windows.Controls.DataGrid  5P   
   -   5          Name$ dtgProductos��5P   W      AutoGenerateColumns .     
IsReadOnly . $��-1,382,1,45q�6B   $��13(�6�   $
��Bold"�6�   $��Segoe UI Semibold)�6�   $��Stretch=�6	  $��Stretch=�6,  ��6o   �� *misProductosventa+   Columns 5Q      0  *System.Windows.Controls.DataGridTextColumn  5R      ,  &System.Windows.Controls.DataGridColumn   Header$ Cantidad��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Cantidad+  5S      $ Nombre��6%      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 150	 6R    65   �� *
NombrePV+6R     5T      $ Barcode��6%   $	 150	 6W    66   �� *CodigoBarras+6W     5U      $ Descripción��6%   $	 200	 6\    6:   �� *DescripcionPV+6\     5V      $ Precio��6%   $	 100	 6Z    65   �� *PrecioUnitarioPV+6Z     5W      $ Subtotal��6%   $	 100	 6T    67   �� *
SubTotal+6T   5Y      �� 5Z   
   -   5         ��Name$ stbBarraEstado��5Z   3   $��Stretch=�6   ���	#FFF4FFFE���	#FFA8A8A8$��Center=�6z   $��	0,521,0,0q�6�   $��Bottom=�6�   .@�5[      �� -   5        $ 
lblImporte��5[      $��IMPORTE��6(   $
��Left=�6:   $	��Top=�6U   $��14(�6m   $
��Bold"�6{   $��Segoe UI Symbol)�6�   �� 5\      -   5        $ 
txtImporte��5\      $
��Left=�6*   $
 Wrap=�6F   $�� ��6Z   $	��Top=�6b   $	��115��6z   ���	#FF111111
�������$��30(�6�   $��Segoe UI Symbol)�6�   �� 5]      -   5        $ 	lblCambio��5]      $��CAMBIO��6'   $
��Left=�68   $	��Top=�6T    J� RenderTransformOrigin$ 0.822,0.562&�6l   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   �� 5^      -   5        $ txtCambioVenta��5^      $
��Left=�6.   $
 Wrap=�6K   $�� ��6_   $	��Top=�6g   $	��115��6   ���	#FF111111
�������$��30(�6�   {�.  $��Segoe UI Symbol)�6�   �� 5_      -   5        $ lblTotalPagar��5_      $��TOTAL A PAGAR��6+   $
��Left=�6C   $	��Top=�6^   $
��Bold"�6v   $��14(�6�   $��Segoe UI Symbol)�6�   �� 5`      -   5        $ txtTotalAPagar��5`      $
��Left=�6.   $
 Wrap=�6K   $�� ��6_   $	��247��6g   ���	#FF111111$��30(�6�   ���	#FF59FD8D$
��Bold"�6�   {�.  $��Segoe UI Symbol)�6�   $	��Top=�6�   $��Stretch=�6  5b      �� 5c   
   -   5         ��Name$ lvProductosEncontrados��5c      $
��Left=�64   $	��162��6O   $��224,213,0,0q�6\   $	��Top=�6q   $	��250��6�   
���������.  $
��Auto=�6/  $
��Auto=�6a  ��6�   �� *misProductos+ �� View 5d      �� 5e      .P�5f      �� $��Nombre del producto��6%     �� DisplayMemberBinding  5g      �� *Nombre+�� 5h      $��Precio��6%   ! �� Width$! 60��5i   B     6   �� *PrecioUnitario+6B   5k      5n      5o      5p      