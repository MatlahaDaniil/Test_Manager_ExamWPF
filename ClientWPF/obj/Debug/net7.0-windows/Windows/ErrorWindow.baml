   M S B A M L   `   `   `  ����D  @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ClientWPF.WindowsClientWPF.Windows  5   	   #    ClientWPF.Windows.ErrorWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ClientWPF.Windows     5   	     � Title$  ErrorWindow��5   	   $	��180��6   $	��500��6*    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��5
   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/Styles.xaml?�6%   %    5      .��5      � .+�5   
   �� ���#36393F �� CornerRadius$ 20��5      $��1q�5      
�������5      � 5   
   
������  � RowDefinitions 5      �� 5      $��30 �6    �� 5      .+�5"      �� $��/Resources/Icons/icon.png��6   $��15,1,0,1q�5#      $
��Left=�5$      $��20��5%      �� 5'      $#��Task Manager - Помилка��6   
�������$��50,5,0,0q�5)      $��15(�5*      �� 5,      -   5        $��Right=�5,      $��35��5-      $��35��5.      $��0,0,5,0q�5/      
������ $��0q�51         Style_btnWithImg#��[  53      .��54      �� $ ��/Resources/Icons/close.png��6   $��0,1,0,5q�55      56      �� 58      $��1��6   $��
10,10,10,0q�59      .+�5:      �� -   5        	 ��Name$	 ExMessage_txb��5:      $��90��5;      $��	20,10,0,0q�5<      
������ $��0q�5>      
�������$��20(�5@      �� 5B      -   5        $��Ok��5B      $��Right=�5C      $	��100��5D      $��30��5E      $��0,8,10,0q�5F        btn_ForStyleTestManager#��[ 5H      5I      5K      5L      5M      