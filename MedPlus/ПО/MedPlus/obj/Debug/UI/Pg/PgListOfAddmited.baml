   M S B A M L   `   `   `  ����B  >MedPlus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MedPlus.UI.PgMedPlus.UI.Pg  5      $    MedPlus.UI.Pg.PgListOfAddmited   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:MedPlus.UI.Pg     5        N� Title$  PgListOfAddmited��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      $	��100 �6   6+   �� 5      6   .+�5   
   �� -   5         ��Name$ BtnBack��5         BtnBlack#��[  6"   $	��200��6D   $
��Left=�6P   .��6�   
Назад6�   �� 5   
   -   5        $ BtnGenerate��5        BtnWhite#��[ 6&   $	��200��6H   $��Right=�6n   .��6�   Сформировать6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� $��25(�6   $��10q�6"   .��6.   С61   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DtpkDateBegin��5      $	��200��60   $��0q�6<   6I   �� 5      $��25(�6   $��40, 10, 10, 10q�6"   .��6:   По6>     5      -   5        $ DtpkDateEnd��5      $	��200��6.   $��0q�6:   6G   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgContainer��5         AutoGenerateColumns .  $��2��6D      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер карты��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   �� 
 �� Path$
 CardID�6\     5      $3 -Дата и время поступления��6%   	 6G   �� $
 DateTimeReceipt�6r     5       $ Отделение��6%   	 68   �� $
 DepartmentName�6b     5!      $ Фамилия��6%   	 66   �� $
 LName�6W     5"      $ Имя��6%   	 62   �� $
 FName�6S     5#      $ Отчество��6%   	 67   �� $
 MName�6X   5%      5&      5'      