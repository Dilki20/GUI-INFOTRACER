   M S B A M L   `   `   `  ����@  <First, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FirstFirst  5   	       First.Shop_Scan_QR   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:First     5   	   b ^MaterialDesignThemes.Wpf, Version=4.2.0.2578, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Shop_Scan_QR��5	   	   $	��750��6   $
��1200��6+    � WindowState$ 	Maximized=�68   .��5
      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ white��6    � Offset$ 1Q�6-   6:   � 5      $ 
WhiteSmoke��6   $ 0Q�62   6?   5      .+�5   
   � $	��Top=�6   $
��Left=�6'   $	��750��6B   $	��250��6O   
����� �.+�5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitionContentSlide��5   2   $��0,0,0,10q�6�   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6R   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�5      �� 5      -   5        	 ��Name$	 ListViewMenu��5      $	��Top=�6Z   $
��0 70q�6r   .@�5      �� -   5        $	��100��5      
���   �.��5      �� $
��20 0q�6!   
 �� Orientation$
 
Horizontal=�6/   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
QrcodeEdit=�62   $��60��6D   $��60��6O   �� 5      $��Scan QR��6$   $��Center=�63   $
��10 0q�6N   $��30(�6\   6l   5      5      5      5       � 5!   
   -   5         �Name$ GridContent��5!   6   $��Bottom=�6   $	��900��6*   $��10q�6K   $	��550��6W   $��Right=�6d   5"      � 5$   
   $	��Top=�6   $��Center=�6'   $
��0 20q�6D   .+�5%      �� $
 
Horizontal=�6   .+�5&      �� $��SCAN QR CODE��6   $��50(�60   $��JOKERMAN)�6>   6V     5'      $ Qrcode=�6*   $��Center=�68   $��60��6S   $��60��6^   $
��15 0q�6j   5(      5)      �� 5*   
   -   5         ��Name$ btnClose��5*       � ToolTip$ Close��6#   $	��Top=�6J   
���   � *  &MaterialDesignFloatingActionMiniButton#��[  6u   $��Right=�6�   $��20 25q�6�   
���  ����6�   Z� .��5+        $ Close=�6&   $��20��63   $��20��6>   5-      5/      50      