   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	       Zadatak_1.View.GuestView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	     � Title$  	GuestView��5   	   $	��450��6   $	��800��6(   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��6 �6   �� 5      $��30 �6   �� 5      $��6 �6   �� 5      $��30 �6   �� 5      $��20 �6   .+�5   
   �� $��1��62   $��Show products��5      $��0,0,611.6,0.4q�6,   $��1��6C   ��5      �� *ShowProducts+5   C   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DataGridMenu��5      $��2��5      $��1��6       
IsReadOnly .    HeadersVisibility$ Column=�5!         AutoGenerateColumns .     HorizontalGridLinesBrush
 �   ���5      �� *ProductList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� *SelectedProduct+$ PropertyChanged=�y�5#      �� *ViewProduct+$ PropertyChanged=�	   Columns	 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Product��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5(   %   �� *ProductName+  5)      $
 Price��6%    5*   %   �� *Price+4  .System.Windows.Controls.DataGridTemplateColumn  5+      $
 Quantity��6)      CellTemplate 5,      �� 5-      .R�5.      �� $��50��50   L   ��5.   &   ��  �� Path$ Order.Quantity� �� RelativeSource �� *FindAncestor+ �� AncestorType"  $ PropertyChanged=�50   L   51      53        54       55      �� 56      .R�57      �� $��80��6%   $��30��58   %   $��Add to order��5;   %   ��59   %   �� $ DataContext.AddToOrder� �� *FindAncestor+"  $ PropertyChanged=�5;   %   5<      5>      5@      �� 5A   
   -   5        $��lblTotalPrice��5C      $��4��5A      $��1��5B      $��Total Price:��5D      $��Center=�5E      $
��Left=�5F      $
��Bold"�5G      $��90��5H      $��323,3.2,0,1.2q�6   �� 5I   
   -   5        $��lblTotal��5J      $��4��5I      $��10,11.2,99.6,3.2q�5L      $��Center=�5M      $��Black"�5N      $��2��6#   ��5K      �� *
TotalPrice+5N   #   �� 5O   
   $��6��6   $��1��6"    �� Orientation$ 
Horizontal=�5P      $��Center=�5Q      .+�5R      �� $��Confirm Order��5S      $	��125��6-   $��
0,6,10,6.4q�69   ��5R      �� *OrderCommand+5S   9   �� 5T      $��Close��5U      $��
0,6,10,6.4q�6%   $	��125��69   ��5T      �� *Close+5U   9   5V      5W      5X      