   M S B A M L   `   `   `  ����G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  5   	   a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  5	   	   Q-clr-namespace:com.boutique.Views.UserControlscom.boutique.Views.UserControls  5   	       com.boutique.Views.Setup   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:com.boutique.Views     5   	   JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     5	   	   J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5
   	   @UserControls-clr-namespace:com.boutique.Views.UserControls  5   	   -   5          �Name$  SetupWindow��5   	    � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=�5   #    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�6   $	��400��62   $	��250��6>   $��Center=�5   	   $��Center=�6&    � Icon$0 */com.boutique;component/Images/appicon.ico��5   	    � Title$ Boutique App��5   	    � DataContext 5   	   ��    Locator �� Source# [  	 �� Path$	 Setup�
 � 	Resources
 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $8 2/com.boutique;component/Common/StandardStyles.xaml?�5      %    5      .��5      � .+�5   
   �� ���#1B1B1C���#434346$��2q�6<    �� CornerRadius$ 0��6P    �� Padding$ 20q�6a   ._�5      ��  �� Orientation$ Vertical=�6   $��Center=�60   $��Center=�6M   .+�5      �� }�. $
��Wrap=�6y   $��25(�6�    �� TextAlignment$ Center=�6�   
�������$��SemiBold"�5   +   $��	Open Sans)�5       ��5      �� $	 Configuration� �� UpdateSourceTrigger$ PropertyChanged=�5    1   �� 5!      "  WpfAnimatedGif.ImageBehavior   AnimatedSource$0 */com.boutique;component/Images/process.gif��6   $��50��5"      $��Center=�6(   $��Center=�6E   6b   �� 5#      }�. $
��Wrap=�5$   0   $��13(�6D   $ Right=�6R   
���   �$��SemiBold"�5%   /   $��	Open Sans)�5&      ��5#      �� $	 TimeCounter�$ PropertyChanged=�5&   5   5'      5(      � 5*   
   -   5        $��
PopUpSetUp��5,   #   ��.  $
��None=�5*       � AllowsTransparency .  � 	StaysOpen . $��Center=�5+   !   $��Bottom=�6>   $��Center=�5,      $	��500��65   $��-50,0,-50,125q�6\   .��5.      �� ���#1B1B1C���#007ACC$��1q�6@   $ 0��6T   ._�5/      � -   5        $��grdProcessing��5/   2   $��Center=�6   ���#1B1B1C}�. $��10q�50   D   $
��Left=�6P   $	��480��6k    � RowDefinitions 51      �� 52      $
��Auto �6(   68   �� 53      $
��Auto �6(   68   �� 54      $
��Auto �6(   68   .+�57      �� $��0��6!   $��0��6.   $
��Left=�6>   $ 
Horizontal=�6Y   ��58   %   �� *ActualWidth+ �� ElementName$ grdProcessing��.+�59      �� $y�Visible=�6    $3 -/com.boutique;component/Images/processing.gif��5:   (   $��30��5;   $   $��Center=�6/   6L   �� 5<      $
 5,15q�6!   ���#efefef._�5=      �� $��Installing Setup��6(   $��15(�6@   $��Center=�6N   $��SemiBold"�5>   $   
�������6O   5?      5@      �� 5B      $��1��6!   $��0��6.   $
��Left=�6>   $ 
Horizontal=�5C   %   $��0,0,0,20q�6>   ��5D   %   �� *ActualWidth+$ grdProcessing��.+�5E      �� $
 Left=�6$   $��50,0,0,0q�69   $��Please wait��5F   )   $��13(�6<   $��Right=�6J   $��Normal"�5G   (   
�������6Q   � 5I      -   5        $��SendingAssetsreachEngine��5J   Q   $��Center=�5I   &   $
��Left=�6A   $	��300��5J   '   $��20��63   $��10,0,0,0q�6?    � Minimum$ 0Q�5K   !    � Maximum$	 100Q�6-    � Value$ 1Q�6;   ���#434346���#007ACC
���   �5L   5   5M      �� 5O      $��2��6   $��0��6*   ���#434346$��1q�5P   !   $ 0q�65   $	��300��6A   ._�5R      �� $ Vertical=�6%   
 5T       �� 
TargetType �� Property �� Value��%T   '��       �� 5U   "   " ��6(   .�5V   &   ��  � ��
 �����6C   5W   #   5X      .+�5Z      �� $��1q�6%   ���#4E4E50���#4E4E50$ 5q�6d   ._�5[   "   �� $@��:Please provide the following details to setup your profile��6,   $
��Wrap=�5\   0   $��14(�6D   $��Center=�5]   0   $ Center=�6M   $��Normal"�5^   $   
�������6M   5_      � 5a      -   5        $��grdUserdetails��5a   #   $y�Visible=�69    5b   "   �� 5c   &   �� 5d   &   �� 5e   &   �� 5f   &   �� 5g   &   .+�5j   "   �� $��0��6-   $
��Left=�6:   $��Center=�5k   2   $ 
Horizontal=�6M   $��10,10,10,10q�6f   .+�5m   &   �� $��70��60   $��First Name : ��6;   $��12(�6P   $ Right=�6^   $��Right=�5n   8   $��Center=�6T   $��SemiBold"�5o   9   ���#8181835p   '   �� 5q   &   -   5        $��txtFirstName��5r   T   $	��200��5s   :     DefaultTextbox#��[ 6F   ��5q   .   �� $	 	FirstName� �� Mode$ TwoWay=�$ PropertyChanged=� �� ValidatesOnDataErrors .  5s   p   5t   #   �� 5v   "   $��1��6-   $
��Left=�6:   $��Center=�5w   2   $ 
Horizontal=�6M   $��
10,0,10,10q�6f   .+�5y   &   �� $��70��60   $��Last Name : ��6;   $��12(�6O   $��Center=�5z   -   $��Center=�6I   $ Right=�6f   $��SemiBold"�5{   9   ���#8181835|   '   �� 5}   &   -   5        $��txtLastName��5~   T   $	��200��5   :   #��[ 6F   ��5}   .   �� $	 LastName�$ TwoWay=�$ PropertyChanged=� .  5   p   5�   #   �� 5�   "   $��2��6-   $
��Left=�6:   $��Center=�5�   *   $ 
Horizontal=�6E   $��	10,0,0,10q�6^   .+�5�   &   �� $��User Name : ��60   $��12(�6D   $��Stretch=�6R   $��Center=�5�   0   $ Right=�6M   $��SemiBold"�5�   1   ���#8181835�   '   �� 5�   &   -   5        $��txtUserName��5�   L   $	��200��5�   2   #��[ 6>   ��5�   .   �� $	 UserName�$ TwoWay=�$ PropertyChanged=� .  5�   h   5�   #   �� 5�   "   $��3��6-   $
��Left=�6:   $��Center=�5�   *   $ 
Horizontal=�6E   $��
10,0,10,10q�6^   .+�5�   &   �� $��70��60   $��Password : ��6;   $��12(�6N   $��Center=�5�   0   $��Center=�6M   $��SemiBold"�5�   1   $ Right=�6G   ���#8181835�   '   G� 5�   &   -	   5        $��txtPassword��5�   2   ?   9com.boutique.Common.UserInterfaceHelper.CustomPasswordBox   BindPassword . $	��200��5�   1     DefaultPasswordbox#��[ 6=       BoundPassword  5�   0   �� $	 Password�$ TwoWay=�! �� NotifyOnValidationError! .   .  5�   k   5�   #   �� 5�   "   $��4��6-   $��Right=�6:   $��Center=�5�   *   $ 
Horizontal=�6E   $��
10,0,10,10q�6^   .+�5�   &   �� -
   5        $��btnNextUserInformation��5�   -     BasicButton#��[ 5�   1   
�������$��Center=�5�   D   $��Cancel��6a   ���#4E4E505�   '   �� 5�   &   -   5        $��btnCancelUserInformation��5�   -   ���#3088da#��[ 5�   1   
�������$��Center=�5�   1   $
��Next��6N   5�   '   5�   #   5�      � 5�      -   5        $��grdBoutiquedetails��5�   #   $y�	Collapsed=�6=    5�   "   �� 5�   &   �� 5�   &   �� 5�   &   �� 5�   &   �� 5�   &   �� 5�   &   .+�5�   "   �� $��0��6-   $
��Left=�6:   $��Center=�5�   *   $ 
Horizontal=�6E   $��10,10q�6^   .+�5�   &   �� $	��105��60   $��Boutique Name : ��6<   $��12(�6T   $��Center=�5�   0   $ Right=�6M   $��Center=�6c   $��SemiBold"�5�   1   ���#8181835�   '   �� 5�   &   -   5        $��txtName��5�   .   $	��160��5�   2   #��[ 6>   ��5�   =   �� $
	 Name�$ TwoWay=�$ PropertyChanged=� .  5�   h   5�   #   �� 5�   "   $��1��6-   $
��Left=�6:   $��Center=�5�   *   $ 
Horizontal=�6E   $��
10,0,10,10q�6^   .+�5�   &   �� $��Boutique Address : ��60   $��12(�6K   $��Center=�5�   0   $��SemiBold"�5�   1   $ Right=�6G   ���#8181835�   '   �� 5�   &   -   5        $��
txtAddress��5�   .   $	��160��5�   -   $��13(�69     DefaultTextArea#��[ 6G   ��5�   @   �� $!	 boutiqueInformation.Address�$ TwoWay=�$ PropertyChanged=�5�   r   5�   #   �� 5�   "   $��2��6-   $
��Left=�6:   $��Center=�5�   *   $ 
Horizontal=�6E   $��
10,0,10,10q�6^   .+�5�   &   �� $	��105��60   $��Phone Number : ��6<   $��12(�6S   $��Center=�5�   0   $��Center=�6M   $��SemiBold"�5�   1   $ Right=�6G   ���#8181835�   '   �� 5�   &   -   5        $��txtPhoneNumber��5�   .   $	��160��5�   -   #��[ 69   ��5�   D   �� $%	 boutiqueInformation.PhoneNumber�$ TwoWay=�$ PropertyChanged=�5�   c   5�   #   �� 5�   "   $��3��6-   $
��Left=�6:   $��Center=�5�   *   $ 
Horizontal=�6E   $��
10,0,10,10q�6^   .+�5�   &   �� $	��105��60   $��Mobile Number : ��6<   $��12(�6T   $��Center=�5�   0   $��Center=�6M   $��SemiBold"�5�   1   $ Right=�6G   ���#8181835�   '   �� 5�   &   -   5        $��txtlandline��5�   .   $	��160��5�   -   #��[ 69   ��5�   A   �� $(	 "boutiqueInformation.LandlineNumber�$ TwoWay=�$ PropertyChanged=�5�   c   5�   #   �� 5�   "   $��4��6-   $��Right=�6:   $��Center=�5�   *   $ 
Horizontal=�6E   $��
10,0,10,10q�6^   .+�5�   &   �� -   5        $$��btnPreviousBoutiqueInformation��5�   -   #��[ 5�   1   
�������$��Center=�5�   D   $��Previous��6a   ���#4E4E505�   '   �� 5�   &   -   5        $"��btnFinsihBoutiqueInformation��5�   -   ���#3088da#��[ 5�   1   
�������$��Center=�5�   1   $��Finsih��6N   5�   '   5�   #   5�      5�      5�      5     5     5     � 5  
   -   5        $��AlertBox��5  D   $��80��6,   $	��230��68   $
��Fade=�6T   " � VerticalOffset$" 50��6j   $��Center=�5     $��Center=�6.   $��Center=�6I    . # K� ZIndex$# 10��6v   ��5     �� *
IsExired+.��5     �� ���#007ACC$��1q�6,   ._�5	     � ���#1B1B1C$��Center=�6,    5
     �� 5     $
��Auto �6(   �� 5     $
��Auto �6(   .+�5     � $��0��6   $��	0,10,10,0q�6(   .+�5     �� -   5        $ ��Name$$ 
messageBox��5  :   $ Center=�5  $   $��Center=�6;   $��Center=�5      $��	15 5 0 10q�6;   $
��Wrap=�5     $��14(�6,   $��Licence has expired��5     
�������63   5     �� 5     -   5        % ��Name$% btnOk��5     $��Center=�6,   $# 11��6I   $��80��5     $��0,0,0,10q�6#   #��[ 5  )   ���#3088da$��Ok��5     & �� 	IsDefault& . $��1��63   5     5     5     5     5      