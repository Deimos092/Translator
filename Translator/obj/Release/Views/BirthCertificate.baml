   M S B A M L   `   `   `  ���� E  ATranslator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Translator.ViewsTranslator.Views  ,    &Translator.Views.Page_BirthCertificate   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  *localclr-namespace:Translator.Views     MaterialDesignPaper  N� 
Background#  �     MaterialDesignBody#���   N� Title$ BirthCertificate��.���  � RowDefinitions �� $��50���� $��50���� $��50���� $��50���� $��50�� � ColumnDefinitions �� �� �� �� �� .+��� -    ��Name$ Name1��$��0��$��0�� % !MaterialDesignFloatingHintTextBox#��[ $��20 10q�$	��220��.��)  #MaterialDesignThemes.Wpf.HintAssist   Hint ��  �� Orientation$ 
Horizontal=�$��-2 0 0 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ 
HumanChild=��� Имя Ребенка.��(  "System.Windows.Controls.DatePicker  -     Name$ Name1_DateBirth��$��0��$��1�� ( $MaterialDesignFloatingHintDatePicker#��[ $��20 10q�$	��220�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ 	DateRange=��� Дата рождения�� -   $ Name1_PlaceBirth��$��0��$��2��$��Center=�#��[ $��20 10q�$	��220��.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ MapMarkerRadius=��� Место рождения.���� -   $ Name2��$��1��$��0��#��[ $��20 10q�$	��220��	   
Foreground
	 �����.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ 	HumanMale=��� (&Имя Первого родителя.���� -   $ Name2_Field1��$��1��$��1��#��[ $��20 10q�$	��220��
	 �����.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ AccountQuestionMark=��� Национальность.���� -   $ Name2_Field2��$��1��$��2��#��[ $��20 10q�$	��220��
	 �����.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ Passport=��� Гражданство.���� -   $ Name3��$��2��$��0��#��[ $��20 10q�$	��220��.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ 	HumanMale=��� (&Имя Второго родителя.���� -   $ Name3_Field1��$��2��$��1��#��[ $��20 10q�$	��220��.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ AccountQuestionMark=��� Национальность.���� -	   $ Name3_Field2��$��2��$��2��#��[ $��20 10q�$	��220��.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ Passport=��� Гражданство.���� -
   $ BC_ActNumber��$��3��$��0��#��[ $��20 10q�$	��220��
	 �����.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ Numeric=��� Номер акта.��  -   $ 
BC_ActDate��$��3��$��1��#��[ $��20 10q�$	��220��
	 ����� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ 	DateRange=��� Дата Акта  -   $ BC_DateIssue��$��3��$��2��#��[ $��20 10q�$	��220��
	 ����� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ 	DateRange=��� Дата выдачи�� -   $ BC_PlaceReg��$��4��$��0��#��[ $��20 10q�$	��220��.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ HouseMapMarker=��� %#Место регистрации 1.���� -   $ BC_PlaceReg_2��$��4��$��1��#��[ $��20 10q�$	��220��.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ HouseMapMarker=��� %#Место регистрации 2.���� -   $ BC_Registrator��$��4��$��2��#��[ $��20 10q�$	��220��.�� �� $ 
Horizontal=�$��-2 0 0 0q�.+�  $ RegisteredTrademark=��� Регистратор.��