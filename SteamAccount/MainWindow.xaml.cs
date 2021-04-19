using System;
using System.Collections.Generic;
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
            Text();
        }
        

        public void Text()
        {
            TextBox_0.Text = Data.ID_Player("11", "77", 55); 
            TextBoxMainInfo.Text = Player.PrintMainInfo(1, "default", 1, "0", 0, "https://");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            TextBoxMainInfo.Text = Player.PrintMainInfo(2, "default", 1, "0", 0, "https://");

        }

        private void ButtonComparePlayer_Click(object sender, RoutedEventArgs e)
        {
            Player character1 = new Player("default", 1, 0, "default", "https://");
            Player character2 = new Player("default", 1, 0, "default", "https://");


            bool comparison_number_of_matches_won1 = character1 > character2;
            bool comparison_number_of_matches_won2 = character1 < character2;
            int difference = Math.Abs(character1.number_of_matches_won - character2.number_of_matches_won);
            int sum = Math.Abs(character1.number_of_matches_won + character2.number_of_matches_won);

            TextBoxCompare.Text = 
                "Количество побед character1 больше чем у character2: " + comparison_number_of_matches_won1 + "\n"+
            "\nКоличество побед character2 больше чем у character1: " + comparison_number_of_matches_won2 + "\n"+
            "\nРазница в победах между character1 и character2: " + difference + "\n"+
            "\nСумма побед character1 и character2: " + sum + "\n";
        }

        private void ButtonGetplayerlink_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("GET", " ", MessageBoxButton.OK);
            switch (result)
            {
                case MessageBoxResult.OK:
                    MessageBox.Show("I don`t know", " ");
                    break;
            }
        }
    }
}
