   M S B A M L   `   `   `  ���� M  IMultiSelect, Version=1.0.5893.20548, Culture=neutral, PublicKeyToken=null9!clr-namespace:DropDownMultiSelectDropDownMultiSelect  +    %DropDownMultiSelect.CustomMultiSelect   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7	Converter!clr-namespace:DropDownMultiSelect     -   $��0q�  � 	Resources  3   -DropDownMultiSelect.VisiblityBooleanConverter   VisiblityConverter  TextBox �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value	 �� RelativeSource��%�  &	        &	        �� " ��.���  � ��$ 7,2,7,2q���  � ��$ 0q���  � ��
 ���� ��  � ��$ 25����  � �� �� *DropDownBackGroundColor+��  � ��$ 13(���  � ��$ Segoe UI)���  � ��
 �������  � ��$ Center=���  � ��$ Normal"���  �@��AcceptsReturn .  ��  � �� �� " ��.R��� $ PART_ContentHost��$��0q� P�  �@J�	IsFocused . . ���  �� 	 �� *Self+ �@+�FocusedElement.���� 
 �� Orientation$
 
Horizontal=����� *DropDownMargin+.+��� ���� *DropDownTextStyle+y��� *IsDropDownTextNameVisibility+ �� 	Converter# [  ���� *DropDownTextName+�� -   $��brdrMainDropDown�� �� Padding$ 0,2,0,2q� �� CornerRadius$ 2������ *DropDownBackGroundColor+���� *DropDownBorderColor+._��� -    ��Name$ stackPanelItems��$
 
Horizontal=�$��0q�.+��� -    ��Name$ listSelectedItems��
������ $��0q�$��0,0,0,0q�$��0��$
��Left=�$��Disabled=����� *DropDownBackGroundColor+y��� *IsSelectedMultipleItems+# [  ���� *SelectedWrapPanelWidth+���� *SelectedItems+ �� NotifyOnSourceUpdated .  �� UpdateSourceTrigger$ PropertyChanged=����� .R��  � Orientation$ 
Horizontal=����� .R��� $��1q�$ 5�����#ccc���#EFEFEF$ 5,2,2,2q�._�� $��StackPanelItem��$ 
Horizontal=�$��0,0,10,0q�.+��� $
��Wrap=����� *Value+ � ToolTip �� *Value+
 � Tag �� *Key+���� *DropDownTextStyle+��  ��Name$ ImageRemoveItem��-    � Cursor$
 Hand��$5��//MultiSelect;component/Images/trash_outline.png��$��14���� -    ��Name$ textboxMultiSerach��#��[ 
�������$	��Top=�$��0q�$
��Left=����� *DropDownText+$ PropertyChanged=� �� Mode$ TwoWay=����� *TextBoxWidth+� -   $��PopUpQueryBuilderFilter��$��Slide=� � AllowsTransparency .  � 	StaysOpen .  |�. $	��225������ *IsDropDownOpen+$ TwoWay=�$ PropertyChanged=� � PlacementTarget ��  �� ElementName$ textboxMultiSerach������ *TextBoxWidth+.���� ���#ccc$ 0,0,2,2��
�������$ 5q�$��1q�._�� .+��� -    ��Name$ lstDropDownItem��$��0q����� *DropDownSourceItems+$ PropertyChanged=� . ���� " �� �� Triggers ��  �� Binding ��   �� Self#	 Z  ! �� Path$! Items.Count�" �� Value" 0.a���  � �� �� .R��� .+��� $��No Items��$��14(�$��SemiBold"�# �� Padding$# 2q�$��Center=�$��Center=����� " ��.��� -  'System.Windows.Input.KeyboardNavigation �@ DirectionalNavigation$ Cycle=���  � �� . ���� .R��� $
 
Horizontal=�.+��� $��14(�$��SemiBold"�$# 2q�$��5,0,0,0q�$��Center=�$
��Left=����� *Value+