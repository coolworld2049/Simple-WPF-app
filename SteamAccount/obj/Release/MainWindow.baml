   M S B A M L   `   `   `  ���� G  CSteamAccount, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SteamAccountSteamAccount  G CClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:ClassLibrary;assembly=ClassLibraryClassLibrary     SteamAccount.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:SteamAccount     IClassLibrary0clr-namespace:ClassLibrary;assembly=ClassLibrary       � Title$  Steam Account��$	��488��$	��900�� � WindowStyle$ SingleBorderWindow=� � 
ResizeMode$ NoResize=�.���  � ColumnDefinitions �� $��9* ��� $	��13* ��� $
��194* ��� $
��118* ��� $	��61* ��� $��0* ��� $��52 ��� $
��112* ��� $
��110* ��� $
��225* � � RowDefinitions �� $��60 ��� $	��329 ��� $��60 �.+��� $��/Pictures/Deep Space.jpg��$��10��$	��392��$��Bottom=�$
��None=�$��2��$��1��$��	0,0,0,-11q��� $��10��$�� Player informations��$��71��$��Center=�$��55(�$5��//SteamAccount;component/Fonts/#Dosis ExtraLight)�$��	0,0,0,320q�
�������$��2�� J� RenderTransformOrigin$ 0.5,0.5&�$
��Bold"�����  �� ImageSource$ Blade Runner.jpg�� j� Stretch$ UniformToFill=� �� RelativeTransform V� .~��� 	 �� CenterY$		 0.5Q�
 �� CenterX$	
 0.5Q� �� ScaleY$ -1Q� �� ScaleX$
 1.05Q���  �� AngleY$ 0Q� �� AngleX$ 3Q� �� CenterY$	 0.5Q� �� CenterX$	 0.5Q���  �� Angle$ 0Q� �� CenterY$	 0.5Q� �� CenterX$	 0.5Q�T� �� -    ��Name$ PlaySong��$��	Play song��$��25��$	��Top=�$��12(�$��5��$��46.25,26.252,0,0q�$��4��$��2��$
��Left=�$	��216���� -   $ 	PlayVideo��$��
Play video��$
��Left=�$��25��$��107,26.252,0,0q�$	��Top=�$	��216��$��12(�$��8��$��2��$��2���� $��5��$��46.25,36.877,12,39.964q�$��5��$��1��$��2��.@��� ����  �� Orientation$ 
Horizontal=�.+��� $��50��$��Fonts/Dosis Bold)�$��12(��� $�	Tracklist��.���� .+��� -    ��Name$ TabTrackList��$��19,0,88,-254q�$��Fonts/Dosis Bold)�$��12(�$��2��$��269.614���� ���� $ 
Horizontal=�.+��� -    ��Name$ TextBlockTrackList��$��50��$��Fonts/Dosis Bold)�$��12(��� $�	Videolist��.���� .+��� -   $ TabVideoList��$��269.606��$��18.75,0,88,0q�$��Fonts/Dosis Bold)�$��12(��� -   $ 
ButtonSave��$
��Save��$��25��$��130,65,19,0q�$	��Top=�$��Fonts/Dosis Bold)�$��12(�$��9��$��1���� -    ��Name$ CheckBoxTrackList_1��$��7��$
��Left=�$��16��$��0,64.922,0,0q�$	��Top=�$��12.667��$��1���� -   $ CheckBoxTrackList_2��$��7��$
��Left=�$��16��$��0,79.797,0,0q�$	��Top=�$��12.667��$��1���� -	   $ CheckBoxTrackList_3��$��7��$
��Left=�$��16��$��0,94.422,0,0q�$	��Top=�$��12.667��$��1���� -
   $ CheckBoxTrackList_4��$��7��$
��Left=�$��16��$��0,109.172,0,0q�$	��Top=�$��12.667��$��1���� -   $ CheckBoxTrackList_5��$��7��$
��Left=�$��16��$��0,123.922,0,0q�$	��Top=�$��12.667��$��1���� -   $ CheckBoxTrackList_6��$��7��$
��Left=�$��16��$��0,138.859,0,0q�$	��Top=�$��12.667��$��1���� -   $ CheckBoxTrackList_7��$��7��$
��Left=�$��16��$��0,154.047,0,0q�$	��Top=�$��12.667��$��1���� -   $ CheckBoxTrackList_8��$��7��$
��Left=�$��16��$��0,168.922,0,0q�$	��Top=�$��12.667��$��1���� -   $ CheckBoxTrackList_9��$��7��$
��Left=�$��16��$��0,183.547,0,0q�$	��Top=�$��12.667��$��1���� -   $ CheckBoxTrackList_10��$��7��$
��Left=�$��16��$��0,198.297,0,0q�$	��Top=�$��12.667��$��1���� -   $ 	TextBox_0��$��Bottom=�$��26.012��$��3,0,24.058,266.111q� �� TextWrapping$
 Wrap=�#��� ��$��1��$��2��$��1���� -   $ TextBoxMainInfo��$��101.036��$��3,68.093,22,0q�$
 Wrap=�$	��Top=�$��14(�$��4��$��1��$��1���� -   $ ButtonComparePlayer��$��Compare Players��$
��Left=�$��26.012��$��3,25.24,0,0q�$	��Top=�$	��361��$��Fonts/Dosis Bold)�$��12(�$��4��$��2��$��1���� -   $ TextBoxCompare��$
��Left=�$��85.844��$��3,263.192,0,0q�$
 Wrap=�$	��Top=�$	��361��$��Fonts/Dosis Light)�$��12(�$��4��$��1��$��2��
�������$��1���� -   $ ButtonGetplayerlink��$��Get player link��$
��Left=�$��26.012��$��71.471,36.877,0,0q�$	��Top=�$��85.529��$��12(�$��3��$��2��$��1���� -    ��Name$ ComboBoxPlayer�� �� SelectedIndex$ 0��$#��174.942,36.877,51.529,266.111q�$��1��$��2��$��2��.@��� -    ��Name$ p1��$��player 1���� -   $ p2��$��player 2���� -   $ p3��$��player 3���� -   $ p4��$��player 4���� -   $ p5��$��player 5��$y�	Collapsed=��� -   $ p6��$��player 6��$y�	Collapsed=��� -   $ TextBoxAddPlayer��$��83.656��$��3,173.994,51.529,0q�$
 Wrap=�$	��Top=�$��14(�$��3��$��1��$��1���� -   $ 
SavePlayer��$��Save player��$��71.471,174.129,0,0q�$��12(�$��3��$��2��$��1��$��46.668��$	��Top=�$
��Left=�$��85.529��	� -    	�Name$ 
AddPlayer5��$��Аdd player 5��$
��Left=�$��16.27��$��71.471,225.797,0,0q�$	��Top=�$��85.529��$��3��
���   �$��12(�$��2��$��1��	� -    $ 
AddPlayer6��$��Add player 6��$
��Left=�$��15.583��$��71.471,242.067,0,0q�$	��Top=�$��85.529��$��3��
���   �$��12(�$��2��$��1��