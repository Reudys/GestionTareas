   M S B A M L   `   `   `  ����H  DGestionTareas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:GestionTareas.ViewGestionTareas.View  5   	        GestionTareas.View.Añadir   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:GestionTareas.View     5   	   -   5          � Title$  Añadir��5   	   $	��350��6   $	��600��6%    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V   ���	#FFFAB023.��5	      �  � RowDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��5* �6   �� 5      $��2* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Center=�6K   $��0��6f   .+�5      �� $��Titulo: ��6   $��38��6(   $��25(�64   $��82��6B   
�������$
��Bold"�6`   �� 5      -   5        $��	txtTitulo��5   .   $��30��6   $	��200��6"   $��18(�6?   5      �� 5   
   $ Vertical=�6   $��Center=�6,   $��Center=�6I   $��1��6d   .+�5      �� $��Descripcion: ��6   $��38��6-   $��25(�69   $	��198��6G   
�������$
��Bold"�6f   �� 5      -   5        $��txtDescripcion��5   /   $	��100��6   $	��199��6#   $��18(�6E   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   $��2��6e   $��0,0,10,0q�6r   .+�5      �� -   5        $��Añadir��5      $��0,0,5,0q�69   $��18(�6J   $
��Bold"�6X   
���   ����	#FFFFFFEE$	��100��6�   $��30��6�   $��0q�6�   �� 5      -   5        $��Cancelar��5      $��18(�6<   $
��Bold"�6J   
���   ����	#FFFFFFEE$	��100��6�   $��30��6�   $��0q�6�   5      5      5       