   M S B A M L   `   `   `  ����F  BWpfTemplate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfTemplate.ViewsWpfTemplate.Views  5      #    WpfTemplate.Views.MessageView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:WpfTemplate.Views     5      -   5          >�Name$  mv��5      .��5
      � $
��auto��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��13��6n   $��13��6y   ��6   ��  �� Path$ State� �� ElementName$ mv��   EventImageConverter �� 	Converter# [  6y   �� 5   
   $��1��6   $��5,0,0,0q�6$   $��14(�6z   $��CharacterEllipsis=�6�   ��65   �� $ Message�$ mv�� �� FallbackValue$ message��6�   �� 5   
   $��1��6   $��2��6!   ��65   �� $ State�$ mv��  EventColorConverter# [ $ Black��5      5      