   M S B A M L   `   `   `  ����F  BOkurleigaHF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:OkurleigaHF.ModelsOkurleigaHF.Models  5      9!clr-namespace:OkurleigaHF.WindowsOkurleigaHF.Windows  5      )    #OkurleigaHF.Windows.NewTenantWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      3Models clr-namespace:OkurleigaHF.Models     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:OkurleigaHF.Windows     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      -   5          � Title$  Nýskrá leigjanda��5
      $��443.666��5      $��478.333��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       +� FocusedElement 5      ��  �� ElementName$ TxtName�� � 	Resources 5      -   'OkurleigaHF.Models.ZeroToEmptyConverter   ZeroToEmptyConverterG  AMaterialDesignThemes.Wpf.Converters.NullableToVisibilityConverter ! NullableToVisibilityConverter��%:   &	        &	        5   
   6&     5   
   67   5      .��5      � .+�5   
   �� $	��185��5      $��48��5      $��0,57,130,345q�5      $��Right=�5      $��Center=�5      $��22(�5      $
��bold"�5      $��Nýskrá leigjanda��5      $
��Wrap=�5       '  !MaterialDesignThemes.Wpf.PackIcon  5!   
   $��25��5"      $��25��5#      $��
32,128,0,0q�5$         Kind$ Person=�5%        5&   
   $��25��5'      $��25��5(      $��
32,174,0,0q�5)      $ 
LocalPhone=�5*        5+   
   $��25��5,      $��25��5-      $��
32,218,0,0q�5.      $ EmailOutline=�5/      �� 50   
   $	��328��51      $��66,109,0,143.667q�52      $
��left=�53       �� Orientation$ Vertical=�54      .+�55      �� -   5         ��Name$ TxtName��56      $��46��57      $��Center=�58      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$
	 Nafn��59       % !MaterialDesignFloatingHintTextBox#��[ 5:      ��5;      �� *
FullName+�� 5<      -   5        $ TxtPhoneNumber��5=      $��46��5>      $��Center=�5?      $	 Símanúmer��5@      
 �� SelectionOpacity$
 3Q�5A      #��[ 5B      ��5C      �� *Phone+ �� 	Converter# [  .��6Y   5D      �� 5E      -   5        $ TxtEmail��5F      $��46��5G      $��Center=�5H      $	 Netfang��5I      #��[ 5J      ��5K      �� *Email+�� 5L      -   5         ��Name$ cbPropertyAddress��5M      $��45��5N      $	 Íbúð til útláns��5O       �� DisplayMemberPath$ Address��5P      ��5Q      �� *.+5R        5S   
   $��25��5T      $��25��5U      $��
32,262,0,0q�5V      $ House=�5W      �� 5X   
   -   5         ��Name$ btnBack��5Y        
BtnButtons#��[ 5X      $	��110��5Z      $��35��5[      $��156,318,0,0q�5\      $��Til baka��5^      
�������
���   �5_       �� 5`   
   -   5        $ btnSave��5a      #��[ 5`      $	��110��5b      $��35��5c      $��286,318,0,0q�5d      $��Vista��5f      5g      5h      