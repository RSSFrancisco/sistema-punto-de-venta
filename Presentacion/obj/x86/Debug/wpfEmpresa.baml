   M S B A M L   `   `   `  ����  Presentacion    Presentacion.wpfEmpresa   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ] YDivelements.SandRibbon, Version=2.0.1.2, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c38sr/http://schemas.divelements.co.uk/wpf/sandribbon  5      Imy@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   }   ?telerik1http://schemas.telerik.com/2008/xaml/presentation  6�   -   5          � Title$  CLIENTES��5      $	��600��6   $	��758��6)    � WindowStyle$ ThreeDBorderWindow=�65    � WindowStartupLocation$ CenterScreen=�6W    � ShowInTaskbar . 
�������)  #Divelements.SandRibbon.RibbonWindow   
Appearance$ Office2010Silver=�6a   � Icon$; 5/Presentacion;component/Images/1344565058_company.png��6  $��14(�6)     	StatusBar 5      &   Divelements.SandRibbon.StatusBar  5   
      ExtendedControl 5      '  !Divelements.SandRibbon.StripPanel  5	      -   5        $��strPanel��5	       .+�5
      �� -   5        $��btnError��5
   (   $�� ��6   ���	#FF2D8340$
��Bold"�6P   5      .@�5      �� -   5        $��
btnMensaje��5       $�� ��6   ���	#FF2D8340$
��Bold"�6J   �� 5      -   5        $��lblTotal��5      $�� ��6   6   �� 5      5       � 	Resources 5      	 �� MergedDictionaries
 �� Source�� 5   
   	 5      �� 5      $+
 %/ReuxablesLegacy;component/candy.xaml?�6%   %    5      .��5      � $��0 0 0 0q�6   ���	#FFFCFCFC.+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  -   5        $��ribbon1��5   a   $��0 0 0 0q�6      CheckedBackground �	#FFCE6A6A$��Stretch=�6C   $	��Top=�6p   ���	#CAC7F4FB   ApplicationMenu 5      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5      ���	#FF1C9D6B8  2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$@ :/Presentacion;component/Images/1344565183_deliverables.png��6B    o� 
IsMainMenu .  .@�5      A  ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5          Name$ 	MenuItem1��5   E   $��Ayuda...��63   6E     5       -   5        $ rbInformacion��5    T   $��Información del Sistema��63   6T   5"      .@�5%      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab  $��Registro��6   $��14(�6-   .@�5&      3	  -Microsoft.Windows.Controls.Ribbon.RibbonGroup	  .@�5'      4
  .Microsoft.Windows.Controls.Ribbon.RibbonButton
  -	   5        $��rbNuevo��5'   �    
  Label$ Nuevo��6&    
  LargeImageSource$@ :/Presentacion;component/Images/1344565422_document-new.png��64    
  ToolTipFooterTitle$$ Presione F1 para obtener ayuda��6�    
  ToolTipTitle$ Genera un nuevo Registro��6�    
  ToolTipDescription$  Los registros se activan  ��6�   6  5(      	  5)      .@�5*      
  -
   5        $��	rbGuardar��5*   �   $ Guardar��6&   $8 2/Presentacion;component/Images/1344565565_Save.png��66   {�.  $$ Presione F1 para obtener ayuda��6�   $ Boton Guardar��6�   $= 7Guarda los registros que ingrese en las cajas de texto ��6  5+      	  5,      .@�5-      
  -   5        $��
rbEliminar��5-   �   $ Eliminar��6&   $A ;/Presentacion;component/Images/1344565383_Close_Box_Red.png��67   {�.  $$ Presione F1 para obtener ayuda��6�   $&  Para Eliminar presione (Delete) ��6�   $+ %Elimina los Registros seleccionados  ��6-  5.      	  5/      .@�50      
  -   5        $��rbActualizar��50   �   $ 
Actualizar��6&   $J D/Presentacion;component/Images/1344567350_system-software-update.png��69   {�.  $$ Presione F1 para obtener ayuda��6�   $" Para Actualizar presione F5 ��6	  $, &Actualiza los registros seleccionados ��65  51      	  52      .@�53      
  -   5        $��
rbCancelar��53   8   $ Cancelar��6&   $? 9/Presentacion;component/Images/1344565469_Cancel__Red.png��6K   $$ Presione F1 para obtener ayuda��6�   $ Boton cancelar  ��6�   $ Cancela las Acciones  ��6�   6  54      	  55      .@�56      
  -   5        $��
rbReportes��56   >   $ Generar Reporte��6&   $B </Presentacion;component/Images/1344565499_custom-reports.png��6i   {�. $$ Presione F1 para obtener ayuda��6�   $ Boton de reportes ��6�   $G AGenera un reporte de los registros que se muestran en el datgrid ��6!  57      58      59      �� 5:   
   -   5        $��label1��5:   ]   $��R.F.C.:��6   $��33��6"   $
��Left=�6.   $��
15,151,0,0q�6I   $	��Top=�6k   $	��102��6�   �� 5;   
   -   5        $��label2��5;   ]   $��Siglas:��6   $��28��6"   $
��Left=�6.   $��
15,190,0,0q�6I   $	��Top=�6k   �� 5<   
   -   5        $��label3��5<   ]   $��Nombre:��6   $��28��6"   $
��Left=�6.   $��
15,224,0,0q�6I   $	��Top=�6k   �� 5=   
   -   5        $��label4��5=   [   $��Giro:��6   $��28��6    $
��Left=�6,   $��
15,258,0,0q�6G   $	��Top=�6i   �� 5>   
   -   5        $��label5��5>   `   $��Direcciòn:��6   $��28��6%   $
��Left=�61   $��
15,295,0,0q�6L   $	��Top=�6n   �� 5?   
   -   5        $��label6��5?   _   $��Colonia:��6   $��28��6#   $
��Left=�6/   $��412,151,0,0q�6J   $	��Top=�6m   �� 5@   
   -   5        $��label7��5@   ^   $��Ciudad:��6   $��28��6"   $
��Left=�6.   $��412,190,0,0q�6I   $	��Top=�6l   �� 5A   
   -   5        $��label8��5A   ^   $��Estado:��6   $��28��6"   $
��Left=�6.   $��411,224,0,0q�6I   $	��Top=�6l   �� 5B   
   -   5        $��label9��5B   \   $��C.P.:��6   $��28��6    $
��Left=�6,   $��411,256,0,0q�6G   $	��Top=�6j   �� 5C   
   -   5        $��txtrfc��5C   [   $��28��6   $��1��6   $
��Left=�6+   $��107,151,0,0q�6F   $	��Top=�6i   $	��234��6�   {�.  6�   �� 5D   
   -   5        $��	txtSiglas��5D   [   $��26��6   $��2��6   $
��Left=�6+   $��108,186,0,0q�6F   $	��Top=�6l   $��88��6�   {�.  6�   �� 5E   
   -   5        $��label10��5E   `   $��
Teléfono:��6   $��27��6$   $
��Left=�60   $��411,292,0,0q�6K   $	��Top=�6o   $��94��6�   �� 5F   
   -   5        $��	txtNombre��5F   [   $��26��6   $��3��6   $
��Left=�6+   $��108,221,0,0q�6F   $	��Top=�6l   $	��281��6�   {�.  6�   �� 5G   
   -   5        $��txtGiro��5G   [   $��27��6   $��4��6   $
��Left=�6+   $��108,256,0,0q�6F   $	��Top=�6j   $	��281��6�   {�.  6�   �� 5H   
   -   5        $��txtDireccion��5H   [   $��73��6   $��5��6   $
��Left=�6+   $��108,291,0,0q�6F   $	��Top=�6o   $	��281��6�   {�.  6�   �� 5I   
   -   5        $��
txtColonia��5I   [   $��27��6   $��6��6   $
��Left=�6+   $��506,152,0,0q�6F   $	��Top=�6m   $	��222��6�   {�.  6�   �� 5J   
   -   5        $��	txtCiudad��5J   [   $��27��6   $��7��6   $
��Left=�6+   $��506,186,0,0q�6F   $	��Top=�6l   $	��222��6�   {�.  6�   �� 5K   
   -    5        $��txtCodigoPostal��5K   [   $��25��6   $��9��6   $
��Left=�6+   $��506,254,0,0q�6F   $	��Top=�6r   $��88��6�    �� 	MaxLength$ 5��6�   {�.  6�   �� 5L   
   -!   5        $��txtTelefono��5L   \   $��29��6   $��10��6   $
��Left=�6,   $��506,291,0,0q�6G   $	��Top=�6o   $ 15��6�   {�.  $	��222��6�   &   System.Windows.Controls.DataGrid  5M   
   -"   5        $��
dtgEmpresa��5M   �      AutoGenerateColumns .  $	��240��6R   $��Stretch=�6_   $��	0 370 0 0q�6}   $	��Top=�6�      
IsReadOnly . {�.  ��6/   �� *	miEmpresa+   Columns 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn   Header$ Clave��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *Clave+  5P      $ R.F.C.��6%   $	 170 65    6A   �� *Rfc+  5Q      $ Siglas��6%   $	 100 65    6A   �� *Siglas+  5R      $ Nombre��6%   $	 200 65    6A   �� *Nombre+  5S      $
 Giro��6%   $	 200 63    6?   �� *Giro+  5T      $ Telefono��6%   $	 150 67    6C   �� *
Telefono+5X      �� 5Y   
   -#   5        $��	cmbEstado��5Y   \   $��26��6   $��8��6   $
��Left=�6,   $��506,219,0,0q�6G   $	��Top=�6m   $	��222��6�   {�.  6�   5Z      5[      