   M S B A M L   `   `   `  ����^  ZWPF ev tapsirigi(verilib 2.05.2019), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:WPF_ev_tapsirigi_verilib_2._05._2019_%WPF_ev_tapsirigi_verilib_2._05._2019_  5   	   6    0WPF_ev_tapsirigi_verilib_2._05._2019_.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:WPF_ev_tapsirigi_verilib_2._05._2019_     5   	     � Title$  Online Store��5   	   $	��620��6   $
��1200��6+   ���#b8eafc � Icon$ mainwindow.jpg��6M    � WindowStartupLocation$ CenterScreen=�6c   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.9* �6   6.   �� 5      $��5* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� -   5        $��	BuyButton��5      $��0��6"   $	��140��62   $��85��6>   $��Buy Disc��6J   $��Comic Sans MS)�6]   $��28(�6x   $��
2,-480,0,5q�6�   
����� �
����  �$��2q�6�    � Cursor$
 Hand��6�    � ToolTip$ Buy Disc��6�   $y�Hidden=�6�   5      � 5   
   $��1��6   $��2��6    � RowDefinitions 5      �� 5      $
��1.1* �6    60   �� 5      $��5* �6    6.   .+�5"      �� -   5        $��mainlistbox��5"   a   
���  ��$��2q�6(   $��1��6<   
������$��20(�6t   $��-149,20,180,5q�6�   ��5#      �� 5$      .R�5%      ��  �� Orientation$ 
Horizontal=�6%   .+�5&      �  5'   "   �� 5(   &   $��1* �67   6D   �� 5)   &   $��2* �67   6D   �� 5*   &   $��1* �67   6D   �� 5+   &   $��1* �67   6D   .+�5-   "   �� $	��128��6(   $	��128��65   $��0��6A   $��10q�6�   ��6Q   �� *ItemImagePath+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5/   "   $��1��6-   $ Vertical=�6=   .+�50   &   �� 	 �� TextAlignment$	 Center=�60   $��Name : ��6G   $��	50,40,0,5q�6V   6k   �� 51   &   $	 Center=�60   $��Price : ��6G   $��	50,40,0,5q�6W   6l   54   #   �� 56   "   $��2��6-   $ Vertical=�6=   .+�57   &   �� $	 Center=�60   $��	50,40,0,0q�6�   ��6G   �� *
ItemName+$ PropertyChanged=�6�   �� 58   &   $	 Center=�60   $��	50,46,0,0q�6�   ��6G   �� *	ItemPrice+$ PropertyChanged=�6�   �� 59   &   62   �� 5:   &   62   5;   #   5<      5=      5?      5A      5B      �� 5I   
   $��3��6   .+�5K      �� -   5        $��AddImage��5K      $��85��6$   $��85��6/   $	��Top=�6;   $��10,35,10,30q�6S   $ Add Product��6h   $
 Hand��6~   ��5L      �� 5M      
 �� 
TargetType"
 ��6   .�5N      ��  �� Property � �� �� Value$ 
addbos.jpg��63   6H    �� Triggers 5O      P� 5P       P� Property �@J�IsMouseOver P� Value . . �5Q   "   ��  � ��$ adddolu.jpg��6;   6Q   5R      5T      5V      �� 5X      -   5        $��	EditImage��5X      $��85��6%   $��85��60   $��Uniform=�6<   $��Center=�6N   $��10,35,10,30q�6i   $ Edit Product��6~   $
 Hand��6�   ��5Y      �� 5Z      "
 ��6   .�5[      ��  � ��$ editbos.png��63   6I    5\      P� 5]       �@J�IsMouseOver . . �5^   "   ��  � ��$ editdolu.jpeg��6;   6S   5_      5a      5c      �� 5e      -   5        $��RemoveImage��5e      $��85��6'   $��85��62   $	��Top=�6>   $��10,35,10,30q�6V   $ Remove Product��6k   $
 Hand��6�   ��5f      �� 5g      "
 ��6   .�5h      ��  � ��$ removebos.png��63   6K    5i      P� 5j       �@J�IsMouseOver . . �5k   "   ��  � ��$ removedolu.png��6;   6T   5l      5n      5p      �� 5t      -   5        $��RemoveAllButton��5t      $��2��6-   $	��120��6=   $��85��6I   $��20(�6U   $��10,35,10,30q�6c   $ 
Remove All��6x   $
 Hand��6�   ���#ef2131$��
Remove All��6�   5u      5w      5{      5~      