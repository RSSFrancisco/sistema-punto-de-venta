   M S B A M L   `   `   `  ����  Presentacion    Presentacion.Sesion   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ] YDivelements.SandRibbon, Version=2.0.1.2, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c38sr/http://schemas.divelements.co.uk/wpf/sandribbon  5      Z VWPFToolkit.Extended, Version=1.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[
extToolkitJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended  5      -   5          � Title$  INICIAR SESIÓN��5   	   $	��260��6    $	��360��6-    � 
ResizeMode$ NoResize=�6:    � WindowState$ Normal=�6P    � WindowStartupLocation$ CenterScreen=�6e   #��["��6�    � ShowInTaskbar . )  #Divelements.SandRibbon.RibbonWindow   
Appearance$ Office2010Blue=�6�    � Icon$: 4/Presentacion;component/Images/1342510081_people.ico��6   � 	Resources 5	       �� MergedDictionaries	 �� Source�� 5
   
    5      �� 5      $+	 %/ReuxablesLegacy;component/candy.xaml?�6%   %    5      .��5      � ��5   
   �� 5      
 �� EndPoint$
 1,0.5&�6"    �� 
StartPoint$ 0,0.5&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#8E769077��6   $ 1Q�61   5      .+�5   
   � -   5        $��grid1��5      $��0q�6    � RowDefinitions 5      �� 5      $��2* �6    �� 5      $
��259* �6    .+�5      �� -   5        $��label1��5   b   $��USUARIO:��6   $��25��6'   $
��Left=�63   $��
106,10,0,0q�6N   $	��Top=�6p   $��97��6�   ���	#FF070606$��1��6�   $��14(�6�   $��Segoe UI Semibold)�6�   1  +Microsoft.Windows.Controls.WatermarkTextBox  5      -   5        $��
txtUsuario��5   �      	Watermark$  ��6+   $��1��68   $��32��6E   $
��Left=�6Q   $��
106,31,0,0q�6l   $	��Top=�6�   $	��206��6�   $��1��6�   $��14(�6�   $��Segoe UI Symbol)�6   �� 5      -   5        $��label2��5   e   $��CONTRASEÑA:��6   $��29��6*   $
��Left=�66   $��
106,74,0,0q�6Q   $	��Top=�6s   $	��102��6�   ���	#FF070606$��1��6�   $��Segoe UI Semibold)�6�   $��14(�6�   �� 5       -   5        $��
btnIniciar��5    I   $��INICIAR��6   $��28��6'   $��159,145,99,0q�63   $	��Top=�6[   $��1��6�   ���	#FFCAD57D$��14(�6�   $��Segoe UI Semibold)�6�   G� 5!      -   5        $��txtContraseña��5!   e   $��30��6   $��2��6(   $
��Left=�65   $��106,103,0,0q�6P   $	��Top=�6z   $	��206��6�   $��1��6�    � ToolTip$ Contraseña��6�   $��Segoe UI Symbol)�6�   $��14(�6�   �� 5"      -   5        $��image2��5"   M   $��61��6   $
��Left=�6    $��24,7,0,0q�6;   $
��Fill=�6[   $	��Top=�6j   $��69��6�   $/��)/Presentacion;component/Images/people.png��6�   $��1��6�   �� 5#      -	   5        $��image3��5#   N   $��67��6   $
��Left=�6    $��	24,74,0,0q�6;   $
��Fill=�6\   $	��Top=�6k   $��72��6�   $C��=/Presentacion;component/Images/1344574661_Login%20Manager.png��6�   $��1��6�   �� 5$      -
   5        $��
statusBar1��5$   _   $��1��6   $��21��6%   $
��Left=�61   $��	0,199,0,0q�6L   $	��Top=�6q   $	��354��6�   .@�5%      �� -   5        $��
lblMensaje��5%   #   $�� ��6   
���   �$��14(�6H   $��Arial)�6V   $��Italic$�6i   $
��Bold"�6|   
�������$��ExtraCondensed&�6�   
�������6�   ��5&      �� 5'      $
 1,0.5&�6*   $ 0,0.5&�6;   .��5(      � $ Black��6'   $ 1Q�65   � 5)      $ 	#60FFFFFF��6'   $ 0.581Q�69   � 5*      $ 	#FFB5FFFC��6'   $ 0.993Q�69   5+      5-      ��5/      �� 50      $
 1,0.5&�6&   $ 0,0.5&�67   .��51      � $ 	#FF89EEE9��6#   $ 1Q�65   � 52      $ White��6#   $ 0Q�61   53      55      56      57      