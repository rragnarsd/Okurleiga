   M S B A M L   `   `   `  ����F  BOkurleigaHF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:OkurleigaHF.WindowsOkurleigaHF.Windows  5      (    "OkurleigaHF.Windows.IncidentWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:OkurleigaHF.Windows     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Title$  Atvikaskráning��5	      $	��808��5
      $��427.999��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      � .+�5   
   �� -   5         ��Name$ BtnNewIncident��5         
BtnButtons#��[  5      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��65   $	��244��5      $��45��5      $��	33,53,0,0q�5      $��Skrá nýtt atvik��5      &   System.Windows.Controls.DataGrid  5   
   $	��736��5      $	��244��5      $��
33,121,0,0q�5      $
��Left=�5      $	��Top=�5         AutoGenerateColumns .     CanUserAddRows .  ��5       ��    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Titill��6D   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� 
 �� Path$
 Title�6D     5#      $ Íbúð��6O   	 6%   �� $
 Property.Address�6O     5$      $ 
Mikilvægi��6G   	 6%   �� $
 Priority�6G     5%      $ Staða��6O   	 6%   �� $
 IsActiveToString�6O   4  .System.Windows.Controls.DataGridTemplateColumn  5&       5'      �� 5(      $��Center=�6$   $��
Aðgerðir��6A      CellTemplate 5*      �� 5+      .R�5,      ��  �� Orientation$ 
Horizontal=�6)   .+�5-   "   �� $ BtnEditIncident��5.   %   -   5        
������ $��0q�51   %   ���	#FF0B13AD��5/   %   0  *MaterialDesignThemes.Wpf.PackIconExtension  *EditOutline+53   %   �� 54   "   $ BtnDeleteIncident��55   %   -   5        
������ $��0q�58   %   ���	#FFFF1313��56   %     *TrashCanOutline+5:   %   5;      5<      5>      5@      5A      5B      