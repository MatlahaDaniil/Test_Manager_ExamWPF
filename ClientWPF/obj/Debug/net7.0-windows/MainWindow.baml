   M S B A M L   `   `   `  ����D  @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ClientWPF	ClientWPF  5   	       ClientWPF.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ClientWPF     5   	   -   5          � Title$  Авторизація��5      $	��450��6%   $	��380��65   $	��450��5	   	   $	��380��6    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � Icon$ /Resources/Icons/icon.png��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/Styles.xaml?�6%   %    5      .��5      � .+�5   
   � 	 � RowDefinitions	 5      �� 5      �� 5      .+�5      �� 
 �� CornerRadius$
 20��6   $��2��6'   ���#36393F5&      �� 5(      $��Center=�6   .+�5)      �� $��/Resources/Icons/icon.png��6   $��80��6;   �� 5*      $��Test Manager��6   $��Light"�60   $��22(�5+      
�������$��Center=�5,      5-      �� 5/      $��1��6   .+�51      ��  �� Orientation$ Vertical=�6   $��0,10,0,0q�64   .+�52      �� -   5         ��Name$ Teacher_btn��52      $	��250��62   $��40��6>   $��ВЧИТЕЛЬ��53      $
��Bold"�54      $��
60,0,60,20q�55         btn_ForStyleTestManager#��[  56      57      �� 59      -   5        $ Student_btn��59      $	��250��62   $��40��6>   $��
УЧЕНЬ��5:      $
��Bold"�5;      #��[  5<      5=      5?      5A      5F      5H      5I      