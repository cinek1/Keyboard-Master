   M S B A M L   `   `   `  ����K  GKeyboardChampion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:KeyboardChampion.ControlsKeyboardChampion.Controls  5      ,    &KeyboardChampion.Controls.ScreenToText   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:KeyboardChampion.Controls     5      (modelKeyboardChampion.Model     5      -   5        .��5      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
�������6!   �� 5   
   $��1��6   
�������6!   �� 5   
   $��2��6   
�������6!   �� 5   
   $��3��6   
�������6!   �� 5   
   $��4��6   
�������6!   �� 5   
   $��5��6   
�������6!   (� 5   
   $
��Left=�6   $��0��6/   $��Center=�6<   .��5      �� -   5         ��Name$ LineOneText��5      
�������$��0��6E   $��consolas)�6�   ��6V   �� *	FirstLine+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5      (� 5   
   -   5         (�Name$ 	LineOneIn��5      $
��Left=�6&   $��1��6A   $��Center=�6N   .��5       �� 
�������$��consolas)�6s   ��6,   �� *FirstLineFromKey+$ PropertyChanged=�6�   5!      (� 5"   
   $
��Left=�6   $��2��6-   $��Center=�6:   .��5#      �� $��14(�6   ��6&   �� *
SecondLine+$ PropertyChanged=�6i   5$      (� 5%   
   -   5        $ 	LineTwoIn��5%      $
��Left=�6%   $��3��6@   $��Center=�6M   .��5&      �� 
���������6+   �� *SecondLineFromKey+$ PropertyChanged=�6u   5'      (� 5(   
   $
��Left=�6   $��4��6-   $��Center=�6:   .��5)      �� 
���������6/   �� *	ThirdLine+$ PropertyChanged=�6q   5*      (� 5+   
   $
��Left=�6   $��5��6.   $��Center=�6;   .��5,      �� -   5        $ LineThirdIn��5,      
���������6A   �� *ThirdLineFromKey+$ PropertyChanged=�6�   5-      5.      50      