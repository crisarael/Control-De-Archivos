   M S B A M L   `   `   `  ����J  FControl_Archivo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Control_Archivo.PaginasControl_Archivo.Paginas  5      )    #Control_Archivo.Paginas.Expedientes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Control_Archivo.Paginas     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$  Expedientes��5	      .��5      �� 
������� �� CornerRadius$ 30,30,30,30��6!   $��	0,0,-57,0q�6<   ._�5   
   �  � ShowGridLines . $	��Top=�6$    � ColumnDefinitions 5      �� 5      $��20 �6#   60   �� 5      $��* �6#   6/   �� 5      $��20 �6#   60   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DGExpedientes��5         
IsReadOnly . $
��auto��6@   $
��auto��6O   $��1��6�   �� 5      -   5         ��Name$ txtClave��5      $��1��6(    �� 
IsReadOnly . $
��Left=�6J   $��28��6e   $��
34,519,0,0q�6q    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��155��6�   �� 5      -   5        $ txtPropietario��5      $��1��6.   $
��Left=�6?   $��23��6Z   $��
34,567,0,0q�6f   $
 Wrap=�6z   $	��Top=�6�   $	��251��6�   �� 5      -   5        $ txtFraccionamiento��5      $��1��62   $
��Left=�6B   $��23��6]   $��34,601,0,-24q�6i   $
 Wrap=�6   $	��Top=�6�   $	��251��6�   5      5      5      