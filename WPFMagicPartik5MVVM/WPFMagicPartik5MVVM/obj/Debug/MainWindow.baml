   M S B A M L   `   `   `  ����  WPFMagicPartik5MVVM$    WPFMagicPartik5MVVM.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Заметки��5   	   $	��411��6   $	��791��6&    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ MainViewModel.xaml?�6%   %    5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� DisplayMemberPath$
 Name��6[   $��0��6t   ��6   �� *Notes+ �� SelectedIndex 60   �� *CurrentNoteIndex+6t   �� 5   
   $��1��6   $��10q�6"   .+�5      �� $
��Bold"�6;   ��6   �� *SelectedNote.Name+6;   �� 5      $	��0 5q�6B   ��6   �� *SelectedNote.Description+6B   �� 5      $	��0 5q�6Y   ��6   �� *SelectedNote.Date+ �� StringFormat$ Дата: {0:d}��6Y   �� 5      $	��0 5q�6`   ��6   �� *SelectedNote.Deadline+$ Дедлайн: {0:d}��6`   5      5      5      