   M S B A M L   `   `   `  ����F  BFontSamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FontSamples.ViewsFontSamples.Views  5      ?$clr-namespace:FontSamples.ViewModelsFontSamples.ViewModels  5      '    !FontSamples.Views.MainControlView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FontSamples.Views     5      ;
viewModels$clr-namespace:FontSamples.ViewModels     5        � DataContext  5      0  *FontSamples.ViewModels.TextSampleViewModel  5   
   .��5      �� $��10q�6   
�������._�5   
   �  � ColumnDefinitions 5      �� 5      6%    � RowDefinitions 5      �� 5      $��75 �6    6.   �� 5      $	��100 �6    6/   �� 5      $	��100 �6    6/   �� 5      $��* �6    6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��0��6   $��0��6%   $��
Font Size:��65   $��20(�6J   �� 5      -   5        $��FontSizeSelector��5      $��0��63   $��0��6@   $��40��6P   $��25��6[   $	��Top=�6g   $��7q�6   5      �� 5      -   5        $��	CBSamples��5      $��1��6(   $��0��65   $	��480��6E   $��40��6Q   $��20(�6]    �� ItemBindingGroup 6k   ��  �� Path$ 
FontLabels� �� Mode$ TwoWay=��� 5#      -   5        $��
SampleText��5#      $��2��6(   $��0��65   $	��480��6E   $��40��6Q   
�������
���   �$��1q�6�   �� 5(      $��3��6   $��0��6"   $	��480��62   $	��110��6>   
���   �$��1q�6_   ._�5)      �� .��5*      �� -   5        $��TextPreview��5*       $��2��63   $��0��6@   $	��480��6P   $	��130��6\   
�������$��0q�5+       �� Padding$ 10q�6'   $
��Auto=�64   $��Disabled=�6d   ��. 5,      5-      5.      50      51      52      