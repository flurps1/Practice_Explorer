   M S B A M L   `   `   `  ����C  ?Practice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PracticePractice  5   	       Practice.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Practice     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	   
   � .+�5
      R� -   5         R�Name$ 
FolderView��5
      ��6+   �� *Items+��5      �� 5       �� 
TargetType" Q�6   .�5      ��  �� Property �@Q�
IsExpanded �� Value 63   �� *
IsExpanded+ �� Mode$ TwoWay=�5      ��5      �� 5       �� ItemsSource 6/   �� *
Children+.R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��30��6$   $��3q�5   $   ��5   $   �� *Type+%   Practice.HeaderToImageConverter   Instance	 �� 	Converter#	 Z �� 5      $��Center=�6(   ��6C   �� *Name+5      5      5      5      5      