using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary;
using Microsoft.Win32;


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
                    MessageBox.Show("I don`t know", " ");
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }


        //вывод названий песен и ссылок на видео из файлов и их открытие по кнопке
        private void CheckBoxTrackList_1_Loaded(object sender, RoutedEventArgs e)
        {
            CheckBoxTrackList_1.Content = SearchTrack.ReadSongName(0);
            CheckBoxTrackList_2.Content = SearchTrack.ReadSongName(0);
            CheckBoxTrackList_3.Content = SearchTrack.ReadSongName(0);
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CheckBoxVideoList_1.Content = YouTubeVideo.ReadYouTubeLink("getVideo");
        }

        private void PlaySong_Click(object sender, RoutedEventArgs e)
        {
            SearchTrack st = new SearchTrack("default", 0, 0, "default", "https://", "music");

            if (CheckBoxTrackList_1.IsChecked == true)
            {
                st.PlaySong(0);
            }
            if (CheckBoxTrackList_2.IsChecked == true)
            {
                st.PlaySong(1);
            }
            if (CheckBoxTrackList_3.IsChecked == true)
            {
                st.PlaySong(2);
            }
        }

        private void PlayVideo_Click(object sender, RoutedEventArgs e)
        {
            //Window1 window1 = new Window1();
            //window1.Show();
            YouTubeVideo yt = new YouTubeVideo("default", 0, 0, "default", "https://");

            yt.OpenYouTubeLink(1);
            yt.OpenYouTubeLink(2);
            yt.OpenYouTubeLink(3);
            yt.OpenYouTubeLink(4);
            yt.OpenYouTubeLink(5);
            yt.OpenYouTubeLink(6);
        }


        //сохранение введенных названий песен и видео
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"H:\repos\ClassLibrary\song_link.txt");
            sw.WriteLine(TabTrackList.Text);
            sw.Close();

            StreamWriter sw1 = new StreamWriter(@"H:\repos\ClassLibrary\link to video.txt");
            sw1.WriteLine(TabVideoList.Text);
            sw1.Close();

        }



    }
}
