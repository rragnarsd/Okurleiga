   M S B A M L   `   `   `  ����F  BOkurleigaHF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:OkurleigaHF.ModelsOkurleigaHF.Models  5      9!clr-namespace:OkurleigaHF.WindowsOkurleigaHF.Windows  5      +    %OkurleigaHF.Windows.NewIncidentWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      3Models clr-namespace:OkurleigaHF.Models     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:OkurleigaHF.Windows     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      -   5          � Title$  Atvikaskráning��5
      $��443.666��5      $��478.333��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       +� FocusedElement 5      ��  �� ElementName$ TxtTitle��.��5      � .+�5   
   �� $	��138��5      $��0,61,140,344q�5      $��Right=�5      $��Center=�5      $��22(�5      $
��bold"�5      $��Nýskrá atvik��5      $��45��6!   �� 5   
   -   5         ��Name$ TxtTitle��5       %  !MaterialDesignFloatingHintTextBox#��[  5      $��46��5      $��69,102,48,302q�5      $��Center=�5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Titill��5!      ��5"      �� *Title+'  !MaterialDesignThemes.Wpf.PackIcon  5#   
   $��25��5$      $��25��5%      $��
34,118,0,0q�5&         Kind$ FormatTitle=�5'      �� 5)   
   -   5         ��Name$ 
cbProperty��5*      $	��320��5+      $��41��5,      $��69,157,0,252q�5-      $
��Left=�5.      $ 
Húsnæði��5/      	   HintOpacity$		 .26Q�50      
 �� DisplayMemberPath$
 Address��51       �� 
IsEditable . ��53      �� *.+  54   
   $��25��55      $��25��56      $��
34,166,0,0q�57      $ HomeEdit=�58      �� 59   
   -   5        $ TxtDescription��5:      $	��320��5;      $��82��5<      $��
69,215,0,0q�5=      $
��Left=�5>      $	��Top=�5?      $ Description��5@       �� AcceptsReturn .  * &MaterialDesignOutlinedTextFieldTextBox#��[ 5B       �� TextWrapping$
 Wrap=�5D      " �� VerticalScrollBarVisibility$
 Auto=�5E      ��5C      �� *Description+5E        5F   
   $��25��5G      $��25��5H      $��
34,220,0,0q�5I      $ AboutVariant=�5J      �� 5K   
   -   5        $ 
cbPriority��5L      $	��320��5M      $��41��5N      $��69,302,0,107q�5O      $ 
Mikilvægi��5P      $		 .26Q�5Q       . $
��Left=�5S       �� Text 5R      �� *
Priority+.@�5T      �� $��Lágt��6   �� 5U      $��	Miðlungs��6   �� 5V      $��Hátt��6   5W        5X   
   $��25��5Y      $��25��5Z      $��
34,311,0,0q�5[      $ PriorityHigh=�5\      �� 5]   
   -   5         ��Name$ BtnBack��5^        
BtnButtons#��[ 5]      $	��110��5_      $��35��5`      $��155,363,0,0q�5a      $��Til baka��5c      
�������
���   �5d       �� 5e   
   -   5        $ BtnSave��5f      #��[ 5e      $	��110��5g      $��35��5h      $��285,363,0,0q�5i      $��Vista��5k      5l      5m      