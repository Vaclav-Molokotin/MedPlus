   M S B A M L   `   `   `  ����B  >MedPlus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MedPlus.UI.WndMedPlus.UI.Wnd  5   	       MedPlus.UI.Wnd.WndHome   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MedPlus.UI.Wnd     5   	   -   5          � Title$%  МедПлюс - Главная��5   	    � Icon$  /Resources/Assets/Icon.png��5	   	   $
��1024��5
   	   $
��1440��6   $	��800��5   	   $	��800��6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��320 �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      6   �� 5      $��64 �6   6*   .+�5   
   �� $��2q�6      AccentColor#��[  6%   $��2��6P   6f   �� 5   
   $ ��/Resources/Assets/Icon.png��6   $��10q�64   $
��Left=�6@   �� 5   
   -   5         ��Name$ 	LabHeader��5      $��1��6#   $
��Left=�63   $��0q�6N   $��0q�6Y   .��6e   Пациенты6o   �� 5   
   $��1��6   $��2q�6   #��[  62   ._�5      ]� .+�5      ��  �� Orientation$ Vertical=�6   $	��Top=�64   .+�5       �� -   5         ��Name$ BtnPatients��5    K     BtnWhite#��[ 6   $	��250��6?   .��6z   Пациенты6�   �� 5!      -   5        $ 
BtnReports��5!   K   #��[ 6   $	��250��6?   .��6x   Отчётность6�   5"      � 5#      .+�5$      �� -   5        $ BtnExit��5$      $	��250��6.   $��Bottom=�6:   #��[ 6U   .��6�   
Выход6�   5%      5&      5'      �� 5)   
   $��1��6   $��1��6   $��2q�6.   #��[  6B   ._�5*       � -   5          �Name$ FrMain��5*      	  � NavigationUIVisibility$	 Hidden=�6$   6c   5+      � 5-   
   #��[  6   $��2��69   $��2��6F   .+�5.      �� -   5        
 ��Name$
 TblCurrentUser��5.      
�������  TblBase#��[ 6C   $/��)Текущий пользователь: ��6d   6�   5/      50      51      