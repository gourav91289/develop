   M S B A M L   `   `   `  ���� K  Gcom.levelsbeyond, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:com.levelsbeyond.ViewModelcom.levelsbeyond.ViewModel  b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes i9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper+com.levelsbeyond.Common.UserInterfaceHelper  I)clr-namespace:com.levelsbeyond.Converterscom.levelsbeyond.Converters  I EAdornedControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:AdornedControl;assembly=AdornedControlAdornedControl Y1clr-namespace:com.levelsbeyond.Views.UserControls#com.levelsbeyond.Views.UserControls  S.clr-namespace:com.levelsbeyond.Views.Componets com.levelsbeyond.Views.Componets  0    *com.levelsbeyond.Views.UserControls.Ingest   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7vm(clr-namespace:com.levelsbeyond.ViewModel     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  XThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  F BWpfControls, Version=1.0.0.8, Culture=neutral, PublicKeyToken=null,AutoCompletBoxhttp://wpfcontrols.com/  HUiHelper9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper  J	 FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com 	 9	Converter)clr-namespace:com.levelsbeyond.Converters 	 =ac4clr-namespace:AdornedControl;assembly=AdornedControl 	 =local1clr-namespace:com.levelsbeyond.Views.UserControls 	 =Componet.clr-namespace:com.levelsbeyond.Views.Componets 	 -     >�Name$  IngestUserControl�� � DataContext ��    Locator �� Source# [   �� Path$ Ingest� � 	Resources  �� MergedDictionaries �� Source��  �� $< 6/com.levelsbeyond;component/Common/StandardStyles.xaml?�%    .��� -   $��grdMainWrapper��
������� ?  9com.levelsbeyond.Converters.GetValueFromKeyValueConverter ! GetValueFromKeyValueConverter9  3com.levelsbeyond.Converters.GetImageSourceConverter  GetImageSourceConverter;   5com.levelsbeyond.Converters.VisiblityBooleanConverter  VisiblityBooleanConverter3  -com.levelsbeyond.Converters.GetWidthConverter  WidthConverterI   Ccom.levelsbeyond.Common.UserInterfaceHelper.AssetSuggestionProvider  AssetSuggestionProvider  txtboxStyle �� 
TargetType �� Property	 �� Value  rdiobtnStyle  txtStyle 	 lblStyle 
 txtTaskStep  BacButtonStyle��%�  &	       &	      &	 
     &	      &	      &	      &	 �     &	 �    &		 h    &	
 �    &	 �              �� " ��.���  � ��$	 12(���  � ��$	 2q���  � ��$	 Normal"���  � ��$	 Segoe UI)���  � ��$	 Center=���  � ��$		 150����  �@��TextAlignment$
	 Left=���  � ��$	 25���� " 	�.���  � ��$	 13(���  � ��$	 Normal"���  � ��$	 Segoe UI)���  � ��$	 Center=���  � ��$		 150����  � ��$		 Top=��� " ��.���  � ��$	 12(���  � ��$	 Normal"���  � ��$	 Segoe UI)���  � ��$	 Center=���  � ��$		 Top=���  �@��TextAlignment$	 Center=���  �@��
LineHeight$	 15���� " ��.���  � ��$	 13(���  � ��$	 Normal"���  � ��$	 Segoe UI)���  � ��$	 Center=���  � ��$		 Top=��� " ��.���  � ��$	 12(���  � ��$	 SemiBold"���  � ��$	 Segoe UI)���  � ��
	 �   ���  � ��$	 Center=���  � ��$	 Center=���  �@��TextAlignment$	 Center=���  �@��
LineHeight$	 15���� " ��.���  � ��	 �#f5f5f5��  � ��$	 5q���  � ��	 �#cdcdcd��  � ��$	 1q���  � ��$	 Segoe UI)�
 � RowDefinitions
 �� $
��1.5* ��� $��50 ��� $��50 ��� $
��1.7* ��� $��50 �.+�� -   $��grdIngestStep2��$	��Top=�$��0��$��0��$��0,0,0,10q�
 �� $��40 ��� $��* �.+��� $��Center=�$��30��$��10,7,0,0q�$	��Top=�$��0��.+��� $
��Wrap=�$��Segoe UI)����#848484$��Drop files to ingest here��$��15(��� -   $��DropBox��$��1��$	��120��$��	0,10,0,10q�$��Stretch=�$��	10,0,10,0q�$��Center=� J� 	AllowDrop . ��.  $��Hidden=�
���   �$��13(�$��Segoe UI)����#f5f5f5$��1q����#f5f5f5���� $ Files� �� NotifyOnSourceUpdated . ���� " ��.���  � ��
	 ���� ��  � ��	 �� *HorizontalContentAlignment+ �� RelativeSource ��  �� AncestorType" ����  � ��	 �� *VerticalContentAlignment+ �� " ����  � ��$	 2,0,0,0q���  � ��	 ��  �� 
TargetType" ��.R���  ��Name$ Bd��#��z��#��z��#��z�� �� Padding# z�� J� SnapsToDevicePixels . ._��� #��z��# z #��z�� �� Triggers P�  P� Property �@��
IsSelected P� Value . . ���  �� 
TargetName$ Bd��#	 � �� � ���� #	 � �� � ��]�  ]� 
Conditions ��  �� Property �@��
IsSelected �� Value . ��  �@��IsSelectionActive .  ./��� $ Bd��#	 � /� � ���� #	 � .� � ��P�  � {� .  . ��� #	 � �� � ������ .R���  �� Orientation$ 
Horizontal=����� *ActualWidth+ �� ElementName$ DropBox��.+���  �� TextAlignment$
 Left=����� �� -   $��Right=� � Cursor$
 Hand��$:��4/com.levelsbeyond;component/Images/trash_outline.png��$��18�� � ToolTip$ Remove File��
 � Tag �� �� -   $��borderCollection��$��1��$��0q�
������ ._�9   3com.levelsbeyond.Views.Componets.CollectionComponet  $��Center=�    Multipel  .  �� -   $��BorderIngestFormDropdown��$��2��$��0��$ 0,0,0,10q�$��0,0,0,1q����#cdcdcd$	��Top=�._��� $ 
Horizontal=�$��Center=�.+��� $
��Wrap=�$��Segoe UI)����#848484$��Select Form:��$��	10,0,10,0q�$��Center=�$��13(��� -   $��IngestCombobox��$��Center=�$��13(�$��Center=�! �� DisplayMemberPath$
! name��" �� SelectedValuePath$" id��$	��253������ *IngestFormItems+� -	   $��grdIngestDynamicContent��$��3��$��10q�$	��Top=�.+��� $��Visible=�.���� -
   $��popupProperties��$��0q�
�������$
��Left=�._�� -   # �Name$# GridWorkFlowProperties��
�������   lblText  txtField  chkField(  "System.Windows.Controls.DatePicker  datePickerField  dropDownField  WrpaGrid  txtBoxImageFileIcon��%@  &	       &	     &	 �    &	 A    &	 *    &	 .    &	 j    �� " ��.���  �@��Padding$	 0q���  � ��$		 200����  � ��$	 14(���  � ��$	 SemiBold"���  � ��$	 Segoe UI)���  � ��$	 Right=���  � ��$	 Center=���  �@��TextAlignment$	 Right=���  � ��
	 �   ��� " ��.���  � ��	 �#cdcdcd��  � ��
	 �������  � ��$	 Segoe UI)���  � ��$	 Center=���  � ��$
	 Left=���  � ��$	 0q���  � ��$		 5,0q���  � ��$	 13(���  � ��$	 25����  � ��$		 200���� " ��.���  � ��$	 5,0,0,0q���  � ��$	 Center=��� "  .���  � ��	 �#cdcdcd��  � ��
	 �������  � ��$	 Segoe UI)���  � ��$
	 Left=���  � ��$	 Center=���  � ��$		 5,0q���  � ��$	 13(���  � ��$	 25����  � ��$		 200���� " ��.���  � ��	 �#cdcdcd��  � ��
	 �������  � ��$	 Segoe UI)���  � ��$
	 Left=���  � ��$	 Center=���  � ��$	 0,0,0,0q���  � ��$		 5,0q���  � ��$	 13(���  � ��$	 25����  � ��$		 200���� " �.���  � ��
	 �������  � ��$		 0,5q��� " ��.���  � ��$	 Right=���  � ��$	 0,0,5,0q���  � ��$	 Center=���  � ��$	 15����  �@�Cursor$
	 Hand���� $��0��$��4��$��Bottom=�$��Right=�$��	15,0,0,10q�._��� -   $	��100��  BasicButton#��[ $��Right=����#3088da$��30��$��1��.��Ingest� -   $��LoadinDataContentPopup��$
��None=�$ � AllowsTransparency$ . % � VerticalOffset$% 30��$��Center=�& � 	StaysOpen& . $��Center=����� *LoadinFormContentPopup+.���� .u��� 
���   �' J� Opacity$	' 0.7Q�( �� CornerRadius$( 5��$��Bottom=����� *ActualHeight+$ grdIngestDynamicContent������ *ActualWidth+$ grdIngestDynamicContent��._��� " 	 WpfAnimatedGif.ImageBehavior)   AnimatedSource$B) </com.levelsbeyond;component/Assets/preloader_transparent.gif��$��80��$��Center=�$��Center=�� -   $��PopUpIngetFiles����.  $
��None=�$ . & . $��Center=�$��Center=�$��Center=�.���� .u�� .+��� 
���   �$	' 0.5Q�$��Bottom=����� *ActualHeight+$ grdMainWrapper������ *ActualWidth+$ grdMainWrapper��� $��Center=�}�. $��Center=�$	��500��
 �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��0�����#EAEAEA.+�� $��Center=�.+��� $y�Visible=�$B) </com.levelsbeyond;component/Assets/preloader_transparent.gif��$��30��$��Center=��� $
 5,15q����#efefef._��� $"��Status: Ingest genric assets��$��14(�$��Center=�$��SemiBold"����#222�� $��1��$��0��$��0q�$ 20q�
�������._�� 
 �� �� .+�� $��0��* � ColumnDefinitions* �� $��1* ��� $��1* �.+��� $��0��$ Right=�$$��Sending assets to Reach Engine��$	��168��$��12(�$��Right=�$��Normal"����#222� -   $��SendingAssetsreachEngine��$��1��$��Center=�$��Stretch=�$��10��$��10,0,0,0q�+ � Minimum$+ 0Q�, � Maximum$	, 100Q����#1D9150� $��1��$��0,10,0,0q�* �� $	��35* ��� $	��11* ��� $	��46* �.+��� $��0��$	��168��$ Right=�$��Applying metadata��$��12(�$��Right=�$��Normal"����#222$��2��� -   $��Applyingmetadata��$��2��$��Center=�$��Stretch=�$��10��$��10,3,0,3q�$+ 0Q�$	, 100Q����#1D9150- � Value- �� *Applyingmetadata+. �� UpdateSourceTrigger$. PropertyChanged=� . / �� NotifyOnTargetUpdated/ . �� $��2��$��0�����#EAEAEA$ 10q�._��� $ 
Horizontal=�.+��� -   $��CancelAction��$	��125�����#f5f5f5���#cdcdcd
���   �#��[ $��30��$��1��.��Cancel Action�� -   $��ResartAction��$	��125�����#f5f5f5���#cdcdcd
���   �#��[ $��30��$��1��.��Restart Action� -   $��AlertBox��$	��300��$	��450��$
��Fade=�$% 50��$��Center=�$��Center=�$��Center=�$ . ���� *IsAlertOpen+.��2	   ,com.levelsbeyond.Views.UserControls.AlertBox	  $��Center=� �� 