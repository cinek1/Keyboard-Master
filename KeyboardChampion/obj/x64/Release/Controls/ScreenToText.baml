   M S B A M L   `   `   `  ���� K  GKeyboardChampion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:KeyboardChampion.ControlsKeyboardChampion.Controls  ,    &KeyboardChampion.Controls.ScreenToText   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9local'clr-namespace:KeyboardChampion.Controls     (modelKeyboardChampion.Model     -   .���   � RowDefinitions  �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��
��������� $��1��
��������� $��2��
��������� $��3��
��������� $��4��
��������� $��5��
�������(� $
��Left=�$��0��$��Center=�.���� -    ��Name$ LineOneText��
�������$��0��$��consolas)����� *	FirstLine+ �� UpdateSourceTrigger$ PropertyChanged=�(� -    (�Name$ 	LineOneIn��$
��Left=�$��1��$��Center=�.���� 
�������$��consolas)����� *FirstLineFromKey+$ PropertyChanged=�(� $
��Left=�$��2��$��Center=�.���� $��14(����� *
SecondLine+$ PropertyChanged=�(� -   $ 	LineTwoIn��$
��Left=�$��3��$��Center=�.���� 
����������� *SecondLineFromKey+$ PropertyChanged=�(� $
��Left=�$��4��$��Center=�.���� 
����������� *	ThirdLine+$ PropertyChanged=�(� $
��Left=�$��5��$��Center=�.���� -   $ LineThirdIn��
����������� *ThirdLineFromKey+$ PropertyChanged=�