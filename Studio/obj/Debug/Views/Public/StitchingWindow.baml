   M S B A M L   `   `   `  ����G  Ccom.boutique, Version=1.4.5.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:com.boutique.Viewscom.boutique.Views  5   	   a5clr-namespace:com.boutique.Common.UserInterfaceHelper'com.boutique.Common.UserInterfaceHelper  5
   	   S OCustomColorPicker, Version=1.0.5937.35858, Culture=neutral, PublicKeyToken=null`Bclr-namespace:DropDownCustomColorPicker;assembly=CustomColorPickerDropDownCustomColorPicker 5   	   (    "com.boutique.Views.StitchingWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:com.boutique.Views     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   DUiHelper5clr-namespace:com.boutique.Common.UserInterfaceHelper  5
   	   J FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	   KcpBclr-namespace:DropDownCustomColorPicker;assembly=CustomColorPicker  5   	   -   5          �Name$  StitchingItem��5   	    � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=�5   #    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�6   $��Center=�5   	   $��Center=�6&   $	��550��5   	   ���#878787$	��400��6*    � Icon$0 */com.boutique;component/Images/appicon.ico��5   	    � Title$ New Measurement��5   	    � DataContext 6!   ��    Locator �� Source# [  	 �� Path$
	 Main�
 � 	Resources
 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $8 2/com.boutique;component/Common/StandardStyles.xaml?�5      %    5      .��5      �� ���#4E4E50$��1q�6#   ._�5   
   � ���#1B1B1C � RowDefinitions 5      �� 5      $��25 �6    6.   �� 5       $��* �6    6-   .+�5#      �� -   5        $��brdTop��5#      
������ ���#4E4E50$��0��6R    �� Padding$ 0,0,0,0q�5$      ._�5%      ��  �� Orientation$ 
Horizontal=�6   $	��Top=�66   $��Right=�5&   !   $��0,0,10,0q�6=   }�. .+�5(      �� -   5        $��MinimizeSettingWindow��5(   *    � Cursor$
 Hand��6   $5��//com.boutique;component/Images/win_minimize.png��5*      $��0,10,0,0q�6U   $��18��5+       � ToolTip$ Minimize��6%   $��Right=�68   $��Center=�6T   6q   �� 5-      -   5        $��CloseSettingWindow��5-   *   $
 Hand��6   $2��,/com.boutique;component/Images/win_close.png��5/      $��10,0,0,0q�6R   $��18��50      $ Close��6%   $��Right=�65   $��Center=�6Q   6n   52      53      �� 55      $��0q�6   $��1��6)   
������ $ 	10,0,10,0q�6P   ._�56      �� -   5        $��
scrollGrid��56      $
��Auto=�61   ��. .��57      �  58      �� 59      $��1* �6,   6:   �� 5:      $
��3.5* �6,   6<   .+�5=      �� $ 	50,0,50,0q�6!   $��0��65   
������ $��0q�6\   ._�5>      �� $ Vertical=�6*   $	��Top=�6A   }�. $��0q�6m   .+�5@   "   �� $��Add New Stitching Item��6,   $
��Wrap=�6J   $��0,10,0,0q�6^     DefaultBoutiuqeName#��[ 5A   %   $��Center=�6R   �� 5C   "   $ Vertical=�6-   $
��Left=�6D   .+�5D   &   �� $��	Item Name��60     Boutiuqefonttext#��[ 6B   �� 5E   &   -   5        $��txtName��5E   ?   $��0,5,0,0q�6.     DefaultTextbox#��[ 6N   $	��200��5F   .   $��
Enter Name��6:   �� 5H   &   -   5        $��	btnAddNew��5H   c   $��0,5,0,0q�6-     BasicButton#��[ 6>   $��80��5I   .   $	��Add��69   6G   �� 5K   &   -   5        $��stcUpdatePanel��5K   J   $ 
Horizontal=�61   $y�	Collapsed=�6`   .+�5L   *   �� -	   5        $��0,5,0,0q�5L   1   #��[ 6B   $��80��5M   .   $��Update��69   6J   �� 5O   *   -
   5        $��0,5,0,0q�5O   1   ���#4E4E50#��[ 6W   $��80��5P   .   $��Cancel��69   6J   5Q   '   5S   #   5U      5V      �� 5X      $ 
10,20,10,0q�6!   $��0,0,0,10q�66   $��1��6H   
������ ._�5Z      &   System.Windows.Controls.DataGrid  -   5          Name$ AssetDataGrid��5e         SelectionMode$ Extended=�5Z   '      CanUserSortColumns .     
IsReadOnly .    AutoGenerateColumns .     CanUserAddRows .     HeadersVisibility$ Column=�5^      ��.     EnableRowVirtualization .  ���#434346$��1q�5`   5   ���#1B1B1C$��	Open Sans)�5a   4   $��12(�6K   
�������   HorizontalGridLinesBrush �#434346   GridLinesVisibility$ 
Horizontal=�5c         AlternatingRowBackground �#4E4E50   	RowHeight$ 35Q�5d   B      ColumnHeaderHeight$ 28Q�6Q   ��5[      �� *StitchingItem+ �� Mode$ TwoWay=�
 5g   "   *  $System.Windows.Controls.DataGridCell  �� 
TargetType! �� Property" �� Value# �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow$ �� Triggers% P� Property& P� Value��%�  '        '  �     '  >    �� 5h   &   "   6,   .�5i   *   �� ! � ��" 5j   .   �� 5k   2   "#  6B   .R�5l   6   � #��z��6;   .+�5m   :   �� $
��Left=�6K   $��Center=�6f   $��10,0,0,0q�6�   5n   7   5o   3   5q   +   5r   '   �� 5s   &   "   6,   .�5t   *   �� ! � ��$" 30��6C   �� 5u   *   ! � ��" �#4E4E506G   �� 5v   *   ! � ��
" �����6G   �� 5w   *   ! � ��$" Normal"�6G   �� 5x   *   ! � ��$" 12(�6E   �� 5y   *   ! � ��$" 5,0,0,0q�6D   �� 5z   *   ! � ��$" 0,0,1,0q�6L   �� 5{   *   ! � ��" �#4343466H   5|   '   �� 5}   &   "   6,   $ 5~   *   P� 5   .   % �@��AlternationIndex$& 0��6_   . �5�   2   �� ! � ��" �#1B1B1C6a   �� 5�   2   ! � ��
" �����6_   5�   /   P� 5�   .   % �@��AlternationIndex$& 1��6_   . �5�   2   �� ! � ��" �#4E4E506a   �� 5�   2   ! � ��
" �����6_   5�   /   5�   '   5�   #   .  (System.Windows.Interactivity.Interaction'   Triggers' 5�   "   /  )System.Windows.Interactivity.EventTrigger  5�   &   (   	EventName$( MouseDoubleClick��65   .  (System.Windows.Interactivity.TriggerBase)   Actions.) 5�   *   6  0System.Windows.Interactivity.InvokeCommandAction  *   Command* 6@   �� *AssetGridRowSelectedCommand++   CommandParameter+ 5�   4   �� $	 SelectedItem�, �� ElementName$, AssetDataGrid��5�   '   -   Columns- 5�   "   4	  .System.Windows.Controls.DataGridTemplateColumn	  5�   &   ,
  &System.Windows.Controls.DataGridColumn. 
  Header$
. Name��6=   / 	  CellTemplate/ 5�   *   �� 5�   .   .R�5�   2   �� 0 �� Padding$0 0,0,0,0q�6k    6<   �� *Name+��6U   �� *Name+6   5�   /   5�   '   	  5�   &   $. Deleted��6=   1 
  Width5  /System.Windows.Controls.DataGridLengthConverter$1 60 6N   / 5�   *   �� 5�   .   .R�5�   2   �� $0 0,0,0,0q�6u    6<   �� *	IsDeleted+��6Z   �� *	IsDeleted+6�   5�   /   5�   '   	  5�   &   $. 
Created On��6=   2 
  MinWidth$2 85Q�6Q   / 5�   *   �� 5�   .   .R�5�   2   �� $0 0,0,0,0q�6v    6<   �� *	_CreateOn+��6[   �� *	_CreateOn+6�   5�   /   5�   '   	  5�   &   $. Last Updated��6=   $2 85Q�6S   / 5�   *   �� 5�   .   .R�5�   2   �� $0 0,0,0,0q�6    6<   �� *_LastUpdatedOn+��6_   �� *_LastUpdatedOn+6�   5�   /   5�   '   	  5�   &   $
. Edit��6=   $1 40 6K   / 5�   *   �� 5�   .   .R�5�   2   �� $��Measurement��6F   -   5        $
 Hand��5�   8   $
 Edit��6l   $4��./com.boutique;component/Images/edit_Pencil.png��5�   4   $��0,0,0,0q�6l   $��15��5�   4   $��Center=�6@   $��Center=�6]   
3 � Tag3 5�   Y   �� *Id+5�   s   5�   /   5�   '   	  5�   &   $. Delete��6=   $1 50 6M   / 5�   *   �� 5�   .   .R�5�   2   �� $��Measurement��6F   -   5        $
 Hand��5�   8   $ Delete��6l   $.��(/com.boutique;component/Images/trash.png��5�   4   $��0,0,0,0q�6f   $��15��5�   4   $��Center=�6@   $��Center=�6]   3 5�   Y   �� *Id+5�   u   5�   /   5�   '   	  5�   &   $. Add Parameters��6=   $	1 100 6U   / 5�   *   �� 5�   .   .R�5�   2   �� -   5        $��Add Parameters��5�   <   $0 0,0,0,0q�6R   ���#007ACC 5�   <   �� *ParameterTypes.Count+3 6e   �� *Id+5�   <   5�   /   5�   '   5�      5�      � 5�      -   5        $��PopUpMeasurementItems��5�       ��.  $��Slide=�5�       4 � AllowsTransparency4 . $��Center=�5�       $��Center=�6;   $��Bottom=�5�       5 � 	StaysOpen5 . $	��400��5�       $	��300��60   .��5�      �� -   5        $��brdrMeasurement��5�   F   ���#007ACC���#1B1B1C$��1q�6!   6 �� CornerRadius$6 0��65   ._�5�   "   �  5�   &   �� 5�   *   $	��.5* �68   6G   �� 5�   *   $��* �68   6E   �� 5�   *   $	��.5* �68   6G   .+�5�   &   �� ���#4E4E50$��0��6B   ._�5�   *   �� $ 
Horizontal=�65   .+�5�   .   �� $��Add Measurement Types��68   $	��240��6U   $��Center=�6a   $��SemiBold"�5�   ,   
�������$
��Wrap=�6U   $��
20,10,0,10q�6i   #��[ 5�   ,   7 �� TextAlignment$7 Center=�6V   �� 5�   .   -   5        $
 Hand��5�   4   $ Close��6B   $2��,/com.boutique;component/Images/win_close.png��5�   0   $��10,0,0,0q�6f   $��18��5�   0   $��Right=�6;   $��Center=�6W   6t   5�   +   5�   '   �� 5�   &   -   5        $��scrollMeasurement��5�   3   $��1��6L   ��. $
��Auto=�5�   +   .��5�   *   � $��15,10,15,10q�6/    5�   .   �� 5�   2   $��2* �6@   6N   �� 5�   2   $��1 �6@   6M   �� 5�   2   $��1* �6@   6N   .+�5�   .   �� $��0��65   
������ $��0,0,0,10q�6\   ._�5�   2   �� $ Vertical=�6=   $
��Left=�6T   $��0��6o   $��10,0,0,0q�6   .+�5�   6   �� $
��Name��6@   $��0,4,0,0q�6L   #��[ 6^   �� 5�   6   -   5        $��txtParameterName��5�   O   $��0,5,0,0q�6>     CustomTextBox#��[ 6g   $	��200��5�   A   $��
Enter Name��6M   �� 5  6   -   5        $��btnAddNewParameter��5  t   $��0,5,0,0q�6=     SubmitButton#��[ 6N   $	��100��5  B   $	��Add��6N   6\   5  3   5  /   �� 5  .   $��1��65   
������ $��0q�6\   ._�5  2   �� 
�������$��1��6L   $��1��6W   8 �� StrokeDashArray$8 1R�6k   9 J� SnapsToDevicePixels9 . 5	  8   5
  /   �� 5  .   -   5        : ��Name$: lstDropDownMeasuremnt��5  7   $��2��6V   $��	0,10,0,10q�6c   
������ $��0q�5  7    ! ListBoxtemStyleNoHighlighting#��[ 5  7   ��5  7   �� *
Parameters+; �� UpdateSourceTrigger$; PropertyChanged=�< �� NotifyOnSourceUpdated< . ��5  2   �� 5  6   "  ��6<   $ 5  :   �� 5  >   = �� Binding= 6J   �� > �� Self? �� RelativeSource#? Z> $	 Items.Count�@ �� Value@ 05  \   .a�5  B   �� ! � ��" 5  F   �� 5  J   .R�5  N   �� .+�5  R   �� $��No Items��6\   $��14(�5  Y   $��Normal"�6g   $0 2q�5  Y   $��Center=�6e   
�������$��Center=�5  Y   5  O   5  K   5!  C   5"  ?   5$  7   ��5&  2   �� 5'  6   .R�5(  :   �� $ 
Horizontal=�6E   .+�5)  >   �� $��14(�6^   $��Normal"�5*  L   $0 2q�6`   
�������$��5,0,0,0q�5+  L   $��Center=�6]   $
��Left=�5,  L   ��5)  H   �� *Name+5,  L   5-  ;   5.  7   50  /   52  +   53  '   55  #   57     59     5<     5=     5>     5@     5A     5B     