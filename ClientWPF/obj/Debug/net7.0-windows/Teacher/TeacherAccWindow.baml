   M S B A M L   `   `   `  ����D  @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ClientWPF.WindowsClientWPF.Windows  5   	   I)clr-namespace:ClientWPF.Teacher.ViewModelClientWPF.Teacher.ViewModel  5   	   (    "ClientWPF.Windows.TeacherAccWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ClientWPF.Windows     5   	   8vm)clr-namespace:ClientWPF.Teacher.ViewModel     5   	     � Title$  TeacherAccWindow��5	   	    � 
ResizeMode$ CanResizeWithGrip=�5
   	   $	��768��5   	   $
��1300��6    � Icon$ /Resources/Icons/icon.png��5   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � DataContext 5      /  )ClientWPF.Teacher.ViewModel.MainViewModel  5   
    � 	Resources 5       �� MergedDictionaries	 �� Source�� 5   
    5      �� 5      $	 /Styles/Styles.xaml?�6%   %    5      .��5      � ���#36393F
 � ColumnDefinitions
 5    
   �� 5!      $	��250 �6   �� 5"       � RowDefinitions 5%   
   �� 5&      $��25 �6   �� 5'      .+�5*   
   �� $��2��6   ���#252525._�5-      � -   5        $��Stretch=�5-      .+�5/      �� $��/Resources/Icons/icon.png��6   $��20��50      $��20��51      $��7,2,0,1q�52      $
��Left=�53      �� 55      $��Task Manager��6   
�������$��14(�57      $
��Bold"�58      $��35,2,0,0q�59      �� 5;      -   5         ��Name$ 	TimeBlock��5<      
�������$��25(�5>      $��1��5?      $��Center=�5@      $��Center=�5A      �� 5C      $��Right=�6    �� Orientation$ 
Horizontal=�69   .+�5D      �� -   5         ��Name$ 	Minus_btn��5H      $��23��5D      $��23��6)   
������ $��0q�5F      $��0,3,5,0q�5G         Style_btnWithImg#��[  5J      .��5K      �� $ ��/Resources/Icons/minus.png��6    5L      �� 5N      -   5        $ 
Expand_btn��5R      $��23��5N      $��23��6)   
������ $��0q�5P      $��0,2,5,0q�5Q      #��[  5T      .��5U      �� $'��!/Resources/Icons/expandWindow.png��6    5V      �� 5X      -   5        $ 	Close_btn��5\      $��23��5X      $��23��6)   
������ $��0q�5Z      $��0,2,5,0q�5[      #��[  5^      .��5_      �� $ ��/Resources/Icons/close.png��6    5`      5a      5b      5c      � 5e   
   $��1��6   ���#2F3136 5g        Names_txb_Style �� 
TargetType �� Property �� Value  Info_txb_style��%�  &	       &	 �     �� 5h      " ��60   .�5i      ��  � ��
 �����63   �� 5j       � ��$ 5,15,0,0q�6/   �� 5k       � ��$
 Bold"�63   �� 5l       � ��$ 20(�61   5m      �� 5o      " ��6/   .�5p      ��  � ��
 �����63   �� 5q       � ��$ 5,19,0,0q�6/   �� 5r       � ��$ 10(�61   �� 5s       � ��$ 16(�61   5t      5v       5x      �� 5y      $	��200 �6    �� 5z      .+�5}      � .+�5~      A� -   5         A�Name$ AccPhoto_elips��5�      $	��170��5~      $	��170��5      $��1��5�      
�������$��Center=�5�      $��Center=�5�      ��5�      �� 5�       �� ImageSource$&  /Resources/Icons/profileUser.png��6%    j� Stretch$ UniformToFill=�6T   5�      �� 5�      $��Right=�6   $��Bottom=�5�      $��	0,0,15,20q�5�      
������ $��30��5�      #��[  5�      ��5�      �� *OpenEditProfile_Page+.��5�      �� $��/Resources/Icons/edit.png��6   5�      �� 5�      
�������$��5��5�      $��5,0,5,0q�5�       �� CornerRadius$ 5��5�      $��Bottom=�5�      5�      o� 5�      $��1��6   
������ $��0,0,0,0q�5�      ��5�      �� 5�      .R�5�      $�  $� Orientation$ Vertical=�61   5�      .@�5�      m� $��
Тести��6     Menu_SubMenu_Template#��[ 5�       m� Icon 5�      �� 5�      $��/Resources/Icons/test.png��6    .@�5�      m� $��Створити��6     Item_Template#��[ 5�       m� Command 5�      �� *OpenCreateTest_Page+ 5�      �� 5�      $��/Resources/Icons/add.png��6$   $
��Fill=�5�   $   5�      m� 5�      $��Редагувати��6   #��[ 5�       5�      �� *OpenEditTest_Page+ 5�      �� 5�      $!��/Resources/Icons/pencil.png��6$   $
��Fill=�5�   $   5�      m� 5�      $��Видалити��6   #��[ 5�       5�      �� *OpenDeleteTest_Page+ 5�      �� 5�      $!��/Resources/Icons/delete.png��6$   $
��Fill=�5�   $   5�      5�      m� 5�      $��Учні��6   #��[ 5�       5�      �� 5�      $#��/Resources/Icons/students.png��6    .@�5�      m� $��Список��6   #��[ 5�       5�      �� *OpenListStudent_Page+ 5�      �� 5�      $��/Resources/Icons/list.png��6$   $
��Fill=�5�   $   5�      m� 5�      $��Статистика��6   #��[ 5�       5�      �� *OpenStatisticStudents_Page+ 5�      �� 5�      $%��/Resources/Icons/statistics.png��6$   $
��Fill=�5�   $   5�      5�      m� 5�      $��Профіль��6     Menu_Template#��[ 5�       5�      �� *OpenProfile_Page+ 5�      �� 5�      $(��"/Resources/Icons/userForButton.png��6    5�      5�      5�       � 5�   
   -   5          �Name$ Frame��5�      $��1��6   $��1��6/     � NavigationUIVisibility$ Hidden=�5�      ��5�      �� *	CurPage+5�      5�      5�      