   M S B A M L   `   `   `  ���� H  DWPF-LoginForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPF_LoginForm.ViewsWPF_LoginForm.Views  C&clr-namespace:WPF_LoginForm.ViewModelsWPF_LoginForm.ViewModels  K*clr-namespace:WPF_LoginForm.CustomControlsWPF_LoginForm.CustomControls  #    WPF_LoginForm.Views.LoginView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:WPF_LoginForm.Views     <	viewModel&clr-namespace:WPF_LoginForm.ViewModels     Ecustomcontrols*clr-namespace:WPF_LoginForm.CustomControls     -     � Title$  	LoginView��$	��550��$	��800�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�
������  � AllowsTransparency .  � DataContext -   'WPF_LoginForm.ViewModels.LoginViewModel   � 	Resources    BooleanToVisibility��%   &	        �� y���  �� Path$ IsViewVisible� �� Mode$ TwoWay=�	 �� 	Converter#	 [  .���� 
 �� CornerRadius$
 12��._��� $
 10��$��2q� J� Opacity$
 0.95Q�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���  � Color$ 	#FF060606�� � Offset$ 0Q�� $ 	#FF494949��$
 0.75Q�� $ 	#FF111111��$ 1Q����� $	 0,1&�$	 1,0&�.��� $ 	#FF100F21��$ 0Q�� $ 	#FF212027��$ 1Q�._��  � RowDefinitions �� $��30 ��� .+�� $��0�� � ColumnDefinitions �� �� $��25 ��� $��25 ��� $��5 �.+��� $��LOG IN��
�������$��10(�$��
Montserrat)�$��0��$��Center=�$��10,0,0,0q��� -    ��Name$ btnMinimize��$��0q�$��-��
�������$��16(�$��
Montserrat)� � Cursor$
 Hand��$��1������  �� 
TargetType" ��.���  �� Property � �� �� Value
 �   � �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �	#FF616161����  �� 
TargetType" ��.R��� $��18��$��18��$
 9��#��z��._��� $��Center=�$��Center=��� -   $ btnClose��$��0q�$��X��
�������$��12(�$��
Montserrat)�$
 Hand��$��2������ " ��.���  � ��
 �   � P�  �@J�IsMouseOver . . ���  � �� �	#FF787477���� " ��.R��� $��18��$��18��$
 9��#��z��._��� $��Center=�$��Center=��� $	��220��$��1�� �� Orientation$ Vertical=�$��0,35,0,0q�.+��� $	��♦��
�������$��50(�$��Medium"�$��
Montserrat)�$��Center=��� $��CHARS��
�������$��25(�$��Medium"�$��
Montserrat)�$��Center=��� $��From Burnout to code��
�������$��12(�$��Medium"�$��
Montserrat)�$
��Wrap=� �� TextAlignment$ Center=�$��0,5,0,0q��� $��Username��
�������$��12(�$��Medium"�$��
Montserrat)�$��0,35,0,0q��� -    ��Name$ txtUser��$��13(�$��Medium"�$��
Montserrat)�
������� �� 
CaretBrush
 �����
�������$��0,0,0,2q�$��28��$��Center=�$��0,5,0,0q�$��20,0,0,0q����� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�.������   �� ImageSource$  /Images/user-icon.png��! j� Stretch$
! None=�" j� 
AlignmentX$
" Left=�.���� $��Password��
�������$��12(�$��Medium"�$��
Montserrat)�$��0,15,0,0q�6   0WPF_LoginForm.CustomControls.BindablePasswordBox  $��28��$��0,5,0,0q�#   Password# �� *
Password+$ TwoWay=�$ PropertyChanged=��� ���#D7596D$��12(�$��Medium"�$��
Montserrat)�$��0,10,0,0q�$
��Wrap=����� *ErrorMessage+�� -   $ btnLogin��$��0q�$��LOG IN��
�������$��12(�$��
Montserrat)�$
 Hand��$��0,30,0,0q����� *LoginCommand+���� " ��.���  � �� �	#FF363636 P�  �@J�IsMouseOver . . ���  � �� �	#FF8B8B8B���� " ��.R��� $	��150��$��40��$
 20��#��z��._��� $��Center=�$��Center=��� $ 
Horizontal=�$��Center=�$��0,15,0,0q�.+��� $��Forgot Password?��
�������$��12(�$��Medium"�$��
Montserrat)��� $��Reset��
�������$��12(�$��Medium"�$��
Montserrat)�$
 Hand��$��8,0,0,0q�