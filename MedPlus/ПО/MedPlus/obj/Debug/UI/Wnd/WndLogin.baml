   M S B A M L   `   `   `  ����B  >MedPlus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MedPlus.UI.WndMedPlus.UI.Wnd  5   	       MedPlus.UI.Wnd.WndLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MedPlus.UI.Wnd     5   	   -   5          � Title$1  +МедПлюс - Вход в систему��5   	    � Icon$  /Resources/Assets/Icon.png��5	   	   $
��1024��5
   	   $
��1440��6   $	��800��5   	   $	��800��6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      ��  �� Orientation$ Vertical=�6   $��Center=�6(   $��Center=�6E   .+�5   
   �� $ Vertical=�6   $��Center=�6,   .+�5      �� -   5         ��Name$ ImgLogo��5      $ ��/Resources/Assets/Icon.png��6%   $	��300��6I   6X   �� 5      .��6   
Войти6   �� 5      $
��Left=�6      TblBase#��[  63   
Логин6[   �� 5      -   5         ��Name$ TbLogin��5      6)   �� 5      $
��Left=�6   #��[  63   Пароль6\   G� 5      -   5         G�Name$ PwbxPassword��5      62   �� 5      -   5        $ 
TbPassword��5      $y�	Collapsed=�6*   6C   �� 5      -   5         ��Name$ ChbxPassword��5      $
��Left=�6-   .��6c   Показать пароль6t   �� 5      -   5         ��Name$ BtnLogin��5   )   $��
0,100,0,20q�6     BtnBlack#��[ 6;   .��6t   
Войти6{   �� 5      $��20(�6   6(   5      �� 5   
   $ Vertical=�6   $��Center=�6,   .+�5       �� #��[  6   ywЕсли вы не помните логин или пароль - обратитесь к администратору6|   5!      5#      5$      