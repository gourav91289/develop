   M S B A M L   `   `   `  ����G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  5      4    .com.boutique.Views.UserControls.BoutiqueDetail   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     5      $	��280��5         � DataContext  5      ��    Locator �� Source# [   �� Path$
 Main� � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $8 2/com.boutique;component/Common/StandardStyles.xaml?�5      %    5      .��5      � -   5        $��grdBoutiquedetails��5      
������  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��100 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $
��Left=�6"   $��Center=�5       �� Orientation$ 
Horizontal=�60   $��10,10q�6I   .+�5      �� $	��105��6   $��Boutique Name : ��6$   $��12(�6<   $��Center=�5       �� TextAlignment$ Right=�65   $��Center=�6K   $��SemiBold"�5       ���#8181835!      �� 5"      -   5        $��txtName��5"      
�������$	��160��5$        DefaultTextbox#��[ 6"   ��5"   %   �� $
 Name�	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� ValidatesOnDataErrors .  5$   L   5%      �� 5'   
   $��1��6   $
��Left=�6"   $��Center=�5(      $ 
Horizontal=�60   $��
10,0,10,10q�6I   .+�5)      �� $��Boutique Address : ��6   $��12(�63   $��Center=�5*      $��SemiBold"�5+      $ Right=�6.   ���#8181835,      �� 5-      -   5        $��
txtAddress��5-      $	��160��5/      $��13(�6"   
�������  DefaultTextArea#��[ 50      ��5-   (   �� $! boutiqueInformation.Address�$	 TwoWay=�$
 PropertyChanged=�50   A   51      �� 53   
   $��2��6   $
��Left=�6"   $��Center=�54      $ 
Horizontal=�60   $��
10,0,10,10q�6I   .+�55      �� $	��105��6   $��Phone Number : ��6$   $��12(�6;   $��Center=�56      $��Center=�65   $��SemiBold"�57      $ Right=�6.   ���#81818358      �� 59      -   5        $��txtPhoneNumber��59      
�������$	��160��5;      #��[ 6"   ��59   ,   �� $% boutiqueInformation.PhoneNumber�$	 TwoWay=�$
 PropertyChanged=�5;   L   5<      �� 5>   
   $��3��6   $
��Left=�6"   $��Center=�5?      $ 
Horizontal=�60   $��
10,0,10,10q�6I   .+�5@      �� $	��105��6   $��Mobile Number : ��6$   $��12(�6<   $��Center=�5A      $��Center=�65   $��SemiBold"�5B      $ Right=�6.   ���#8181835C      �� 5D      -   5        $��txtlandline��5D      $	��160��5E      $��13(�6"   
�������#��[ 5F      ��5D   )   �� $( "boutiqueInformation.LandlineNumber�$	 TwoWay=�$
 PropertyChanged=�5F   @   5G      �� 5I   
   $��4��6   $��Center=�6"   $��Center=�5J      $ 
Horizontal=�60   $��
10,0,10,10q�6I   .+�5K      �� -   5        $$��btnPreviousBoutiqueInformation��5K        BasicButton#��[ 5L      
�������$��Center=�5M   (   $��Cancel��6E   ���#4E4E505P      �� 5R      -   5        $"��btnFinsihBoutiqueInformation��5R      ���#3088da#��[ 5T      
�������$��Center=�5V      $��Update��62   5X      5Z      5\      5]      