   M S B A M L   `   `   `  ����D  @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:ClientWPF.Teacher.TeacherWindows ClientWPF.Teacher.TeacherWindows  5   	   2    ,ClientWPF.Teacher.TeacherWindows.AddQuestion   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:ClientWPF.Teacher.TeacherWindows     5   	     � Title$  Add Question��5   	   $	��550��5	   	   $	��500��5
   	   $	��550��5   	   $	��500��5   	   
������  � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/Styles.xaml?�6%   %    5      .��5      � .+�5   
   �� ���#2F3136
�������$��3q�5       �� CornerRadius$ 25��5      ._�5       �� .+�5!      � $��10,10,10,10q�6    � ColumnDefinitions 5#      �� 5$      �� 5%      $��70 �6+   .+�5'      �� -   5        	 ��Name$	 Question_txb��5'      
�������$��35(�5)      
������ $��Center=�5+      $��Запитання?��5,      $��0q�5-      $��Center=�5.      �� 50      -   5        
 ��Name$
 SaveQuestion_btn��51      $��1��50      $��0 ,0,0,0q�53      
������ $��0q�55      $	��Top=�56         Style_btnWithImg#��[  57      .��59      �� $'��!/Resources/Icons/WhiteChecked.png��6    $��50��5:       5<      5=      �� 5?      $��0q�6   $��5��5@      
�������$��	20,0,90,0q�5B      $ 5��5C      �� 5E      
�������$��1q�5F      
������ $ 30��5H      $��5,20,5,0q�5I      $	��440��5J      ._�5K      �� .+�5L      � $��5,15,5,0q�6    5M      �� 5N   "   �� 5O   "   $��60 �63   .+�5R      �� $��Відповіді��6(   $��Center=�5S   (   
�������$��30(�5U   (   $
��Bold"�5V   (   �� 5X      -   5        $
 
Add_Answer��5[   %   $��1��5X   %   
������ $��0q�5Z   %   #��[  5]   %   .��5_   "   �� $��/Resources/Icons/add.png��6(   $��50��5`   (   5a      5b      �� 5d      $��0q�6!   $��5��5e   !   
�������$��	20,0,90,0q�5g   !   $ 5��5h   !   5i      5j      5l      5m      5n      5p      