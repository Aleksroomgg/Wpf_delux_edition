   M S B A M L   `   `   `  ����G  CApp_Practice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:App_Practice.WindowsApp_Practice.Windows  5   	   +    %App_Practice.Windows.Practice14Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:App_Practice.Windows     5   	   -   5          � Title$1  +Практическая работа №14��5   	   $	��450��6)   $	��800��66    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� -   5         ��Name$ TaskSelector��5      $	��190��6-   $��0,0,10,0q�69   �� 5      -   5         ��Name$ SolveButton��5      $��Решить��6*   $	��100��6;   6G   5      �� 5   
   -   5         ��Name$ 	ResultBox��5      $��1��6%   $��10q�62    �� 
IsReadOnly . " �� VerticalScrollBarVisibility$
 Auto=�5   $   	 �� TextWrapping$
	 Wrap=�5      $��Consolas)�6&   $��14(�6<   �� 5   
   -   5        $��2��5      $3��-Вернуться к выбору работ��6   $��10q�5      $��5q�6   6)   5      5      