   M S B A M L   `   `   `  ���� E  ATranslator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Translator
Translator      Translator.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $localclr-namespace:Translator     MaterialDesignPaper#���     MaterialDesignBody#���  $	��450��$	��800��  � Title$  Word Template Translater��$	��450��$	��800�� � WindowStyle$ SingleBorderWindow=� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $��50 ��� $��* ��� $��50 �.+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryDark=�$��Center=�$��50��   CornerRadius$ 10��$��0��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�.���� $��0�� �� Orientation$ 
Horizontal=�$��Center=�.+�  $
 Dark=�$ 5��$��8 4 0 4q�$ Depth1=�.���� -    ��Name$ Btn_OpenFolder��$��0��  MaterialDesignFlatButton#��[ 	 � ToolTip$%	 Загрузить шаблон������ *OpenCommand+.��� .+��� $��Открыть��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Download=�$��20��$��20��  $
 Dark=�$ Depth1=�$	��250��$
��20 5q�$ 10��.���� $��0��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Список шаблонов��   
Foreground
 � E��.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 � E��$
��10 0q�$��10 7.5q� �� 
IsEditable .     HintOpacity$	 .42Q����� *MyTemplates+ �� SelectedItem �� *SelectTemplate+ �� Mode$ TwoWay=����� .R��� ����  �� Path$
 Name�  $
 Dark=�$ 5��$��8 4 0 4q�$ Depth1=�.���� -   $ Btn_LoadTemplate��$��0��#��[ $%	 Загрузить шаблон������ *OpenDocument+.��� .+��� $��Загрузить��  $
 Download=�$��20��$��20��  $ Standard=�$ 10��$��Right=�$��8 4 0 4q�$��0��$ Depth1=�.���� $ 
Horizontal=�$��Stretch=�$��RightToLeft=�.+��� -   $ Btn_Exit��#��[ $	 Закрыть��$��Right=�$
��Auto��$��1��.��  $
 Power=�
��� E��$
��Auto��$��35��$��Center=��� -   $ 	Btn_About��#��[ $0	 *Информация о программе��$
��Auto��$��1��.��  $
 About=�$
��Auto��$��35��$��Center=��� -   $ 	Btn_Print��#��[ $	 Печать��$
��Auto��$��1��.��  $
 Printer=�$
��Auto��$��35��$��Center=�  $ Standard=�$��1��$��Stretch=�$��Stretch=�.�� � -   $��	MainFrame��  � Source$ BirthCertificate.xaml?�  $ Standard=�$ 10��$��Right=�$��8 4 0 4q�$��2��$ Depth3=�.���� $ 
Horizontal=�$��Stretch=�$��LeftToRight=�.+��� -    ��Name$ tb_Path��$	��150��$	��450��$
��10 0q�$( "Путь до схоранения������ *PathTemplate+.���� -   $ btn_GetPath��$
��10 0q�.��Указать путь�� -	   $ Btn_Translate��#��[ $#	 Перевести текст��$
��Auto��$��1��.��  $
 	Translate=�$
��Auto��
���k���$��35��$��Center=��� -
   $ Btn_Save��#��[ $	 Печать��$
��Auto��$��1��.��  $
 ContentSave=�$
��Auto��$��35��$��Center=�