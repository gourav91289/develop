   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  Q-clr-namespace:com.boutique.Views.UserControlscom.boutique.Views.UserControls  A%clr-namespace:com.boutique.Converterscom.boutique.Converters  S OCustomColorPicker, Version=1.0.5906.26774, Culture=neutral, PublicKeyToken=null`Bclr-namespace:DropDownCustomColorPicker;assembly=CustomColorPickerDropDownCustomColorPicker '    !com.boutique.Views.NewMeasurement   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:com.boutique.Views     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  DUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper  J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  @UserControls-clr-namespace:com.boutique.Views.UserControls  5	Converter%clr-namespace:com.boutique.Converters  KcpBclr-namespace:DropDownCustomColorPicker;assembly=CustomColorPicker  -     �Name$  NewMeasurementWindow�� � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�$��Center=�$��Center=�$	��600��$	��650�� � Icon$0 */com.boutique;component/Images/appicon.ico�� � Title$ New Measurement�� � DataContext ��    Locator �� Source# [  	 �� Path$
	 Main�
 � 	Resources
  �� MergedDictionaries �� Source��  �� $8 2/com.boutique;component/Common/StandardStyles.xaml?�%    .���� ���#434346���#1B1B1C$��1q� �� Padding$ 0q�._��  � RowDefinitions �� $��25 ��� $��* �.+��� -   $��brdTop�����#4E4E50$��0�����#878787$ 0,0,0,0q�._���  �� Orientation$ 
Horizontal=�$��Center=�$��Right=�$��0,0,10,0q�}�. .+��� -   $��MinimizeSettingWindow�� � Cursor$
 Hand��$5��//com.boutique;component/Images/win_minimize.png��$��0,10,0,0q�$��15�� � ToolTip$ Minimize��$��Right=�$��Center=��� -   $��CloseSettingWindow��$
 Hand��$2��,/com.boutique;component/Images/win_close.png��$��10,0,0,0q�$��15��$ Close��$��Right=�$��Center=��� $��0q�$��1��
������ ._��� -   $��
scrollGrid��$
��Auto=���. .���  �� $��4* ��� $
��0.3* ��� $��3* ��� $
��0.3* ��� $��3* ��� $��1* �.+��� $ 	50,0,50,0q�$��0��
������ $��0q�._��� $ Vertical=�$	��Top=�}�. $��0,0,0,10q�.+��� 
�������$
��Wrap=�$��0,15,0,0q�  DefaultBoutiuqeName#��[ $��Center=����� $	 BoutiqueDetails.Name��� 
�������$��0,2,0,0q�$
��Wrap=�  Boutiuqefonttext#��[ $��Center=����� $	 BoutiqueDetails.Address��� $ 
Horizontal=�$��Center=�$��0,2,0,0q�.+��� 
�������$
��Wrap=�#��[ $��Center=����� $!	 BoutiqueDetails.PhoneNumber��� $��, ��$��0,5,0,0q�
�������#��[ $��Center=��� 
�������$
��Wrap=�#��[ $��Center=����� $$	 BoutiqueDetails.LandlineNumber��  � Orientation$ 
Horizontal=�$
��Left=�$��0,15,0,0q� �� $	 measurement�.+��� $ Vertical=�$
��Left=�.+��� $��Bill No��#��[ �� -   $��txtBill��$��0,5,0,0q�  CustomTextBox#��[  �� 
IsReadOnly . $	��140��
����������� $	 BillNo� �� UpdateSourceTrigger$ PropertyChanged=��� $ Vertical=�$
��Left=�$��20,0,0,0q�.+��� $��Select Date��#��[ �� -   $��txtDate��$��0,5,0,0q�  CustomDropDown#��[  . $	��140��
����������� $
	 Date� �� Mode$ TwoWay=��� $ Vertical=�$
��Left=�$��20,0,0,0q�.+��� $��Delivery Date��#��[ �� -   $��0,5,0,0q�#��[  . 
�������$	��140������ $	 DeliveryDate�$ TwoWay=��� $ Vertical=�$
��Left=�$��0,15,0,0q�.+��� $��Customer Name��#��[ �� -	   $��txtCustomerName��$��0,5,0,0q�#��[ $	��220������ $	 CustomerName�$ TwoWay=��� $ Vertical=�$
��Left=�$��	20,15,0,0q�.+��� $��Customer Contact No.��#��[ �� -
   $��txtContactNo��$��0,5,0,0q�#��[ $	��220������ $	 ContactNumber�$ TwoWay=��� $ Vertical=�$
��Left=�$��0,15,0,0q�.+��� $��Customer Address��#��[ �� -   $��
txtAddress��$��0,5,0,0q�  CustomTextArea#��[ $	��460�� �� TextWrapping$
 Wrap=� �� AcceptsReturn . ���� $	 Address�$ TwoWay=��� $��1��
������ 
������ $��0q�._��� 
�������$��1��$��1�� �� StrokeDashArray$	 3 4R� J� SnapsToDevicePixels . �� $ 
45,20,45,0q�$��2��
������ 
������ $��0,0,0,10q�._��  �� $
��Auto ��� $
��Auto �.+��� -   $��stckPanelMain��$ Vertical=�$��0��$	��Top=�}�. $��0q�
  �� 
TargetType  	wrapPanel �� Property �� Value �� ElementName��%�   &	       �� " �.���  �@�Orientation$ 
Horizontal=���  � ��$
 Left=���  � ��$ 0,15,0,0q���  � �� �� *ActualWidth+$ stckPanelMain��.+��� $��STITCHING SIZE DETAILS��
�������$��SemiBold"�$��0,0,0,0q�#��[ $��Center=��� -   $��stcUpdatePanel��$��35��$�� 1��$ 
Horizontal=�.+��� -   $��0,5,0,0q�  SubmitButton#��[ $��Add With Same Size���� -   $��0,5,0,0q�#��[ $��80��$��Add More���� $��3��
������ 
������ $��0q�._��� 
�������$��1��$��1��$	 3 4R� . �� $ 
45,20,45,0q�$��4��
������ 
������ $��0,0,0,10q�._��  �� $
��Auto ��� $
��Auto �.+��� -   $��stckEmbrodiaryPanelMain��$ Vertical=�$��0��$	��Top=�}�. $��0q�
 ��%�   &	       �� " �.���  �@�Orientation$ 
Horizontal=���  � ��$
 Left=���  � ��$ 0,15,0,0q���  � �� �� *ActualWidth+$ stckPanelMain��.+��� $��EMBROIDERY DETAILS��
�������$��SemiBold"�$��0,0,0,0q�#��[ $��Center=��� -   $��stcEmbrodiaryUpdatePanel��$��35��$�� 1��$ 
Horizontal=�.+��� -   $��0,5,0,0q�#��[ $��Add With Same Size���� -   $��0,5,0,0q�#��[ $��80��$��Add More���� -   $��5��$	��130��$��35��$��	0,10,0,10q�$��16(�$��SemiBold"�#��[ $��Submit��� -    �Name$ popupDateSelector����.  $��Slide=� � AllowsTransparency .   � 	StaysOpen  .  $��Center=�! � PlacementTarget! �� $ txtDate��.���� .u�&   System.Windows.Controls.Calendar  -   $��calendar��$
��Left=�$	��Top=�� -   $��PopUpStitchingItems��$��Slide=� .   .  $	��225��$	��130������ $	 IsStitchingItem�$ PropertyChanged=�! �� $ txtstitchingItem��.���� ���#007ACC���#1B1B1C$ 2q�$��1,0,1,1q�._�� 
������  �� �� .+��� -   $��0��$��Add New Item��$��0��$	��Top=�  TextButtonStyle#��[ $
��Left=�$��	Open Sans)�$��13(�$��10,0,0,0q�
������ $��Normal"�$
 Hand���� -   " ��Name$" ListStitchingItem��$��1��$��0q�
������ ���� *StitchingItem+# �� NotifyOnTargetUpdated# . $ PropertyChanged=����� " ��$ �� Triggers$ P� % P� Property% �@��AlternationIndex& P� Value$& 1��. ���  � ��$ 0,0,1,0q���  � �� �#cdcdcd��  � ��$ 0,0,5,0q����� " ��.��� -  'System.Windows.Input.KeyboardNavigation �@ DirectionalNavigation$ Cycle=���  � �� . ���� .R��� $ 
Horizontal=�.+��� $��13(�$��Normal"�' �� Padding$' 1q�$��Center=�$
��Left=�
����������� *Name+� -   $��PopUpMeasurementItems����.  $��Slide=� . $��Center=�$��Center=�$��Center=�  . $	��500��$	��500��! �� $ NewMeasurementWindow��.���� -   $��brdrMeasurement�����#007ACC���#1B1B1C$��1q�( �� CornerRadius$( 0��._��  �� $	��.5* ��� $��* ��� $	��.5* �.+��� ���#4E4E50$��0��._��� $ 
Horizontal=�.+��� $"��Add/Select Measurement Types��$	��450��$��Center=�$��SemiBold"�
�������$
��Wrap=�$��
20,10,0,10q�#��[ ) �� TextAlignment$) Center=��� -   $
 Hand��$ Close��$2��,/com.boutique;component/Images/win_close.png��$��10,0,0,0q�$��18��$��Right=�$��Center=��� -   $��scrollMeasurement��$��1����. $
��Auto=�.��� $��15,10,15,10q� �� $��2* ��� $��1 ��� $��1* ��� $
��3.5* �.+��� $��0��
������ $��0,0,0,10q�._��� $ Vertical=�$	��Top=�}�. $��0q�.+�� * � ColumnDefinitions* �� $��1* ��� $��1* �.+��� $ Vertical=�$
��Left=�$��0��$��10,0,0,0q�.+��� $
��Name��$��0,4,0,0q�#��[ �� -   $��txtName��$��0,5,0,0q�#��[ $	��200��$��
Enter Name���� -   $��	btnAddNew��$��0,5,0,0q�#��[ $	��100��$	��Add���� $��1��$��Center=�$��Right=�$��0,0,10,0q�.+��� -    $��stackSearch��$ 
Horizontal=�$	��Top=�$��0q�.+��� -!   + ��Name$+ FilterCombobox��$	��175�� 	 CustomSerachTextBox#��[	 $��Serach��, ^� ShowOnDisabled, . .��- J� InputBindings- �� 
. �� Key$. Enter��/ �� Command/ �� $	 FilterItems�.���� -"    
 CustomButtonStyle#��[
 $��1��.���� $
 Hand��$��12��$4��./com.boutique;component/Images/search_icon.png��$��Center=�$��Center=�� -#   $��PopUpQueryBuilderFilter��$��Slide=� .   .  |�. $	��195��$	��225������ *IsDropDownOpen+$ TwoWay=�$ PropertyChanged=�! �� $ stackSearch��.���� ���#007ACC$( 2,2,2,2�����#1B1B1C$ 5q�$��1q�._�� .+��� -$   $" lstDropDownMeasuremnt��
������ $��0q����� *
Parameters+$ PropertyChanged=�0 �� NotifyOnSourceUpdated0 . ���� " ��$ �� 1 �� Binding1 �� 2 �� Self3 �� RelativeSource#3 Z2 $	 Items.Count�4 �� Value4 0.a���  � �� �� .R��� .+��� $��No Items��$��14(�$��Normal"�$' 2q�$��Center=�
�������$��Center=����� " ��.���  �@ DirectionalNavigation$ Cycle=���  � �� . ���� .R��� $ 
Horizontal=�.+��� $��14(�$��Normal"�$' 2q�
�������$��5,0,0,0q�$��Center=�$
��Left=����� *Name+�� $��1��
������ $��0q�._��� 
�������$��1��$��1��$ 1R� . �� $��2��$��0,10,0,0q�
������ $��0q�._��� $��Selected Parameters��$��14(�$��SemiBold"�$' 2q�$��Center=�
�������$��Center=��� -%   $" lstDropDownItem��$��4��$��	0,10,0,10q�$��0q� ! ListBoxtemStyleNoHighlighting#��[ $��Hidden=�
������ 
������ 
   ItemBackgroundHover5 �� Color��%!   &	       �� $5 Transparent������ " ��$ �� 1 �� #3 Z2 $	 Items.Count�4 0.a���  � �� �� .R��� .+��� $��No Parameters��$��14(�$��Normal"�
�������$' 2q�$��Center=�$��Center=����� .R��� 
������ $��0,0,0,0q�$ 0,0,0,2q�
������ $��0,0,0,0q����� *ActualWidth+$ lstDropDownItem��._�� $
��Left=�* �� $��2* ��� $��2* ��� $	��.5* �.+��� $��0��$	��170��#��[ $
��Wrap=�$��Center=�$) Right=�$��0,0,0,0q�
�������$��13(����� *name+�� $��1��$��5,5,0,0q�#��[ $��75��$��30��$��Normal"�
����������� *value+�� -&   $��2��$ Remove��$��5,5,0,0q�#��[ $��30��$��-��$��Center=��� -'   $��0,10,0,0q�$��2��#��[ $��80��$��Submit��� -(   $��AlertBox��$	��300��$	��450��$
��Fade=�6 � VerticalOffset$6 50��$��Center=�$��Center=�$��Center=� . 7 K� ZIndex$7 10������ *IsAlertOpen+.��.   (com.boutique.Views.UserControls.AlertBox  $��Center=� �� 