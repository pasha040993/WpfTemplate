   M S B A M L   `   `   `  ����F  BWpfTemplate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfTemplate.ViewsWpfTemplate.Views  5      =#clr-namespace:WpfTemplate.ViewModelWpfTemplate.ViewModel  5      !    WpfTemplate.Views.EventView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:WpfTemplate.Views     5      9	viewModel#clr-namespace:WpfTemplate.ViewModel     5        � 	Resources  5         TextBlockBaseStyle �� 
TargetType �� Property �� Value  DateTimeStyle �� BasedOn  SourceStyle  PointLabelStyle  LabelEventStyle �� DataType.   (WpfTemplate.ViewModel.GeneratorViewModel#   WpfTemplate.Views.MessageView   Message   State)   #WpfTemplate.ViewModel.RiskViewModel0  *WpfTemplate.ViewModel.MessageTextViewModel��%�  &	        &	 n     7   &	 �     7   &	 �    7   &	 �    7   (�� D    5       *, +)(�� �    5#      *, +)(��     5&      *, +)�� 5   
   " ��6+   .�5      ��  � ��
 �����6+   �� 5       � ��$ 12(�6)   5      �� 5   
   " ��6&   8   .�5      ��  � ��$ 16(�6)   �� 5       � ��$ 0,5,0,5q�6'   5      �� 5   
   " ��6$   8   .�5      ��  � ��$ 16(�6)   �� 5       � ��$ 5q�6'   �� 5       �@J�Opacity$	 0.5Q�6(   5      �� 5   
   " ��6(   8   .�5      ��  � ��$ 30(�6)   5      �� 5   
   " ��6(   8   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ 5,0,0,0q�6'   5      �� 5    
   "  6   .R�5!         6    �� *	Message+ 6<   �� *State+5"      �� 5#   
   "  6   .R�5$         6    �� *	Message+ 6<   �� *State+5%      �� 5&   
   "  6   .R�5'      �� $��5,0,0,0q�61   ��6   �� *	Message+61   5(      5)      .��5*      � ���#3a3a3a � RowDefinitions 5+   
   �� 5,      $��40 �6   �� 5-      	 � ColumnDefinitions	 5/   
   �� 50      $��10 �6   �� 51      �� 52      $��40 �6   .+�54   
   �� 
 �� Orientation$
 
Horizontal=�6   $��0��6.   $��1��6;   .+�55      �� #��[ 62   ��6   �� *
DateTime+62   �� 56      #��[ 60   ��6   �� *Source+60   57      � 58   
   $��0��6   $��2��6   .+�59      �� $0��*/Wpftemplate;component/Images/table-40.png��6   $��30��6H   $��30��6S    J� Opacity$	 0.5Q�6_   5:      � 5;   
   $��1��6   $��1��6    5<      �� 5=      $
��auto �6    �� 5>      $
��auto �6    �� 5?      $
��auto �6    .+�5A      � 	 5B      �� 5C      $
��auto �6'   �� 5D      .+�5F      A� $��15��6v   $��15��6�   ��6   �� *State+  EventColorConverter �� 	Converter# [  �� FallbackValue$ White��6�   �� 5G      $��1��6   $0��*Условно-допустимый ВСО��6,   #��[ 6J   5H      � 5I      $��1��6   $��0,10,0,0q�6     5J      �� 5K      $
��auto �6$   �� 5L      $
��auto �6$   .+�5N      �� $0��*Отличие  от норм. схемы:��6   $��14(�6<   $��0,0,0,10q�6J   �� 5O      $��1��6   ��6,   �� *
Equipments+��5P      �� 5Q      .R�5R      �� $
 Vertical=�6)   5S      ��5U      �� 5V      .R�5W        $��0,5,0,0q�6a    60   �� *Name+ 6I   �� *State+6a   5X      5Z      5[      �� 5\      $��2��6   $��0,10,0,0q�6E   ��6(   �� *Tags+��5]      �� 5^      .R�5_      �  K� IsItemsHost$
 True��6$   5`      ��5b      �� 5c      .R�5d      �� $��5,0,0,0q�6)   ��6:   �� 5e      5g      5h      5i      5j      