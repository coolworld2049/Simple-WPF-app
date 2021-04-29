using ClassLibrary;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace SteamAccount
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //основная информация о 4 игроках
        private void p1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox_0.Text = Data.ID_Player("11", "77", 55);
            TextBoxMainInfo.Text = Player.PrintMainInfo(1, "default", 1, "0", 10, "https://");
        }

        private void p2_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox_0.Text = Data.ID_Player("11", "77", 55);
            TextBoxMainInfo.Text = Player.PrintMainInfo(2, "default", 1, "0", 10, "https://");
        }

        private void p3_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox_0.Text = Data.ID_Player("11", "77", 55);
            TextBoxMainInfo.Text = Player.PrintMainInfo(3, "default", 1, "0", 10, "https://");
        }

        private void p4_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox_0.Text = Data.ID_Player("11", "77", 55);
            TextBoxMainInfo.Text = Player.PrintMainInfo(4, "default", 1, "0", 10, "https://");
        }

        //добавление нового игрока
        private void AddPlayer5_Checked(object sender, RoutedEventArgs e)
        {
            TextBoxMainInfo.Text = "Введите данные игрока:" +
                "\n1)Никнейм" +
                "\n2)Количество выигранных матчей" +
                "\n3)Самый дорогой оружейный скин" +
                "\n4)Цена оружейного скина";

            if (AddPlayer5.IsChecked == true)
            {
                TextBoxAddPlayer.Text = ReadNewPlayer(5);
            }
        }

        private void AddPlayer6_Checked(object sender, RoutedEventArgs e)
        {
            TextBoxMainInfo.Text = "Введите данные игрока:"+
                "\n1)Никнейм" +
                "\n2)Количество выигранных матчей" +
                "\n3)Самый дорогой оружейный скин" +
                "\n4)Цена оружейного скина";

            if (AddPlayer6.IsChecked == true)
            {
                TextBoxAddPlayer.Text = ReadNewPlayer(6);
            }
        }

        //сохранение введенных данных
        private void SavePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (AddPlayer5.IsChecked == true)
            {
                AddNewPlayerWrite(5);

                TextBox_0.Text = Data.ID_Player("11", "def", 55);
                p5.Visibility = Visibility.Visible;
                TextBoxMainInfo.Text = Player.PrintMainInfo(5, "default", 1, "0", 10, "https://");
            }
            AddPlayer5.IsChecked = false;

            if (AddPlayer6.IsChecked == true)
            {
                AddNewPlayerWrite(6);

                TextBox_0.Text = Data.ID_Player("11", "def", 55);
                p6.Visibility = Visibility.Visible;
                TextBoxMainInfo.Text = Player.PrintMainInfo(6, "default", 1, "0", 10, "https://");
            }
            AddPlayer6.IsChecked = false;
        }

        private static string ReadNewPlayer(int name_file)
        {
            return File.ReadAllText($@"H:\repos\ClassLibrary\Datas\{name_file}.txt");
        }

        private void AddNewPlayerWrite(int name_file)
        {
            File.WriteAllText($@"H:\repos\ClassLibrary\Datas\{name_file}.txt", TextBoxAddPlayer.Text);
        }


        //сравнение игроков 1 и 2 и всплывающее окно для получения ссылки
        private void ButtonComparePlayer_Click(object sender, RoutedEventArgs e)
        {
            Player character1 = new Player("default", 1, 0, "default", "https://");
            Player character2 = new Player("default", 1, 0, "default", "https://");


            bool comparison_number_of_matches_won1 = character1 > character2;
            bool comparison_number_of_matches_won2 = character1 < character2;
            int difference = Math.Abs(character1.number_of_matches_won - character2.number_of_matches_won);
            int sum = Math.Abs(character1.number_of_matches_won + character2.number_of_matches_won);

            TextBoxCompare.Text =
                "Количество побед character1 больше чем у character2: " + comparison_number_of_matches_won1 +
            "\nКоличество побед character2 больше чем у character1: " + comparison_number_of_matches_won2 +
            "\nРазница в победах между character1 и character2: " + difference +
            "\nСумма побед character1 и character2: " + sum;
        }

        private void ButtonGetplayerlink_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("GET", " ", MessageBoxButton.OKCancel);
            switch (result)
            {
                case MessageBoxResult.OK:
                    if (p1.IsSelected == true)
                    {
                        MessageBox.Show(Player.PrintMainInfoGetValue(1, "default", 1, "0", 10, "https://"));
                    }
                    if (p2.IsSelected == true)
                    {
                        MessageBox.Show(Player.PrintMainInfoGetValue(2, "default", 1, "0", 10, "https://"));
                    }
                    if (p3.IsSelected == true)
                    {
                        MessageBox.Show(Player.PrintMainInfoGetValue(3, "default", 1, "0", 10, "https://"));
                    }
                    if (p4.IsSelected == true)
                    {
                        MessageBox.Show(Player.PrintMainInfoGetValue(4, "default", 1, "0", 10, "https://"));
                    }
                    if (p5.IsSelected == true)
                    {
                        MessageBox.Show(Player.PrintMainInfoGetValue(5, "default", 1, "0", 10, "https://"));
                    }
                    if (p6.IsSelected == true)
                    {
                        MessageBox.Show(Player.PrintMainInfoGetValue(6, "default", 1, "0", 10, "https://"));
                    }
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }


        //вывод названий песен и ссылок на видео из файлов 
        private void TabTrackList_Loaded(object sender, RoutedEventArgs e)
        {
            PlaySong.Opacity = 100; //отображение кнопок при разных TextBlock
            PlayVideo.Opacity = 0;
            TabTrackList.Text = SearchTrack.ReadSongName("getTrack");

            CheckBoxTrackList_1.IsChecked = false;
            CheckBoxTrackList_2.IsChecked = false;
            CheckBoxTrackList_3.IsChecked = false;
            CheckBoxTrackList_4.IsChecked = false;
            CheckBoxTrackList_5.IsChecked = false;
            CheckBoxTrackList_6.IsChecked = false;
            CheckBoxTrackList_7.IsChecked = false;
            CheckBoxTrackList_8.IsChecked = false;
            CheckBoxTrackList_9.IsChecked = false;
            CheckBoxTrackList_10.IsChecked = false;
        }

        private void TextBlockTrackList_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PlaySong.Opacity = 0;
            PlayVideo.Opacity = 100;
            TabVideoList.Text = YouTubeVideo.ReadYouTubeLink("getVideo");

            CheckBoxTrackList_1.IsChecked = false;
            CheckBoxTrackList_2.IsChecked = false;
            CheckBoxTrackList_3.IsChecked = false;
            CheckBoxTrackList_4.IsChecked = false;
            CheckBoxTrackList_5.IsChecked = false;
            CheckBoxTrackList_6.IsChecked = false;
            CheckBoxTrackList_7.IsChecked = false;
            CheckBoxTrackList_8.IsChecked = false;
            CheckBoxTrackList_9.IsChecked = false;
            CheckBoxTrackList_10.IsChecked = false;
        }


        //открытие песен и ссылок на видео с проверкой CheckBox на нажатие и открытие по нажатию кнопки PlaySong
        private void PlaySong_Click(object sender, RoutedEventArgs e)
        {
            SearchTrack st = new SearchTrack("default", 0, 0, "default", "https://", "music");

            if (CheckBoxTrackList_1.IsChecked == true)
            {
                st.PlaySong(0);
                CheckBoxTrackList_1.IsChecked = false;
            }

            if (CheckBoxTrackList_2.IsChecked == true)
            {
                st.PlaySong(1);
                CheckBoxTrackList_2.IsChecked = false;
            }

            if (CheckBoxTrackList_3.IsChecked == true)
            {
                st.PlaySong(2);
                CheckBoxTrackList_3.IsChecked = false;
            }

            if (CheckBoxTrackList_4.IsChecked == true)
            {
                st.PlaySong(3);
                CheckBoxTrackList_4.IsChecked = false;
            }

            if (CheckBoxTrackList_5.IsChecked == true)
            {
                st.PlaySong(4);
                CheckBoxTrackList_5.IsChecked = false;
            }

            if (CheckBoxTrackList_6.IsChecked == true)
            {
                st.PlaySong(5);
                CheckBoxTrackList_6.IsChecked = false;
            }

            if (CheckBoxTrackList_7.IsChecked == true)
            {
                st.PlaySong(6);
                CheckBoxTrackList_7.IsChecked = false;
            }

            if (CheckBoxTrackList_8.IsChecked == true)
            {
                st.PlaySong(7);
                CheckBoxTrackList_8.IsChecked = false;
            }

            if (CheckBoxTrackList_9.IsChecked == true)
            {
                st.PlaySong(8);
                CheckBoxTrackList_9.IsChecked = false;
            }

            if (CheckBoxTrackList_10.IsChecked == true)
            {
                st.PlaySong(9);
                CheckBoxTrackList_10.IsChecked = false;
            }
        }

        private void PlayVideo_Click(object sender, RoutedEventArgs e)
        {      
            YouTubeVideo yt = new YouTubeVideo("default", 0, 0, "default", "https://");


            if (CheckBoxTrackList_1.IsChecked == true)
            {
                yt.OpenYouTubeLink(0);
                CheckBoxTrackList_1.IsChecked = false;
            }

            if (CheckBoxTrackList_2.IsChecked == true)
            {
                yt.OpenYouTubeLink(1);
                CheckBoxTrackList_2.IsChecked = false;
            }

            if (CheckBoxTrackList_3.IsChecked == true)
            {
                yt.OpenYouTubeLink(2);
                CheckBoxTrackList_3.IsChecked = false;
            }

            if (CheckBoxTrackList_4.IsChecked == true)
            {
                yt.OpenYouTubeLink(3);
                CheckBoxTrackList_4.IsChecked = false;
            }

            if (CheckBoxTrackList_5.IsChecked == true)
            {
                yt.OpenYouTubeLink(4);
                CheckBoxTrackList_5.IsChecked = false;
            }

            if (CheckBoxTrackList_6.IsChecked == true)
            {
                yt.OpenYouTubeLink(5);
                CheckBoxTrackList_6.IsChecked = false;
            }

            if (CheckBoxTrackList_7.IsChecked == true)
            {
                yt.OpenYouTubeLink(6);
                CheckBoxTrackList_7.IsChecked = false;
            }

            if (CheckBoxTrackList_8.IsChecked == true)
            {
                yt.OpenYouTubeLink(7);
                CheckBoxTrackList_8.IsChecked = false;
            }

            if (CheckBoxTrackList_9.IsChecked == true)
            {
                yt.OpenYouTubeLink(8);
                CheckBoxTrackList_9.IsChecked = false;
            }

            if (CheckBoxTrackList_10.IsChecked == true)
            {
                yt.OpenYouTubeLink(9);
                CheckBoxTrackList_10.IsChecked = false;
            }
        }


        //сохранение введенных названий песен и видео
        private void TabTrackList_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ButtonSave.IsEnabled == true)
            {
                StreamWriter sw = new StreamWriter(@"H:\repos\ClassLibrary\song_link.txt");
                sw.WriteLine(TabTrackList.Text);
                sw.Close();
            }
        }

        private void TabVideoList_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ButtonSave.IsEnabled == true)
            {
                StreamWriter sw1 = new StreamWriter(@"H:\repos\ClassLibrary\link to video.txt");
                sw1.WriteLine(TabVideoList.Text);
                sw1.Close();
            }
        }


    }
}
