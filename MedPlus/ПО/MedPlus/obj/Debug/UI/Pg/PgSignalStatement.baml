   M S B A M L   `   `   `  ����B  >MedPlus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MedPlus.UI.PgMedPlus.UI.Pg  5      %    MedPlus.UI.Pg.PgSignalStatement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:MedPlus.UI.Pg     5      -   5          N� Title$  PgSignalStatement��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      6   .+�5   
   � .+�5      �� -   5         ��Name$ BtnBack��5         BtnBlack#��[  6&   $	��200��6H   $
��Left=�6T   .��6�   
Назад6�   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ DtpkDay��5      $	��200��6.   6<   �� 5      -   5        $ BtnGenerate��5        BtnWhite#��[ 6.   $	��200��6P   .��6v   Сформировать6�   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgContainer��5         AutoGenerateColumns .  $��1��6D      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Отделение��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   �� 
 �� Path$
 DepartmentName�6b     5      $ На начало��6%   	 68   �� $
 OnStart�6[     5      $ Поступило��6%   	 68   �� $
 AddmitedPatientsCount�6i     5      $ Переведено из��6%   	 6<   �� $
 TransferredFrom�6g     5       $ Переведено в��6%   	 6;   �� $
 TransferredIn�6d     5!      $ Выписано��6%   	 67   �� $
 DischargedCount�6b     5"      $ Умерло��6%   	 65   �� $
 	DiesCount�6Z     5#      $ На конец��6%   	 67   �� $
 OnEnd�6X   5%      5&      5'      