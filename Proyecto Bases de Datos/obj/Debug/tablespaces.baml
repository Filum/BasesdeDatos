   M S B A M L   `   `   `  ����R  NProyecto Bases de Datos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Proyecto_Bases_de_DatosProyecto_Bases_de_Datos  5   	   )    #Proyecto_Bases_de_Datos.tablespaces   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Proyecto_Bases_de_Datos     5   	     � Title$  Tablespaces��5   	   $	��600��6   $
��1000��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $%��Administración de tablespaces ��6   $��Center=�6H   $��0,20,0,0q�6e   $	��Top=�6w   � 5   
   $
��Left=�6   $	��189��6*   $��0,86,0,0q�67   $	��Top=�6I   $	��310��6a   ���	#FF35CD47.+�5      �� -   5        $ label1��5      $��Crear un tablespace��6$   $��Center=�6B   $��0q�6_   $	��Top=�6j   �� 5      -   5         ��Name$ txb_nombretablespace��5      $��Right=�64   $��23��6P   $��0,50,0,0q�6\    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��167��6�   �� 5      -   5        $ label2��5      $��Nombre del Tablespace :��6$   $
��Left=�6F   $	��Top=�6a   $��	-1,50,0,0q�6y   �� 5      -   5        $ tbx_tamañotablespace��5      $��Right=�64   $��23��6P   $��	0,119,0,0q�6\   $
 Wrap=�6o   $	��Top=�6�   $	��167��6�   �� 5      -   5        $ label3��5      $��Tamaño del Tablespace:��6$   $��	0,116,0,0q�6E   $	��Top=�6X   $
��Left=�6p   $	��138��6�   �� 5      -   5         ��Name$ button1��5      $��Crear Tablespace��6&   $��Center=�6A   $��0,0,0,15q�6^   $��Bottom=�6p   6�   5      � 5   
   $
��Left=�6   $	��189��6*   $��
315,86,0,0q�67   $	��Top=�6K   $	��310��6c   ���	#FF35CD47.+�5      �� -   5        $ label4��5      $"��Crear un Tablespace temporal��6$   $��Center=�6K   $��0q�6h   $	��Top=�6s   �� 5      -	   5        $ tbx_nombretemporal��5      $��Right=�62   $��23��6N   $��0,50,0,0q�6Z   $
 Wrap=�6l   $	��Top=�6�   $	��167��6�   �� 5      -
   5        $ label5��5      $��Nombre del Temporal :��6$   $
��Left=�6D   $	��Top=�6_   $��	-1,50,0,0q�6w   �� 5      -   5        $ txb_tamañotemporal��5      $��Right=�62   $��23��6N   $��	0,119,0,0q�6Z   $
 Wrap=�6m   $	��Top=�6�   $	��167��6�   �� 5      -   5        $ label6��5      $��Tamaño del Temporal:��6$   $��	0,116,0,0q�6C   $	��Top=�6V   $
��Left=�6n   $	��138��6�   �� 5      -   5        $ button2��5      $��Crear Temporal��6&   $��Center=�6?   $��0,0,0,15q�6\   $��Bottom=�6n   6�   5      5      5      