   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  Q-clr-namespace:com.boutique.Views.UserControlscom.boutique.Views.UserControls      com.boutique.Views.Setup   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:com.boutique.Views     JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  @UserControls-clr-namespace:com.boutique.Views.UserControls  -     �Name$  SetupWindow�� � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�$	��400��$	��250��$��Center=�$��Center=� � Icon$0 */com.boutique;component/Images/appicon.ico�� � Title$ Boutique App�� � DataContext ��    Locator �� Source# [  	 �� Path$	 Setup�
 � 	Resources
  �� MergedDictionaries �� Source��  �� $8 2/com.boutique;component/Common/StandardStyles.xaml?�%    .��� .+��� ���#1B1B1C���#434346$��2q� �� CornerRadius$ 0�� �� Padding$ 20q�._���  �� Orientation$ Vertical=�$��Center=�$��Center=�.+��� }�. $
��Wrap=�$��25(� �� TextAlignment$ Center=�
�������$��SemiBold"�$��	Open Sans)����� $	 Configuration� �� UpdateSourceTrigger$ PropertyChanged=��� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$0 */com.boutique;component/Images/process.gif��$��50��$��Center=�$��Center=��� }�. $
��Wrap=�$��13(�$ Right=�
���   �$��SemiBold"�$��	Open Sans)����� $	 TimeCounter�$ PropertyChanged=�� -   $��
PopUpSetUp����.  $
��None=� � AllowsTransparency .  � 	StaysOpen . $��Center=�$��Bottom=�$��Center=�$	��500��$��-50,0,-50,125q�.���� ���#1B1B1C���#007ACC$��1q�$ 0��._�� -   $��grdProcessing��$��Center=����#1B1B1C}�. $��10q�$
��Left=�$	��480�� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��0��$
��Left=�$ 
Horizontal=����� *ActualWidth+ �� ElementName$ grdProcessing��.+��� $y�Visible=�$3 -/com.boutique;component/Images/processing.gif��$��30��$��Center=��� $
 5,15q����#efefef._��� $��Installing Setup��$��15(�$��Center=�$��SemiBold"�
��������� $��1��$��0��$
��Left=�$ 
Horizontal=�$��0,0,0,20q����� *ActualWidth+$ grdProcessing��.+��� $
 Left=�$��50,0,0,0q�$��Please wait��$��13(�$��Right=�$��Normal"�
�������� -   $��SendingAssetsreachEngine��$��Center=�$
��Left=�$	��300��$��20��$��10,0,0,0q� � Minimum$ 0Q� � Maximum$	 100Q� � Value$ 1Q����#434346���#007ACC
���   ��� $��2��$��0�����#434346$��1q�$ 0q�$	��300��._��� $ Vertical=�
  �� 
TargetType �� Property �� Value��%/   '��       �� " ��.���  � ��
 �����.+��� $��1q����#4E4E50���#4E4E50$ 5q�._��� $@��:Please provide the following details to setup your profile��$
��Wrap=�$��14(�$��Center=�$ Center=�$��Normal"�
�������� -   $��grdUserdetails��$y�Visible=� �� �� �� �� �� .+��� $��0��$
��Left=�$��Center=�$ 
Horizontal=�$��10,10,10,10q�.+��� $��70��$��First Name : ��$��12(�$ Right=�$��Right=�$��Center=�$��SemiBold"����#818183�� -   $��txtFirstName��$	��200��  DefaultTextbox#��[ ���� $	 	FirstName� �� Mode$ TwoWay=�$ PropertyChanged=� �� ValidatesOnDataErrors .  �� $��1��$
��Left=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� $��70��$��Last Name : ��$��12(�$��Center=�$��Center=�$ Right=�$��SemiBold"����#818183�� -   $��txtLastName��$	��200��#��[ ���� $	 LastName�$ TwoWay=�$ PropertyChanged=� .  �� $��2��$
��Left=�$��Center=�$ 
Horizontal=�$��	10,0,0,10q�.+��� $��User Name : ��$��12(�$��Stretch=�$��Center=�$ Right=�$��SemiBold"����#818183�� -   $��txtUserName��$	��200��#��[ ���� $	 UserName�$ TwoWay=�$ PropertyChanged=� .  �� $��3��$
��Left=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� $��70��$��Password : ��$��12(�$��Center=�$��Center=�$��SemiBold"�$ Right=����#818183G� -	   $��txtPassword��?   9com.boutique.Common.UserInterfaceHelper.CustomPasswordBox   BindPassword . $	��200��  DefaultPasswordbox#��[     BoundPassword  �� $	 Password�$ TwoWay=�! �� NotifyOnValidationError! .   .  �� $��4��$��Right=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� -
   $��btnNextUserInformation��  BasicButton#��[ 
�������$��Center=�$��Cancel�����#4E4E50�� -   $��btnCancelUserInformation�����#3088da#��[ 
�������$��Center=�$
��Next��� -   $��grdBoutiquedetails��$y�	Collapsed=� �� �� �� �� �� �� .+��� $��0��$
��Left=�$��Center=�$ 
Horizontal=�$��10,10q�.+��� $	��105��$��Boutique Name : ��$��12(�$��Center=�$ Right=�$��Center=�$��SemiBold"����#818183�� -   $��txtName��$	��160��#��[ ���� $
	 Name�$ TwoWay=�$ PropertyChanged=� .  �� $��1��$
��Left=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� $��Boutique Address : ��$��12(�$��Center=�$��SemiBold"�$ Right=����#818183�� -   $��
txtAddress��$	��160��$��13(�  DefaultTextArea#��[ ���� $!	 boutiqueInformation.Address�$ TwoWay=�$ PropertyChanged=��� $��2��$
��Left=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� $	��105��$��Phone Number : ��$��12(�$��Center=�$��Center=�$��SemiBold"�$ Right=����#818183�� -   $��txtPhoneNumber��$	��160��#��[ ���� $%	 boutiqueInformation.PhoneNumber�$ TwoWay=�$ PropertyChanged=��� $��3��$
��Left=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� $	��105��$��Mobile Number : ��$��12(�$��Center=�$��Center=�$��SemiBold"�$ Right=����#818183�� -   $��txtlandline��$	��160��#��[ ���� $(	 "boutiqueInformation.LandlineNumber�$ TwoWay=�$ PropertyChanged=��� $��4��$��Right=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� -   $$��btnPreviousBoutiqueInformation��#��[ 
�������$��Center=�$��Previous�����#4E4E50�� -   $"��btnFinsihBoutiqueInformation�����#3088da#��[ 
�������$��Center=�$��Finsih��� -   $��AlertBox��$��80��$	��230��$
��Fade=�" � VerticalOffset$" 50��$��Center=�$��Center=�$��Center=� . # K� ZIndex$# 10������ *
IsExired+.���� ���#007ACC$��1q�._�� ���#1B1B1C$��Center=� �� $
��Auto ��� $
��Auto �.+�� $��0��$��	0,10,10,0q�.+��� -   $ ��Name$$ 
messageBox��$ Center=�$��Center=�$��Center=�$��	15 5 0 10q�$
��Wrap=�$��14(�$��Licence has expired��
��������� -   % ��Name$% btnOk��$��Center=�$# 11��$��80��$��0,0,0,10q�#��[ ���#3088da$��Ok��& �� 	IsDefault& . $��1��