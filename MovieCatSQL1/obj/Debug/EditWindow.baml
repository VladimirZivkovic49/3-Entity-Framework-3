   M S B A M L   `   `   `  ����G  CMovieCatSQL1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MovieCatSQL1MovieCatSQL1  5   	       MovieCatSQL1.EditWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MovieCatSQL1     5   	     � Title$  
EditWindow��5   	   $	��300��6   $	��300��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Right=�5      $��Center=�5   	   $��1 ��5      .+�5      �� $��Name:��6   $��5q�5      $
��Left=�5   
   $��Center=�5   	   5      �� 5       -   5        $��EddName��5&      $��5q�5!      $	��180��5#   
   $��Right=�5$      .��5&       5)      5+      �� 5,   
   $ 
Horizontal=�6   $��Right=�5-      $��Center=�5.   	   $��2 ��5/      .+�51      �� $��Genere:��6   $��5q�52      $
��Left=�53   
   $��Center=�54   	   55      �� 56      -   5        $��	EddGenere��5>      $��5q�57      $	��180��59   
    �� 
IsEditable . $��Right=�5<      $��Center=�5=   	   .@�5?      �� $��Drama��6   �� 5@      $��Ratni��6   �� 5A      $��Komedija��6   �� 5B      $��Dečji��6   �� 5C      $�� ��6   5D      5F      �� 5G   
   $ 
Horizontal=�6   $��Right=�5H      $��Center=�5I   	   $��3 ��5L      $��0,10,0,7q�6   .+�5N      �� $��	Director:��6   $��5q�5O      $
��Left=�5P   
   $��Center=�5Q   	   5R      �� 5S      -   5        $��EddDirector��5Y      $��5q�5T      $	��183��5V   
   $��Right=�5W      $��22��5Y       .��61   5[      5]      �� 5^   
   $ 
Horizontal=�6   $��Right=�5_      $��Center=�5`   	   $��4 ��5c      .+�5d      �� $��Release date:��6   $��5q�5e      $��Center=�5f   
   $��Center=�5g   	   5h      (  "System.Windows.Controls.DatePicker  5j      -   5        $��EddRealeseDate��5k      $	��170��5l      $��5q�5m      5o      5s      �� 5t   
   $ 
Horizontal=�6   $��Center=�5u      $��Center=�5v   	   $��5 ��5y      .+�5z      �� -   5        $��OkEdit��5{      $��OK��5z      $	�� 55��5|      $��20��5}      $��10(�5~      
�������$��10q�5�      5�      �� 5�      -   5        $��
CancelEdit��5�      $��Cancel��5�      $	�� 55��5�      $��20��5�      $��10(�5�      
�������$��10q�5�      5�      5�      5�      5�      