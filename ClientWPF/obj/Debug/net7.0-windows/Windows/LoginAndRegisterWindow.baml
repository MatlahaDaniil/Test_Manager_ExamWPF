   M S B A M L   `   `   `  ����D  @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ClientWPF.PagesClientWPF.Pages  5   	   !    ClientWPF.Pages.LoginWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ClientWPF.Pages     5   	   -   5          � Title$  Авторизація��5   	   $	��450��6   $	��380��6-   $	��450��5	   	   $	��380��6    � WindowStartupLocation$ CenterOwner=�5
   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	   
������  � 
ResizeMode$ NoResize=�5   	    � Icon$ /Resources/Icons/icon.png��5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/Styles.xaml?�6%   %    5      .��5      � .+�5   
   � 	 � RowDefinitions	 5      �� 5      �� 5      .+�5!      �� 
 �� CornerRadius$
 20��6   $��2��6'   ���#36393F68   �� 5#      $��Center=�6   .+�5$      �� $��/Resources/Icons/icon.png��6   $��80��6;   �� 5%      $��Test Manager��6   $��Light"�60   $��22(�5&      
�������$��Center=�5'      5(      �� 5*      $��1��6   .+�5+      ��  �� Orientation$ 
Horizontal=�6   .+�5,      �� -   5         ��Name$ Username_txb��5,      $��Light"�64   $��
Логін��5-      $��20(�6'   $��Center=�5.      
������ $
��Left=�5/      $��0q�50      
�������$	��235��6A    J� Opacity$	 0.5Q�51      $��25��6(   $��62,0,0,0q�64   53      �� 55      $��/Resources/Icons/user.png��6   $��20��56      $��20��57      $��Center=�58      $��Center=�59      5;      �� 5<      $	��255��6   $��2��6%   
�������$	 0.5Q�6C   �� 5>      $ 
Horizontal=�6   $��0,30,0,0q�66   .+�5?      G� -   5         G�Name$ Password_pb��5?   "   $��Light"�67   $��20(�6J   $��Center=�5@      
������ $
��Left=�5A      $��0q�5B      
�������$	��235��6A    G� Password$ password��5C      $	 0.5Q�5D      $��25��6(   $��62,0,0,0q�64   5F      �� 5H      $#��/Resources/Icons/password.png��6   $��20��6C   $��Center=�5I      $��Center=�65   5J      �� 5K      $	��255��6   $��2��6%   
�������$	 0.5Q�6C   �� 5N      $ 
Horizontal=�6   $��0,50,0,0q�66   .+�5O      �� -   5         ��Name$ 	LogIn_btn��5O      $	��100��60   $��40��5P      $��УВІЙТИ��6)   $
��Bold"�5Q      $��	60,0,60,0q�5R         btn_ForStyleTestManager#��[  5T      �� 5V      -   5        $ Register��5V      $	��100��6/   $��40��5W      $��РЕЄСТРАЦІЯ��6)   $
��Bold"�5X      #��[  5Z      5[      5\      5]      5^      5_      