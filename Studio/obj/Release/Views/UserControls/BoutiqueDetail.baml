   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  4    .com.boutique.Views.UserControls.BoutiqueDetail   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     $	��280��  � DataContext  ��    Locator �� Source# [   �� Path$
 Main� � 	Resources  �� MergedDictionaries �� Source��  �� $8 2/com.boutique;component/Common/StandardStyles.xaml?�%    .��� -   $��grdBoutiquedetails��
������  � RowDefinitions �� $��50 ��� $	��100 ��� $��40 ��� $��40 ��� $��40 ��� $��40 �.+��� $��0��$
��Left=�$��Center=� �� Orientation$ 
Horizontal=�$��10,10q�.+��� $	��105��$��Boutique Name : ��$��12(�$��Center=� �� TextAlignment$ Right=�$��Center=�$��SemiBold"����#818183�� -   $��txtName��
�������$	��160��  DefaultTextbox#��[ ���� $
 Name�	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� ValidatesOnDataErrors .  �� $��1��$
��Left=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� $��Boutique Address : ��$��12(�$��Center=�$��SemiBold"�$ Right=����#818183�� -   $��
txtAddress��$	��160��$��13(�
�������  DefaultTextArea#��[ ���� $! boutiqueInformation.Address�$	 TwoWay=�$
 PropertyChanged=��� $��2��$
��Left=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� $	��105��$��Phone Number : ��$��12(�$��Center=�$��Center=�$��SemiBold"�$ Right=����#818183�� -   $��txtPhoneNumber��
�������$	��160��#��[ ���� $% boutiqueInformation.PhoneNumber�$	 TwoWay=�$
 PropertyChanged=��� $��3��$
��Left=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� $	��105��$��Mobile Number : ��$��12(�$��Center=�$��Center=�$��SemiBold"�$ Right=����#818183�� -   $��txtlandline��$	��160��$��13(�
�������#��[ ���� $( "boutiqueInformation.LandlineNumber�$	 TwoWay=�$
 PropertyChanged=��� $��4��$��Center=�$��Center=�$ 
Horizontal=�$��
10,0,10,10q�.+��� -   $$��btnPreviousBoutiqueInformation��  BasicButton#��[ 
�������$��Center=�$��Cancel�����#4E4E50�� -   $"��btnFinsihBoutiqueInformation�����#3088da#��[ 
�������$��Center=�$��Update��