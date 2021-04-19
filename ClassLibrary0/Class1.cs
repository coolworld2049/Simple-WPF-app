using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace ClassLibraryMain
{
    public class Class2
    {
        class Program
        {
            static void Main()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n\tCS_GO_account_info\t\n");
                Console.WriteLine("\tPC-Name: " + Convert.ToString(Environment.UserName) + "\n\n\t");

                //экземпляры классов
                Player character1 = new Player("default", 1, 0, "default", "https://");
                Player character2 = new Player("default", 1, 0, "default", "https://");
                //Player character3 = new Player("default", 0, 0, "default", "https://", 0);
                //Player character4 = new Player("default", 0, 0, "default", "https://", 0);
                Data dt = new Data("default", 0, 0, "default", "https://");
                YouTubeVideo yt = new YouTubeVideo("default", 0, 0, "default", "https://");
                SearchTrack st = new SearchTrack("default", 0, 0, "default", "https://", "music");
                PrintQuote pq = new PrintQuote();


                //1 класс
                Data.ID_Player("11", "77", 55); //ID character1
                //character1.PrintMainInfo(1, "default", 1, "0", 0, "https://");
                Data.ID_Player("11", "77", 55); //ID character2
                //character2.PrintMainInfo(2, "default", 1, "0", 0, "https://");


                //2 класс
                //перегрузка операторов >, <, +, -
                bool comparison_number_of_matches_won1 = character1 > character2;
                bool comparison_number_of_matches_won2 = character1 < character2;
                int difference = Math.Abs(character1.number_of_matches_won - character2.number_of_matches_won);
                int sum = Math.Abs(character1.number_of_matches_won + character2.number_of_matches_won);
                Console.WriteLine("\nКоличество побед character1 больше чем у character2: " + comparison_number_of_matches_won1 + "\n");
                Console.WriteLine("\nКоличество побед character2 больше чем у character1: " + comparison_number_of_matches_won2 + "\n");
                Console.WriteLine("Разница в победах между character1 и character2: " + difference + "\n\n\n");
                Console.WriteLine("Сумма побед character1 и character2: " + sum + "\n\n\n");

                //3 класс
                //dt.Add_new_player(); // 1перегрузка
                dt.Add_new_player("default", 0, 0, "default"); // 2перегрузка

                //4 класс
                //yt.LinkYouTube();
                yt.Write_to_file("link to video");
                Console.WriteLine(YouTubeVideo.EndOfProgramm(1));
                Console.WriteLine(YouTubeVideo.EndOfProgramm(true, true));

                //5 класс
                Console.WriteLine("-------------------------------------");
                //st.ReadSongName();

                //6 класс
                Console.WriteLine("-------------------------------------");
                pq.RandomQuote();



                Console.WriteLine("\nPress ENTER to exit");
                Console.ReadKey();
            }

        }
    }
}
