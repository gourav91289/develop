   M S B A M L   `   `   `  ���� K  Gcom.levelsbeyond, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:com.levelsbeyond.Converterscom.levelsbeyond.Converters  i9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper+com.levelsbeyond.Common.UserInterfaceHelper  :    4com.levelsbeyond.Views.UserControls.SetCondtionModel   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ?	Converter)clr-namespace:com.levelsbeyond.Converters     J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  BUI9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper  -     >�Name$  SetConditionMetaData�� � DataContext ��    Locator �� Source# [   �� Path$
 Main� � 	Resources ;   5com.levelsbeyond.Converters.VisiblityBooleanConverter  VisiblityBooleanConverter  
dateBorder �� 
TargetType �� Property �� Value��%�   &	       &	        �� " ��.���  �@��CornerRadius$ 5����  � �� �#d6d6d6��  � �� �#d6d6d6��  �@��Padding$ 5,2,5,2q���  � ��$
 Left=���  � ��$ 1q�.��� $	��565��$��Center=�|�.  � RowDefinitions �� $��* ��� $��* ��� $��* �.+��� -   $��0�����#fafafa$��2��.+�� 	 � ColumnDefinitions	 �� $��* ��� $��25 �.+�� $��Center=�$��0��$��25,0,0,0q�.+��� -   
 ��Name$!
 ImageGetFileDirectoryLoader��"  WpfAnimatedGif.ImageBehavior   AnimatedSource$B </com.levelsbeyond;component/Assets/preloader_transparent.gif��$��30��$��Center=�y��� *IsSetCondition+ �� 	Converter# [ ��  �� Padding$
 5,15q����#efefef._��� $��Set Conditions��$��18(�$��Center=�$��SemiBold"����#222�� -    ��Name$ CancelButton��$��1��$��Right=�$	��Top=� � Cursor$
 Hand��$��25��$��25��$��	0,-10,0,0q�����  �� 
TargetType" ��.R��� $@��:/com.levelsbeyond;component/Images/popup-button-cancel.png��$��25��$��25��$
 Hand��$	��top=�� -   $��gridConditionProperties��$��1��$��2��$	��Top=�
������� �� $��* ��� $��* �.+��� $��0��$��0q�
�������$	��305��._��� $
��Auto=�.���� $��1��$��0q�$ 10,20,10,20q�
�������._�� -    �Name$ GridSetConditionModel��
�������   lblText  txtField(  "System.Windows.Controls.DatePicker  datePickerField  dropDownField  WrpaGrid  txtBoxImageFileIcon 	 btnStyle��%f  &	       &	 �     &	 �    &	 �    &	 �    &	 �    &		 e    �� " ��.���  �@��Padding$ 0q���  � ��$
 Auto����  � ��$ 14(���  � ��$ SemiBold"���  � ��$ Segoe UI)���  � ��$ Center=���  � ��$ Center=���  � ��
 �   ��� " ��.���  � �� �#ABADA3��  � ��
 �������  � ��$ Segoe UI)���  � ��$	 140����  � ��$ 0,0,0,0q���  � ��$ 5q���  � ��$ 13(���  � ��$ 30���� "  .���  � �� �#ABADA3��  � ��
 �������  � ��$ Segoe UI)���  � ��$ Stretch=���  � ��$ 0,0,0,0q���  � ��$ 5q���  � ��$	 130����  � ��$ 13(���  � ��$ 30����  � }� . �� " ��.���  � �� �#efefef��  � �� �#efefef��  � ��$ Segoe UI)���  � ��$
 Left=���  � ��$ 0,0,10,0q���  � ��$ 5q���  � ��$ 13(���  � ��$ 30����  � ��$	 140���� " �.���  � ��
 �������  � ��$	 0,5q��� " ��.���  � ��$ Right=���  � ��$ 0,0,10,0q���  � ��$ Center=���  � ��$ 15����  �@�Cursor$
 Hand���� " ��.���  � ��$ Center=���  � ��
 �������  � �� �#cdcdcd��  � ��$ 1q���  � ��$ 20����  � ��$ 20����  �@�Cursor$
 Hand���� $��0 1 0 0q�$ 5q�$��1�����#fafafa���#efefef._�� 	 �� $��1* ��� $��1* �.+��� $
��left=�$��0��$��0��$��5q�$��0q����#000 �� CornerRadius$ 3��|�. ._��� -   $��comobboxMatchCondition��$	��100��$��Segoe UI)�$��13(�$��30��$��5q�$
��Left=�.@��� -   $��or��$��	Match Any���� -	   $	��and��$��	Match All���� $��Right=�$��0��$��1��$��5q�$��1q����#00aeef$ 3��|�. ._��� -
   $ SetConditionButton��$��Set Conditions��$��15(�$	��3,5q�$
 Hand��$��SemiBold"�$	��110�����#00aeef
�������$��0,0,0,0q�� -   $��gridWarning��$��1��$��2��
�������$	��Top=�$y�Hidden=� �� $��* ��� $��* �.+��� $��0��$��0q�
�������$ 10,20,10,20q�._��� $	��230��$��Segoe UI)�$
��Wrap=�$��14(�$��Center=�}�. $����You have edited your RQL query in a way that this modal cannot display.                             If you wish to continue, your changes will be overwritten.���� $��1�����#fafafa$��2��.+��� $��0 1 0 0q�$ 5q����#fafafa���#efefef._�� 	 �� $��1* �.+��� $��Right=�$��0��$��5q�$��1q����#00aeef$ 3��|�. ._��� -   $ WarningContinueButton��$��Continue��$��15(�$	��3,5q�$
 Hand��$��SemiBold"�$	��110�����#00aeef
�������� -    �Name$ popupDateSelector����.  $��Slide=� � AllowsTransparency .  � 	StaysOpen .  $��Center=�$��Center=�$��Center=� +� IsFocusScope .  .���� .u�&   System.Windows.Controls.Calendar  -   $��calendar��$
��Left=�$	��Top=�