   M S B A M L   `   `   `  ���� K  Gcom.levelsbeyond, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper+com.levelsbeyond.Common.UserInterfaceHelper  Y1clr-namespace:com.levelsbeyond.Views.UserControls#com.levelsbeyond.Views.UserControls  I)clr-namespace:com.levelsbeyond.Converterscom.levelsbeyond.Converters  :    4com.levelsbeyond.Views.UserControls.MediaModelWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     HUI9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper     JUserControls1clr-namespace:com.levelsbeyond.Views.UserControls     ?	Converter)clr-namespace:com.levelsbeyond.Converters     J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  -     � DataContext  ��    Locator �� Source# [   �� Path$
 Main� � 	Resources  �� MergedDictionaries �� Source��  �� $< 6/com.levelsbeyond;component/Common/StandardStyles.xaml?�%    .���  ;   5com.levelsbeyond.Converters.VisiblityBooleanConverter  VisiblityBooleanConverter �� 
TargetType �� Property �� Value��%�   &	       '�      '�� .       �� " �.���  � �� �#2E2D2E�� " ��.���  � ��
 �   ���  � ��$ 0 0 0 1q�	 � RowDefinitions	 �� $	��10* ��� $��5 ��� $
��Auto ��� $
��Auto �
 � ColumnDefinitions
 �� $��3* ��� $	��11* �.+��� $��0��$��0��$��4��$��Hidden=�$��Visible=���. .��� $��
10,10,0,10q�	 �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��
�������$��SemiBold"�$��16(�Asset DetailsH   Bcom.levelsbeyond.Common.UserInterfaceHelper.CustomTextBlockControl  
�������$��14"�$��1��$
��Wrap=�$
��Left=�$��10,0,0,0q����� *ContentWidthModelWindow+ �� Mode$ TwoWay=�   
CustomText �� *FirstGroupText+�� $��2��
�������$��SemiBold"�$��16(�
Categories�� ���#7A8990$��14"�$
��Wrap=� �� TextAlignment$
 Left=�$��3��$��10,0,0,0q�$
��Left=����� *ContentWidthModelWindow+$ TwoWay=����� *SecondGroupText+�� $��4��
�������$��SemiBold"�$��16(�Content Details  $��5��
�������$��14"�$
��Wrap=�$
��Left=�$��10,0,0,0q�$
 Left=����� *ContentWidthModelWindow+$ TwoWay=� �� *ThirdGroupText+� $��1��$��0��
���   �.+�:   4com.levelsbeyond.Views.UserControls.VideoClipControl    �� �� $��1��$��1��$��Stretch=�$��2��
���   �� $��1��$��2��
�������.+��� .+�>   8com.levelsbeyond.Views.UserControls.WorkFlowMediaControl    �� � -    �Name$ MetatdataAreaGrid��
�������   HeaderProperty  HeaderValueProperty �� 
TargetType ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	       &	 s     '�� �     '��     �� " ��.���  � ��$ 12(���  � ��$
 Bold"���  � ��$ Segoe UI)���  � �� �#444444�� " ��.���  � ��$ 12(���  � ��$ Light"���  � ��$ Segoe UI)���  � �� �#444444�� " ��.���  � ��$ 	10,5,20,5q��� " ��.���  � �� �� " ��.R�� $��Panel��.+��� $ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P�  �@��
IsSelected . . ��� $ Panel�� � �� �#00aeef��  � ��
 �������  � ��$ 2,0,0,0q���  � ��$ Segoe UI)���  � ��$
 Bold"���  � ��$ 5q���  � ��$ 12(�P�  �@��
IsSelected .  . ��� $ Panel�� � �� �#efefef��  � ��
 �   ���  � ��$ 2,0,0,0q���  � ��$ Segoe UI)���  � ��$
 Bold"���  � ��$ 12(���  � ��$ 5q���  �@�Cursor$
 Hand��