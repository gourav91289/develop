   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  A%clr-namespace:com.boutique.Converterscom.boutique.Converters  Q-clr-namespace:com.boutique.Views.UserControlscom.boutique.Views.UserControls      com.boutique.Views.Order   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:com.boutique.Views     JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     ;	Converter%clr-namespace:com.boutique.Converters     J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  @UserControls-clr-namespace:com.boutique.Views.UserControls  -     �Name$  OrderWindow�� � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�$��Center=�$��Center=�$	��650��$	��500��
������ $��0q�
������  � Icon$0 */com.boutique;component/Images/appicon.ico�� � Title$ Login�� � DataContext ��    Locator �� Source# [  	 �� Path$	 Order�
 � 	Resources
  �� MergedDictionaries �� Source7   1com.boutique.Converters.VisiblityBooleanConverter  VisiblityConverter��  �� $8 2/com.boutique;component/Common/StandardStyles.xaml?�%   &	         .���� ���#1B1B1C���#434346$��2q� �� CornerRadius$ 0��._��  � RowDefinitions �� $��35 ��� $��3* �.+��� ���#4E4E50$��0��._�� $��Center=� � ColumnDefinitions �� $��30 ��� $��3* ��� $��45 �.+��� -   $��imgLoginProcessing��$��0,0,0,0q�$��0��"  WpfAnimatedGif.ImageBehavior   AnimatedSource$3 -/com.boutique;component/Images/processing.gif��$��22��$��Center=�y��� *IsBackgroundInProgress+ �� 	Converter# [ �� -   $��txtToday��$�� ��
�������$��Center=�$��SemiBold"�$��0,0,0,0q�$��1��  Boutiuqefonttext#��[ $��Center=��� $��2�� �� Orientation$ 
Horizontal=�$	��Top=�$��Right=�.+��� -   $��MinimizeSettingWindow�� � Cursor$
 Hand��$5��//com.boutique;component/Images/win_minimize.png��$��0,10,0,0q�$��15�� � ToolTip$ Minimize��$��Center=�$��Center=��� -   $��CloseSettingWindow��$
 Hand��$2��,/com.boutique;component/Images/win_close.png��$��10,0,0,0q�$��18��$ Close��$��Center=�$��Center=��� $��1��$��10q�$ Vertical=�.+�� -   $��grdSerachpanel��$��0,0,0,15q� �� ��  �� $	��1*  ��� $��20 ��� $	��2*  �.+��� -   $��txtGenrateReport��$��0,5,0,0q�$��0��$��0��  CustomDropDown#��[  �� 
IsReadOnly .  �� TextAlignment$
 Left=�$
��Left=�$	��140��
����������� $	 SelectedReport.type� �� Mode$ TwoWay=��� $��Or�����#818183$��Center=�$��0��$��1��$��SemiBold"�$��	10,0,10,0q�$��14(�#��[ $��Center=��� $ 
Horizontal=�$��0��$��2��$��Right=�$��Center=�.+��� $��From: ��
�������$��Center=�$��Normal"�$��0,0,0,0q�$��13(�#��[ $��Center=��� -   $��txtDateFrom��$��0,5,0,0q�#��[ $
 Left=� .  $	��100��
����������� $	 FromDate�$ TwoWay=��� $
��To: ��
�������$��Center=�$��Normal"�$��20,0,0,0q�$��0��$��13(�#��[ $��Center=��� -	   $��	txtDateTo��$��0,5,0,0q�#��[ $
 Left=� .  $	��100��
����������� $	 ToDate�$ TwoWay=��� -
   $��	btnSerach��$��0,10,0,0q�$��3��$��35��$��1��$��Center=����#3088da$	��110��  BasicButton#��[ 
�������$��Search��� -   $��PopGenrateReportItems����.  $��Slide=� � AllowsTransparency .  � 	StaysOpen .  $	��160�� � PlacementTarget ��  �� ElementName$ txtGenrateReport��.���� ���#007ACC���#1B1B1C �� Padding$ 2q�$��1,1,1,1q�$ 2��._��� -    ��Name$ ListreportItem��$��1��$��0q�
������ ���� *ReportItems+ �� NotifyOnTargetUpdated .  �� UpdateSourceTrigger$ PropertyChanged=�����   �� 
TargetType"  ��! �� Triggers! P� " P� Property" �@��AlternationIndex# P� Value$# 1��. ��� $ �� Property$ � ��% �� Value$% 0,0,1,0q��� $ � ��% �#cdcdcd�� $ � ��$% 0,0,5,0q����� "  ��.��� -  'System.Windows.Input.KeyboardNavigation$ �@ DirectionalNavigation$% Cycle=��� $ � ��% . ���� .R��� $ 
Horizontal=�.+��� $��13(�$��Normal"�& �� Padding$& 1q�$��Center=�$
��Left=�
����������� *type+� -   ' �Name$' popupDateSelector����.  $��Slide=� .  .  $��Center=� �� $ txtDateFrom��.���� .u�&   System.Windows.Controls.Calendar  -   $��calendar��$
��Left=�$	��Top=�&   System.Windows.Controls.DataGrid  -   (  Name$( OrderDataGrid��)   SelectionMode$) Extended=�*   CanUserSortColumns* .  +   
IsReadOnly+ . ,   AutoGenerateColumns, .  -   CanUserAddRows- .  .   HeadersVisibility$. Column=���.  /   EnableRowVirtualization/ .  
������ $��1q����#1B1B1C$��	Open Sans)�$��12(�
�������0   HorizontalGridLinesBrush0 �#4343461   GridLinesVisibility$1 
Horizontal=�2   AlternatingRowBackground2 �#4E4E503   	RowHeight$3 35Q�4   ColumnHeaderHeight$4 28Q����� *
OrderItems+$ TwoWay=�
 *  $System.Windows.Controls.DataGridCell5 �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow��%%  '        '  f     '  ?    �� "   .��� $ � ��% �� "5  .R�� #��z��.+��� $
��Left=�$��Center=�$��10,0,0,0q��� "   .��� $ � ��$% 30���� $ � ��% �#4E4E50�� $ � ��
% ������� $ � ��$% Normal"��� $ � ��$% 12(��� $ � ��$% 5,0,0,0q��� $ � ��$% 0,0,1,0q��� $ � ��% �#434346�� "   ! P� " �@��AlternationIndex$# 0��. ��� $ � ��% �#1B1B1C�� $ � ��
% �����P� " �@��AlternationIndex$# 1��. ��� $ � ��% �#4E4E50�� $ � ��
% �����6   Columns6 4	  .System.Windows.Controls.DataGridTemplateColumn	  ,
  &System.Windows.Controls.DataGridColumn7 
  Header$7 Bill No��8 
  Width5  /System.Windows.Controls.DataGridLengthConverter$8 70 9 	  CellTemplate9 �� .R��� $& 0,0,0,0q����� *BillNo+	  $7 Customer Name��: 
  MinWidth$	: 100Q�9 �� .R��� $& 0,0,0,0q� �� *CustomerName+���� *CustomerName+	  $7 Contact Number��$	: 100Q�9 �� .R��� $& 0,0,0,0q����� *ContactNumber+	  $7 Delivery Date��$	: 100Q�9 �� .R��� $& 0,0,0,0q����� *_DeliveryDate+	  $7 Order Preview/Print ��$	: 125Q�9 �� .R��� -   $
 Hand��$ Preview Order��$0��*/com.boutique;component/Images/Preview.png��$��0,0,0,0q�$��20��$��Center=�$��Center=�
; � Tag; �� *Id+	  $7 Update Order��$8 90 9 �� .R��� $��Measurement��-   $
 Hand��$
 Edit��$4��./com.boutique;component/Images/edit_Pencil.png��$��0,0,0,0q�$��15��$��Center=�$��Center=�; �� *Id+� -   $��AlertBox��$	��300��$	��450��$
��Fade=�< � VerticalOffset$< 50��$��Center=�$��Center=�$��Center=� . = K� ZIndex$= 10������ *IsAlertOpen+.��.   (com.boutique.Views.UserControls.AlertBox  $��Center=� �� 