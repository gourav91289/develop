   M S B A M L   `   `   `  ����   com.levelsbeyond:    4com.levelsbeyond.Views.UserControls.VideoClipControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     >�Name$  VideoWindow�� � DataContext ��    Locator �� Source# [   �� Path$
 Main�{��� *IsPlayerEnabled+ �� Mode$ TwoWay=�.��� ���#111111.+��� -    ��Name$ VideoControl��$��10q��� $��/Images/document.png��$
��None=�y��� *ShowDocumentDefaultImage+$ TwoWay=��� $��/Images/audio.png��$
��None=�y��� *ShowAudioDefaultImage+$ TwoWay=��� 
�������$	��200��$��Center=�$��Center=� �� TextAlignment$ Center=�$��20(�y��� *ShowNoProxyAvailableMessage+$ TwoWay=�Proxy Not Available�� $��Bottom=����#111111y��� *ShowMediaBottomPanel+$ TwoWay=�.+��� -   $��videoSlider�� �� IsMoveToPointEnabled . $��	10,0,10,0q��  � ColumnDefinitions �� $��2* ��� $��4* ��� $��4* ��� $��3* �.+��� 
�������$ Center=�$��Center=��� 
�������$
��Bold"���� *CurrentTime+$ TwoWay=� �� $�/�� �� 
�������$
��Bold"���� *DisplayEndTime+�� 	 �� Orientation$	 
Horizontal=�$��1��$��2��$��5,0,0,0q�
 � 	Resources
  �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� CornerRadius � UseLayoutRounding J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   ShadowDepth �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� " ��.���  � ��$ 1,0,0,0q���  � ��$ 0q���  � �� �#282828��  � ��$ 22����  � �� �� " ��.R��� $��border��$��0q�$	 4,2q�
�������$ 1��
������  .    $ 4Q�$ 2Q�._�� .+��� $��contentShadow�� P�  �@J�IsMouseOver . . ��� $ border�� � ��
 �   ���  � ��
 ���� P�  � �� . . ���  � ��
 ���� P�  �@��IsDefaulted . . ��� $ border�� � �� �	#FF282828P�  �@J�	IsFocused . . ��� $ border�� � �� �	#FF282828��  � ��
 �����P�  � {� .  . ��� $ border�� �@J�Opacity$	 0.7Q��� $ border�� � �� �	#FF282828.+��� -    ��Name$ VideoBackButton��
 � Tag$
 Back�� � Cursor$
 Hand��$y�	Collapsed=�.���� $��0,0,0,0q����� " �� �� Triggers ��  �� Binding �� *isBackActive+ �� Value True.a���  � ��$= 7/com.levelsbeyond;component/Images/PlayerIcons/back.png����  �� *isBackActive+	 False.a���  � ��$D >/com.levelsbeyond;component/Images/PlayerIcons/back_active.png���� -   $ VideoPlayButton��$
 Play��$
 Hand��.���� $��0,0,0,0q����� " �� ��  �� *isPlayActive+ True.a���  � ��$G A/com.levelsbeyond;component/Images/PlayerIcons/forward_active.png����  �� *isPlayActive+	 False.a���  � ��$E ?/com.levelsbeyond;component/Images/PlayerIcons/pause_active.png���� -   $ VideoForwardButton��$ Forward��$
 Hand��$y�	Collapsed=�.���� $��0,0,0,0q����� " �� ��  �� *isForwardActive+ True.a���  � ��$@ :/com.levelsbeyond;component/Images/PlayerIcons/forward.png����  �� *isForwardActive+	 False.a���  � ��$G A/com.levelsbeyond;component/Images/PlayerIcons/forward_active.png���� 
�������$��Center=�$��Center=�
������ ���� *CurrentSpeedRatio+� $��3��$��0,0,10,0q�$��Right=�.+��� 
�������$��Center=�$
��Left=�$��5q�Volume�� -   $��volumeSlider��$��Center=�$
��Left=� � Minimum$ 0Q�  � Maximum$  1Q�! � Value$
! 0.25Q� . 