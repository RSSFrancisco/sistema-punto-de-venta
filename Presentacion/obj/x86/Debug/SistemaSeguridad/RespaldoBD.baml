   M S B A M L   `   `   `  ����  Presentacion.    (Presentacion.SistemaSeguridad.RespaldoBD   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Respaldo Avanzado��5   	   $	��300��6#   $	��350��60    � WindowStartupLocation$ CenterScreen=�6<    � ShowInTaskbar .  ���	#FFECFCEC � Icon$G A/Presentacion;component/Images/1354938078_connect_to_database.ico��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $+ %/ReuxablesLegacy;component/candy.xaml?�6%   %    5
      .��5      � ���	#FFDBEFC7.+�5   
   �� -   5        $��	txtNombre��5   \   $��28��6   $
��Left=�6    �� 	MaxLength$ 60��69   $��
107,27,0,0q�6H   $	��Top=�6m   $	��202��6�    � ToolTip$ Nombre del respaldo��6�   �� 5   
   -   5        $��	lblNombre��5   [   $��Nombre��6   $��28��6!   $
��Left=�6-   $��	20,27,0,0q�6H   $	��Top=�6l   �� 5   
   -   5        $��lblFecha��5   Z   $��Fecha��6   $��28��6    $
��Left=�6,   $��	20,71,0,0q�6G   $	��Top=�6j   �� 5   
   -   5        $��lblDispositivo��5   a   $��Dispositivo��6   $��28��6&   $
��Left=�62   $��
21,113,0,0q�6M   $	��Top=�6w   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dtFecha��5   P   $��25��6   $
��Left=�6!   $��
107,71,0,0q�6<   $	��Top=�6_   $	��202��6w   $8 2Seleccione la fecha en que se guardara el respaldo��6�   �� 5   
   -   5        $��cmbDispositivo��5   O   $��23��6   $
��Left=�6   $��107,113,0,0q�6:   $	��Top=�6e   $	��202��6}   $; 5seleccione la unidad en donde se guardara el respaldo��6�   �� 5   
   -   5        $��
btnAceptar��5   _   $��Aceptar��6   $��23��6#   $
��Left=�6/   $��107,218,0,0q�6J   $	��Top=�6q   $��75��6�   6�   �� 5   
   -   5        $��btnCancelar��5   `   $��Cancelar��6   $��23��6$   $
��Left=�60   $��235,218,0,0q�6K   $	��Top=�6s   $��75��6�   6�   �� 5   
   -	   5        $��
lblCarpeta��5   ]   $��Carpeta��6   $��28��6"   $
��Left=�6.   $��
22,155,0,0q�6I   $	��Top=�6o   �� 5   
   -
   5        $��
txtCarpeta��5   ]   $��23��6   $ 80��6   $
��Left=�6-   $��107,155,0,0q�6H   $	��Top=�6o   $	��202��6�   $F @Ingrese el nombre de la carpeta en donde se guardara el respaldo��6�   5      5      