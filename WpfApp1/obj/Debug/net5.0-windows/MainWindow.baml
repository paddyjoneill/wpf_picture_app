   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   7
viewModels clr-namespace:WpfApp1.ViewModels     5   	     � Title$!  Paddy's Picture Loading App��5	   	   $	��496��6-   $	��960��6:    � DataContext 5
      '   !WpfApp1.ViewModels.ImageViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��28 �6   �� 5      $��* �6   �� 5      $��28 �6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6"   $��2q�6/   ��6:   �� *CurrentImage.FilePath+6c   �� 5   
   $��1��6   $��1��6    $��2��6-   $��2q�6>   $
��Auto��6r   $
��Auto��6   ��6I   �� *CurrentImage.BmpImage+6   �� 5   
   -   5        $��0��5      $��0��6!   $��	Add Image��6.   $��2q�6B   6M   �� 5   
   -   5        $��ImagesListView��5      $��0��5       $��1��6   $��2q�6*   ��5!      �� *Images+��5%      �� 5&      .R�5'      � .+�5(      �� $��48��6    ��6,   �� *
BmpImage+�� 5)      $	��200��6$   $
��Wrap=�60   ��6D   �� *
FilePath+5*      5+      5-      �� 5/   
   -   5        $��2��5/      $��0��6   $��2q�6.   $��Remove Selected Image��69   6Y   51      52      