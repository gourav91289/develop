   M S B A M L   `   `   `  ����G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  5   	   a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  5	   	   Q-clr-namespace:com.boutique.Views.UserControlscom.boutique.Views.UserControls  5   	        com.boutique.Views.Setting   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:com.boutique.Views     5   	   JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     5	   	   J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5
   	   @UserControls-clr-namespace:com.boutique.Views.UserControls  5   	   -   5          �Name$  SettingsWindow��5   	    � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=�5   #    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�6   $��Center=�5   	   $��Center=�6&   $	��500��5   (   $	��375��64    � Icon$0 */com.boutique;component/Images/appicon.ico��5   	    � Title$ Setting��5   	   
������ {�5   	   �� *IsParentWindowEnabled+ � DataContext 5   	   ��    Locator �� Source# [  	 �� Path$
	 Main�.��5      �� $��1q�6   ���#434346._�5   
   � 
 � RowDefinitions
 5      �� 5      $��35 �6    6.   �� 5      $��* �6    6-   .+�5      �� -   5        $��brdTop��5      ���#4E4E50$��0��68   ���#4E4E50$��0,0,0,1q�5       �� Padding$ 0,0,0,0q�6/   ._�5      �  � ColumnDefinitions 5      �� 5      �� 5       .+�5#      ��  �� Orientation$ 
Horizontal=�6!   $��Bottom=�6:   $��Right=�5$   !   $��1��6=   }�. .+�5'      �� -   5        $��MinimizeSettingWindow��5'   .    � Cursor$
 Hand��6    $5��//com.boutique;component/Images/win_minimize.png��5)      $��0,10,0,0q�6U   $��20��5*       � ToolTip$ Minimize��6%   $��Right=�68   $��Center=�6T   6q   �� 5,      -   5        $��CloseSettingWindow��5,   .   $
 Hand��6    $2��,/com.boutique;component/Images/win_close.png��5.      $��10,0,0,0q�6R   $��20��5/      $ Close��6%   $��Right=�65   $��Center=�6Q   6n   �� 51      -   5        $��LogoutSettingWindow��51   .   $
 Hand��6    $/��)/com.boutique;component/Images/logout.png��53      $��10,0,0,0q�6O   $��20��54      $ Logout��6%   $��Right=�66   $��Center=�6R   6o   �� 56      $��Right=�6%   $ 
Horizontal=�6<   $��Right=�57   %   $��0,0,10,0q�6A   .+�58      �� $2��,/com.boutique;component/Images/user-male.png��6$   $��16��6Z   $��10,0,0,0q�6e   o� 5:      $��14(�6#    � 	Resources 5;   "    �� 
TargetType �� Property �� Value �� 
TargetType K� IsItemsHost��%v  'o�       �� 5<   &   " o�6,   .�5=   *   ��  �@�OverridesDefaultStyle . 6R   �� 5>   *    �@J�SnapsToDevicePixels . 6P   �� 5?   *    � ��
 �   �6W   �� 5@   *    � �� 5A   .   �� 5B   2   " o�6B   .R�5C   6   �� $��0,0,0,0q�6=   ._�5D   :   �� }�. $ 
Horizontal=�6Y    . 6r   5E   7   5F   3   5H   +   5I   '   5J   #   .@�5K   "   m� $��Center=�6Q   
�������$��Normal"�5L   7   ��5K   +   �� *LoggedUserFullName+.@�5M   &   m� -   5        $��Change Password��5M   /   
���   �$��30��6[   6g   �� 5N   &   
�������$��2��6F   m� 5O   &   $��Sign Out��6/   
���   �$��30��6T    m� Command 6`   �� *	OnSignOut+m� 5P   &   $��About��6/   
���   �$��30��6Q    6]   �� *About+5Q   #   5R      5T      5V      5X      5Z      �� 5\      ���#1B1B1C$��1��6*   ���#434346$��0,1,0,0q�6M    �� CornerRadius$ 0��5]      $ 20,20,20,50q�6&   $��0q�6<   ._�5^      � $	��Top=�6   
 5_      �� 5`      $
��4.5* �6(   68   �� 5a      $
��4.5* �6(   68   .+�5d      �� $ 
Horizontal=�6!   $��0��6:   $��Center=�6G   .+�5f      �� $ Vertical=�6%   .+�5g      �� $	��New��6(   }�. $
��Wrap=�5h   $   $��15(�68    �� TextAlignment$ Center=�6F   
�������$��Normal"�5i   7   $��	Open Sans)�5j   $   6=   �� 5k      $��Measurement��6(   }�. $
��Wrap=�5l   $   $��15(�68   $ Center=�6F   
�������$��Normal"�5m   3   $��	Open Sans)�5n       69   �� 5o      -   5        $��Measurement��5o   2   $
 Hand��6$   $4��./com.boutique;component/Images/measurement.png��5p   $   $��0,10,0,0q�6\   $��75��5q      $��Center=�6(   $��Center=�6E   5r   k   5s      �� 5u      $ Vertical=�6%   $��20,0,0,0q�6<   .+�5v      �� $��Today��6(   }�. $
��Wrap=�5w   $   $��15(�68   $ Center=�6F   
�������$��Normal"�5x   /   $��	Open Sans)�5y      65   �� 5z      $��Orders��6(   }�. $
��Wrap=�5{   $   $��15(�68   $ Center=�6F   
�������$��Normal"�5|   /   $��	Open Sans)�5}      65   �� 5~      -   5        $
 Hand��5~   $   $.��(/com.boutique;component/Images/order.png��62   $��0,10,0,0q�6d   $��75��5�      $��Center=�6(   $��Center=�6E   6b   5�      �� 5�      $ Vertical=�6%   $��20,0,0,0q�6<   .+�5�      �� $��Today��6(   }�. $
��Wrap=�5�   $   $��15(�68   $ Center=�6F   
�������$��Normal"�5�   3   $��	Open Sans)�5�       69   �� 5�      $��Delivery��6(   }�. $
��Wrap=�5�   $   $��15(�68   $ Center=�6F   
�������$��Normal"�5�   7   $��	Open Sans)�5�   $   6=   �� 5�      -	   5        $
 Hand��5�   $   $6��0/com.boutique;component/Images/order_deliver.png��62   $��0,10,0,0q�6l   $��75��5�      $��Center=�6(   $��Center=�6E   6b   5�      5�      �� 5�      $ 
Horizontal=�6!   $��1��6:   $��Center=�6G   .+�5�      �� $ Vertical=�6%   $��	20,18,0,0q�6<   .+�5�      �� $��Settings��6(   }�. $
��Wrap=�5�   $   $��15(�68   $ Center=�6F   
�������$��Normal"�5�   /   $��	Open Sans)�5�      65   �� 5�      -
   5        $
 Hand��5�   $   $1��+/com.boutique;component/Images/settings.png��62   $��0,10,0,0q�6g   $��75��5�   "   $��Center=�6.   $��Center=�6K   5�   "   5�      �� 5�      $ Vertical=�6%   $��	20,18,0,0q�6<   .+�5�      �� $��Order/Invoices��6(   }�. $
��Wrap=�5�   $   $��15(�68   $ Center=�6F   
�������$��Normal"�5�   /   $��	Open Sans)�5�      65   �� 5�      -   5        $
 Hand��5�   $   $0��*/com.boutique;component/Images/invoice.png��62   $��0,10,0,0q�6f   $��75��5�      $��Center=�6(   $��Center=�6E   6b   5�      �� 5�      $ Vertical=�6%   $��	20,18,0,0q�6<   .+�5�      �� $��Reports��6(   }�. $
��Wrap=�5�   $   $��15(�68   $ Center=�6F   
�������$��Normal"�5�   /   $��	Open Sans)�5�      65   �� 5�      -   5        $
 Hand��5�   $   $0��*/com.boutique;component/Images/reports.png��62   $��0,10,0,0q�6f   $��75��5�   !   $��Center=�6-   $��Center=�6J   5�   '   5�      5�      5�      5�      � 5�      -   5        $��AlertBox��5�   L   $	��300��63   $	��450��6@   $
��Fade=�6\    � VerticalOffset$ 50��6r   $��Center=�5�      $��Center=�6.   $��Center=�6I    � AllowsTransparency .  K� ZIndex$ 10��6v   ��5�      �� *IsAlertOpen+.��5�      .   (com.boutique.Views.UserControls.AlertBox  $��Center=�6@    6(   �� 6@   5�      � 5�      -   5        $��ChangePasswordBox��5�      $
��Fade=�6-   $ 0��6C   $��Center=�5�      $��Center=�6.   $��Center=�6I    . ��5�      �� *IsChangePasswordOpen+.��5�      4   .com.boutique.Views.UserControls.ChangePassword  $��Center=�6F    6.   �� 6F   5�      5�      5�      5�      