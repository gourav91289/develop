   M S B A M L   `   `   `  ���� K  Gcom.levelsbeyond, Version=1.4.5.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:com.levelsbeyond.Converterscom.levelsbeyond.Converters  Y1clr-namespace:com.levelsbeyond.Views.UserControls#com.levelsbeyond.Views.UserControls  6    0com.levelsbeyond.Views.UserControls.SavedFilters   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?	Converter)clr-namespace:com.levelsbeyond.Converters     Clocal1clr-namespace:com.levelsbeyond.Views.UserControls     -     >�Name$  SavedFilterUserControl�� � DataContext ��    Locator �� Source# [   �� Path$
 Main� � 	Resources  �� MergedDictionaries �� Source;   5com.levelsbeyond.Converters.VisiblityBooleanConverter  VisiblityBooleanConverter��  �� $< 6/com.levelsbeyond;component/Common/StandardStyles.xaml?�%   &	         .��� .+��� 
���   �$��1q� �� CornerRadius$ 3��$	��Top=�$
��Left=�._��   �� 
TargetType	 �� Property
 �� Value��%�   &	       '�      '�� *     '�� O       �� " �.��� 	 � ��

 ������� " ��.��� 	 � ��$

 Bold"��� " ��.��� 	 � ��
 �#F4F4F4�� 	 � ��$
 0 0 0 2q� � RowDefinitions �� $��* ��� $	��10* ��� $��2* ��� $��* � � ColumnDefinitions �� $��3* ��� $��2* ��� $��2* �.+��� $��SAVED FILTERS��$��0��$��0�� �� Padding$ 10q�
���   �$��5,0,0,0q��� $��1��$��0��y��� *IsFiltercollapse+ �� 	Converter# [ .+��  �� $��2* ��� $��1* �.+��� $��0��$
��Left=� �� Padding$ 10q�$��0q�
������ ._���  �� Orientation$ 
Horizontal=�.+�	� -   $��radioFilterCondition��$��
CONDITIONS��
���   �$
��Bold"� d� 	IsChecked �� *IsFilterCondition+�� -   $��ConditionButton��$��16�� � Cursor$
 Hand��$��5,0,0,0q�$��Right=�{��� *IsFilterCondition+����  �� 
TargetType" ��.R��� ���#cdcdcd���#cdcdcd$��1q�._��� $<��6/com.levelsbeyond;component/Images/magic-wand_icon.png��$��14��$��14��$��Center=�$��Center=��� $��1��$��right=�$ 10q�$��0q�
������ ._�	� -   $��radioFilterRQL��$	��RQL��
���   �$
��Bold"� �� *IsFilterRQL+�� $��2��$��0��.+��  �� $��2* ��� $��1* �.+��� $��SORT BY��$��0��$
��Left=�
���   �$ 10q�$��5,0,0,0q��� -   $��Expend��$��1��$��16��$
 Hand��
������ $��0q�
������ $	��Top=�$��0,5,5,0q� � ToolTip$ Expend Filter��y��� *IsFilterexpend+# [ .���� $3��-/com.levelsbeyond;component/Images/expand.png��y��� *IsFilterexpend+# [ �� -   $��collapse��$��1��$��16��$��16��$
 Hand��
������ $��0q�
������ $��Right=�$	��Top=�$��0,5,5,0q�$ Collapse Filter��y��� *IsFiltercollapse+# [ .���� $5��//com.levelsbeyond;component/Images/collapse.png��y��� *IsFiltercollapse+# [ �� -    ��Name$ ListViewSavedFilters��$��1��$	��250��$��5,5,10,5q�$	��210�� �� SelectedItem �� *SelectedSavedFilter+���� *AssetFilterSavedModel.rows+ �� Mode$ TwoWay=����� .R��� $��0,0,0,1q�
�������$ 0,5,0,5q�$��50��$��0,0,5,0q�$��Stretch=�._�� $��Stretch=�$	��230�� �� $��2* ��� $��3* � �� $��5* ��� $��* �.+��� $��0��$
��Wrap=�$��SemiBold"�$ 5,0,0,0q�$��Center=�$
��Left=����� *name+� $��1��$��0,0,2,0q�$
��Left=� � Orientation$ 
Horizontal=� ��%]   '��       �� " ��.��� 	 � ��$
 5,0,0,0q��� 	 � ��$
 0q��� 	 � ��$
 25��.+��� $2��,/com.levelsbeyond;component/Images/audio.png��$��30��y��� *SearchData.IsAudioIconVisible+# [ �� $2��,/com.levelsbeyond;component/Images/image.png��$��30��y��� *SearchData.IsImageIconVisible+# [ �� $2��,/com.levelsbeyond;component/Images/video.png��$��30��y��� *SearchData.IsVideoIconVisible+# [ �� $7��1/com.levelsbeyond;component/Images/video_clip.png��$��30��y��� *#!SearchData.IsVideoClipIconVisible+# [ �� $5��//com.levelsbeyond;component/Images/document.png��$��30��y��� *" SearchData.IsDocumentIconVisible+# [ �� $9��3/com.levelsbeyond;component/Images/unclassified.png��$��30��y��� *" SearchData.IsUnclassifiedVisible+# [ �� $��Right=�$
 Hand��
������ $��0q�$��-4q�
������ $��20��$��20��$��0��$��2��$��1��$��Right=�����  �� ElementName$ SavedFilterUserControl��$) #DataContext.DeletSavedFilterCommand����� *id+���� " ��.R��� $9��3/com.levelsbeyond;component/Images/deleteButton.png��$ Delete Filter���� $��1��$��1��$��5,5,10,5q�y��� *IsFiltercollapse+# [ ._��� -    ��Name$ TextCondtionRql��$	��250�� �� AcceptsReturn .  �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=�$	��160������ *RqlFilterText+$ TwoWay=� �� 
IsReadOnly �� *IsFilterCondition+.���� -	   $ SortByListView��$��1��$	��250��$��2��$��5,5,10,5q� �� SelectedIndex$ 1�� �� *SelectedSortByFilter+$ TwoWay=����� *#!AllMetadataPropertyListModel.rows+$ TwoWay=����� .R��� $��0,0,0,1q�
�������$��30��$��5,0,5,0q�$��Stretch=�._�� $��Stretch=�.+��� $��SemiBold"�$ 10,0,0,0q�$��Center=�$
��Left=�$	��150������ *displayName+�� $ 
Horizontal=�$��2��$��3��$��5,5,0,5q�.+��� $��0,0,0,0q�
SORT ORDER	� $��5,0,0,0q�  	� 	GroupName$	  RD1�� �� *%#IsAscendingSortSelectedOnSaveFilter+$ TwoWay=�.��ASCENDING SORT	� $��5,0,0,0q�$	  RD1�� �� *&$IsDescendingSortSelectedOnSaveFilter+$ TwoWay=�.��DESCENDING SORT�� $��0��$��3��$��3�����#EEEEEE._�� $��5,5,5,5q����#EEEEEE.+���   BasicButton#��[ ���#1B1B1B$��30��$	��150��$
��Left=����� *OpenSaveCurrentFilterPopup+.��Save Current Filter�� $ 
Horizontal=�$��Right=�.+��� #��[ ���#1B1B1B$��30��$	��100��$��Right=�$��Right=����� *ResetFilter+.��Reset�� -
   #��[ ���#3088da$��30��$	��100��$��Right=�$��Right=�.��Filter� -   ! �Name$! popupSetCondtionModel��$
��None=�" � AllowsTransparency" . # � 	StaysOpen# . $��Center=�$��Center=�$��Center=����� *IsSetConditionPopupOpen+.���� .u�� .+��� -   $��layoutBorder��
���   �$ J� Opacity$	$ 0.3Q�$��Bottom=�:   4com.levelsbeyond.Views.UserControls.SetCondtionModel   �� 