   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  4    .com.boutique.Views.UserControls.ChangePassword   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     $	��280��  � DataContext  ��    Locator �� Source# [   �� Path$
 Main� � 	Resources  �� MergedDictionaries �� Source��  �� $8 2/com.boutique;component/Common/StandardStyles.xaml?�%    .���� ���#1B1B1C$��1q� �� CornerRadius$ 0�����#007ACC$��Center=�._�� 
������  � RowDefinitions �� $��2* ��� $��6* ��� $��2* �.+��� $��Center=�$��0��$��0�����#4E4E50 �� Padding$ 0,5,0,5q�._��� $��Change Password��$��15(�$��Center=�$��Center=�$��0,0,0,0q�$��Normal"�	 �� TextAlignment$	 Right=�
�������� $��0��$��1�� �� �� �� .+��� $��0��$
��Left=�$��Center=�
 �� Orientation$
 
Horizontal=�$��10,10q�.+��� $	��150��$��Current Password: ��$��13(�$��Center=�$	 Right=�$��Center=�$��Normal"����#818183G� -    G�Name$ CurrentPasswordBox��$	��160��  DefaultPasswordbox#��[ ?   9com.boutique.Common.UserInterfaceHelper.CustomPasswordBox   BindPassword .    BoundPassword �� * ChangePasswordData.oldPassword+ �� Mode$ TwoWay=� �� NotifyOnValidationError .   �� ValidatesOnDataErrors .  �� $��1��$
��Left=�$��Center=�$
 
Horizontal=�$��	10,5,10,5q�.+��� $	��150��$��New Password: ��$��13(�$��Center=�$	 Right=�$��Center=�$��Normal"����#818183G� -   $ NewPasswordPasswordBox��$	��160��#��[  .  �� * ChangePasswordData.newPassword+$ TwoWay=� .   .  �� $��2��$
��Left=�$��Center=�$
 
Horizontal=�$��
10,10,10,5q�.+��� $	��150��$��Confirm New Password: ��$��13(�$��Center=�$	 Right=�$��Center=�$��Normal"����#818183G� -   $  ConfirmPasswordPasswordBox��$	��160��#��[  .  �� *'%ChangePasswordData.confirmNewPassword+$ TwoWay=� .   .  �� $��2��$��Center=�$��Center=�$
 
Horizontal=�$��10,10,10,10q�.+��� -   $$��btnPreviousBoutiqueInformation��  BasicButton#��[ 
�������$��Center=�$��Cancel�����#4E4E50���� *OnCancelChangePasswordClick+�� -   $"��btnFinsihBoutiqueInformation�����#3088da#��[ 
�������$��Center=�$��Apply������ *OnSaveChangePasswordClick+