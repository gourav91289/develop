   M S B A M L   `   `   `  ���� K  Gcom.levelsbeyond, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:com.levelsbeyond.Views.UserControls#com.levelsbeyond.Views.UserControls  I)clr-namespace:com.levelsbeyond.Converterscom.levelsbeyond.Converters  i9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper+com.levelsbeyond.Common.UserInterfaceHelper  /    )com.levelsbeyond.Views.Private.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     JUserControls1clr-namespace:com.levelsbeyond.Views.UserControls     ?	Converter)clr-namespace:com.levelsbeyond.Converters     J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  BUI9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper  -   $��	MainPanel��  � Title$  Reach Engine Craft�� � Icon$? 9/com.levelsbeyond;component/Assets/craft_icon_512X512.ico��$	��920��$	��600�� � WindowStartupLocation$ CenterOwner=� � DataContext ��    Locator �� Source# [   �� Path$
 Main�{��� *IsParentWindowEnabled+ � 	Resources  �� MergedDictionaries �� Source��  �� $8 2/com.levelsbeyond;component/Common/LoginStyle.xaml?��� $< 6/com.levelsbeyond;component/Common/StandardStyles.xaml?�%    .��� 
������� ;   5com.levelsbeyond.Converters.VisiblityBooleanConverter  VisiblityBooleanConverter3  -com.levelsbeyond.Converters.GetWidthConverter  WidthConverter��%   &	       &	          	 � RowDefinitions	 �� $��40 ��� $��* �.+�]� $��0��$��2��
���   �$��40��$	��Top=�.+��� 
 �� Orientation$
 
Horizontal=�.+��� $��	10,0,10,0q�$��30��$7��1/com.levelsbeyond;component/Images/craft_icon.png��$
��Left=�$
��Left=��� $��Craft��$��Segoe UI)�
�������$��Center=�$��14(�$��SemiBold"�$��0,0,10,0q��� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$< 6/com.levelsbeyond;component/Assets/preloader_small.gif��$��20��$��Center=�$��Center=�y��� *IsBackgroundInProgress+ �� 	Converter# [ �� $��Right=�$
 
Horizontal=�$��Right=�$��0,0,10,0q�.+��� $6��0/com.levelsbeyond;component/Images/User-blue.png��$��15��$��5q�o� $��14(�  �� 
TargetType �� Property �� Value �� 
TargetType K� IsItemsHost��%�   'o�       �� " o�.���  �@�OverridesDefaultStyle . ��  �@J�SnapsToDevicePixels . ��  � ��
 �   ���  � �� �� " o�.R��� $��0,0,0,0q�._��� }�. $
 
Horizontal=� . .@�m� -   $��Center=�
�������$��SemiBold"����� *LoggedUserFullName+.@�m� $ ��Configure visible metadata��
���   �$��30�� m� Command �� *OnPreferenceSettingClick+m� -   $��Preferences��
���   �$��30��m� $��Change Password��
���   �$��30�� �� *OnChangePasswordClick+�� 
�������$��2��m� $��Sign Out��
���   �$��30�� �� *	OnSignOut+m� $��About��
���   �$��30�� �� *About+�� $��1��  StyleMainWIndowtabControl#��[ $��5q�.@��� -   $��	tabAssets��$��Assets��  StyleMainWindowTabItem#��[  J� 	AllowDrop . .��� 
�������$��10q�.+�3   -com.levelsbeyond.Views.UserControls.AssetGrid   �� �� -   $��	tabIngest��$��Ingest��#��[ .��� ���#EFEFEF.+�0   *com.levelsbeyond.Views.UserControls.Ingest  �� -   $��	tabStatus��$��Action Status��#��[  . .��� ���#EFEFEF.+�<   6com.levelsbeyond.Views.UserControls.WorkflowExecutions   �� � -   $��SettingPopUp��$	��300��$	��600��$
��Fade=� � VerticalOffset$ 50��$��Center=�$��Center=�$��Center=� � AllowsTransparency . ���� *IsPopUpOpen+.��3   -com.levelsbeyond.Views.UserControls.SettingUC  $��Center=� �� � $	��650��$	��600��$
��Fade=�$��Center=�$��Center=�$��Center=� . ���� *IsPrefrencePopUpOpen+.��B   <com.levelsbeyond.Views.UserControls.ConfigureVisibleMetadata   �� � -   $��AlertBox��$	��300��$	��450��$
��Fade=�$ 50��$��Center=�$��Center=�$��Center=� .  K� ZIndex$ 10������ *IsAlertOpen+.��2	   ,com.levelsbeyond.Views.UserControls.AlertBox	  $��Center=� �� � -	   $��ChangePasswordBox��$	��300��$	��450��$
��Fade=�$ 50��$��Center=�$��Center=�$��Center=� . ���� *IsChangePasswordOpen+.��:
   4com.levelsbeyond.Views.UserControls.ChangePasswordUC
  $��Center=� �� � -
   $��AboutAccessEngine��$	��300��$	��450��$
��Fade=� � 	StaysOpen .  $��Center=�$��Center=�$��Center=� . ���� *	IsAbout+.��/   )com.levelsbeyond.Views.UserControls.About  $��Center=� �� � -   $��UCWFDynamicProp��$��Center=�.+�H   Bcom.levelsbeyond.Views.UserControls.WorkflowDynamicPropertiesModel  