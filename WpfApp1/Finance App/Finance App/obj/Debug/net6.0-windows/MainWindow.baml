   M S B A M L   `   `   `  ����F  BFinance App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Finance_AppFinance_App  5   	       Finance_App.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:Finance_App  5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � AllowsTransparency$
 True��5   	   ��5   (   Z�  � 	Resources 5         DataTemplate_Level2  DataTemplate_Level1 �� Orientation��%  &	        &	 k     �� 5   
   .R�5      �� $��40��6)   $	��215��65   $��4,4,4,4q�6A   ��6   �� 6A   5      �� 5   
   .R�5      �� #���   63   ��6   �� ��5      �� 5      .R�5      �� $ 
Horizontal=�6%   5      5      5      5       .��5#      � .+�5$   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 15Q�6*   ���#fefefe.��5&      �  � RowDefinitions 5(      �� 5)      $	��100 �6$   �� 5*      	 � ColumnDefinitions	 5,      �� 5-      $	��250 �6'   �� 5.      .+�53      � -   5        
 �Name$
 GridMenu��53   $   $��1��6   $	��250��66   $
��Left=�6B   $��0 0 0 0q�6]   
������  J� RenderTransformOrigin$ 0.5,0.5&�6�   .+�55      �� .+�58      �� -   5        ���	#FF313131$��Champagne & Limousines)�58   g   $��18(�6�   .@�59      �� -   5        $
��Home��59   +   $��45��67   $��0q�6C   .��5:   &   �� $ 
Horizontal=�61   $
��10 0q�6J   .+�5;   *   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Recycle=�6B   $��20��6Q   $��20��6\   
�������$��5q�6z   $��Center=�6�   �� 5<   *   $��Recycle��64   $��10q�6C   5=   '   5>      �� 5@      -   5        $��Income��5@   +   $��45��69   $��0q�6E   .��5A   "   �� $ 
Horizontal=�6-   $
��10 0q�6F   .+�5B   &     $ HelpCircleOutline=�6>   $��20��6W   $��20��6b   ���	#FFF08033$��5q�6�   $��Center=�6�   �� 5C   &   $
��Help��60   $��10q�6<   5D   #   5E      �� 5F      -   5        $��Expences��5F   +   $��45��6;   $��0q�6G   .��5G   "   �� $ 
Horizontal=�6-   $
��10 0q�6F   .+�5H   &     $ 	Lightbulb=�6>   $��20��6O   $��20��6Z   
��� � �$��5q�6y   $��Center=�6�   �� 5I   &   $��Send Feedback��60   $��10q�6E   5J   #   5K      �� 5L      $��45��6+   $��0q�67   .��5M   "   �� $ 
Horizontal=�6-   $
��10 0q�6F   .+�5N   &     $ Heart=�6>   $��20��6K   $��20��6V   ���	#FFD41515$��5q�6y   $��Center=�6�   �� 5O   &   $��	Recommend��60   $��10q�6A   5P   #   5Q      �� 5R      $��45��6+   $��0q�67   .��5S   "   �� $ 
Horizontal=�6-   $
��10 0q�6F   .+�5T   &     $ 
StarCircle=�6>   $��20��6P   $��20��6[   ���	#FFE6A701$��5q�6~   $��Center=�6�   �� 5U   &   $��Premium Subscription��60   $��10q�6L   5V   #   5W      �� 5X      $��45��6+   $��0q�67   .��5Y   "   �� $ 
Horizontal=�6-   $
��10 0q�6F   .+�5Z   &     $ Settings=�6>   $��20��6N   $��20��6Y   ���	#FF0069C1$��5q�6|   $��Center=�6�   �� 5[   &   $��Settings��60   $��10q�6@   5\   #   5]      5^      5_      5a      A� 5c      -   5        ���#D00$��1��5d      $��15��5e      $��15��5f      $��Right=�5g      $	��Top=�5h      $��	0,10,10,0q�5i       � ToolTip$ Close��5k       � Cursor$
 Hand��5l      6>   A� 5n      -   5        ���#DD0$��1��5o      $��15��5p      $��15��5q      $��Right=�5r      $	��Top=�5s      $��	0,10,30,0q�5t      $ Minimize��5v      $
 Hand��5x      6$   �� 5{      $��1��5|      $��1��5}      $��10q�5~      ��5{   !   �� 5~      5�      5�      5�      5�      