   M S B A M L   `   `   `  ����F  BOkurleigaHF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OkurleigaHFOkurleigaHF  5           OkurleigaHF.PropertyWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:OkurleigaHF     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          � Title$  
Húsnæði��5	      $��859.726��5
      $��427.999��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      � .+�5   
   �� -   5         ��Name$ 
BtnNewProp��5      $	��244��5      $��45��5      $��	33,53,0,0q�5      $��Nýskrá leiguhúsnæði��5         
BtnButtons#��[  5      �� 5   
   -   5        $ BtnNewIncident��5      $	��244��5      $��45��5      $��
286,53,0,0q�5      
�������$��Atvikaskráning��5!      
���   �#��[  5#      &   System.Windows.Controls.DataGrid  5$   
   $	��244��5%      $��33,121,33.667,0q�5&      $	��Top=�5'         AutoGenerateColumns .     CanUserAddRows .  ��5*      ��    Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Heimilisfang��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 	 �� Path$	 Address�6F     5-      $ Póstnúmer��6F    6%   �� $	 ZipCode�6F     5.      $ Stærð��6K    6%   �� $	 PropertySize�6K     5/      $ Svefnherbergi��6G    6%   �� $	 Bedrooms�6G     50      $ Mánaðarleg greiðsla��6G    6%   �� $	 RentCost�6G     51      $ Á skrá��6R    6%   �� $	 IsAvailableToString�6R   4  .System.Windows.Controls.DataGridTemplateColumn  52       53      �� 54      $��Center=�6$   $��
Aðgerðir��6A   
   CellTemplate
 56      �� 57      .R�58      ��  �� Orientation$ 
Horizontal=�6)   .+�59   "   �� $ BtnEdit��5:   %   -   5        
������ $��0q�5=   %   ���	#FF0B13AD��5;   %   0  *MaterialDesignThemes.Wpf.PackIconExtension  *EditOutline+5?   %   �� 5@   "   $ 	BtnDelete��5A   %   -   5        
������ $��0q�5D   %   ���	#FFFF1313��5B   %     *TrashCanOutline+5F   %   5G      5H      5J      5M      5P      5Q      