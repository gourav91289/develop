   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  Q-clr-namespace:com.boutique.Views.UserControlscom.boutique.Views.UserControls      com.boutique.Views.Login   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:com.boutique.Views     JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  @UserControls-clr-namespace:com.boutique.Views.UserControls  -     �Name$  LoginWindow�� � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�$��Center=�$��Center=�$	��400��$	��300��
������ $��0q�
������  � Icon$0 */com.boutique;component/Images/appicon.ico�� � Title$ Login�� � DataContext ��    Locator �� Source# [  	 �� Path$	 Login�
 � 	Resources
  �� MergedDictionaries �� Source��  �� $8 2/com.boutique;component/Common/StandardStyles.xaml?�%    .���� ���#1B1B1C���#434346$��2q� �� CornerRadius$ 0��._��  � RowDefinitions �� $��35 ��� $��* �.+��� ���#4E4E50$��0��._���  �� Orientation$ 
Horizontal=�$	��Top=�$��Right=�.+��� -   $��MinimizeSettingWindow�� � Cursor$
 Hand��$5��//com.boutique;component/Images/win_minimize.png��$��0,10,0,0q�$��15�� � ToolTip$ Minimize��$��Center=�$��Center=��� -   $��CloseSettingWindow��$
 Hand��$2��,/com.boutique;component/Images/win_close.png��$��10,0,0,0q�$��18��$ Close��$��Center=�$��Center=��� -   $��
stackLogin��$ Vertical=�$��1��$��Center=�$��Center=�.+��� $��Enter Login Details��$��SemiBold"� �� TextAlignment$ Center=�$	��205��}�. $��10,0,0,0q�$
��Wrap=�$��20(�
�������$��	Open Sans)��� ���#535355$��1q����#434346$ 2��$	��250�� �� Padding$ 5q�$��0,10,0,0q�._��� $ 
Horizontal=�.+��� $
 Hand��$-��'/com.boutique;component/Images/male.png��$��18��$��Center=�$��Center=��� -   $��txtUserName��$��0q�
������ 
������ $	��205��}�. $��10,0,0,0q� �� TextWrapping$
 Wrap=�$��14(� �� TextAlignment$
 Left=�$��	Open Sans)����#818183���� $	 UserName� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� -   $��brdrFocusBorder�����#535355$��1q����#434346$ 2��$	��250��$ 5q�$��0,10,0,0q�._��� $ 
Horizontal=�.+��� $
 Hand��$,��&/com.boutique;component/Images/key.png��$��18��$��Center=�$��Center=��� -   $��txtFocusBorder��$��0q�$��Enter Password��
������ 
������ $	��205��}�. $��10,0,0,0q����#818183$��14(�$��	Open Sans)��� -   $��brderPasswordBorder�����#535355$��1q����#434346$ 2��$	��250��$ 5q�$��0,10,0,0q�$y�	Collapsed=�._��� $ 
Horizontal=�.+��� $
 Hand��$,��&/com.boutique;component/Images/key.png��$��18��$��Center=�$��Center=�G� -	   $��txtPasswordBorder��$��0q�?   9com.boutique.Common.UserInterfaceHelper.CustomPasswordBox   BindPassword . 
������ 
������ $	��205��}�. $��10,0,0,0q�
�������$��14(�$��	Open Sans)�   BoundPassword �� $	 Password�$ TwoWay=�$ PropertyChanged=� �� NotifyOnValidationError .   �� ValidatesOnDataErrors .  �� -
   $��btnLogin��$��0,10,0,0q�$��35�����#3088da  BasicButton#��[ 
�������$��Center=�$��Login������ *ActualWidth+ �� ElementName$ 
stackLogin���� -   $��imgLoginProcessing��$��0,10,0,0q�$y�	Collapsed=�"  WpfAnimatedGif.ImageBehavior   AnimatedSource$3 -/com.boutique;component/Images/processing.gif��$��30��$��Center=�� -   $��AlertBox��$	��300��$	��450��$
��Fade=� � VerticalOffset$ 50��$��Center=�$��Center=�$��Center=� � AllowsTransparency .   K� ZIndex$  10������ *IsAlertOpen+.��.   (com.boutique.Views.UserControls.AlertBox  $��Center=�