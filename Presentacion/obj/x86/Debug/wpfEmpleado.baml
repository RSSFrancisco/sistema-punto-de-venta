   M S B A M L   `   `   `  ����  Presentacion    Presentacion.wpfEmpleado   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ] YDivelements.SandRibbon, Version=2.0.1.2, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c38sr/http://schemas.divelements.co.uk/wpf/sandribbon  5      Z VWPFToolkit.Extended, Version=1.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[
extToolkitJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended  5   	   Imy@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   �   ?telerik1http://schemas.telerik.com/2008/xaml/presentation  6�   -   5          � Title$  EMPLEADO��5   	   $	��600��6   $	��800��6'    � 
ResizeMode$ CanMinimize=�63    � WindowStyle$ ThreeDBorderWindow=�6L    � WindowStartupLocation$ CenterScreen=�6m    � ShowInTaskbar . #��["��6O   � AllowsTransparency .   � Icon$@ :/Presentacion;component/Images/1344564985_free_for_job.png��6�  )  #Divelements.SandRibbon.RibbonWindow   
Appearance$ Office2010Blue=�6'   � 	Resources 5      	 �� MergedDictionaries
 �� Source�� 5   
   	 5	      �� 5
      $+
 %/ReuxablesLegacy;component/candy.xaml?�6%   %    5         	StatusBar 5      &   Divelements.SandRibbon.StatusBar  5   
      ExtendedControl 5      '  !Divelements.SandRibbon.StripPanel  5      -   5        $��strPanel��5       5      .@�5      �� -   5        $��
btnMensaje��5       $�� ��6   $
��Bold"�63   
���   ����	#FFF5F2F2��5      �� 5       �� EndPoint$ 1,0.5&�6*    �� 
StartPoint$ 0,0.5&�6;   .��5      �  � Color$ 	#FF9DC7D6��6'    � Offset$ 0Q�69   � 5      $ White��6'   $ 1Q�65   5      5      �� 5      -   5        $��lblTotal��5      $�� ��6   6   �� 5!      5#      .��5&      � $��0 0 0 0q�6   ���	#FFF8F8F8 � ColumnDefinitions 5'   
   �� 5(      $
��325* �6   �� 5)      $
��553* �6   .+�5+   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��
ribbonmenu��5+   2   $��Stretch=�6      CheckedBackground �	#FFCE6A6A$	��Top=�6b   $	��118��6{   ���	#FFC4DECF$��2��6�   ���	#CAC7F4FB$��14(�6�      ApplicationMenu 5,      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5-      ���	#FF1C9D6B8  2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$2 ,/Presentacion;component/Images/themes256.png��6B    o� 
IsMainMenu .  .@�5.      A  ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5          Name$ 	MenuItem1��5.   E   $��Ayuda...��63   6E     5/      -   5        $ rbInformacion��5/   T   $��Información del Sistema��63   6T   51      .@�58      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  -   5        $��menuRegistro��58   -   $��REGISTRO��6   .@�5:      3	  -Microsoft.Windows.Controls.Ribbon.RibbonGroup	  .@�5;      4
  .Microsoft.Windows.Controls.Ribbon.RibbonButton
  -	   5        $��rbNuevoRegistro��5;   �    
  Label$ Nuevo��6&   $��14(�64    
  LargeImageSource$@ :/Presentacion;component/Images/1344565422_document-new.png��6D    
  ToolTipFooterTitle$$ Presione F1 para obtener ayuda��6�    
  ToolTipTitle$ Genera un nuevo Registro��6�    
  ToolTipDescription$  Los registros se activan  ��6#  5=      5>      	  5?      .@�5@      
  -
   5        $��	rbGuardar��5@   �   $ Guardar��6&   $��14(�66   $- '/Presentacion;component/Images/save.png��6D   {�.  $$ Presione F1 para obtener ayuda��6�   $ Boton Guardar��6�   $= 7Guarda los registros que ingrese en las cajas de texto ��6  5A      	  5B      .@�5C      
  -   5        $��
rbeliminar��5C   �   $ Eliminar��6&   $��14(�67   $A ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��6E   {�.  $$ Presione F1 para obtener ayuda��6�   $&  Para Eliminar presione (Delete) ��6
  $+ %Elimina los Registros seleccionados  ��6:  5D      	  5E      .@�5F      
  -   5        $��rbActualizar��5F   �   $ 
Actualizar��6&   $��14(�69   $J D/Presentacion;component/Images/1344567350_system-software-update.png��6G   {�.  $$ Presione F1 para obtener ayuda��6�   $" Para Actualizar presione F5 ��6  $+ %Actualiza los reportes seleccionados ��6B  5G      	  5H      .@�5I      
  -   5        $��
rbCancelar��5I   F   $ Cancelar��6&   $��14(�67   $? 9/Presentacion;component/Images/1344565469_Cancel__Red.png��6Y   $$ Presione F1 para obtener ayuda��6�   $ Boton cancelar  ��6�   $ Cancela los Acciones  ��6�   {�.  6@  5J      	  5K      $	��150��6!   .@�5L      
  -   5        $��rbBuscar��5L   D   $ Buscar��6&   $��14(�65   $/ )/Presentacion;component/Images/search.png��6U   $$ Presione F1 para obtener ayuda��6�   $ Boton cancelar  ��6�   $ Cancela los Acciones  ��6�   {�.  6,  5  /Microsoft.Windows.Controls.Ribbon.RibbonTextBox  5N      -   5        $��	txtBuscar��5N   *   $��Center=�6;   $��1��6W   6d   5P      5V        5W      -   5        $��menuFiltros��5W   ,   $��FILTROS��6   .@�5X      	  .@�5Y      
  -   5        $��rbAscendente��5Y   G   $ 
Ascendente��6&   $��13(�69   $< 6/Presentacion;component/Images/1344553792_button_2.ico��6v   6�   
  5Z      -   5        $��rbDescendente��5Z   H   $ Descendente��6&   $��13(�6:   $? 9/Presentacion;component/Images/1343951245_Preferences.png��6y   6�   	  5^      -   5        $
��grop��5^   )   $��Rango��65   $��13(�6D   .@�5_      
  -   5        $��rbEntre��5_   A   $5 //Presentacion;component/Images/printpreview.png��6P   6�     5`      -   5        $��TxtMin��5`   ,      SmallImageSource$- '/Presentacion;component/images/calc.png��6;     5a      -   5        $��TxtMax��5a   +   $- '/Presentacion;component/images/calc.png��69   5b      
  5d      -   5        $��
rbApellido��5d   7   $ Apellido��6&   $4 ./Presentacion;component/1343952252_Network.ico��6b   6�   
  5e      -   5        $��rbEliminado��5e   9   $ 
Eliminados��6&   $4 ./Presentacion;component/1343952252_Network.ico��6M   6�   5f      5h        5i      -   5        $��menuReportes��5i   N   $��REPORTES��6   $��14(�6-   $��Arial)�6;   .@�5j      	  .@�5k      
  -   5        $��
rbReportes��5k   6   $ Generar��6&   $B </Presentacion;component/Images/1344565499_custom-reports.png��6H   {�. $$ Presione F1 para obtener ayuda��6�   $ Generar reportes ��6�   $P JGenera un reporte de los registros que se muestran en la ventana Empleado ��6  �� 5l      -   5        $��
lblNombrer��5l      $�� ��6.   �� 5m      -   5        $��txtNombreReporte��5m      $	��150��66   �� 5n      -   5        $��lblNombrereport��5n      $��     Nombre del Reporte��63   5o      5p      5q      &   System.Windows.Controls.DataGrid  5r   
   -   5        $��dtgEmpleado��5r   �      AutoGenerateColumns .  $��Stretch=�6V   $��	0,401,0,0q�6t   $	��Top=�6�      
IsReadOnly . {�.  � ToolTip$( "Tabla de los empleados registrados��6  $��2��62  $��14(�6F  ��60   �� *misEmpleados+    Columns  5s      0  *System.Windows.Controls.DataGridTextColumn  5t      ,  &System.Windows.Controls.DataGridColumn!   Header$! Clave��6%   "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 60 6O   #   FontSize$# 13Q�6Z   1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 64   �� *Clave+6Z     5u      $! Nombre��6%   $	" 120 6Q   $ 65   �� *Nombre+6Q     5v      $! Apellido Paterno��6%   $	" 160 6^   $ 6?   �� *	ApPaterno+6^     5w      $! Apellido Materno��6%   $	" 160 6^   $ 6?   �� *	ApMaterno+6^     5x      $! 	Teléfono��6%   $	" 120 6U   $ 67   �� *
Telefono+6U     5y      $! Correo��6%   $" * 6Q   $ 65   �� *Correo+6Q   5      �� 5�   
   -   5        $��	groupBox1��5�   Z   $��2��6   $�� ��6'   $	��284��61   $
��Left=�6>   $	��Top=�6k   $	��800��6�   $��LeftToRight=�6�   $��Stretch=�6�   $��	0,118,0,0q�6�   .��5�      �  5�      �� 5�      $	��55* �6'   �� 5�      $
��811* �6'   .+�5�      �� -    5        $��label1��5�   u   $��Nombre:��6   $
��12.5(�6+   $��26��6;   $
��Left=�6G   $��	11,14,0,0q�6b   $	��Top=�6�   $��55��6�   $��2��6�   �� 5�      -!   5        $��label2��5�   ~   $��Apellido Paterno:��6   $
��12.5(�64   $��24��6D   $
��Left=�6P   $��	10,52,0,0q�6k   $	��Top=�6�   $	��103��6�   $��2��6�   �� 5�      -"   5        $��label3��5�   ~   $��Apellido Materno:��6   $
��12.5(�64   $��27��6D   $
��Left=�6P   $��	10,83,0,0q�6k   $	��Top=�6�   $	��108��6�   $��2��6�   �� 5�      -#   5        $��label4��5�   }   $��No. Afiliación:��6   $
��12.5(�62   $��29��6B   $
��Left=�6N   $��
11,120,0,0q�6i   $	��Top=�6�   $��89��6�   $��2��6�   �� 5�      -$   5        $��label5��5�      $��Fecha Nacimiento:��6   $
��12.5(�64   $��29��6D   $
��Left=�6P   $��
11,158,0,0q�6k   $	��Top=�6�   $	��107��6�   $��2��6�   �� 5�      -%   5        $��label6��5�   x   $��Dirección:��6   $
��12.5(�6-   $��25��6=   $
��Left=�6I   $��
12,189,0,0q�6d   $	��Top=�6�   $��69��6�   $��2��6�   �� 5�      -&   5        $��label7��5�   v   $��Colonia:��6   $
��12.5(�6+   $��23��6;   $
��Left=�6G   $��
13,224,0,0q�6b   $	��Top=�6�   $��73��6�   $��2��6�   �� 5�      -'   5        $��label8��5�   \   $��Ciudad:��6   $
��12.5(�6*   $��23��6:   $��345,12,330,0q�6F   $	��Top=�6j   $��1��6�   �� 5�      -(   5        $��label9��5�   \   $��Estado:��6   $
��12.5(�6*   $��25��6:   $��343,49,330,0q�6F   $	��Top=�6j   $��1��6�   �� 5�      -)   5        $��label10��5�   s   $��C.P.:��6   $
��12.5(�6(   $��25��68   $
��Left=�6D   $��
343,83,0,0q�6_   $	��Top=�6�   $��89��6�   $��1��6�   �� 5�      -*   5        $��label11��5�   x   $��
Teléfono:��6   $
��12.5(�6,   $��31��6<   $
��Left=�6H   $��343,115,0,0q�6c   $	��Top=�6�   $��90��6�   $��1��6�   �� 5�      -+   5        $��label12��5�   �   $��Correo Electrónico:��6   $
��12.5(�66   $��27��6F   $
��Left=�6R   $��344,157,0,0q�6m   $	��Top=�6�   $	��105��6�   $��1��6�   �� 5�      -,   5        $��label13��5�   }   $��Nivel Escolar:��6   $
��12.5(�61   $��25��6A   $
��Left=�6M   $��345,187,0,0q�6h   $	��Top=�6�   $��93��6�   $��1��6�   �� 5�      --   5        $��label14��5�   |   $��Especialidad:��6   $
��12.5(�60   $��28��6@   $
��Left=�6L   $��345,228,0,0q�6g   $	��Top=�6�   $��92��6�   $��1��6�   �� 5�      -.   5        $��txtapellidomaterno��5�   g   $��26��6   $
��Left=�6&   {�.  $��
70,0,0,152q�6S   $��3��6�   $��Bottom=�6�   $	��256��6�   $��1��6�   $��13(�6�   �� 5�      -/   5        $��txtnoAfiliacion��5�   v   $��26��6   $
��Left=�6&   {�.  $��
71,119,0,0q�6S   % �� 	MaxLength$% 12��6g   $��4��6�   $	��Top=�6�   $	��255��6�   $��1��6�   $��13(�6�   �� 5�      -0   5        $��txtdirección��5�   w   $��26��6   $
��Left=�6&   {�.  $��
70,189,0,0q�6S   $	% 150��6g   $��6��6�   $	��Top=�6�   $	��256��6�   $��1��6�   $��13(�6�   �� 5�      -1   5        $��
txtcolonia��5�   w   $��26��6   $
��Left=�6&   {�.  $��
70,224,0,0q�6S   $	% 150��6g   $��7��6�   $	��Top=�6�   $	��256��6�   $��1��6�   $��13(�6�   �� 5�      -2   5        $��	txtCiudad��5�   w   $��26��6   $
��Left=�6&   {�.  $��
459,10,0,0q�6S   $	% 150��6g   $��8��6�   $	��Top=�6�   $	��255��6�   $��1��6�   $��13(�6�   �� 5�      -3   5        $��txtCp��5�   u   $��26��6   $
��Left=�6&   {�.  $��
459,80,0,0q�6S   $% 7��6g   $��10��6�   $	��Top=�6�   $��99��6�   $��1��6�   $��13(�6�   �� 5�      -4   5        $��txtTelefono��5�   ^   $��26��6   {�.  $��459,111,180,0q�68   $% 15��6O   $��11��6q   $	��Top=�6   $��1��6�   $��13(�6�   �� 5�      -5   5        $��	txtCorreo��5�   x   $��26��6   $
��Left=�6&   {�.  $��459,151,0,0q�6S   $	% 150��6h   $��12��6�   $	��Top=�6�   $	��255��6�   $��1��6�   $��13(�6�   �� 5�      -6   5        $��txtEspecialidad��5�   x   $��26��6   $
��Left=�6&   {�.  $��461,220,0,0q�6S   $	% 150��6h   $��14��6�   $	��Top=�6�   $	��253��6�   $��1��6�   $��13(�6�   (  "System.Windows.Controls.DatePicker  5�      -7   5        $��dtfecha��5�   j   $��26��6   $
��Left=�6)   {�.  $��
71,156,0,0q�6V   $��5��6y   $	��Top=�6�   $	��140��6�   $��1��6�   $��13(�6�   �� 5�      -8   5        $��	cmbEstado��5�   h   $��26��6   $
��Left=�6'   {�.  $��
459,49,0,0q�6T   $��9��6y   $	��Top=�6�   $	��255��6�   $��1��6�   $��13(�6�   �� 5�      -9   5        $��cmbNivelescolar��5�   i   $��26��6   $
��Left=�6'   {�.  $��460,184,0,0q�6T   $��13��6�   $	��Top=�6�   $	��254��6�   $��1��6�   $��13(�6�   �� 5�      -:   5        $��	txtnombre��5�   u   $��26��6   $
��Left=�6&   {�.  $��	71,17,0,0q�6S   $% 50��6f   $��1��6�   $	��Top=�6�   $	��255��6�   $��1��6�   & �� 
AcceptsTab& .  ' �� IsReadOnlyCaretVisible' .  $��13(�6  �� 5�      -;   5        $��txtapellidoPaterno��5�   v   $��26��6   $
��Left=�6&   {�.  $��	71,51,0,0q�6S   $	% 100��6f   $��2��6�   $	��Top=�6�   $	��255��6�   $��1��6�   $��13(�6�   5�      5�      5�      5�      