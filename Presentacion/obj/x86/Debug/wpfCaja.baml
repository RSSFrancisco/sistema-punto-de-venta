   M S B A M L   `   `   `  ����`  \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon  5       Presentacion   Presentacion.wpfCaja   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      aribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     5      -   5          � Title$
  CAJA��5      $	��650��6    � WindowStartupLocation$ CenterScreen=�6"   $	��800��6G   #��["��6U    � ShowInTaskbar .  � Icon$A ;/Presentacion;component/Images/1344563647_cash_register.png��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $+ %/ReuxablesLegacy;component/candy.xaml?�6%   %    5      .��5      � $��0,0,0,1q�6   ���	#FFFDFDFD.+�5   
   .   (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��ribbon1��5      $��Stretch=�6'      CheckedBackground �	#FFCE6A6A$��0 0 0 0q�6d   $	��Top=�6w   ���	#CAC7F4FB���	#FFC5C5C5$��13(�6�   .@�5!      1   +Microsoft.Windows.Controls.Ribbon.RibbonTab  $��Registro��6   .@�5#      3   -Microsoft.Windows.Controls.Ribbon.RibbonGroup  .@�5$      4   .Microsoft.Windows.Controls.Ribbon.RibbonButton  -   5        $��	rbGuardar��5$   }      Label$ Generar venta��6*   	   LargeImageSource$-	 '/Presentacion;component/Images/save.png��6@   
   ToolTipFooterTitle$$
 Presione F1 para obtener ayuda��6�      ToolTipTitle$: 4Para Guardar la venta presione la tecla(RightShift) ��6�      ToolTipDescription$= 7Guarda los registros que ingrese en las cajas de texto ��6  $��13(�6l  5%        5&      .@�5'        -   5        $��rbCancelarProducto��5'   �   $ Cancelar producto��6*   $A	 ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��6]   {�.  $$
 Presione F1 para obtener ayuda��6�   $3 -Para Cancelar el producto presione tecla(F2) ��6  $( "Cancela el producto seleccionado  ��6K  $��13(�6�  5(        5)      .@�5*        -   5        $��rbDevoluciones��5*   �   $  Devolución de producto(s)��6*   $2	 ,/Presentacion;component/Images/ganancias.png��6L   {�. $$
 Presione F1 para obtener ayuda��6�   $R LPara realizar una devolución de uno o más productos presione la tecla(F3) ��6�   $+ %devolución de productos ya vendidos ��6C  $��13(�6�  5+      5,      5-      �� 5.   
   -   5        $��txtClave��5.   [   $��35��6   $��1��6   $
��Left=�6,   $��
13,222,0,0q�6G   $	��Top=�6k   $	��205��6�   
����������	#FF34200F$��16(�6�   $
��Bold"�6�   
 � Tag$ 1��6$  $��Segoe UI Symbol)�6,  �� 5/   
   -   5        $��cmbEmpleado��5/   O   $��23��6   $
��Left=�6   $��418,167,0,0q�6:   $	��Top=�6b   $	��222��6z   $��Segoe UI Symbol)�6�   $��14(�6�   $
��Bold"�6�   ��50      �� 51      .R�52      ��  �� Orientation$ 
Horizontal=�6!   .+�53      �� $	��200��6A   ��6$   ��  �� Path$ Nombre�6A   54      55      57      �� 58   
   -   5        $��	groupBox1��58   i   $��Datos de cliente��6   $��57��6-   $
��Left=�69   $��212,143,0,0q�6T   $	��Top=�6z   $	��189��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   .��59      � .+�5;      �� -	   5        $��
cmbEmpresa��5;   S   $��23��6   $
��Left=�6'   $��9,5,0,0q�6B   $	��Top=�6e   $	��161��6}   ��5<      �� 5=      .R�5>      �� $ 
Horizontal=�6)   .+�5@   "   �� $	��200��6I   ��6,   �� $ Nombre�6I   5A      5B      5D      5E      5F      �� 5G   
   -
   5        $��label2��5G   f   $��Codigo de barras��6   $��28��6+   $
��Left=�67   $��
13,203,0,0q�6R   $	��Top=�6t   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   �� 5H   
   -   5        $��	groupBox2��5H   `   $��	N° Venta��6   $��57��6%   $
��Left=�61   $��
13,143,0,0q�6L   $	��Top=�6q   $	��194��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   .��5I      �  � ColumnDefinitions 5J      �� 5K      $��2* �6'   �� 5L      $��7* �6'   .+�5N      �� -   5        $��txtNumVenta��5N   A   $��27��6   $
��Left=�6&   $	��Top=�6T   $	��172��6l   {�.  �� 
IsReadOnly . $��0,3,0,0q�6�   $��2��6�   5O      5P      �� 5Q   
   -   5         ��Name$ 
grBAtendio��5Q   `   $��Atendio��6   $��57��6$   $
��Left=�60   $��406,142,0,0q�6K   $	��Top=�6t   $	��376��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   .��5R      � 5S      �� 5T   
   -   5         ��Name$ lblCantidadProductos��5T      $��Cantidad producto��6.   $
��Left=�6J   $��
13,268,0,0q�6e   $	��Top=�6y   $	��133��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   �� 5U   
   -   5         ��Name$ txtCantidadProducto��5U      $
��Left=�6/   $��35��6J   $��
13,287,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $�� ��6   $	��Top=�6�   $	��205��6�   $��Segoe UI Symbol)�6�   $
��Bold"�6   $��20(�6  �� 5V   
   -   5        $ grbDetallaProducto��5V   n   $��Detalle del producto��6   $	��130��61   $
��Left=�6>   $��228,200,0,0q�6Y   $	��Top=�6�   $	��557��6�   $��14(�6�   $
��Bold"�6�   $��Segoe UI Semibold)�6�   .��5W      �� 
���   �$��1q�6)   $
��Left=�6=   $��96��6X   $��10,4,0,0q�6d   $	��Top=�6v   $��99��6�   ._�5X      �� -   5         ��Name$ imgProducto��5X      5Y      5Z      �� 5[   
   -   5        $ 
txtBarcode��5[      $
��Left=�6&   $��23��6A   $��357,226,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��166��6�   {�.  . 6�   �� 5\   
   -   5        $ txtNombreProducto��5\      $
��Left=�6-   $��23��6H   $��358,258,0,0q�6T   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��165��6�   {�.  . 6�   �� 5]   
   -   5        $ txtPrecioProducto��5]      $
��Left=�6-   $��23��6H   $��359,288,0,0q�6T   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��164��6�   {�.  . 6�   &   System.Windows.Controls.DataGrid  5^   
   -   5          Name$ dtgProductos��5^   V      AutoGenerateColumns .     
IsReadOnly . $��
0,334,0,52q�6B   $��13(�6�   $
��Bold"�6�   $��Segoe UI Semibold)�6�   $��Stretch=�6  $��Stretch=�6+  ��6n   �� *misProductosventa+   Columns 5_      0  *System.Windows.Controls.DataGridTextColumn  5`      ,  &System.Windows.Controls.DataGridColumn   Header$ Cantidad��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Cantidad+  5a      $ Nombre��6%      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 150	 6R    65   �� *
NombrePV+6R     5b      $ Barcode��6%   $	 150	 6W    66   �� *CodigoBarras+6W     5c      $ Descripción��6%   $	 200	 6\    6:   �� *DescripcionPV+6\     5d      $ Precio��6%   $	 100	 6Z    65   �� *PrecioUnitarioPV+6Z     5e      $ Subtotal��6%   $	 100	 6T    67   �� *
SubTotal+6T   5g      �� 5h   
   -   5         ��Name$ stbBarraEstado��5h      ���	#FFF4FFFE���	#FFA8A8A8$��Center=�6[   $��Bottom=�6}   .@�5i      �� -   5        $ 
lblImporte��5i      $��IMPORTE��6(   $
��Left=�6:   $	��Top=�6U   $��14(�6m   $
��Bold"�6{   $��Segoe UI Symbol)�6�   �� 5j      -   5        $ 
txtImporte��5j      $��2��6*   $
��Left=�67   $
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��115��6�   ���	#FF111111
�������$��30(�6�   $��Segoe UI Symbol)�6�   �� 5k      -   5        $ 	lblCambio��5k      $��CAMBIO��6'   $
��Left=�68   $	��Top=�6T    J� RenderTransformOrigin$ 0.822,0.562&�6l   $��14(�6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   �� 5l      -   5        $ txtCambioVenta��5l      $
��Left=�6.   $
 Wrap=�6K   $�� ��6_   $	��Top=�6g   $	��115��6   ���	#FF111111
�������$��30(�6�   {�.  $��Segoe UI Symbol)�6�   �� 5m      -   5        $ lblTotalPagar��5m      $��TOTAL A PAGAR��6+   $
��Left=�6C   $	��Top=�6^   $
��Bold"�6v   $��14(�6�   $��Segoe UI Symbol)�6�   �� 5n      -   5        $ txtTotalAPagar��5n      $
��Left=�6.   $
 Wrap=�6J   $�� ��6^   $	��247��6f   ���	#FF111111$��30(�6�   ���	#FF59FD8D$
��Bold"�6�   {�.  $��Segoe UI Symbol)�6�   $	��Top=�6�   $��Stretch=�6  5p      5q      5r      