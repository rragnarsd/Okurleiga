   M S B A M L   `   `   `  ����F  BOkurleigaHF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:OkurleigaHF.DesignOkurleigaHF.Design  5   	   '    !OkurleigaHF.Design.NewLoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ,local clr-namespace:OkurleigaHF.Design  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStyle$
 None=�5   	   $	��500��5   	   $	��350��6    +� FocusedElement 5   	   ��  �� ElementName$ TxtEmail��.��5      � $��0,-1,0,1q�6   .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF1B5481��6#   � 5      $ 	#FF709AB0��6#    � Offset$ 1Q�65   � 5      $ 	#FF3277A3��6#   $	 0.5Q�65   5      5      '  !MaterialDesignThemes.Wpf.PackIcon  5   
   	   Kind$	 House=�6"   $��
125,20,0,0q�6/   $	��100��6C   $	��100��6P   $	��top=�6\   ���	#FF5B9EC86t   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��35,0,35,100q�6U   
 �� RadiusY$

 7.58��6j    �� RadiusX$
 7.58��6y    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFA4A4A4��6#      	Direction$ 0Q�65      
BlurRadius$ 10Q�6C      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5      � 5   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0,100q�6C   .+�5      �� $��Okurleiga.hf��6   $��Center=�6,   $	��Top=�6I   $��5q�6a   
�������$��18(�6~   �� 5       $��Center=�6   $��10q�64   .+�5!      �� -   5         ��Name$ TxtEmail��5!      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Netfang��6,    %  !MaterialDesignFloatingHintTextBox#��[  6U   $
��0,10q�6�   $��16(�6�   G� 5"      -   5         G�Name$ 
PwPassword��5"      $ 	Lykilorð��62    ) %MaterialDesignFloatingHintPasswordBox#��[ 6\   $
��0,10q�6�   $��16(�6�   5#      5$      �� 5%   
   -   5         ��Name$ 	BtnSignIn��5&        
BtnButtons#��[ 5%      $��Bottom=�5'      $��	90,0,0,77q�5(      $	��170��5)      $��Innskráning��6    �� 	IsDefault . $��43��5+      5-      5.      