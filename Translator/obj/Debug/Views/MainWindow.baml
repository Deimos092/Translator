   M S B A M L   `   `   `  ����E  ATranslator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Translator
Translator  5          Translator.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Translator     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Word Template Translater��5	      $	��800��5
      $	��450��5      $	��800��5      $	��450��5         MaterialDesignPaper#���   5        MaterialDesignBody#���  5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$ ThreeDBorderWindow=�5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��5      $��50��5      $��Center=�5      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5         CornerRadius$ 10��5         Mode$ PrimaryDark=�5       .��5!      �� $��0��5"      $��Center=�5#       �� Orientation$ 
Horizontal=�5$      .+�5%        $��8,4,0,4q�5&      $ Depth1=�5'      $ 5��5(      $
 Dark=�5)      .��5*      �� -   5         ��Name$ Btn_OpenFolder��5+      $��0��5,        MaterialDesignFlatButton#��[ 5.      	 � ToolTip$2	 ,Открыть список шаблонов��5/      ��5-      �� *OpenFolderTemplate+.��50      � .+�51      �� $��Загрузить��6(   '  !MaterialDesignThemes.Wpf.PackIcon  52      $��20��53   !   $��20��54   !   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Download=�55   !   56      57      58        59      $	��250��5:      $
��20,5q�5;      $ Depth1=�5<      $ 10��5=      $
 Dark=�5>      .��5?      �� $��0��5@      $
��10,0q�5A      $��10,7.5q�5B      )  #MaterialDesignThemes.Wpf.HintAssist   
Foreground
 � E��   Hint$# Список шаблонов��5D         HintOpacity$	 .42Q�5E      .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 � E�� �� 
IsEditable .  ��5H      �� *	Templates+ �� SelectedItem 5I      �� *SelectTemplate+ �� Mode$ TwoWay=���5J      �� 5K      .R�5L   "   �� ��6,   ��  �� Path$
 Name�5M      5O      5P      5R      5S        5T   
   $��0��5U      $��8,4,0,4q�5V      $��Right=�5W      $ Depth1=�5X      $ 10��5Y      $ Standard=�5Z      .��5[      �� $��Stretch=�5\      $��RightToLeft=�5]      $ 
Horizontal=�5^      .+�5_      �� -   5        $ Btn_Exit��5`      $��1��5a      $
��Auto��5b      $��Right=�5c      #��[ 5e      $	 Закрыть��5f      .��5g        $��35��5h      $
��Auto��5i      $��Center=�5j      
��� E��$
 Power=�5l      5m      �� 5n      -   5        $ 	Btn_About��5o      $��1��5p      $
��Auto��5q      #��[ 5s      $0	 *Информация о программе��5t      .��5u        $��35��5v      $
��Auto��5w      $��Center=�5x      $
 About=�5y      5z      �� 5{      -   5        $ 	Btn_Print��5|      $��1��5}      $
��Auto��5~      #��[ 5      $	 Печать��5�      .��5�        $��35��5�      $
��Auto��5�      $��Center=�5�      $
 Printer=�5�      5�      5�      5�      �� 5�   
   -   5         ��Name$ contentPresent��5�      $��1��5�      ��5�      �� *UserInterface+  5�   
   $��2��5�      $��8,4,0,4q�5�      $��Right=�5�      $ Depth3=�5�      $ 10��5�      $ Standard=�5�      .��5�      �� $��Stretch=�5�      $��LeftToRight=�5�      $ 
Horizontal=�5�      .+�5�      �� -   5         ��Name$ tb_Path��5�      $	��150��5�      $	��450��5�      $
��10,0q�5�      $( "Путь до схоранения��5�      ��5�      �� *PathTemplate+�� 5�      -   5        $ btn_GetPath��5�      $
��10,0q�6.   .��6<   Указать путь5�      �� 5�      -   5        $ Btn_Translate��5�      $��1��5�      $
��Auto��5�      #��[ 5�      $#	 Перевести текст��5�      ��5�      �� *TranslateCommand+.��5�        $��35��5�      $
��Auto��5�      $��Center=�5�      
���k���$
 	Translate=�5�      5�      �� 5�      -	   5        $ Btn_Save��5�      $��1��5�      $
��Auto��5�      #��[ 5�      $	 Печать��5�      .��5�        $��35��5�      $
��Auto��5�      $��Center=�5�      $
 ContentSave=�5�      5�      5�      5�      5�      5�      