   M S B A M L   `   `   `  ���� C  ?WpfGraph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfGraphWpfGraph      WpfGraph.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     R NOxyPlot.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  #local1clr-namespace:WpfGraph    � Title$  Таблица��$	��600��$	��700��$��16(� � WindowStyle$ ThreeDBorderWindow=�$	��620��$	��720��.���  � ColumnDefinitions �� $
��153* ��� $
��227* � � RowDefinitions �� �� �� .+��� $��0��$��0��
��� ���.+��� -    ��Name$ label3��$@��:Введите имя заголовка точек по X��$��Center=�$
��Left=�$��15(�$
��Bold"��� -    ��Name$ textHeaderX��$��33�� �� TextWrapping$
 Wrap=�$��8,0,49,0q��� -   $ label4��$@��:Введите имя заголовка точек по Y��$��Center=�$
��Left=�$��15(�$
��Bold"��� -   $ textHeaderY��$��35��$
 Wrap=�$��7,0,49,0q��� $��0��$��1��$��2��
��� ���.+��� -   $ label��$'��!Кнопки управления��$��Center=�$��Center=�$��21(�$
��Bold"��� -    ��Name$ BtnPath��$��Путь к файлу��$��16(�$��Center=�$��Bottom=�$��40��$	��150��$��	0,18,0,10q��� -   $ BtnGraph��$%��Настроить график��$��16(�$��Center=�$��Bottom=�$��40��$	��160��$��0,10,0,0q��� -   $ label5��$<��6Разделитель элементов списка��$��Center=�$��Center=�$��16(�$
��Bold"�$��0,30,0,0q��� -	   $��delimeterList��$��30��$	��200�� �� SelectedIndex$ 1��$��Center=�$��Center=�$��0,8,0,0q�
�������.@��� -
   	 ��Name$	 	semicolon��;�� -   $	 comma��,�� -   $ label2��$��1��$��0��$,��&      Данные из таблицы��$	��Top=�$��Center=�$��22(�$
��Bold"�$��48��$��	90,0,78,0q�$	��286���� -   
 ��Name$
 ListViewPeople��$��1��$��3��
�������$��0,56,0,0q� �� View �� -   	gridView1��.P��� -   NumberPoint��$��№ точки�� �� Width$	 130�� �� DisplayMemberBinding ��  �� Path$ numberPoint��� -   ElementX��$��Vector X��$	 130�� �� $ vectorX2��� -   ElementY��$��Vector Y��$	 146�� �� $ vectorY2�