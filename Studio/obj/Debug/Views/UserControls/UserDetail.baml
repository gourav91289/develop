   M S B A M L   `   `   `  ����G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  5      0    *com.boutique.Views.UserControls.UserDetail   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5      DUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper  5        � DataContext  5	      ��    Locator �� Source# [   �� Path$
 Main� � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $8 2/com.boutique;component/Common/StandardStyles.xaml?�5      %    5      .��5      � -   5        $��grdUserdetails��5      
������  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $
��Left=�6"   $��Center=�5       �� Orientation$ 
Horizontal=�60   $��10,10,10,10q�6I   .+�5      �� $��70��6   $��First Name : ��6#   $��12(�68    �� TextAlignment$ Right=�6F   $��Right=�5      $��Center=�64   $��SemiBold"�5      ���#8181835      �� 5       -   5        $��txtFirstName��5!   5   
�������$	��200��5"        DefaultTextbox#��[ 6"   ��5       �� $ 	FirstName�	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� ValidatesOnDataErrors .  5"   L   5#      �� 5%   
   $��1��6   $
��Left=�6"   $��Center=�5&      $ 
Horizontal=�60   $��
10,0,10,10q�6I   .+�5'      �� $��70��6   $��Last Name : ��6#   $��12(�67   $��Center=�6E   $��Center=�5(      $ Right=�65   $��SemiBold"�5)      ���#8181835*      �� 5+      -   5        $��txtLastName��5,   5   
�������$	��200��5-      #��[ 6"   ��5+      �� $ LastName�$	 TwoWay=�$
 PropertyChanged=� .  5-   L   5.      �� 50   
   $��2��6   $
��Left=�6"   $��Center=�51      $ 
Horizontal=�60   $��	10,0,0,10q�6I   .+�52      �� $��User Name : ��6   $��12(�6,   $��Center=�6:   $��Center=�53      $ Right=�65   $��SemiBold"�54      ���#81818355      �� 56      -   5        $��txtUserName��57   5   
�������$	��200��58      #��[ 6"   ��56      �� $ UserName�$	 TwoWay=�$
 PropertyChanged=� .  58   L   59      �� 5;   
   $��3��6   $��Center=�6"   $��Center=�5<      $ 
Horizontal=�60   $��	10,0,0,10q�6I   .+�5=      �� -   5        $��btnNextUserInformation��5=        BasicButton#��[ 5>      
�������$��Center=�5?   (   $��Cancel��6E   ���#4E4E505A      �� 5C      -   5        $��btnCancelUserInformation��5C      ���#3088da#��[ 5E      
�������$��Center=�5G      $��Update��62   5I      5K      5M      5N      