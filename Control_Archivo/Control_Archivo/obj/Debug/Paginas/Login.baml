   M S B A M L   `   `   `  ����J  FControl_Archivo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Control_ArchivoControl_Archivo  5   	       Control_Archivo.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Control_Archivo     5   	     � Title$  Control De Archivos��5   	   $	��766��6%   $	��499��62    � WindowStartupLocation$ CenterScreen=�6>    � 
ResizeMode$ NoResize=�6c   $��Poppins)�5	   	   .��5      � ���#73203E � ColumnDefinitions 5   
   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��80px �6   5      �� 5      $��200px �6   6-   �� 5      $��3* �6   6*   �� 5      $
��80px �6   6,   .+�5   
   �� $��0��6   $��0��6"   .+�5      �� ���#B4845C$��CONTROL DE ARCHIVO��6)   $
��Bold"�6F   $��39(�6X   $��Center=�6f   $
��Left=�6�   $��Center=�6�   $��0,10,0,0q�6�   $��59��6�   6�   5      �� 5   
   $��1��6   $��0��6"   .+�5      �� $��0��6   $��1��6$   $��200px��61   $��/Images/Expediente.png��6?   5      �� 5   
   $��1��6   $��0��6"   .+�5       �� $��0��6   $��1��6$   $��200px��61   $��/Images/Expediente.png��6?   5!      �� 5#   
   -   5         ��Name$ btnLogin��5#      $��0��6#   $��3��63   $
��30px��6@   $��300px��6N   $��Center=�6\   $��Iniciar sesión��6y   6�   �� 5%   
   -   5         ��Name$ 
txtUsuario��5%      $
��Left=�6&   $��32��6A   $��249,151,0,0q�6M   $��2��6b    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��187��6�   $��Center=�6�    �� 
IsReadOnly .  6�   �� 5&   
   $
��Bold"�6   
�������$��Usuario��66   $
��Left=�6H   $	��Top=�6c   $��
72,146,0,0q�6{   $��2��6�   $��61��6�   $	��140��6�   $��36(�6�   G� 5'   
   -   5        	 G�Name$	 txtPassword��5'      $
��Left=�6,   $��32��6G   $��249,240,0,0q�6S   $��2��6h   $	��Top=�6w   $	��187��6�   $��Center=�6�   
 G� 	MaxLength$
 16��6�   
���  ��6�   �� 5(   
   $
��Bold"�6   
�������$��Contraseña��65   $
��Left=�6J   $	��Top=�6e   $��
28,235,0,0q�6}   $��2��6�   $��61��6�   $	��221��6�   $��36(�6�   5)      5+      