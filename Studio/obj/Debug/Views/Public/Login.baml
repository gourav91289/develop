   M S B A M L   `   `   `  ����G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  5   	   a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  5	   	   Q-clr-namespace:com.boutique.Views.UserControlscom.boutique.Views.UserControls  5   	       com.boutique.Views.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:com.boutique.Views     5   	   JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     5	   	   J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5
   	   @UserControls-clr-namespace:com.boutique.Views.UserControls  5   	   -   5          �Name$  LoginWindow��5   	    � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=�5   #    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�6   $��Center=�5   	   $��Center=�6&   $	��400��5   	   $	��300��6   
������ $��0q�5   #   
������  � Icon$0 */com.boutique;component/Images/appicon.ico��5   	    � Title$ Login��5   	    � DataContext 6   ��    Locator �� Source# [  	 �� Path$	 Login�
 � 	Resources
 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $8 2/com.boutique;component/Common/StandardStyles.xaml?�5      %    5      .��5      �� ���#1B1B1C���#434346$��2q�68    �� CornerRadius$ 0��6L   ._�5      �  � RowDefinitions 5      �� 5       $��35 �6$   62   �� 5!      $��* �6$   61   .+�5$      �� ���#4E4E50$��0��6*   ._�5%      ��  �� Orientation$ 
Horizontal=�6   $	��Top=�66   $��Right=�6N   .+�5&      �� -   5        $��MinimizeSettingWindow��5&   *    � Cursor$
 Hand��6   $5��//com.boutique;component/Images/win_minimize.png��5(      $��0,10,0,0q�6U   $��15��5)       � ToolTip$ Minimize��6%   $��Center=�68   $��Center=�6U   6r   �� 5+      -   5        $��CloseSettingWindow��5+   *   $
 Hand��6   $2��,/com.boutique;component/Images/win_close.png��5-      $��10,0,0,0q�6R   $��18��5.      $ Close��6%   $��Center=�65   $��Center=�6R   6o   50      51      �� 53      -   5        $��
stackLogin��54   8   $ Vertical=�53      $��1��60   $��Center=�6=   $��Center=�54      .+�56      �� $��Enter Login Details��6    $��SemiBold"�6=    �� TextAlignment$ Center=�6T   $	��205��57   !   }�. $��10,0,0,0q�6A   $
��Wrap=�58   !   $��20(�65   
�������$��	Open Sans)�59   !   6:   �� 5;      ���#535355$��1q�6.   ���#434346$ 2��6X   $	��250��6i    �� Padding$ 5q�5<      $��0,10,0,0q�6)   ._�5=      �� $ 
Horizontal=�6%   .+�5>      �� $
 Hand��6$   $-��'/com.boutique;component/Images/male.png��62   $��18��5?       $��Center=�6,   $��Center=�6I   6f   �� 5A      -   5        $��txtUserName��5A   :   $��0q�6&   
������ 
������ $	��205��5D   ?   }�. $��10,0,0,0q�6_    �� TextWrapping$
 Wrap=�5E   $   $��14(�68    �� TextAlignment$
 Left=�6F   $��	Open Sans)�5F   !   ���#818183��5B   &   �� $	 UserName� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5F   O   5H      5I      �� 5K      -   5        $��brdrFocusBorder��5L   ;   ���#535355$��1q�5K   .   ���#434346$ 2��6X   $	��250��6i   $ 5q�5L      $��0,10,0,0q�6)   ._�5M      �� $ 
Horizontal=�6%   .+�5N      �� $
 Hand��6$   $,��&/com.boutique;component/Images/key.png��62   $��18��5O       $��Center=�6,   $��Center=�6I   6f   �� 5Q      -   5        $��txtFocusBorder��5Q   :   $��0q�6&   $��Enter Password��5R   &   
������ 
������ $	��205��5T   ?   }�. $��10,0,0,0q�6_   ���#818183$��14(�5U   7   $��	Open Sans)�5V       69   5X      5Y      �� 5[      -   5        $��brderPasswordBorder��5\   ;   ���#535355$��1q�5[   .   ���#434346$ 2��6X   $	��250��6i   $ 5q�5\      $��0,10,0,0q�6)   $y�	Collapsed=�6V   ._�5]      �� $ 
Horizontal=�6%   .+�5^      �� $
 Hand��6$   $,��&/com.boutique;component/Images/key.png��62   $��18��5_       $��Center=�6,   $��Center=�6I   6f   G� 5a      -	   5        $��txtPasswordBorder��5a   >   $��0q�6*   ?   9com.boutique.Common.UserInterfaceHelper.CustomPasswordBox   BindPassword . 
������ 
������ $	��205��5g   ?   }�. $��10,0,0,0q�6_   
�������$��14(�5h   3   $��	Open Sans)�5i          BoundPassword 5c   &   �� $	 Password�$ TwoWay=�$ PropertyChanged=� �� NotifyOnValidationError .   �� ValidatesOnDataErrors .  5i   9   5k      5l      �� 5n      -
   5        $��btnLogin��5n      $��0,10,0,0q�6-   $��35��5o      ���#3088da  BasicButton#��[ 5q      
�������$��Center=�5r   0   $��Login��6M   ��5p   2   �� *ActualWidth+ �� ElementName$ 
stackLogin��5t      �� 5v      -   5        $��imgLoginProcessing��5v      $��0,10,0,0q�66   $y�	Collapsed=�6H   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$3 -/com.boutique;component/Images/processing.gif��5w   (   $��30��5x   $   $��Center=�6/   6L   5{      � 5}      -   5        $��AlertBox��5}   L   $	��300��63   $	��450��6@   $
��Fade=�6\    � VerticalOffset$ 50��6r   $��Center=�5~      $��Center=�6.   $��Center=�6I    � AllowsTransparency .   K� ZIndex$  10��6v   ��5}      �� *IsAlertOpen+.��5      .   (com.boutique.Views.UserControls.AlertBox  $��Center=�6(   5�      5�      5�      5�      