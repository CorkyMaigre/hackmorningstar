   M S B A M L   `   `   `  ����J  Fhackmorningstar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:hackmorningstarhackmorningstar  5   	   E'clr-namespace:hackmorningstar.ViewModelhackmorningstar.ViewModel  5	   	   ;"clr-namespace:hackmorningstar.Viewhackmorningstar.View  5
   	   %    hackmorningstar.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:hackmorningstar     5   	   6vm'clr-namespace:hackmorningstar.ViewModel     5	   	   1vw"clr-namespace:hackmorningstar.View     5
   	   -   5          �Name$
  this��5   	    � Icon$, &/hackmorningstar;component/Favicon.ico��5   	    � Title$ 
MainWindow��5   	   $	��115��6   $	��275��6)    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    +� FocusedElement 5   	   ��  �� ElementName$ 	tickerBox�� � 	Resources 5       �� DataType3  -hackmorningstar.ViewModel.MainWindowViewModel��%-   (��       5      *, +)�� 6
   "  6   5      .��5      � ���	#FF1A1717 5   
   	 �� 
TargetType
 �� Property �� Value��%W  'o�       '�� H     '�� �     '�� g    �� 5      "	 o�6   .�5      �� 
 � ��$ 20��6+   5      �� 5      "	 ��6   .�5      �� 
 � ��
 �����6/   �� 5      
 � ��$ Consolas)�6/   �� 5      
 � ��$ Center=�66   5      �� 5      "	 ��6   .�5      �� 
 � ��$ Consolas)�6/   �� 5       
 � ��$
 Left=�68   �� 5!      
 � ��$	 Top=�66   �� 5"      
 �@��TextAlignment$
 Left=�62   �� 5#      
 � ��$	 300��6*   �� 5$      
 � ��$ 18��6+   �� 5%      %
 �@��HorizontalScrollBarVisibility$
 Auto=�6B   �� 5&      
 � ��$ 0,2,0,0q�6+   5'      �� 5(      "	 ��6   .�5)      �� 
 � �� �	#FF1A17176/   �� 5*      
 � ��$ Arial)�6/   �� 5+      
 � ��$ Stretch=�68   �� 5,      
 � ��$ Center=�66   5-      5.       � RowDefinitions 5/   
   �� 50      �� 51      �� 52      �� 53       � ColumnDefinitions 55   
   �� 56      �� 57      �� 58      �� 59      �� 5:      �� 5;      �� 5<      �� 5=      �� 5>      �� 5?      �� 5@      �� 5A      �� 5B      �� 5C      �� 5D      �� 5E      .+�5H   
   o� -   5        $��mainMenu��5H   A   $��0��6   $��0��6   $��16��6,   .@�5I      m� $��_File��6    m� Command 6&   �� *OpenCommand+5J      �� 5L   
   -   5         ��Name$ filePath��5L   R   $��1��6   $��0��6   $��3��6-   $��3��6A   $��Ticker��6d   �� 5M   
   -   5         ��Name$ 	tickerBox��5M   C   $��2��6   $��4��6   $��7��6/   ��6V   �� *Ticker+�� 5O   
   -   5         ��Name$ searchButton��5O   C   $��2��6   $��12��6   $��3��6/   $��Search��6Y   ��6j   �� *SearchCommand+5Q      5R      