   M S B A M L   `   `   `  ����R  NProyecto Bases de Datos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Proyecto_Bases_de_DatosProyecto_Bases_de_Datos  5   	        Proyecto_Bases_de_Datos.BD   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Proyecto_Bases_de_Datos     5   	     � Title$  BD��5   	   $	��450��6   $	��800��6!   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ 	#FF5454FF��6   � 5      $ Black��6   $ 0.991Q�6-   � 5      $ 	#FF3262C7��6   $ 0.041Q�61   5      .+�5   
   �� -   5         ��Name$ 
btn_menuBD��5      $
��Menu��6%   $
��Left=�64   $��710,347,0,0q�6O   $	��Top=�6d   $��59��6|   
�������$��36��6�   6�   �� 5   
   $��26,38,115.6,37q�6   .@�5      �� $��Tablespaces��6   .��5      � ���	#FFE5E5E5.+�5      �� $��Nombre del Tablespace:��6   $
��Left=�6=   $��	28,40,0,0q�6X   $	��Top=�6k   �� 5      -   5         ��Name$ txt_nombretablespace��5      $
��Left=�6<   $��23��6W   $��
221,43,0,0q�6c    �� TextWrapping$
 Wrap=�6w   $�� ��6�   $	��Top=�6�   $	��212��6�   �� 5      -   5         ��Name$ label��5      $��Tamaño del Tablespace:��6+   $
��Left=�6L   $��	28,71,0,0q�6g   $	��Top=�6z   $	��134��6�   �� 5      -   5        $ txt_tamañotablespace��5      $
��Left=�6<   $��23��6W   $��
221,74,0,0q�6c   $
 Wrap=�6w   $�� ��6�   $	��Top=�6�   $	��212��6�   	 J� RenderTransformOrigin$	 
0.49,1.009&�6�   �� 5      -   5        $ button��5      $��Crear Tablespace��6-   $
��Left=�6H   $��
460,43,0,0q�6c   $	��Top=�6w   $��97��6�   $��54��6�   6�   �� 5      $%��Nombre del Tablespace Temporal:��6   $
��Left=�6F   $��
28,131,0,0q�6a   $	��Top=�6u   �� 5      -   5        $ txt_nombretemporal��5      $
��Left=�6:   $��23��6U   $��221,134,0,0q�6a   $
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��212��6�   �� 5      -   5        $ 
label_Copy��5      $&�� Tamaño del Tablespace Temporal:��60   $
��Left=�6Z   $��
28,162,0,0q�6u   $	��Top=�6�   $	��188��6�   �� 5      -   5        $ txt_tamañotemporal��5      $
��Left=�6:   $��23��6U   $��221,166,0,0q�6a   $
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��212��6�   $	 
0.49,1.009&�6�   �� 5      -	   5        $ button_Copy��5      $!��Crear Tablespace
 Temporal��62   $
��Left=�6`   $��460,134,0,0q�6{   $	��Top=�6�   $��97��6�   $��54��6�   6�   �� 5       -
   5        $ lbl_respuesta1��5       $�� ��64   $��Center=�6?   $��	0,243,0,0q�6\   $	��Top=�6o   �� 5!      -   5        $ lbl_respuesta2��5!      $�� ��64   $��Center=�6?   $��	0,278,0,0q�6\   $	��Top=�6o   5"      5#      �� 5$      $��Schema��6   .��5%      � ���	#FFE5E5E56   5&      5'      5)      5*      