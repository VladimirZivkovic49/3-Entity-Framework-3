   M S B A M L   `   `   `  ����G  CMovieCatSQL1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MovieCatSQL1MovieCatSQL1  5   	       MovieCatSQL1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MovieCatSQL1     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��75* �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��5      $��1��5      .+�5      �� $	��230��5      $��20��5      $��5q�5      �� 5      $��75��5      $��20��5      $��5q�5      $��Search��5       5!      5#      &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ dataGrid��5&      $��1��5'      $��1��5(         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 122 5)      ��5*      �� *Movies+51      �� 52   
   $ 
Horizontal=�53      $��Right=�54      $��2��55      $��1��56      .+�57      �� -   5        $��Adding��59      $	��Add��58      $��75��5:      $��20��5;      $��5q�5<      5?      �� 5A      -   5        $��Editing��5C      $
��Edit��5B      $��75��5D      $��20��5E      $��5q�5F      5I      �� 5K      -   5        $��Deliting��5M      $��Delite��5L      $��75��5N      $��20��5O      $��5q�5P      5S      5U      �� 5V   
   $ 
Horizontal=�6   $
��Left=�5W      $��3��5X      $��1��5Y      .+�5[      �� -   5         ��Name$
 Save��5[      $
��Save��5\      $��75��5]      $��20��5^      $��5q�5_      5a      5c      �� 5e   
   $ 
Horizontal=�5f      $��Right=�5g      $��3��5h      $��1��5i      .+�5k      �� -   5        $��Exiting��5m      $
��Exit��5l      $��75��5n      $��20��5o      $��5q�5p      5r      5t      5v      5w      