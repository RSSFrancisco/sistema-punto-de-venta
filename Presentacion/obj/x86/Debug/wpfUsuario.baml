   M S B A M L   `   `   `  ����  Presentacion    Presentacion.wpfUsuario   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ] YDivelements.SandRibbon, Version=2.0.1.2, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c38sr/http://schemas.divelements.co.uk/wpf/sandribbon  5   	   Imy@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   m   -   5          � Title$  USUARIOS��5   	   $	��500��6   $	��800��6'    � ShowInTaskbar .  � WindowStartupLocation$ CenterScreen=�6H   ���	#FFFCFCFC � Icon$: 4/Presentacion;component/Images/1344562217_couple.png��6�   )  #Divelements.SandRibbon.RibbonWindow   	StatusBar 5      &   Divelements.SandRibbon.StatusBar  5   
      ExtendedControl 5      '  !Divelements.SandRibbon.StripPanel  5	      -   5        $��strPanel��5	       .+�5
      �� -   5        $��
btnMensaje��5
   (   $�� ��6   ���	#FF2D8340$
��Bold"�6R   5      .@�5      �� -   5        $��lblFecha��5       $�� ��6   6    �� 5      -   5        $��lblHora��5       $�� ��6   6    �� 5      �� 5      -   5        $��lblTotal��5      $�� ��6   6   5      .��5   
   � ���	#FFFFFCFC.+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��ribbon1��5   2   $��Stretch=�6   $	��Top=�6A   $	��110��6Z   ���	#CAC7F4FB.@�5      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $��Registro��6   .@�5      3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  .@�5      4  .Microsoft.Windows.Controls.Ribbon.RibbonButton  -   5        $��rbNuevoRegistro��5   �      Label$ Nuevo��6&      LargeImageSource$@ :/Presentacion;component/Images/1344565422_document-new.png��67      ToolTipFooterTitle$$ Presione F1 para obtener ayuda��6�   	   ToolTipTitle$	 Genera un nuevo Registro��6�   
   ToolTipDescription$ 
 Los registros se activan  ��6�   6)  5        5      .@�5        -	   5        $ Guardar��5   &   $8 2/Presentacion;component/Images/1344565565_Save.png��66    � ToolTip$ Guardar registro��6�   5        5      .@�5        -
   5        $��
rbEliminar��5   &   $ Eliminar��68   $A ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��6I   $$ Presione F1 para obtener ayuda��6�   $&	  Para Eliminar presione (Delete) ��6�   $+
 %Elimina los Registros seleccionados  ��6�   {�.  69  5         5!      .@�5"        -   5        $��rbActualizar��5"   &   $ 
Actualizar��6:   $J D/Presentacion;component/Images/1344567350_system-software-update.png��6M   $$ Presione F1 para obtener ayuda��6�   $"	 Para Actualizar presione F5 ��6�   $,
 &Actualiza los registros seleccionados ��6  {�.  6C  5#        5$      .@�5%        -   5        $��
rbCancelar��5%   8   $ Cancelar��6&   $? 9/Presentacion;component/Images/1344565469_Cancel__Red.png��6K   $$ Presione F1 para obtener ayuda��6�   $	 Boton cancelar  ��6�   $
 Cancela las Acciones  ��6�   6  5&      5'      5(      a� 5)   
   -   5        $��toolBarPanel1��5)   H   $��Stretch=�6   $��0,29,0,0q�66   $	��Top=�6]   �� 5*   
   -   5        $��
statusBar1��5*   N   $��28��6   $
��Left=�6    $��	0,833,0,0q�6;   $	��Top=�6`   $	��778��6x   �� 5+   
   -   5        $��lblNick��5+   [   $��Nick :��6   $��27��6!   $
��Left=�6-   $��	7,118,0,0q�6H   $	��Top=�6j   $��89��6�   �� 5,   
   -   5        $��lblApellidoPaterno��5,   a   $��Contraseña :��6   $��28��6'   $
��Left=�63   $��	7,176,0,0q�6N   $	��Top=�6{   $	��102��6�   �� 5-   
   -   5        $��lblEmpleado��5-   _   $��	Empleado:��6   $��25��6$   $
��Left=�60   $��
10,294,0,0q�6K   $	��Top=�6r   $��99��6�   �� 5.   
   -   5        $��txtNick��5.   M   $��25��6   $
��Left=�6   $��
11,145,0,0q�69   $	��Top=�6\   $	��393��6t   {�.  6�   �� 50   
   -   5        $��cmbEmpleado��50   N   $��24��6   $
��Left=�6   $��
11,317,0,0q�6:   $	��Top=�6a   $	��178��6y   {�.  ��51      �� 52      .R�53      ��  �� Orientation$ 
Horizontal=�6!   .+�55      �� $��50��6A   ��6$   ��  �� Path$ Nombre�6A   �� 56      $��50��6E   ��6$   �� $ 	ApPaterno�6E   5:      5;      5>      &   System.Windows.Controls.DataGrid  5?   
   -   5        $��
dtgUsuario��5?   �      AutoGenerateColumns .  $	��151��6/      
IsReadOnly . $
��Left=�6r   $��	0,358,0,0q�6�   $	��Top=�6�   $	��779��6�   {�.  ��6N   �� *misUsuarios+   Columns 5@      0	  *System.Windows.Controls.DataGridTextColumn	  5A      ,
  &System.Windows.Controls.DataGridColumn 
  Header$ Clave��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Clave+	  5B      $
 Nick��6%    63   �� *Nick+	  5C      $ Contraseña��6%    69   �� *Contrasenia+	  5D      $ Empleado��6%    67   �� *
Idempleado+5F      �� 5G   
   -   5        $��lblConfirmar��5G   i   $��Confirmar Contraseña��6   $��23��6/   $
��Left=�6;   $��	7,235,0,0q�6V   $	��Top=�6}   $	��172��6�   G� 5H   
   -   5        $��txtConfirmarContrasenia��5H   Q   $��26��6   $
��Left=�6"   $��
12,264,0,0q�6=   $	��Top=�6p   $	��392��6�   {�.  6�   G� 5I   
   -   5        $��txtcntrasenia��5I   Q   $��28��6   $
��Left=�6"   $��
12,201,0,0q�6=   $	��Top=�6f   $	��392��6~   {�.  6�   5J      5L      