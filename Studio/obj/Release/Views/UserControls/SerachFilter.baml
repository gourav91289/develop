   M S B A M L   `   `   `  ���� K  Gcom.levelsbeyond, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:com.levelsbeyond.ViewModelcom.levelsbeyond.ViewModel  b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes i9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper+com.levelsbeyond.Common.UserInterfaceHelper  I)clr-namespace:com.levelsbeyond.Converterscom.levelsbeyond.Converters  I EAdornedControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:AdornedControl;assembly=AdornedControlAdornedControl Y1clr-namespace:com.levelsbeyond.Views.UserControls#com.levelsbeyond.Views.UserControls  S.clr-namespace:com.levelsbeyond.Views.Componets com.levelsbeyond.Views.Componets  6    0com.levelsbeyond.Views.UserControls.SerachFilter   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7vm(clr-namespace:com.levelsbeyond.ViewModel     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  XThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  F BWpfControls, Version=1.0.0.8, Culture=neutral, PublicKeyToken=null,AutoCompletBoxhttp://wpfcontrols.com/  HUiHelper9clr-namespace:com.levelsbeyond.Common.UserInterfaceHelper  J	 FWpfAnimatedGif, Version=1.4.12.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com 	 9	Converter)clr-namespace:com.levelsbeyond.Converters 	 =ac4clr-namespace:AdornedControl;assembly=AdornedControl 	 =local1clr-namespace:com.levelsbeyond.Views.UserControls 	 =Componet.clr-namespace:com.levelsbeyond.Views.Componets 	 -     >�Name$  SerachFilterUserControl�� � DataContext ��    Locator �� Source# [   �� Path$
 Main� � 	Resources  �� MergedDictionaries �� Source��  �� $< 6/com.levelsbeyond;component/Common/StandardStyles.xaml?�%    .��� 
������� ;   5com.levelsbeyond.Converters.VisiblityBooleanConverter  VisiblityBooleanConverter7  1com.levelsbeyond.Converters.ListToStringConverter  ListToStringConverter3  -com.levelsbeyond.Converters.GetWidthConverter  WidthConverter �� 
TargetType  comboBoxThunailSelctAll �� Property	 �� Value  comboxoxstackpanel  txtName  txtValue��%m  &	       &	      &	 
     &	      &	 �     &	 $    &	 �          �� " ��.���  � ��$	 	0,10,10,0q���  � ��
	 �������  � ��$	 26����  � ��$	 Right=���  � ��$	 Center=���  � ��$		 3,5q���  � ��$	 13(���  � ��$	 Segoe UI)��� " ��.���  � ��$	 10,0,0,0q���  � ��$
	 Left=��� " ��.���  � ��$	 Segoe UI)���  � ��	 �#474747��  � ��$	 13(���  � ��$
	 Bold"��� " ��.���  � ��$	 Segoe UI)���  � ��	 �#474747��  � ��$	 13(���  � ��$	 5,0,5,0q���  � ��$	 Normal"�
 � RowDefinitions
 �� $��50 ��� $��* �.+�]� -    ]�Name$ DocSearchArea��$��0,0,0,0q�$��0��.+��� -    ��Name$ BorderSerachTearm��  borderSearchtermHide#��[ $
��Left=�$	��565��._�� $��0,0,0,0q�
 �� $��* �.+�� $��0�� � ColumnDefinitions �� $��* ��� $��* �.+��� $��0��#��[ $��Center=�.+���  �� Orientation$ 
Horizontal=�$��Center=�.+��� -    ��Name$ FilterCombobox��$	��200�� 	 CustomTextBox#��[	  �� 
IsReadOnly .   ^� ShowOnDisabled . ���� *SavedFilterTextInCombobox+ �� NotifyOnSourceUpdated .  �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.�� J� InputBindings �� 
 �� Key$ Enter�� �� Command �� $ FilterItems�.���� -    
 CustomButtonStyle#��[
 $��1��.����  � Cursor$
 Hand��$��12��$8��2/com.levelsbeyond;component/Images/search_icon.png��$��Center=�$��Center=��� -    ��Name$# SpAssetGridSuggestionProvider��$��1��$
��Left=�$y�	Collapsed=�$��10,0,0,0q�#��[ �� -   $��StackPanelSoryByArea��$ 
Horizontal=�$��Right=�$��Center=�$��0,0,10,0q�.+��� -   $ FilterSortByCombobox��$	��275��#��[	 ���#595959 . ���� *SortByFilterText+ . $ PropertyChanged=�$ TwoWay=�.���� -	   #��[
 $��1��.���� $5��//com.levelsbeyond;component/Images/dropdown.png��$��Center=�$��Center=��� $ 
Horizontal=�$��1��.+��� -
    ��Name$ listSelectedFilters��$
��Left=�
������ $��0q�$��0q�
�������$��Hidden=���.  ���� *Criteria.criteria+ . $ PropertyChanged=����� *ActualWidth+ �� ElementName$ DocSearchArea�� �� ConverterParameter$ 50�� �� 	Converter# [ ���� " ��.���  � ��
	 ���� ��  � ��	 �� *HorizontalContentAlignment+ �� RelativeSource ��  �� AncestorType" ����  � ��	 �� *VerticalContentAlignment+ �� " ����  � ��$	 0q���  � ��	 ��   �� 
TargetType"  ��.R��� $ Bd��#��z��#��z��#��z��! �� Padding#! z��" J� SnapsToDevicePixels" . ._��� #��z��#" z" #��z��# �� Triggers# P� $ P� Property$ �@��
IsSelected% P� Value% . . ��� & �� 
TargetName$& Bd�� � ��
	 ���� ��  � ��	 �#474747P� $ �@J�IsMouseOver% . . ���  � ��
	 ���� ]� ' ]� 
Conditions' �� ( �� Property( �@��
IsSelected) �� Value) . �� ( �@��IsSelectionActive) .  ./��� $& Bd�� � ��
	 ���� ��  � ��	 �#474747P� $ � {�% .  . ��� #	 � �� � ������ .R�� * � Orientation$* 
Horizontal=����� .R��� $��StackPanelItem��$ 
Horizontal=�$��0,0,10,0q�.+��� #��[ ���� *name+�� #��[ ���� *op+�� $��:��#��[ �� #��[ ���� $ value�# [ �� + ��Name$+ ImageRmoveFilter��-   $
 Hand��$9��3/com.levelsbeyond;component/Images/deleteButton.png��$��14���� -   , ��Name$, CriteriaContentCountinue��$y�	Collapsed=�$	��...��#��[ $��18(�$
��Left=�� -   $��SavedFiltersBox��$��Slide=�- � AllowsTransparency- . . � 	StaysOpen. .  ���� *IsQueryBuilderPopUp+/ � PlacementTarget/ �� $ BorderSerachTearm��0 �� NotifyOnTargetUpdated0 . .���� -   $	��565��1 �� CornerRadius$1 0,0,2,2�����#282828$	��Top=�$! 10,10,10,10q�$��0,0,0,0q�._�� $��0,0,0,0q�
 �� �� .+��� $��0��$1 2��$��1q�
����������#C4C4C4._�� 
 �� $��* ��� $��* �.+��� $��0��$	��260��$��0q�
������ $��0,10,0,0q�._��� -   $��
scrollGrid��$
��Auto=���.  .��� $��0,15,0,0q� ��%3   '��       �� " ��.���  � ��$	 0,10,0,0q�
 �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$ 
Horizontal=�$��0q� ��%L   '��       �� " ��.���  � ��$	 5,0,0,0q���  � ��$	 Center=�.+���   queryBuilderTextBlock#��[ $��Asset type:���� $
 Hand��$��30������ *AudioFilterImagePathDefault+ d� 2 d� Gesture$2 	LeftClicka�3 �� CommandParameter$3 audio�� �� *OnTypesFilterClick+$ OneTime=��� $
 Hand��$��30������ *ImageFilterImagePathDefault+ d� $2 	LeftClicka�$3 image�� �� *OnTypesFilterClick+$ OneTime=��� $
 Hand��$��30������ *VideoFilterImagePathDefault+ d� $2 	LeftClicka�$3 video�� �� *OnTypesFilterClick+$ OneTime=��� $
 Hand��$��30������ *!VideoClipFilterImagePathDefault+ d� $2 	LeftClicka�$
3 clip�� �� *OnTypesFilterClick+$ OneTime=��� $
 Hand��$��30������ * DocumentFilterImagePathDefault+ d� $2 	LeftClicka�$3 document�� �� *OnTypesFilterClick+$ OneTime=��� $
 Hand��$��30������ *$"UnclassifiedFilterImagePathDefault+ d� $2 	LeftClicka�$3 unclassified�� �� *OnTypesFilterClick+$ OneTime=��� -   $��10,0,0,0q�  NormalButtonStyle#��[ $
 Hand��.���� #��[ $
��auto��4 �� Padding$4 	10,8,12,8q�$��Center=����� *AssetSelectionTypeText+$ PropertyChanged=��� -   $��stackCollection��$��1��$��0q�.+�9   3com.levelsbeyond.Views.Componets.CollectionComponet  5   Multipel5 . �� $��2��$ 
Horizontal=�.+��� #��[ $��Categories:���� $
��Left=�$��10,0,0,0q�$��Center=����#EFEFEF.+��  �� $	��18* ��� $��7* ��� $
��Auto �.+��� -   $ stackPanelCategory��$ 
Horizontal=�$��0q�.+��� $��1,0,0,1q�$! 2,3,0,0q����#EFEFEF$1 2,0,0,2�����#EFEFEF$
��Left=�._��� -   $ listSelectedCategories�����#EFEFEF
������ $��0q�$��0q�$��0��$��Disabled=�$	��257������ *SelectedCategories+ . $ PropertyChanged=����� .R�� $* 
Horizontal=����� .R��� $��1q�$1 5�����#CDCDCD���#EFEFEF$! 5,2,2,2q�._��� $��StackPanelItem��$ 
Horizontal=�$��0,0,10,0q�$	��255��.+��� #��[ $	��240��$
��Wrap=����� *name+�� $+ ImageRmoveFilter��-   $
 Hand��$:��4/com.levelsbeyond;component/Images/trash_outline.png��$��14���� -   $! QuearyBuilercategoryTextbox��#��[	 $	��253��$
��Left=����� *$"CurrentQuerBuilderSelectedCategory+�� $��3��$ 
Horizontal=�.+��� #��[ $��Created:���� $ 
Horizontal=�$
��Left=�$��0,0,0,0q�$��Center=�.+��� -   $  CalenderCreatedFromTextbox��$��10,0,0,0q�#��[	 6 �� TextAlignment$6 Center=�$	��100������ *QueryBuliderCreatedFrom+$ TwoWay=�.���� -   7 ��Name$&7  CalenderButtonCreatedFromTextbox��$��0,1,1,1q�$��17��#��[
 .���� $��12��$:��4/com.levelsbeyond;component/Images/calendar_icon.png���� #��[ $��to��$
��Left=�$
��Auto��$��Center=�$��5,5,5,5q��� $ 
Horizontal=�$
��Left=�$��0,0,0,0q�$��Center=�.+��� -   $ CalenderCreatedToTextbox��$��0,0,0,0q�#��[	 $6 Center=�$	��100������ *QueryBuliderCreatedTo+$ TwoWay=�.���� -   $$7 CalenderButtonCreatedToTextbox��$��0,1,1,1q�$��17��#��[
 .���� $��12��$:��4/com.levelsbeyond;component/Images/calendar_icon.png���� $��4��$ 
Horizontal=�.+��� #��[ $��Updated:���� $ 
Horizontal=�$
��Left=�$��0,0,0,0q�$��Center=�.+��� -   $  CalenderUpdatedFromTextbox��$��10,0,0,0q�#��[	 $6 Center=�$	��100������ *QueryBuliderUpdatedFrom+$ TwoWay=�.���� -   $&7  CalenderButtonUpdatedFromTextbox��$��0,1,1,1q�$��17��#��[
 .���� $��12��$:��4/com.levelsbeyond;component/Images/calendar_icon.png���� #��[ $��to��$
��Left=�$
��Auto��$��Center=�$��5,5,5,5q��� $ 
Horizontal=�$
��Left=�$��0,0,0,0q�$��Center=�.+��� -   $ CalenderUpdatedToTextbox��$��0,0,0,0q�#��[	 $6 Center=�$	��100������ *QueryBuliderUpdatedTo+$ TwoWay=�.���� -   $$7 CalenderButtonUpdatedToTextbox��$��0,1,1,1q�$��17��#��[
 .���� $��12��$:��4/com.levelsbeyond;component/Images/calendar_icon.png��� -   $��grdDynamicQueryBuilder��$��5��
�������$��
10,10,10,0q�
 �� $��* ��� $��* �.+��� $��0��$ 
Horizontal=�$��0,0,0,10q�.+��� $
��Auto��#��[ $��Search the following if���� -   $��comobboxMatchCondition��$��60��$��Segoe UI)�$��13(�$��30��$��Normal"�$��5q�$
��Left=�$��10,0,0,0q�.@��� -    $��or��$	��Any���� -!   $	��and��$	��All��8 �� 
IsSelected8 . �� $
��Auto��#��[ $��conditions are a match:��$��10,0,0,0q�F   @com.levelsbeyond.Views.UserControls.QueryBuilderSetCondtionModel  $��1�� �� � -"   $��PopUpCategoryFilter��$��Slide=�- . . .  $	��225��$	��255������ *IsCategoryQueryBuilderPopUp+/ �� $! QuearyBuilercategoryTextbox��.���� ���#ccc
�������$! 1q�$��1q�._��    ButtonWithoutHover��%�  &	       �� " ��.���  �@�OverridesDefaultStyle	 . ��  � ��
	 ���� ��  � ��
	 ���� ��  � ��$	 0q���  � ��$	 13(���  � ��$	 SemiBold"���  � ��$	 Segoe UI)���  �@�Cursor$
	 Hand����  � ��	 �� "  ��.R��� $��border�����#e7e7e7���#cdcdcd$	! 5,5q�$��0,1,0,0q�._��� $
��Left=�$��Center=�# P� $ �@J�IsMouseOver% . . ��� $& border�� � ��	 �#cdcdcd�� $& border�� � ��	 �#e7e7e7
 �� �� .+��� -#   9 ��Name$$9 QueryBuilderCategoryCollection��$��0��$��0q����� *SerachedCategories+0 . $ PropertyChanged=�.  (System.Windows.Interactivity.Interaction:   Triggers: /  )System.Windows.Interactivity.EventTrigger  ;   	EventName$; PreviewMouseLeftButtonUp��.  (System.Windows.Interactivity.TriggerBase<   Actions.< 6	  0System.Windows.Interactivity.InvokeCommandAction	  = 	  Command= �� *QueryBuilderSelectedCategory+> 	  CommandParameter> �� $ SelectedItem�$$ QueryBuilderCategoryCollection������ " ��? �� Triggers? P� $ �@��AlternationIndex$% 1��. ���  � ��$	 0,0,1,0q���  � ��	 �#cdcdcd��  � ��$	 0,0,5,0q����� " ��.��� -
  'System.Windows.Input.KeyboardNavigation �@
 DirectionalNavigation$	 Cycle=���  � ��	 . ���� .R��� $ 
Horizontal=�.+��� $��13(�$��SemiBold"�$4 1q�$��Center=�$
��Left=����� *name+� -$   @ �Name$@ popupDateSelector����.  $��Slide=�- . . .  $��Center=�/ �� $  CalenderCreatedFromTextbox��.���� .u�&   System.Windows.Controls.Calendar  -%   $��calendar��$
��Left=�$	��Top=��� -&   $&�� borderButtonAddAnotherCondituion��$��1q�$1 2�����#EFEFEF���#EFEFEF$��1��$! 	10,3,10,5q�$��10,10,10,20q�$
 Hand��$	��180��$
��Left=�._��� $ 
Horizontal=�$��Center=�.+��� #��[ $
��Auto��$��Add Another Condition��$
��Left=�A �� TextAlignment$
A Left=��� $A Right=�$��Right=�$��10,0,0,0q�$��18(�#��[ $
��Auto��$��+��$
��Bold"����#858585� $��1��$��0,10,0,0q� �� �� .+��� $ 
Horizontal=�$��0��.+���   DefaultButtonStyle#��[ $y�	Collapsed=�.���� $ 
Horizontal=�.+��� $��16��$6��0/com.levelsbeyond;component/Images/icon_star.png���� #��[ $
��auto��$
4 15,8q�$��Center=�$��Save This Search���� -'   $��0,0,0,0q�#��[ $
 Hand��.���� #��[ $
��auto��$
4 15,8q�$��Center=�$��Reset���� $ 
Horizontal=�$��1��$��Right=�.+��� -(     SerachButtonStyle#��[ $��10,0,0,0q�.���� 
�������$��SemiBold"�#��[ $
��auto��$��	13,0,10,0q�$��Center=�$��Search��� -)   $��AlertBox��$	��300��$	��450��$
��Fade=�B � VerticalOffset$B 50��$��Center=�$��Center=�$��Center=�- . C K� ZIndex$C 10������ *IsQueryBuilderAlertOpen+.��2   ,com.levelsbeyond.Views.UserControls.AlertBox  $��Center=� �� � -*   $��SortFilterPopUp��$��Slide=�- . . .  ���� *IsQueryBuilderSortByPopup+$ PropertyChanged=� . 0 . / �� $ StackPanelSoryByArea������ *ActualWidth+$ StackPanelSoryByArea��.���� $��0,0,0,0q����#ccc
�������$��1q�$1 0,0,2,2��._�� 
 �� $��* ��� $��* ��� $��* �.+��� -+   $9 SortByMetaDataItems��$��0��$��0q�
�������$��1q����#F6F6F6$��15q�$	��150��$��Hidden=���.  ���� *SortByFilterRows+:   $; PreviewMouseLeftButtonUp��.< 	  = �� *SelectedSortByFilterItem+> �� $ SelectedItem�$ SortByMetaDataItems������ " ��? �� D �� BindingD �� E �� Self# ZE $ Items.Count�F �� ValueF 0.a���  � ��	 �� .R��� .+��� 
�������$��There are no items��$��14(�$��SemiBold"�$4 2q�$��Center=�$��Center=����� " ��.���  �@
 DirectionalNavigation$	 Cycle=���  � ��	 . ���� .R��� $ borderSortByItem��$! 0q�$��0,0,0,1q�$
��Left=����#F6F6F6���� *ActualWidth+$ SortByMetaDataItems��$ 20��# [ ._��� $, txtSortByItem�����#484848$��13(�$
A Left=�$
4 10,5q�$��Segoe UI)�$��SemiBold"�$��Center=�$
��Left=����� *displayName+�� $��1��$��15q�$ 
Horizontal=�$
��Left=�.+��� ���#686868$��Sort By:��$��13(�$
A Left=�$��Segoe UI)�$��Center=�$
��Left=��� -,   $, SortByAscending��$��10,0,0,0q�$��	Ascending��$��13(�$
A Left=�$��Segoe UI)�$��SemiBold"����#3C3C3C$
 Hand��$��Center=�$
��Left=��� ���#AAAAAA$��	10,0,10,0q�$��|��$��13(�$
A Left=�$��Segoe UI)�$��Center=�$
��Left=��� --   $, SortByDescending�����#AAAAAA$��
Descending��$��13(�$
A Left=�$��Segoe UI)�$
 Hand��$��Center=�$
��Left=��� $ 
Horizontal=�$��2��$��Right=�$��	0,0,15,10q�.+��� -.   #��[ .���� 
�������$��SemiBold"�#��[ $
��auto��$��Center=�$
��Sort��