   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  S OCustomColorPicker, Version=1.0.5906.26774, Culture=neutral, PublicKeyToken=null`Bclr-namespace:DropDownCustomColorPicker;assembly=CustomColorPickerDropDownCustomColorPicker (    "com.boutique.Views.StitchingWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:com.boutique.Views     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  DUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper  J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  KcpBclr-namespace:DropDownCustomColorPicker;assembly=CustomColorPicker  -     �Name$  StitchingItem�� � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�$��Center=�$��Center=�$	��550�����#878787$	��400�� � Icon$0 */com.boutique;component/Images/appicon.ico�� � Title$ New Measurement�� � DataContext ��    Locator �� Source# [  	 �� Path$
	 Main�
 � 	Resources
  �� MergedDictionaries �� Source��  �� $8 2/com.boutique;component/Common/StandardStyles.xaml?�%    .���� ���#4E4E50$��1q�._�� ���#1B1B1C � RowDefinitions �� $��25 ��� $��* �.+��� -   $��brdTop��
������ ���#4E4E50$��0�� �� Padding$ 0,0,0,0q�._���  �� Orientation$ 
Horizontal=�$	��Top=�$��Right=�$��0,0,10,0q�}�. .+��� -   $��MinimizeSettingWindow�� � Cursor$
 Hand��$5��//com.boutique;component/Images/win_minimize.png��$��0,10,0,0q�$��18�� � ToolTip$ Minimize��$��Right=�$��Center=��� -   $��CloseSettingWindow��$
 Hand��$2��,/com.boutique;component/Images/win_close.png��$��10,0,0,0q�$��18��$ Close��$��Right=�$��Center=��� $��0q�$��1��
������ $ 	10,0,10,0q�._��� -   $��
scrollGrid��$
��Auto=���. .���  �� $��1* ��� $
��3.5* �.+��� $ 	50,0,50,0q�$��0��
������ $��0q�._��� $ Vertical=�$	��Top=�}�. $��0q�.+��� $��Add New Stitching Item��$
��Wrap=�$��0,10,0,0q�  DefaultBoutiuqeName#��[ $��Center=��� $ Vertical=�$
��Left=�.+��� $��	Item Name��  Boutiuqefonttext#��[ �� -   $��txtName��$��0,5,0,0q�  DefaultTextbox#��[ $	��200��$��
Enter Name���� -   $��	btnAddNew��$��0,5,0,0q�  BasicButton#��[ $��80��$	��Add���� -   $��stcUpdatePanel��$ 
Horizontal=�$y�	Collapsed=�.+��� -	   $��0,5,0,0q�#��[ $��80��$��Update���� -
   $��0,5,0,0q����#4E4E50#��[ $��80��$��Cancel���� $ 
10,20,10,0q�$��0,0,0,10q�$��1��
������ ._�&   System.Windows.Controls.DataGrid  -     Name$ AssetDataGrid��   SelectionMode$ Extended=�   CanUserSortColumns .     
IsReadOnly .    AutoGenerateColumns .     CanUserAddRows .     HeadersVisibility$ Column=���.     EnableRowVirtualization .  ���#434346$��1q����#1B1B1C$��	Open Sans)�$��12(�
�������   HorizontalGridLinesBrush �#434346   GridLinesVisibility$ 
Horizontal=�   AlternatingRowBackground �#4E4E50   	RowHeight$ 35Q�   ColumnHeaderHeight$ 28Q����� *StitchingItem+ �� Mode$ TwoWay=�
 *  $System.Windows.Controls.DataGridCell  �� 
TargetType! �� Property" �� Value# �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow$ �� Triggers% P� Property& P� Value��%%  '        '  f     '  ?    �� "   .��� ! � ��" �� "#  .R�� #��z��.+��� $
��Left=�$��Center=�$��10,0,0,0q��� "   .��� ! � ��$" 30���� ! � ��" �#4E4E50�� ! � ��
" ������� ! � ��$" Normal"��� ! � ��$" 12(��� ! � ��$" 5,0,0,0q��� ! � ��$" 0,0,1,0q��� ! � ��" �#434346�� "   $ P� % �@��AlternationIndex$& 0��. ��� ! � ��" �#1B1B1C�� ! � ��
" �����P� % �@��AlternationIndex$& 1��. ��� ! � ��" �#4E4E50�� ! � ��
" �����.  (System.Windows.Interactivity.Interaction'   Triggers' /  )System.Windows.Interactivity.EventTrigger  (   	EventName$( MouseDoubleClick��.  (System.Windows.Interactivity.TriggerBase)   Actions.) 6  0System.Windows.Interactivity.InvokeCommandAction  *   Command* �� *AssetGridRowSelectedCommand++   CommandParameter+ �� $	 SelectedItem�, �� ElementName$, AssetDataGrid��-   Columns- 4	  .System.Windows.Controls.DataGridTemplateColumn	  ,
  &System.Windows.Controls.DataGridColumn. 
  Header$
. Name��/ 	  CellTemplate/ �� .R��� 0 �� Padding$0 0,0,0,0q� �� *Name+���� *Name+	  $. Deleted��1 
  Width5  /System.Windows.Controls.DataGridLengthConverter$1 60 / �� .R��� $0 0,0,0,0q� �� *	IsDeleted+���� *	IsDeleted+	  $. 
Created On��2 
  MinWidth$2 85Q�/ �� .R��� $0 0,0,0,0q� �� *	_CreateOn+���� *	_CreateOn+	  $. Last Updated��$2 85Q�/ �� .R��� $0 0,0,0,0q� �� *_LastUpdatedOn+���� *_LastUpdatedOn+	  $
. Edit��$1 40 / �� .R��� $��Measurement��-   $
 Hand��$
 Edit��$4��./com.boutique;component/Images/edit_Pencil.png��$��0,0,0,0q�$��15��$��Center=�$��Center=�
3 � Tag3 �� *Id+	  $. Delete��$1 50 / �� .R��� $��Measurement��-   $
 Hand��$ Delete��$.��(/com.boutique;component/Images/trash.png��$��0,0,0,0q�$��15��$��Center=�$��Center=�3 �� *Id+	  $. Add Parameters��$	1 100 / �� .R��� -   $��Add Parameters��$0 0,0,0,0q����#007ACC �� *ParameterTypes.Count+3 �� *Id+� -   $��PopUpMeasurementItems����.  $��Slide=�4 � AllowsTransparency4 . $��Center=�$��Center=�$��Bottom=�5 � 	StaysOpen5 . $	��400��$	��300��.���� -   $��brdrMeasurement�����#007ACC���#1B1B1C$��1q�6 �� CornerRadius$6 0��._��  �� $	��.5* ��� $��* ��� $	��.5* �.+��� ���#4E4E50$��0��._��� $ 
Horizontal=�.+��� $��Add Measurement Types��$	��240��$��Center=�$��SemiBold"�
�������$
��Wrap=�$��
20,10,0,10q�#��[ 7 �� TextAlignment$7 Center=��� -   $
 Hand��$ Close��$2��,/com.boutique;component/Images/win_close.png��$��10,0,0,0q�$��18��$��Right=�$��Center=��� -   $��scrollMeasurement��$��1����. $
��Auto=�.��� $��15,10,15,10q� �� $��2* ��� $��1 ��� $��1* �.+��� $��0��
������ $��0,0,0,10q�._��� $ Vertical=�$
��Left=�$��0��$��10,0,0,0q�.+��� $
��Name��$��0,4,0,0q�#��[ �� -   $��txtParameterName��$��0,5,0,0q�  CustomTextBox#��[ $	��200��$��
Enter Name���� -   $��btnAddNewParameter��$��0,5,0,0q�  SubmitButton#��[ $	��100��$	��Add���� $��1��
������ $��0q�._��� 
�������$��1��$��1��8 �� StrokeDashArray$8 1R�9 J� SnapsToDevicePixels9 . �� -   : ��Name$: lstDropDownMeasuremnt��$��2��$��	0,10,0,10q�
������ $��0q� ! ListBoxtemStyleNoHighlighting#��[ ���� *
Parameters+; �� UpdateSourceTrigger$; PropertyChanged=�< �� NotifyOnSourceUpdated< . ���� "  ��$ �� = �� Binding= �� > �� Self? �� RelativeSource#? Z> $	 Items.Count�@ �� Value@ 0.a��� ! � ��" �� .R��� .+��� $��No Items��$��14(�$��Normal"�$0 2q�$��Center=�
�������$��Center=����� .R��� $ 
Horizontal=�.+��� $��14(�$��Normal"�$0 2q�
�������$��5,0,0,0q�$��Center=�$
��Left=����� *Name+