   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  0    *com.boutique.Views.UserControls.UserDetail   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  DUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper    � DataContext  ��    Locator �� Source# [   �� Path$
 Main� � 	Resources  �� MergedDictionaries �� Source��  �� $8 2/com.boutique;component/Common/StandardStyles.xaml?�%    .��� -   $��grdUserdetails��
������  � RowDefinitions �� $��50 ��� $��40 ��� $��40 ��� $��40 �.+��� $��0��$
��Left=�$��Center=� �� Orientation$ 
Horizontal=�$��10,10,10,10q�.+��� $��70��$��First Name : ��$��12(� �� TextAlignment$ Right=�$��Right=�$��Center=�$��SemiBold"����#818183�� -   $��txtFirstName��
�������$	��200��  DefaultTextbox#��[ ���� $ 	FirstName�	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� ValidatesOnDataErrors .  �� $��1��$
��Left=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� $��70��$��Last Name : ��$��12(�$��Center=�$��Center=�$ Right=�$��SemiBold"����#818183�� -   $��txtLastName��
�������$	��200��#��[ ���� $ LastName�$	 TwoWay=�$
 PropertyChanged=� .  �� $��2��$
��Left=�$��Center=�$ 
Horizontal=�$��	10,0,0,10q�.+��� $��User Name : ��$��12(�$��Center=�$��Center=�$ Right=�$��SemiBold"����#818183�� -   $��txtUserName��
�������$	��200��#��[ ���� $ UserName�$	 TwoWay=�$
 PropertyChanged=� .  �� $��3��$��Center=�$��Center=�$ 
Horizontal=�$��	10,0,0,10q�.+��� -   $��btnNextUserInformation��  BasicButton#��[ 
�������$��Center=�$��Cancel�����#4E4E50�� -   $��btnCancelUserInformation�����#3088da#��[ 
�������$��Center=�$��Update��