   M S B A M L   `   `   `  ���� P  LCapturedImages, Version=1.0.5906.26773, Culture=neutral, PublicKeyToken=null/clr-namespace:CapturedImagesCapturedImages  )    #CapturedImages.CustomStitchingImage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2	Converterclr-namespace:CapturedImages     -   $��0q�  � 	Resources  (   "CapturedImages.BytesArrayConverter   BytesArrayConverter �� 
TargetType �� Property �� Value �� 
TargetType � Cursor �� Padding �� CornerRadius �� Triggers	 P� Property
 P� Value �� 
TargetName��%�  &	        '��        �� " ��.���  � �� �#007ACC��  � ��$ 1q���  � ��$ 13(���  � ��
 �   ���  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R��� $��border��$
 Hand��$��2q�$��0,0,0,0q�$	 4,2q�$��35��
������ $ 3��#��z��._��� $��Center=�$��Center=� P� 	 �@J�IsMouseOver
 . . ��� $ border�� � ��
 ���� ��  � �� �#007ACC.����  �� Orientation$ 
Horizontal=����� *DropDownMargin+.+��� -    ��Name$ stackPanelItems��$ Vertical=�$��0q�.+��� -    ��Name$ listSelectedItems��
������ 
������ $��0q�$��0,0,0,0q�$
��Left=�$��Disabled=����� *	ListWidth+���� *SelectedImages+ �� NotifyOnSourceUpdated .  �� UpdateSourceTrigger$ PropertyChanged=����� .R��  � Orientation$ 
Horizontal=����� .R��� $��1q�$ 5�����#434346���#2D2D30$ 5,2,2,2q�$��0,0,10,5q�._�� $��StackPanelItem��$ 
Horizontal=�.+��� $
 Hand��$��25��
 � Tag �� *Key+���� *Value+ �� 	Converter# [  ��  ��Name$ ImageRemoveItem��-   $
 Hand��$��Center=�$8��2/CapturedImages;component/Images/trash_outline.png��$��18��$��Center=��� -   $��btnCaptureImages��$��Take Images��
�������$	��Top=�$��0q�$	��100��$
��Left=�� -   $��PopUpImagecapture��$��Slide=� � AllowsTransparency .  � 	StaysOpen .  $��Bottom=�|�. $	��300��$	��550������ *IsDropDownOpen+ �� Mode$ TwoWay=�$ PropertyChanged=� � PlacementTarget ��  �� ElementName$ btnCaptureImages��.���� ���#1B1B1C���#007ACC$��1q�._��  � RowDefinitions �� $
��.02* ��� $��0.442* ��� $��0.02* ��� $��0.088* ��� $��0.02* � � ColumnDefinitions �� $��0.274* ��� $��0.274* ��� $��0.20* �.+��� $��0��$��20,0,0,0q�$��1��$��1q�$ 0�����#434346._��� -   $ imgVideo��$
��Fill=��� $��1��$��20,0,0,0q�$��1��$��1q�$ 3�����#434346._��� -   $ 
imgCapture��$
��Fill=��� $��1��$��20,0,0,0q�$��3��$ 
Horizontal=�.+��� -	    ��Name$ 
bntCapture��$��Capture Image���� -
   $ bntSaveImage��$��
Save Image��$��8,0,0,0q��� $��2��$��1��$��Center=�.+��� -   $ bntResolution��$��Video Format��$	��120���� -   $ 
bntSetting��$��Video Source��$	��120��$��0,10,0,0q��� $��0��$��20,0,0,0q�$��3��$ 
Horizontal=�$��Center=�.+��� -   $ bntStart��$��Start���� -   $ bntStop��$
��Stop��$��10,0,0,0q��� -   $ bntContinue��$��Continue��$��10,0,0,0q�