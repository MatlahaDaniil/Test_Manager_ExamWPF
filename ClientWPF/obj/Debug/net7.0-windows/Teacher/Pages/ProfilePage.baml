   M S B A M L   `   `   `  ����D  @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ClientWPF.PagesFromTeacherClientWPF.PagesFromTeacher  5      ,    &ClientWPF.PagesFromTeacher.ProfilePage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:ClientWPF.PagesFromTeacher     5        N� Title$  ProfilePage��5	       � 	Resources 5       �� 
TargetType   	Names_txb �� Property �� Value  Info_txb��%  &	        &	 �     �� 5   
   " ��6   .�5      ��  � ��$ 25(�6)   �� 5       � ��$ 	10,10,0,0q�6'   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ 5,10,0,0q�6'   5      5      .��5      � 
������  � RowDefinitions 5   
   �� 5      $	��300 �6   �� 5      .+�5   
   � 
������ $��20q�6(    � ColumnDefinitions 5!      �� 5"      $	��200 �6#   �� 5#      .+�5&      �� $��2��6    �� CornerRadius$ 15��5'      ���#DFD9D9
���   �$��3q�5*      A� 5,      -   5         A�Name$ AccPhoto_elips��52      $	��170��5,      $	��170��5-      $��2��5.      
���   �$��Center=�50      $��Center=�51      ��53      �� 54      	 �� ImageSource$'	 !/Resources/Icons/DarkIconUser.png��6!   
 j� Stretch$
 UniformToFill=�6Q   56      A� 58       A� Columns$ 2��6   $��1��6&   .+�5:      �� $��	П.І.Б.��6   #��[  5;      �� 5=      -   5         ��Name$ Fullname_txb��5>      $��Не вказано��5=      #��[ 5?      �� 5A      $��
Пошта��6   #��[  5B      �� 5D      -   5        $ 	Email_txb��5E      $��Не вказано��5D      #��[ 5F      �� 5H      $!��Номер телефону��6   #��[  5I      �� 5K      -   5        $ NumPhone_txb��5L      $��Не вказано��5K      #��[ 5M      �� 5O      $��Номер школи��6   #��[  5P      �� 5R      -   5        $ NumSchool_txb��5S      $��Не вказано��5R      #��[ 5T      5V      5W      �� 5Y   
   ���#2F3136$ 15��5Z      
�������$��2q�5\      $��20q�5]      $��1��5^      ._�5`      �� $��1��6   .+�5a      �� $2��,СПИСОК СТВОРЕНИХ ТЕСТІВ��6   $��25(�5b      $
��Bold"�5c      
�������
������ $��Center=�5f      $��0,10,0,0q�5g      �� 5i      
�������$��5��5j      $ 5��5k      $��	50,5,50,0q�5l      �� 5n      -   5         ��Name$ ls_View��5r      $��10q�5n      $	��230��5o      
������ $��0q�5q      5r      5t      5v      5w      5x      