   M S B A M L   `   `   `  ����E  AQuanLySach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QuanLySach
QuanLySach  5   	       QuanLySach.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:QuanLySach     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   6*   �� 5      $��6* �6   6*   �� 5      $��1* �6   6*   .+�5   
   �� $��Center=�6   $��0��61   $��30(�6>   
����  �$��0,10,0,0q�6^   �� 6r   .�6w   Quản Lý Danh Mục6�   6�   � 5   
   $��1��6    5      �� 5      $��1* �6    6.   �� 5      $��9* �6    6.   .+�5      � $��0��6   $��Right=�6     � ColumnDefinitions 5      �� 5      $��2* �6'   64   �� 5      $��2* �6'   64   �� 5      $��2* �6'   64   .+�5      �� $��0��6   $��-252,0,156,0q�6,   $��15(�6B   	Loai Sach6\   �� 5      -   5         ��Name$ cbbLoaiSach��5       �� DisplayMemberPath$ tenloai��60    �� SelectedValuePath$ 
MAloaisach��6L   $��-174,0,95,0q�6k   6�   �� 5      $��
-79,0,10,0q�6   .��6/   
Tim Kiem69   5      � 5      $��1��6   .+�5       &   System.Windows.Controls.DataGrid  -   5        $��datagridSach��5       $��Center=�6/   $	��243��6L   $��Center=�6Y      
IsReadOnly .    AutoGenerateColumns .     SelectionMode$ Single=�6�   $	��800��6�   	   Columns	 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      -   5        	colMaSach��,  &System.Windows.Controls.DataGridColumn
   Header$
 Ma Sach��5"   [      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *MaSach+6z     5#      -   5        
colTenSach��$
 Ten Sach��5#   ]   $	 120 6o    6A   �� *	TenSach+6}     5$      -   5        
colGiaSach��$
 Gia Sach��5$   \   $	 120 6n    6A   �� *DonGia+6|     5%      -   5        colLoaiSach��$
 	Loai Sach��5%   a   $	 120 6t    6B   �� *
MAloaisach+6�     5&      -   5        colSoLuongSach��$
 So Luong Sach��5&   a   $	 120 6x    6E   �� *	SoLuong+6�   4  .System.Windows.Controls.DataGridTemplateColumn  5'      $	
 Sua��61   $ 50 6>      CellTemplate 5(      �� 5)   "   .R�5*   &   �� .��6/   Sua64   5+   #   5-        5.      $	
 Xoa��61   $ 50 6>    5/      �� 50   "   .R�51   &   �� .��6.   Xoa63   52   #   54      56      57      59      �� 5:   
   $��2��6    �� Orientation$ 
Horizontal=�6"   .+�5;      � .+�5<      �� -   5        $��70,0,-149,21q�5<      $��80��6;   $��30��6F   .��6R   Them6X   �� 5=      -	   5        $��237,0,-320,21q�5=      $��80��60   $��30��6;   .��6Z   Sua6_   �� 5>      $��453,2,-520,22q�6   $��80��60   $��30��6;   .��6G   Xoa6L   �� 5?      -
   5        $��647,2,-709,22q�5?      $��80��60   $��30��6;   .��6W   Thoat6^   5@      5A      5B      5C      