   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Presentacion.VentasPresentacion.Ventas  5   	   ` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon 5   	   )    #Presentacion.Ventas.wpfDetalleVenta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Presentacion.Ventas     5   	   aribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     5   	   -   5        $��wTitulo��5	        � Title$  Detalle venta��6	   $	��650��6.   $	��800��6;    � WindowStartupLocation$ CenterScreen=�6G   $��14(�6l    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $+ %/ReuxablesLegacy;component/candy.xaml?�6%   %    5      .��5      � .+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��ribbon1��5      $��Stretch=�6'      CheckedBackground �	#FFCE6A6A$��0 0 0 0q�6d   $	��Top=�6w   ���	#CAC7F4FB���	#FFC5C5C5$��14(�6�   .@�5      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $��Opciones��6   .@�5      3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  .@�5      4  .Microsoft.Windows.Controls.Ribbon.RibbonButton  -   5        $��rbActualizarVenta��5   �      Label$ Actualizar venta��6*      LargeImageSource$J D/Presentacion;component/Images/1344567350_system-software-update.png��6C      ToolTipFooterTitle$$ Presione F1 para obtener ayuda��6�   	   ToolTipTitle$:	 4Para Guardar la venta presione la tecla(RightShift) ��6�   
   ToolTipDescription$
 Actualiza la venta ��60  {�.  6Y  5        5      .@�5        -   5        $��rbCancelarProducto��5   �   $ Cancelar producto��6*   $A ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��6E   {�.  $$ Presione F1 para obtener ayuda��6�   $3	 -Para Cancelar el producto presione tecla(F2) ��6�   $(
 "Cancela el producto seleccionado  ��63  5        5      .@�5        -   5        $��rbCancelarVenta��5   �   $ Cancelar venta��6*   $? 9/Presentacion;component/Images/1344565469_Cancel__Red.png��6B   {�. $$ Presione F1 para obtener ayuda��6�   $0	 *Para Cancelar la venta presione tecla(F3) ��6�   $%
 Cancela la venta seleccionada  ��6'  6\  5      5       5!      &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ dtgProductos��5"   U      AutoGenerateColumns .     
IsReadOnly . $��	0,219,0,0q�6B   $	��Top=�6k   $	��300��6�   ��6�   �� *misProductosventa+   Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Cantidad��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Cantidad+  5%      $ Nombre��6%      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 150	 6R    65   �� *
NombrePV+6R     5&      $ Barcode��6%   $	 150	 6W    66   �� *CodigoBarras+6W     5'      $ Descripción��6%   $	 200	 6\    6:   �� *DescripcionPV+6\     5(      $ Precio��6%   $	 100	 6Z    65   �� *PrecioUnitarioPV+6Z     5)      $ Subtotal��6%   $	 100	 6T    67   �� *
SubTotal+6T   5+      �� 5,   
   -   5         ��Name$ txtFolio��5,      $
��Left=�6$   $��23��6?   $��	1,164,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��143��6�   {�.  6�   �� 5-   
   -   5         ��Name$ label��5-      $��	Num.Venta��6   $
��Left=�63   $��	1,143,0,0q�6N   $	��Top=�6a   �� 5.   
   -	   5        $��cmbEmpleado��5.   O   $��23��6   $
��Left=�6   $��339,164,0,0q�6:   $	��Top=�6b   $	��222��6z   ��5/      �� 50      .R�51      ��  �� Orientation$ 
Horizontal=�6!   .+�52      �� $	��200��6A   ��6$   ��  �� Path$ Nombre�6A   53      54      56      �� 57   
   -
   5        $��
cmbEmpresa��57   O   $��23��6   $
��Left=�6   $��159,164,0,0q�6:   $	��Top=�6a   $	��161��6y   ��58      �� 59      .R�5:      �� $ 
Horizontal=�6!   .+�5<      �� $	��200��6A   ��6$   �� $ Nombre�6A   5=      5>      5@      �� 5A   
   -   5        $ 
lblCliente��5A      $��Cliente��6$   $
��Left=�66   $��159,143,0,0q�6Q   $	��Top=�6f   �� 5B   
   -   5        $ lblEmpleado��5B      $��Atendio��6%   $
��Left=�67   $��339,143,0,0q�6R   $	��Top=�6g   (
  "System.Windows.Controls.DatePicker
  5C   
   -   5        $��dtFechaVenta��5C      $
��Left=�6)   $��579,162,0,0q�6D   $	��Top=�6Y   $	��183��6q   �� 5D   
   -   5        $ lblFecha��5D      $��Fecha��6"   $
��Left=�62   $��579,143,0,0q�6M   $	��Top=�6b   �� 5E   
   -   5        $ 
lblImporte��5E      $��Importe��6$   $
��Left=�66   $��373,520,0,0q�6Q   $	��Top=�6f   �� 5F   
   -   5        $ 
txtImporte��5F      $
��Left=�6&   $��23��6A   $��372,541,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5G   
   -   5        $ 	lblCambio��5G      $��Cambio��6#   $
��Left=�64   $��515,520,0,0q�6O   $	��Top=�6d   �� 5H   
   -   5        $ 	txtCambio��5H      $
��Left=�6%   $��23��6@   $��516,541,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5I   
   -   5        $ lblTotal��5I      $��Total��6"   $
��Left=�62   $��662,521,0,0q�6M   $	��Top=�6b   �� 5J   
   -   5        $ txtTotal��5J      $
��Left=�6$   $��23��6?   $��662,541,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   5K      5L      