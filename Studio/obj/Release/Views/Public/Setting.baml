   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  Q-clr-namespace:com.boutique.Views.UserControlscom.boutique.Views.UserControls       com.boutique.Views.Setting   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:com.boutique.Views     JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  @UserControls-clr-namespace:com.boutique.Views.UserControls  -     �Name$  SettingsWindow�� � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�$��Center=�$��Center=�$	��500��$	��375�� � Icon$0 */com.boutique;component/Images/appicon.ico�� � Title$ Setting��
������ {��� *IsParentWindowEnabled+ � DataContext ��    Locator �� Source# [  	 �� Path$
	 Main�.���� $��1q����#434346._�� 
 � RowDefinitions
 �� $��35 ��� $��* �.+��� -   $��brdTop�����#4E4E50$��0�����#4E4E50$��0,0,0,1q� �� Padding$ 0,0,0,0q�._��  � ColumnDefinitions �� �� .+���  �� Orientation$ 
Horizontal=�$��Bottom=�$��Right=�$��1��}�. .+��� -   $��MinimizeSettingWindow�� � Cursor$
 Hand��$5��//com.boutique;component/Images/win_minimize.png��$��0,10,0,0q�$��20�� � ToolTip$ Minimize��$��Right=�$��Center=��� -   $��CloseSettingWindow��$
 Hand��$2��,/com.boutique;component/Images/win_close.png��$��10,0,0,0q�$��20��$ Close��$��Right=�$��Center=��� -   $��LogoutSettingWindow��$
 Hand��$/��)/com.boutique;component/Images/logout.png��$��10,0,0,0q�$��20��$ Logout��$��Right=�$��Center=��� $��Right=�$ 
Horizontal=�$��Right=�$��0,0,10,0q�.+��� $2��,/com.boutique;component/Images/user-male.png��$��16��$��10,0,0,0q�o� $��14(� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType K� IsItemsHost��%�   'o�       �� " o�.���  �@�OverridesDefaultStyle . ��  �@J�SnapsToDevicePixels . ��  � ��
 �   ���  � �� �� " o�.R��� $��0,0,0,0q�._��� }�. $ 
Horizontal=� . .@�m� $��Center=�
�������$��Normal"����� *LoggedUserFullName+.@�m� -   $��Change Password��
���   �$��30���� 
�������$��2��m� $��Sign Out��
���   �$��30�� m� Command �� *	OnSignOut+m� $��About��
���   �$��30�� �� *About+�� ���#1B1B1C$��1�����#434346$��0,1,0,0q� �� CornerRadius$ 0��$ 20,20,20,50q�$��0q�._�� $	��Top=�
 �� $
��4.5* ��� $
��4.5* �.+��� $ 
Horizontal=�$��0��$��Center=�.+��� $ Vertical=�.+��� $	��New��}�. $
��Wrap=�$��15(� �� TextAlignment$ Center=�
�������$��Normal"�$��	Open Sans)��� $��Measurement��}�. $
��Wrap=�$��15(�$ Center=�
�������$��Normal"�$��	Open Sans)��� -   $��Measurement��$
 Hand��$4��./com.boutique;component/Images/measurement.png��$��0,10,0,0q�$��75��$��Center=�$��Center=��� $ Vertical=�$��20,0,0,0q�.+��� $��Today��}�. $
��Wrap=�$��15(�$ Center=�
�������$��Normal"�$��	Open Sans)��� $��Orders��}�. $
��Wrap=�$��15(�$ Center=�
�������$��Normal"�$��	Open Sans)��� -   $
 Hand��$.��(/com.boutique;component/Images/order.png��$��0,10,0,0q�$��75��$��Center=�$��Center=��� $ Vertical=�$��20,0,0,0q�.+��� $��Today��}�. $
��Wrap=�$��15(�$ Center=�
�������$��Normal"�$��	Open Sans)��� $��Delivery��}�. $
��Wrap=�$��15(�$ Center=�
�������$��Normal"�$��	Open Sans)��� -	   $
 Hand��$6��0/com.boutique;component/Images/order_deliver.png��$��0,10,0,0q�$��75��$��Center=�$��Center=��� $ 
Horizontal=�$��1��$��Center=�.+��� $ Vertical=�$��	20,18,0,0q�.+��� $��Settings��}�. $
��Wrap=�$��15(�$ Center=�
�������$��Normal"�$��	Open Sans)��� -
   $
 Hand��$1��+/com.boutique;component/Images/settings.png��$��0,10,0,0q�$��75��$��Center=�$��Center=��� $ Vertical=�$��	20,18,0,0q�.+��� $��Order/Invoices��}�. $
��Wrap=�$��15(�$ Center=�
�������$��Normal"�$��	Open Sans)��� -   $
 Hand��$0��*/com.boutique;component/Images/invoice.png��$��0,10,0,0q�$��75��$��Center=�$��Center=��� $ Vertical=�$��	20,18,0,0q�.+��� $��Reports��}�. $
��Wrap=�$��15(�$ Center=�
�������$��Normal"�$��	Open Sans)��� -   $
 Hand��$0��*/com.boutique;component/Images/reports.png��$��0,10,0,0q�$��75��$��Center=�$��Center=�� -   $��AlertBox��$	��300��$	��450��$
��Fade=� � VerticalOffset$ 50��$��Center=�$��Center=�$��Center=� � AllowsTransparency .  K� ZIndex$ 10������ *IsAlertOpen+.��.   (com.boutique.Views.UserControls.AlertBox  $��Center=� �� � -   $��ChangePasswordBox��$
��Fade=�$ 0��$��Center=�$��Center=�$��Center=� . ���� *IsChangePasswordOpen+.��4   .com.boutique.Views.UserControls.ChangePassword  $��Center=� �� 