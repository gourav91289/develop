   M S B A M L   `   `   `  ����   com.levelsbeyondB    <com.levelsbeyond.Views.UserControls.ConfigureVisibleMetadata   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       � 	Resources   �� MergedDictionaries �� Source��  �� $< 6/com.levelsbeyond;component/Common/StandardStyles.xaml?�%    .���� 
���   �$��2q� �� CornerRadius$ 3��$��Center=�._��    �� 
TargetType �� Property �� Value��%}   '�       '�� %     �� " �.���  � ��
 ������� " ��.���  � �� �#F4F4F4��  � ��$ 0 0 0 2q� � RowDefinitions �� $��2* ��� $��3* ��� $��8* ��� $��2* �.+��� $��0��$��0��._��� $��Center=�.+��� ���#212121$��30(� �� TextAlignment$ Center=�$
��Bold"�Configure Visible Columns�� $��0��$��1��._��� 	 �� Padding$	 	10,0,10,0q�$��14(�$
��Wrap=��� $R�LYou can choose the columns that you would like to appear in the search grid.���� �� �� $`�ZDrag or double click metadata fields from the Available Fields list to add them to Visible�� �� $X�RFields. Drag them back or double click to remove from Visible Fields. You can sort�� �� $4�.assets by these fields in the filter dropdown.���� �� $��2��$��0��._��  �� $��* ��� $��9* �
 � ColumnDefinitions
 �� $��5* ��� $��2* ��� $��5* �.+��� $��20,0,0,0q�$��1��$��0��.+��� $��Center=�$��16(�$��SemiBold"�$��0,0,20,0q�Available Fields�� -   $��LeftListView��$��
10,10,0,13q�$
��Left=�$	��Top=�$	��194��$	��240�� J� 	AllowDrop .  �� SelectionMode$ Multiple=����� * MetadataPropertyListModel.rows+ �� Mode$ TwoWay=����� .R��� $��0,0,0,1q�
�������$��30��$��5,0,5,0q�._�� .+��� $��SemiBold"�$	 10,0,0,0q�$��Center=�$
��Left=�$	��150������ *displayName+�� $��1��$��1��$��Center=�   �� 
TargetType��%  '��       �� " ��.���  � ��$ 30����  � ��$ 25����  � ��$ 5q���  �@�Cursor$
 Hand����  � �� �� " ��.R��� 
�������$��1q�$ 3��._�� ���#EFEFEF.+��� $
��Bold"�
���   �$��Center=�$��Center=�#��z��.+��� -   $��<���� -   $��>���� $��20,0,0,0q�$��1��$��2��.+��� $��Center=�$��16(�$��SemiBold"�$��0,0,20,0q�Visible Fields�� -   $��RightListView��$��
10,10,0,13q�$
��Left=�$	��Top=�$	��194��$	��240�� . $ Multiple=����� *SelectedRows+$ TwoWay=����� .R��� $��0,0,0,1q�
�������$��30��$��5,0,5,0q�._�� .+��� $��SemiBold"�$	 10,0,0,0q�$��Center=�$
��Left=�$	��150������ *displayName+�� $��0��$��3��._�� ���#EEEEEE
 �� �� $	��255 �.+�� $��1�����#EEEEEE
 �� $��1* ��� $��1* �.+���    BasicButton#��[  ���#1B1B1B$��40��$��0������ *ClosePrefrencePopupClick+.��Cancel�� #��[  ���#3088da$��40��$��1������ *SavePrefrenceClick+.��Apply