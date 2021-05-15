using System;
using ClassLibrary;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Player
    {
        private string Nickname;
        private int Number_of_matches_won;
        private int Price_weapon_skins_rub;
        private string Expensive_weapon_skins;
        private string Link_to_the_Steam_account;
        private string Identification_number;

        public string nickname
        {
            get { return Nickname; }
            set { Nickname = value; }
        }
        public int number_of_matches_won
        {
            get { return Number_of_matches_won; }

            set
            {
                if (Number_of_matches_won != -1)
                {
                    Number_of_matches_won = value;
                }

                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public int price_weapon_skins_rub
        {
            get { return Price_weapon_skins_rub; }
            set
            {
                if (Price_weapon_skins_rub > -1)
                {
                    Price_weapon_skins_rub = value;
                }
            }
        }
        public string expensive_weapon_skins
        {
            get { return Expensive_weapon_skins; }
            set { Expensive_weapon_skins = value; }
        }
        public string link_to_the_Steam_account
        {
            get { return Link_to_the_Steam_account; }
            set { Link_to_the_Steam_account = value; }
        }
        public virtual string identification_number //виртуальный метод
        {
            get => Identification_number;
            set => Identification_number = value;
        }

        public Player(string nickname, int number_of_matches_won, int price_weapon_skins_rub, string expensive_weapon_skins, string link_to_the_Steam_account)
        {
            Nickname = nickname;
            Number_of_matches_won = number_of_matches_won;
            Price_weapon_skins_rub = price_weapon_skins_rub;
            Expensive_weapon_skins = expensive_weapon_skins;
            Link_to_the_Steam_account = link_to_the_Steam_account;
        }

        public static string PrintMainInfoGetValue(object count_player, string nickname, int number_of_matches_won, string expensive_weapon_skins,
            int price_weapon_skins_rub, string link_to_the_Steam_account)
        {
            TextReader reader = new StreamReader($@"H:\repos\ClassLibrary\Datas\{count_player}.txt");

            nickname = Convert.ToString(reader.ReadLine());
            number_of_matches_won = Convert.ToInt32(reader.ReadLine());
            expensive_weapon_skins = reader.ReadLine();
            price_weapon_skins_rub = Convert.ToInt32(reader.ReadLine());
            link_to_the_Steam_account = reader.ReadLine();

            List<string> list = new List<string>();
            list.Add(nickname);
            list.Add(Convert.ToString(number_of_matches_won));
            list.Add(expensive_weapon_skins);
            list.Add(Convert.ToString(price_weapon_skins_rub));
            list.Add(link_to_the_Steam_account);
            string[] getParameters = list.ToArray();

            return getParameters[4];

        }

        public static string PrintMainInfo(object count_player, string nickname, int number_of_matches_won, string expensive_weapon_skins,
            int price_weapon_skins_rub, string link_to_the_Steam_account) // виртуальный метод
        {
            using (TextReader reader = new StreamReader($@"H:\repos\ClassLibrary\Datas\{count_player}.txt"))
            {
                nickname = Convert.ToString(reader.ReadLine());
                number_of_matches_won = Convert.ToInt32(reader.ReadLine());
                expensive_weapon_skins = reader.ReadLine();
                price_weapon_skins_rub = Convert.ToInt32(reader.ReadLine());
                link_to_the_Steam_account = reader.ReadLine();
            }

            return
                $"Игрок номер {count_player}\n" +
            $"Имя игрока:  {nickname}\n" +
            $"Количество выигранных матчей игрока:  { number_of_matches_won}\n" +
            $"Самый дорогой оружейный скин:  { expensive_weapon_skins}\n" +
            $"Цена оружейного скина:  {price_weapon_skins_rub}\n\n";
        }

        //перегрузка операторов
        public static bool operator >(Player character1, Player character2) => character1.number_of_matches_won > character2.number_of_matches_won;
        public static bool operator <(Player character1, Player character2) => character1.number_of_matches_won < character2.number_of_matches_won;
    }

    public class Data : Player
    {
        private string new_player;
        private string Identification_number;

        public string New_player { get => new_player; set => new_player = value; }
        public override string identification_number //переопределение виртуального свойства в дочернем классе c запретом дальнейшего переопределения
        {
            get { return Identification_number; }
            set
            {
                if (Identification_number != null)
                {
                    Identification_number = value;
                }
            }
        }

        public Data(string nickname, int number_of_matches_won, int price_weapon_skins_rub, string expensive_weapon_skins, string link_to_the_Steam_account) :
               base(nickname, number_of_matches_won, price_weapon_skins_rub, expensive_weapon_skins, link_to_the_Steam_account)
        {

        }


        public void Add_new_player(int name_file)
        {
            StreamWriter sw = new StreamWriter($@"H:\repos\ClassLibrary\{name_file}.txt");
            sw.WriteLine(nickname);
            sw.WriteLine(number_of_matches_won);
            sw.WriteLine(price_weapon_skins_rub);
            sw.WriteLine(expensive_weapon_skins);
            sw.Close();
        }

        public static string ID_Player(string Identification_number, string nickname, int number_of_matches_won)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            Identification_number = Convert.ToString("Player_ID [" + $"{nickname}" + $"{number_of_matches_won}" + $"{finalString}" + "]\n");

            return "Player_ID [" + $"{nickname}" + $"{number_of_matches_won}" + $"{finalString}" + "]\n";

        }
    }

    public class YouTubeVideo : Data
    {
        public string need_video;
        private string link_to_video1;
        private string link_to_video2;
        private string link_to_video3;
        private string link_to_video4;
        private string link_to_video5;
        private string link_to_video6;

        public string Link_to_video1
        {
            get => link_to_video1; set => link_to_video1 = value;
        }
        public string Link_to_video2
        {
            get => link_to_video2; set => link_to_video2 = value;
        }
        public string Link_to_video3
        {
            get => link_to_video3; set => link_to_video3 = value;
        }
        public string Link_to_video4
        {
            get => link_to_video4; set => link_to_video4 = value;
        }
        public string Link_to_video5
        {
            get => link_to_video5; set => link_to_video5 = value;
        }
        public string Link_to_video6
        {
            get => link_to_video6; set => link_to_video6 = value;
        }

        public YouTubeVideo(string nickname, int number_of_matches_won, int price_weapon_skins_rub, string expensive_weapon_skins, string link_to_the_Steam_account) :
            base(nickname, number_of_matches_won, price_weapon_skins_rub, expensive_weapon_skins, link_to_the_Steam_account)
        {
            Link_to_video1 = link_to_video1;
            Link_to_video2 = link_to_video2;
            Link_to_video3 = link_to_video3;
            Link_to_video4 = link_to_video4;
            Link_to_video5 = link_to_video5;
            Link_to_video6 = link_to_video6;
        }

        public void OpenYouTubeLink(int tap)
        {
            using (TextReader reader = new StreamReader($@"H:\repos\ClassLibrary\Datas\link to video.txt"))
            {
                link_to_video1 = reader.ReadLine();
                link_to_video2 = reader.ReadLine();
                link_to_video3 = reader.ReadLine();
                link_to_video4 = reader.ReadLine();
                link_to_video5 = reader.ReadLine();
                link_to_video6 = reader.ReadLine();
            }

            ProcessStartInfo prs = new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");

            switch (tap)
            {
                case 1:
                    prs.Arguments = link_to_video1;
                    Process.Start(prs);
                    break;
                case 2:
                    prs.Arguments = link_to_video2;
                    Process.Start(prs);
                    break;
                case 3:
                    prs.Arguments = link_to_video3;
                    Process.Start(prs);
                    break;
                case 4:
                    prs.Arguments = link_to_video4;
                    Process.Start(prs);
                    break;
                case 5:
                    prs.Arguments = link_to_video5;
                    Process.Start(prs);
                    break;
                case 6:
                    prs.Arguments = link_to_video6;
                    Process.Start(prs);
                    break;
            }
        }

        public static string ReadYouTubeLink(string getVideo)
        {
            using (TextReader reader = new StreamReader($@"H:\repos\ClassLibrary\Datas\link to video.txt"))
            {
                getVideo = reader.ReadToEnd();
            }
            return getVideo;
        }

    }

    public class SearchTrack : Data
    {
        private string getTrack;

        public string GetTrack { get => getTrack; set => getTrack = value; }
        public SearchTrack(string nickname, int number_of_matches_won, int price_weapon_skins_rub, string expensive_weapon_skins,
            string link_to_the_Steam_account, string getTrack)
            : base(nickname, number_of_matches_won, price_weapon_skins_rub, expensive_weapon_skins, link_to_the_Steam_account)
        {
            this.getTrack = getTrack;
        }


        public static string ReadSongName(string getTrack) //чтение названий песен из файла
        {
            using (TextReader reader = new StreamReader($@"H:\repos\ClassLibrary\Datas\song_link.txt"))
            {
                getTrack = reader.ReadToEnd();
                return getTrack;
            }
        }

        public void PlaySong(int i) //поиск названий песен в браузере
        {
            ProcessStartInfo prs = new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");

            string[] getTrackNew = File.ReadAllLines($@"H:\repos\ClassLibrary\Datas\song_link.txt");

            prs.Arguments = "https://www.google.com/search?q=" + getTrackNew[i];
            Process.Start(prs.Arguments);
        }
    }

    public abstract class Quote //абстрактный класс
    {
        protected string[] Citates = new string[]
        {
            "Что разум человека может постигнуть и во что он может поверить, того он может достичь! -Наполеон Хилл",
            "Надо любить жизнь больше, чем смысл жизни -Фёдор Достоевский",
            "Каждый думает что знает меня, но не каждый знает, что не знает, кто думает -Цитаты волка"
        };
        public abstract void RandomQuote(); //инкапсуляция абстрактного метода
    }

    public class PrintQuote : Quote
    {
        public override void RandomQuote() //переопределение метода в классе-наследнике
        {
            Random rnd = new Random();
            int i = rnd.Next(0, Citates.Length);
            string cts = Citates[i];
            Console.WriteLine(cts);
        }
    }

}
