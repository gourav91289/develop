   M S B A M L   `   `   `  ���� K  Gcom.levelsbeyond, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:com.levelsbeyond.ViewModelcom.levelsbeyond.ViewModel  b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes i9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper+com.levelsbeyond.Common.UserInterfaceHelper  I)clr-namespace:com.levelsbeyond.Converterscom.levelsbeyond.Converters  I EAdornedControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:AdornedControl;assembly=AdornedControlAdornedControl Y1clr-namespace:com.levelsbeyond.Views.UserControls#com.levelsbeyond.Views.UserControls  Y1clr-namespace:com.levelsbeyond.Views.UserControls#com.levelsbeyond.Views.UserControls  3    -com.levelsbeyond.Views.UserControls.AssetGrid   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7vm(clr-namespace:com.levelsbeyond.ViewModel     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  XThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  F BWpfControls, Version=1.0.0.8, Culture=neutral, PublicKeyToken=null,AutoCompletBoxhttp://wpfcontrols.com/  HUiHelper9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper  J	 FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com 	 9	Converter)clr-namespace:com.levelsbeyond.Converters 	 =ac4clr-namespace:AdornedControl;assembly=AdornedControl 	 DUserControls1clr-namespace:com.levelsbeyond.Views.UserControls 	 =local1clr-namespace:com.levelsbeyond.Views.UserControls 	 -     >�Name$  AssetGridUserControl�� � DataContext ��    Locator �� Source# [   �� Path$
 Main�.���  � 	Resources ?  9com.levelsbeyond.Converters.GetValueFromKeyValueConverter ! GetValueFromKeyValueConverter9  3com.levelsbeyond.Converters.GetImageSourceConverter  GetImageSourceConverter;   5com.levelsbeyond.Converters.VisiblityBooleanConverter  VisiblityBooleanConverter3  -com.levelsbeyond.Converters.GetWidthConverter  WidthConverter  DataGridCellStyle �� 
TargetType*  $System.Windows.Controls.DataGridCell �� Property �� Value �� 
TargetType  DataGridRowStyle)  #System.Windows.Controls.DataGridRow  Name_CellTemplate  ColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%O  &	       &	      &	 
     &	      &	      &	 �     &	 �    &	 �            �� "  .���  �@�FocusVisualStyle Z� ��  � ��
 ���� ��  � ��$ 0q���  � �� �� "  .R�� #��z��.+��� $
��Left=�$��Center=�$��10,0,0,0q��� "  .���  �@�FocusVisualStyle Z� ��  � ��
 �������  � ��$ 0q���  � �� �� "  .R�� #��z��.+��� $
��Left=�$��Center=�$��0,0,0,0q��� �� "  .���  � �� �#EFEFEF��  � ��
 �   ���  � ��$ 13(���  � ��$ Segoe UI)�	 � RowDefinitions	 �� ���� *AssetgridRowWidth+�� $��* �.+�]� $��0��
�������$��0,0,0,10q�.+�6   0com.levelsbeyond.Views.UserControls.SerachFilter   �� � -   
 �Name$
 gridDataContent��$��1�����#EFEFEF	 �� $
��Auto ��� $��* �.+�� $��0��$��0,10,0,0q�$	��Top=� � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��1��$��80,0,0,0q� �� Orientation$ 
Horizontal=�$��Center=�.+��� ���#3C3C3C$��13(�$��Segoe UI)�$��SemiBold"�$��Center=�$
��Left=����� *SerachResultHeaderText+�� -    ��Name$ ShowWorkFlow�����#00AEEF$��	2,-10,0,0q� � Cursor$
 Hand��$��Center=�$��20(� �� TextAlignment$
 Left=�$
��Bold"�$	��...���� $��0,0,10,0q�$��2��$ 
Horizontal=�$��Right=�.+��� ���#686868$��Select: ��$��12(�$
 Left=�$��Segoe UI)�$��Center=�$
��Left=��� -   $ SelectAllAsset��$��5,0,0,0q�$��
Select All��$��12(�$
 Left=�$��Segoe UI)����#AAAAAA$
 Hand��$��Center=�$
��Left=��� ���#AAAAAA$��5,0,5,0q�$��|��$��12(�$
 Left=�$��Segoe UI)�$��Center=�$
��Left=��� -   $ SelectNoneAllAssets�����#3C3C3C$
��None��$��12(�$
 Left=�$��Segoe UI)�$��	Underline{�$��SemiBold"�$
 Hand��$��Center=�$
��Left=��� $��0q�
������  �� Padding$ 10q�$��1�����#EFEFEF$	��Top=�y��� *IsAssetGridVisible+ �� 	Converter# [ ._�&	   System.Windows.Controls.DataGrid	  -    	 Name$ AssetDataGrid��$��0q� 	  SelectionMode$ Extended=� 	  CanUserSortColumns .  	  
IsReadOnly .  	  AutoGenerateColumns .   	  CanUserAddRows .   	  HeadersVisibility$ Column=� 	  	CellStyle# [  	  HorizontalGridLinesBrush
 ����� 	  GridLinesVisibility$ 
Horizontal=���.   	  EnableRowVirtualization .   	  AlternatingRowBackground
 ����� 	  	RowHeight$ 35Q� 	  ColumnHeaderHeight$ 28Q����� *MediaListModel.results+  �� Mode$  TwoWay=�  	 CenteredCellStyle 
 ArchivedTruncateTemplate  AvailableTruncateTemplateH
   Bcom.levelsbeyond.Common.UserInterfaceHelper.TruncateStatusTemplate  TruncateStatusTemplate! 
  ArchivedTruncateTemplate " 
  AvailableTruncateTemplate��%�  &		       &	
 f     &	     &	 I    7 
 7  �� "  .���  � �� �� "  .R�� #��z��.+��� $
��Left=�$��Center=�$��10,0,0,0q��� .R��� $ 
Horizontal=�$
��Left=�.+��� 
���  ��$��Archived���� $:��4/com.levelsbeyond;component/Images/archived_icon.png��$��15��$��4,0,0,0q�$
��Left=��� .R��� $ 
Horizontal=�.+��� $��	Avialable��
  8!   8"  .  (System.Windows.Interactivity.Interaction#   Triggers# /  )System.Windows.Interactivity.EventTrigger  $   	EventName$$ MouseDoubleClick��.  (System.Windows.Interactivity.TriggerBase%   Actions.% 6  0System.Windows.Interactivity.InvokeCommandAction  &   Command& �� *AssetGridRowSelectedCommand+'   CommandParameter' �� $ SelectedItem�( �� ElementName$( AssetDataGrid��) 	  Columns) 4  .System.Windows.Controls.DataGridTemplateColumn  -   CheckBoxHeader��*   CellTemplate* �� .R��� -   + d� IsThreeState+ .  , d� 	IsChecked, �� *IsRowChecked+$  TwoWay=�- �� UpdateSourceTrigger$- PropertyChanged=����� $( AssetDataGrid��$4 .DataContext.AssetGridRowCheckboxCheckedCommand�����   ,  &System.Windows.Controls.DataGridColumn.   Header$
. Name��/   SortMemberPath$
/ name��* �� .R��� $ 
Horizontal=�$
��Left=�.+��� $��4q�$
��Left=����� *	MediaIcon+�� 0 �� Padding$0 0,10,0,0q�1 � ToolTip1 �� *name+���� *name+  $. Status��2   CellTemplateSelector#2 [ $/ metadata.truncateFlag��� ���#EFEFEF$��1��$	��Top=�y��� *IsAssetGridThumbnailVisible+# [ .+��� -	   3 ��Name$3 
appRootUrl��$y�Hidden=����� *	RootUrl+�� -
   $3 appSessionKey��$y�Hidden=����� *
SessionKey+� -   4 �Name$4 AssetGridThumbnail��   scrollViewStyle  txtMetaData  txtBoxFileName  txtBlock  
mainBorder  selectedItemBorder  	mainImage  
nameBorder  SimpleListBoxItem5 �� CornerRadius6 �� Triggers7 P� Property8 P� Value9 �� 
TargetName��%N  &	       &	 N     &	     &	 �    &	 �    &	 �    &	 D    &	 �    &	 *    �� " ��.���  � �� �� *ActualWidth+$( AssetGridUserControl���� " ��.���  � ��$ 12(���  � ��$ Normal"���  � ��$ Segoe UI)���  � ��$
 Left=���  �@��TextAlignment$
 Left=���  �@��
LineHeight$ 15���� " ��.���  � ��$ 14(���  � ��$
 Left=���  �@��TextAlignment$
 Left=���  � }� . ��  � ��$ SemiBold"���  � ��$ Segoe UI)��� " ��.���  � ��$ 18(���  � ��$ Center=��� " ��.���  �@��CornerRadius$ 2����  � �� �#c5c5c5��  � ��$ 0q���  �@��Padding$ 0q���  � ��$
 Left=���  � ��$ 1q��� " ��.���  �@��CornerRadius$ 2����  � �� �#2e9ed8��  � ��$ 0q���  �@��Padding$ 0q���  � ��$
 Left=���  � ��$ 2q��� " ��.���  � ��$	 190����  � ��$	 110����  � ��$	 Top=���  � ��$ Stretch=��� " ��.���  � �� �#F3F3F3��  �@��Padding$ 2q���  � ��$
 Left=���  � ��$ 0,0,0,1q��� " ��.���  � �� �� " ��.R��� $��Border��$ 0q�$��2q�$5 2��$��2q�
�������$
��Left=�._��� 6 P� 7 �@��
IsSelected8 . . ��� $9 Border�� � �� �#2e9ed8.+��� -   : ��Name$: assetGridThumbnailItems��$��10q����#EFEFEF$��Disabled=�$��0q�$��0q�; �� SelectionMode$; Extended=�#��[ ���� *MediaListModel.results+$  TwoWay=����� *ActualWidth+$( AssetGridUserControl��< �� ConverterParameter$< 15��# [ = �� ItemStringFormat= �� > �� IsAsync> . ? J� InputBindings? �� @ �� 	Modifiers$
@ Ctrlf�
A �� Key$A A��B �� CommandB �� *ThumbnailListBoxSlectAll+���� .R�� C � Orientation$C 
Horizontal=�#   $$ MouseDoubleClick��.%   & �� *AssetGridRowSelectedCommand+' �� $ SelectedItem�$( assetGridThumbnailItems��� -   $��LoadinDataContentPopup��$
��None=�D � AllowsTransparencyD . E � VerticalOffset$E 30��$��Center=�F � 	StaysOpenF . $��Center=�$��Center=����� *LoadinDataContentPopup+.���� .u��� 
���   �G J� Opacity$	G 0.7Q�$5 5��$��Bottom=�$	��350��$	��700������ *ActualHeight+$( gridDataContent������ *ActualWidth+$( gridDataContent��._��� " 	 WpfAnimatedGif.ImageBehaviorH   AnimatedSource$BH </com.levelsbeyond;component/Assets/preloader_transparent.gif��$��80��$��Center=�$��Center=��� -   $3 lblAssetGrid��$��	AssetGrid��$y�	Collapsed=�� -   $��PopUpGlobalWorkFlow��$��Slide=�D . F .  $��16,0,0,0q�$	��200������ **(IsWorkFlowMediaAssetGridControlPopupOpen+I � PlacementTargetI �� $( ShowWorkFlow������ *ActualWidth+$( ShowWorkFlow��.���� ���#ccc
�������$ 5q�$��1q�$5 3��._�� 	 �� $
��Auto ��� $��* � ;  5com.levelsbeyond.Converters.WorkFlowITriggerConverter  WorkFlowITrigger��%   &	         .+��� -   $��PopworkflowIsWorkFlowtext��$��0�����#999$��Global Workflows��$��14(�$��SemiBold"�$0 2q�$��Center=�$��Center=��� -   J ��Name$J WorkFlowItems��$��1��$	��200��$��0q���.  ���� *#!WorkFlowMediaItemsModel.workflows+#   $$ PreviewMouseLeftButtonUp��.%   & �� *WorkFlowRowSelectedCommand+' `� K `� 	Converter#K [ .1��� $( WorkFlowItems��$ SelectedItem��� $( lblAssetGrid��$ Content����� " ��L �� TriggersL �� M �� BindingM �� N �� SelfO �� RelativeSource#O ZN $ Items.Count�P �� ValueP 0.a���  � �� �� .R��� $��14(�$��SemiBold"�$0 2q�$��Center=�$��Center=����� *WorkFlowResultText+���� .R��� $��14(����#333$��SemiBold"�$0 2q�$��Center=�$
��Left=����� *name+