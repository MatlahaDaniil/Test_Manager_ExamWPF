   M S B A M L   `   `   `  ����D  @ClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ClientWPF.StudentClientWPF.Student  5   	   %    ClientWPF.Student.StudentWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ClientWPF.Student     5   	     � Title$  StudentWindow��5   	    � 
ResizeMode$ CanResizeWithGrip=�5	   	   $	��800��5
   	   $
��1300��6    � Icon$ /Resources/Icons/icon.png��5   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/Styles.xaml?�6%   %    5      .��5      � ���#36393F	 � ColumnDefinitions	 5   
   �� 5       $	��250 �6   �� 5!      
 � RowDefinitions
 5$   
   �� 5%      $��25 �6   �� 5&      .+�5)   
   �� $��2��6   ���#252525._�5,      � -   5        $��Stretch=�5,      .+�5.      �� $��/Resources/Icons/icon.png��6   $��20��5/      $��20��50      $��7,2,0,1q�51      $
��Left=�52      �� 54      $��Task Manager��6   
�������$��14(�56      $
��Bold"�57      $��35,2,0,0q�58      �� 5:      $��Right=�6    �� Orientation$ 
Horizontal=�69   .+�5;      �� -   5         ��Name$ 	Minus_btn��5?      $��23��5;      $��23��6)   
������ $��0q�5=      $��0,3,5,0q�5>         Style_btnWithImg#��[  5A      .��5B      �� $ ��/Resources/Icons/minus.png��6    5C      �� 5E      -   5        $ 
Expand_btn��5I      $��23��5E      $��23��6)   
������ $��0q�5G      $��0,2,5,0q�5H      #��[  5K      .��5L      �� $'��!/Resources/Icons/expandWindow.png��6    5M      �� 5O      -   5        $ 	Close_btn��5S      $��23��5O      $��23��6)   
������ $��0q�5Q      $��0,2,5,0q�5R      #��[  5U      .��5V      �� $ ��/Resources/Icons/close.png��6    5W      5X      5Y      5Z      � 5\   
   $��1��6   ���#2F3136 5^        Names_txb_Style �� 
TargetType �� Property �� Value  Info_txb_style��%�  &	       &	 �     �� 5_      " ��60   .�5`      ��  � ��
 �����63   �� 5a       � ��$ 5,15,0,0q�6/   �� 5b       � ��$
 Bold"�63   �� 5c       � ��$ 20(�61   5d      �� 5f      " ��6/   .�5g      ��  � ��
 �����63   �� 5h       � ��$ 5,19,0,0q�6/   �� 5i       � ��$ 10(�61   �� 5j       � ��$ 16(�61   5k      5m      
 5o      �� 5p      $	��200 �6    �� 5q      .+�5t      � .+�5u      A� -   5         A�Name$ AccPhoto_elips��5{      $	��170��5u      $	��170��5v      $��1��5w      
�������$��Center=�5y      $��Center=�5z      ��5|      �� 5}       �� ImageSource$&  /Resources/Icons/profileUser.png��6%    j� Stretch$ UniformToFill=�6T   5      �� 5�      $��Right=�6   $��Bottom=�5�      $��	0,0,15,20q�5�      
������ $��30��5�      #��[  5�      ��5�      �� *OpenEditProfile_Page+.��5�      �� $��/Resources/Icons/edit.png��6   5�      �� 5�      
�������$��5��5�      $��5,0,5,0q�5�       �� CornerRadius$ 5��5�      $��Bottom=�5�      5�      o� 5�      $��1��6   
������ $��0,0,0,0q�5�      ��5�      �� 5�      .R�5�      $�  $� Orientation$ Vertical=�61   5�      .@�5�      m� $��
Тести��6     Menu_Template#��[ 5�       m� Icon 5�      �� 5�      $��/Resources/Icons/test.png��6    5�      m� 5�      $��Історія��6   #��[ 5�       m� Command 5�      �� *OpenProfile_Page+ 5�      �� 5�      $"��/Resources/Icons/history.png��6    5�      m� 5�      $��Профіль��6   #��[ 5�       5�      �� *OpenProfile_Page+ 5�      �� 5�      $(��"/Resources/Icons/userForButton.png��6    5�      5�      5�       � 5�   
   -   5          �Name$ Frame��5�      $��1��6   $��1��6/     � NavigationUIVisibility$ Hidden=�5�      ��5�      �� *	CurPage+5�      5�      5�      