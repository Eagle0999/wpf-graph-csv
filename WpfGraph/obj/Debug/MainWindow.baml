   M S B A M L   `   `   `  ����C  ?WpfGraph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfGraphWpfGraph  5   	       WpfGraph.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   R NOxyPlot.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	   #local1clr-namespace:WpfGraph  5   	     � Title$  Таблица��5   	   $	��600��6   $	��700��6)   $��16(�68    � WindowStyle$ ThreeDBorderWindow=�6F   $	��620��6g   $	��720��6w   .��5      �  � ColumnDefinitions 5   
   �� 5	      $	��35* �6   �� 5
      $
��117* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ BtnPath��5      $��0��67   $��Путь к файлу��6H   $��16(�6_   $
��Left=�6m   $��Center=�6�   $��28��6�   $	��102��6�   $��
10,70,0,70q�6�   �� 5   
   -   5        $ BtnGraph��5      $��1��6:   $%��Построить график��6H   $��16(�6c   $
��Left=�6q   $��Center=�6�   $��28��6�   $	��140��6�   $��
10,70,0,70q�6�   �� 5   
   -   5         ��Name$ ListViewPeople��5   5   $��1��6   $��3��6$    �� View 5      �� 5      .P�5      �� -   5        ElementX��$��Vector X��5   7    �� Width$	 250��6I    �� DisplayMemberBinding 6V   �� 	 �� Path$	 VectorX��� 5      -   5        ElementY��$��Vector Y��5   7   $	 300��6I    6V   �� $	 VectorY�5      5      5      5       