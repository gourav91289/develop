   M S B A M L   `   `   `  ���� K  Gcom.levelsbeyond, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:com.levelsbeyond.ViewModelcom.levelsbeyond.ViewModel  3    -com.levelsbeyond.Views.UserControls.SettingUC   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7vm(clr-namespace:com.levelsbeyond.ViewModel     -     >�Name$  UC_Settings�� � 	Resources  �� MergedDictionaries �� Source��  �� $< 6/com.levelsbeyond;component/Common/StandardStyles.xaml?�%    .���� 
���   �$��2q� �� CornerRadius$ 3��$��Center=�._�� $	��300��  �� 
TargetType �� Property �� Value��%}   '�       '�� %     �� " �.���  � ��
 ������� " ��.���  � �� �#F4F4F4��  � ��$ 0 0 0 2q� � RowDefinitions �� $��1* ��� $��2* ��� $��3* ��� $��2* �.+��� $��0��$��1��._��� $��Center=�.+��� ���#212121$��30(�	 �� TextAlignment$	 Center=�$
��Bold"�Preferences�� $��0��$��2��._�� $��Center=� �� $��* ��� $��* ��� $��* �
 � ColumnDefinitions
 �� $��2* ��� $��3* �.+���  �� Orientation$ 
Horizontal=�$��2��.+��� $��16(�$��10,0,0,0q�$
��Bold"����#212121$	 Center=�$��Center=�Reach Engine URL :�� -    ��Name$ SettingUrlTextBox�� �� TextWrapping$ WrapWithOverflow=�$	��200��   BasicTextBoxBlackForeGround#��[  $��12(�$
��Left=�$��Center=�$��10,0,0,0q�
 � Tag$  http://yourdomain.com:port�� ! errorTemplateSilverlightStyle =� ErrorTemplate# [ ���� *	RootUrl+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError . .���� $ 
Horizontal=�$��2��$��1��y��� *ShowUseProxy+$ TwoWay=�.+��� $��16(�$
��Bold"�$��10,0,0,0q����#212121$	 Center=�$��Center=�Use Proxy :�� $��Center=�$��Center=�$��10,5,0,0q� d� 	IsChecked �� *
IsUseProxy+$ TwoWay=��� $ 
Horizontal=�$��2��$��2��y��� *ShowUseThumnail+$ TwoWay=�.+��� $��16(�$
��Bold"�$��10,0,0,0q����#212121$	 Center=�$��Center=�Show Thumbnail :�� $��Center=�$��Center=�$��10,5,0,0q� �� *IsShowThumbnail+$ TwoWay=��� $��0��$��3��._�� ���#EEEEEE
 �� �� $	��255 �.+�� $��1�����#EEEEEE
 �� $��1* ��� $��1* �.+��� -     BasicButton#��[ ���#1B1B1B$��40��$��0��.��Cancel�� -   #��[ ���#3088da$��40��$��1������ *OnSavePreferencesClick+����  �� ElementName$ UC_Settings��.��Save