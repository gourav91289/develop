   M S B A M L   `   `   `  ���� G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  A%clr-namespace:com.boutique.Converterscom.boutique.Converters  Q-clr-namespace:com.boutique.Views.UserControlscom.boutique.Views.UserControls       com.boutique.Views.Reports   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:com.boutique.Views     JUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper     ;	Converter%clr-namespace:com.boutique.Converters     J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  @UserControls-clr-namespace:com.boutique.Views.UserControls  -     �Name$  ReportsWindow�� � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�$��Center=�$��Center=�$	��375��$	��300��
������ $��0q�
������  � Icon$0 */com.boutique;component/Images/appicon.ico�� � Title$ Login�� � DataContext ��    Locator �� Source# [  	 �� Path$	 Report�
 � 	Resources
  �� MergedDictionaries �� Source7   1com.boutique.Converters.VisiblityBooleanConverter  VisiblityConverter��  �� $8 2/com.boutique;component/Common/StandardStyles.xaml?�%   &	         .���� ���#1B1B1C���#434346$��2q� �� CornerRadius$ 0��._��  � RowDefinitions �� $��35 ��� $��3* �.+��� ���#4E4E50$��0��._�� $��Center=� � ColumnDefinitions �� $��3* ��� $��.2 �.+��� -   $��txtToday��
�������$��Center=�$��SemiBold"�$��15,0,0,0q�$��0��  Boutiuqefonttext#��[ $
��Left=��� $�Reports(�� �� $-�'You can genrate six months reports only��$��Normal"�$��13(�
���  �� �� $�)����  �� Orientation$ 
Horizontal=�$	��Top=�$��Right=�.+��� -   $��MinimizeSettingWindow�� � Cursor$
 Hand��$��1��$5��//com.boutique;component/Images/win_minimize.png��$��0,10,0,0q�$��15�� � ToolTip$ Minimize��$��Center=�$��Center=��� -   $��CloseSettingWindow��$
 Hand��$2��,/com.boutique;component/Images/win_close.png��$��10,0,0,0q�$��18��$ Close��$��Center=�$��Center=��� $��1�� �� Padding$ 10q�._��  �� �� $��20 ��� �� �� �� .+��� $ 
Horizontal=�$��0��$��Center=�$��Center=�.+��� $��Select Reports: ��
�������$��Center=�$��Normal"�$��0,0,0,0q�$��0��$��13(�#��[ $��Center=��� -   $��txtGenrateReport��$��0,5,0,0q�  CustomDropDown#��[  �� 
IsReadOnly .  �� TextAlignment$
 Left=�$	��160��
����������� $	 SelectedReport.type� �� Mode$ TwoWay=��� $��Or�����#818183$��Center=�$��1��$��SemiBold"�$��0,6,0,0q�$��0��$��14(�#��[ $��Center=��� $ 
Horizontal=�$��2��$��Center=�$��Center=�.+��� $��From: ��
�������$��Center=�$��Normal"�$��0,0,0,0q�$��0��$��13(�#��[ $��Center=��� -   $��txtDateFrom��$��0,5,0,0q�#��[ $
 Left=� .  $	��120��
����������� $	 FromDate�$ TwoWay=��� $
��To: ��
�������$��Center=�$��Normal"�$��20,0,0,0q�$��0��$��13(�#��[ $��Center=��� -   $��	txtDateTo��$��0,5,0,0q�#��[ $
 Left=� .  $	��120��
����������� $	 ToDate�$ TwoWay=��� $ 
Horizontal=�$��3��$��Center=�$��Center=�.+��� $��Select Folder To Save: ��
�������$��Center=�$��Normal"�$��0,0,0,0q�$��0��$��13(�#��[ $��Center=��� -   $��	txtFolder��$��0,5,0,0q�  FileDirectory#��[ $
 Left=� . $	��190������ $	 SaveFolderLocation�$ TwoWay=��� $ 
Horizontal=�$��4��$��Center=�$��Center=�.+��� $��Enter Save File Name: ��
�������$��Center=�$��Normal"�$��0,0,0,0q�$��0��$��13(�#��[ $��Center=��� -	   $��txtFileName��$��0,5,0,0q�  DefaultTextbox#��[ $
 Left=�$��Normal"�$	��190������ $	 SaveFileName�$ TwoWay=��� -
   $��btnLogin��$��0,10,0,0q�$��35��$��5�����#3088da$	��110��  BasicButton#��[ 
�������$��Center=�$��Genrate Report��� -    �Name$ popupDateSelector����.  $��Slide=� � AllowsTransparency .  � 	StaysOpen .  $��Center=� � PlacementTarget ��  �� ElementName$ txtDateFrom��.���� .u�&   System.Windows.Controls.Calendar  -   $��calendar��$
��Left=�$	��Top=�� -   $��PopGenrateReportItems����.  $��Slide=� .  .  $	��160�� �� $ txtGenrateReport��.���� ���#007ACC���#1B1B1C$ 2q�$��1,1,1,1q�$ 2��._��� -    ��Name$ ListreportItem��$��1��$��0q�
������ ���� *ReportItems+ �� NotifyOnTargetUpdated .  �� UpdateSourceTrigger$ PropertyChanged=�����  �� 
TargetType" ��  �� Triggers  P� ! P� Property! �@��AlternationIndex" P� Value$" 1��. ��� # �� Property# � ��$ �� Value$$ 0,0,1,0q��� # � ��$ �#cdcdcd�� # � ��$$ 0,0,5,0q����� " ��.��� -  'System.Windows.Input.KeyboardNavigation# �@ DirectionalNavigation$$ Cycle=��� # � ��$ . ���� .R��� $ 
Horizontal=�.+��� $��13(�$��Normal"�% �� Padding$% 1q�$��Center=�$
��Left=�
����������� *type+� -   $��AlertBox��$	��300��$	��450��$
��Fade=�& � VerticalOffset$& 50��$��Center=�$��Center=�$��Center=� . ' K� ZIndex$' 10������ *IsAlertOpen+.��.   (com.boutique.Views.UserControls.AlertBox  $��Center=� �� 