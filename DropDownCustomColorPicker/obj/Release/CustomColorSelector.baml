   M S B A M L   `   `   `  ���� S  OCustomColorPicker, Version=1.0.5906.26773, Culture=neutral, PublicKeyToken=nullE'clr-namespace:DropDownCustomColorPickerDropDownCustomColorPicker  +    %DropDownCustomColorPicker.ColorPicker   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5d'clr-namespace:DropDownCustomColorPicker       � 	Resources  ?   9DropDownCustomColorPicker.ColorToSolidColorBrushConverter '  #FromColorToSolidColorBrushConverter �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� RelativeSource � Cursor �� 
TargetName  ScrollThumbs �Name ��Name � RowDefinitions ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name J� Opacity ]� DecreaseRepeatButton P� 
SourceName  ButtonSelectBrush  	DarkBrush �� Angle  SliderThumb  SliderRepeatButton  SliderRepeatButton1 J� SnapsToDevicePixels 
 Slider �� Triggers��%J  &	        '��      '�� �     '�� �    &	 �    '�� �    &	 �	    &	 �
    &	 \    &	     7  7  7  '�� �    7    �� " ��.���  � ��$ 0,0,5,0q���  � ��$ 13(���  � ��$ 	Open Sans)���  � ��
 �������  � ��$ Normal"���  � ��$ Center=���  � ��$
 Left=��� " ��.���  �@��TextAlignment$
 Left=���  � ��$ 1,0,1,0q���  � ��$ 0q���  � ��
 ���� ��  � ��$ 13(���  � ��$ 	Open Sans)���  � ��
 �������  � ��$ Center=���  � ��$ Normal"���  �@��AcceptsReturn .  ��  � �� �� " ��.R��� $��border��$��1q����#2D2D30$ 2,5,2,5q����#434346$ 2��$��Center=�._��� $ PART_ContentHost��$��0q� P� 	 �@J�	IsFocused
 . . ���  ��  �� *Self+ �@+�FocusedElement�� " ��.���  � �� �#007ACC��  � ��$ 1q���  � ��$ 13(���  � ��
 �   ���  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R��� $��border��$
 Hand��$��2q�$��0,0,0,0q�$	 4,2q�$��30��
������ $ 3��#��z��._��� $��Center=�$��Center=� P� 	 �@J�IsMouseOver
 . . ��� $ border�� � ��
 ���� ��  � ��
 ���� �� " n�.���  � �� �� " n�.R�� $
 Grid��.+��� $��Stretch=�$��Stretch=�$
��Auto��$
��Auto��
������ �� $ 
Rectangle1��$ 5��$��Stretch=�$��Stretch=�$
��Auto��$
��Auto��#��z�� P� 	 �@�Tag$
 
Horizontal��. ��� $ 
Rectangle1�� � ��$
 Auto���� $ 
Rectangle1�� � ��$ 7���� " ��.���  �@��IsFlicksEnabled .  ��  � �� �#8C8C8C��  � ��
 ���� ��  � ��$ 8����  � �� �� " ��.R�� $ GridRoot��$��8��#��z�� �� $��0.00001* �.+�]� $ 
PART_Track��$��0����. |�.   n� $ Thumb��#��z��#���   �� $ PageUp��$��ScrollBar.PageDownCommand��$ 0Q�|�.   �� $ PageDown��$��ScrollBar.PageUpCommand��$ 0Q�|�.   P� $ Thumb��	 �@J�IsMouseOver
 . . ��� # �  $ Thumb�� � ��P� $ Thumb��	 �@n�
IsDragging
 . . ��� # �  $ Thumb�� � ��P� 	 � {�
 .  . ��� $ Thumb�� � y�$ 	Collapsed=�P� 	 �@��Orientation$
 
Horizontal=�. ��� $ GridRoot�� �@�LayoutTransform �� $	 -90Q��� $ 
PART_Track�� �@�LayoutTransform �� $	 -90Q���  � ��$
 Auto����  � ��$ 8���� $ Thumb�� �@�Tag$ 
Horizontal���� $ PageDown�� � ��$ ScrollBar.PageLeftCommand���� $ PageUp�� � ��$  ScrollBar.PageRightCommand���� " n�.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� �� " n�.R�A� $��13��$��13��
��������� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  � �� �� " ��.R��� $��1q����#7A8990
���   �$��8��$ 2���� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� �� " ��.R���  . ���#00AEEF$��1q����#7A8990$��8��$ 2���� " ��.R��  �� $
��Auto ��� $
��Auto �#��z���� $
��Auto �.+�]� $ 
PART_Track��$��1�� �� 8��  $��Slider.DecreaseLarge�� n� 8��  �� 8�� $��Slider.IncreaseLarge���� " ��.���  � |� .  ��  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle .  P� 	 �@��Orientation$
 
Horizontal=�. ���  � ��$ 21����  � ��$	 104����  � ��8   .���� ���#1B1B1C$��1q�$ 2�����#007ACC$ 10q�._��� -   $��
scrollGrid��$
��Auto=���. .���� $	��230��.+�9� -   $��epDefaultcolor��$��Default Colors��
�������$��	Open Sans)�$��13(� 9� 
IsExpanded . .���� -    ��Name$ DefaultPicker��
������ $
��10,5q����#434346$��1q�$��Disabled=� . ���� .R��� $��15��$��15�����#696969$��Center=�$��0q�$
 Hand������  �� 	Converter# [  ���� .R�� $��0 1 0 0q�9� -   $��epCustomcolor��$��More Colors��
�������$��	Open Sans)�$��13(� .  .����  �� Orientation$ Vertical=�.+�� $��	10,10,0,0q�.+��� ���#007ACC$��1q�$��Center=�$	��Top=����#1B1B1C$	��130��$	��100��._��� -     ��Name$  image��$	��130��$��80���� -   ! ��Name$! CanColor��$	��125��$��95��$��Center=�
������ $	��Top=�$��2q�.+�A� -   " A�Name$" 	EpPointer��$��8��$��8��
���   �
��������� $��	10,10,0,0q�$ 
Horizontal=�.+��� $
��ARGB���� -   # ��Name$# txtAlpha��$��0��$��35��$ �� 	MaxLength$$ 3���� -	   $
# txtR��$��1��$��35��$$ 3��$��2,1,2,1q��� -
   $
# txtG��$��2��$��35��$$ 3��$��2,1,2,1q��� -   $
# txtB��$��3��$��35��$$ 3��$��2,1,2,1q��� $ 
Horizontal=�$��	20,5,10,0q�.+��� $	��Hex��$��0,0,0,0q�
��������� -   $# txtAll��$��4��$��3,0,0,0q�$	��145���� -   % ��Name$	% SdA��& �� Orientation$& 
Horizontal=�$	��180��' � Minimum$' 0Q�( � Maximum$	( 255Q�) � SmallChange$) 1Q�* � LargeChange$* 25Q�$��Center=�$��5q�+ � Value$	+ 255Q��� -   , ��Name$, 
btnPreview��$��Ok��$��5,0,0,10q�$��Center=�$��50��