﻿using System;
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
        public Player(string nickname, int number_of_matches_won, int price_weapon_skins_rub, string expensive_weapon_skins)
        {
            Nickname = nickname;
            Number_of_matches_won = number_of_matches_won;
            Price_weapon_skins_rub = price_weapon_skins_rub;
            Expensive_weapon_skins = expensive_weapon_skins;
        }
        public Player(string nickname, int number_of_matches_won, int price_weapon_skins_rub)
        {
            Nickname = nickname;
            Number_of_matches_won = number_of_matches_won;
            Price_weapon_skins_rub = price_weapon_skins_rub;
        }


        public static string PrintMainInfo(object count_player, string nickname, int number_of_matches_won, string expensive_weapon_skins,
            int price_weapon_skins_rub, string link_to_the_Steam_account) // виртуальный метод
        {
            string comp_name = Convert.ToString(Environment.UserName);

            using (TextReader reader = new StreamReader($@"C:\Users\{comp_name}\source\repos\ConsoleApp2\{count_player}.txt"))
            {
                nickname = reader.ReadLine();
                number_of_matches_won = Convert.ToInt32(reader.ReadLine());
                expensive_weapon_skins = reader.ReadLine();
                price_weapon_skins_rub = Convert.ToInt32(reader.ReadLine());
                link_to_the_Steam_account = reader.ReadLine();
            }

            return 
                $"Игрок номер {count_player}\n" +
            $"Имя игрока: {nickname}\n" +
            $"Количество выигранных матчей игрока { nickname}: { number_of_matches_won}\n" +
            $"Самый дорогой оружейный скин:{ expensive_weapon_skins}\n" +
            $"Цена оружейного скина:{price_weapon_skins_rub}\n" +
            $"Получить ссылку игрока?\n" +
            $"Ссылка {link_to_the_Steam_account}\n\n";


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

        //перегрузка метода Add_new_player()
        public void Add_new_player()
        {
            Console.Write("Добавить нового игрока?[Y/n]\n");

            New_player = Convert.ToString(Console.ReadLine());
            if (((New_player == "Y") || (New_player == "y")) || (New_player == "Н") || (New_player == "н"))
            {
                Console.WriteLine($"Введите данные игрока:");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
                $"\n 1)Никнейм" +
                $"\n 2)Количество выигранных матчей" +
                $"\n 3)Самый дорогой оружейный скин" +
                $"\n 4)Цена оружейного скина" +
                $"\n 5)Ссылка на инвентарь игрока\n");

                Console.ForegroundColor = ConsoleColor.White;
                nickname = Console.ReadLine();
                number_of_matches_won = Convert.ToInt32(Console.ReadLine());
                expensive_weapon_skins = Console.ReadLine();
                price_weapon_skins_rub = Convert.ToInt32(Console.ReadLine());
                link_to_the_Steam_account = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Игрок не добавлен\n");
            }
            Console.WriteLine();
            Write_to_file("new player");
        }
        public void Add_new_player(string nickname, int number_of_matches_won, int price_weapon_skins_rub, string expensive_weapon_skins)
        {
            Console.Write("Добавить нового игрока?[Y/n]\n");
            New_player = Convert.ToString(Console.ReadLine());

            if (((New_player == "Y") || (New_player == "y")) || (New_player == "Н") || (New_player == "н"))
            {
                Console.WriteLine($"Введите данные игрока:");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
                $"\n 1)Никнейм" +
                $"\n 2)Количество выигранных матчей" +
                $"\n 3)Самый дорогой оружейный скин" +
                $"\n 4)Цена оружейного скина");

                Console.ForegroundColor = ConsoleColor.White;
                nickname = Console.ReadLine();
                number_of_matches_won = Convert.ToInt32(Console.ReadLine());
                expensive_weapon_skins = Console.ReadLine();
                price_weapon_skins_rub = Convert.ToInt32(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Игрок не добавлен\n");
            }
            Console.WriteLine();

            Write_to_file("new player");
        }

        //перегрузка метода Write_to_file()
        public virtual void Write_to_file(string name_file)
        {
            try
            {
                string comp_name2 = Convert.ToString(Environment.UserName);

                StreamWriter sw = new StreamWriter($@"C:\Users\{comp_name2}\source\repos\ConsoleApp2\{name_file}.txt");

                sw.WriteLine(nickname);
                sw.WriteLine(number_of_matches_won);
                sw.WriteLine(price_weapon_skins_rub);
                sw.WriteLine(expensive_weapon_skins);

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Данные записаны в текстовый файл\n");
            }
        }

        public static string ID_Player(string Identification_number,string nickname,int number_of_matches_won)
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
        private string link_to_video1 = "https://www.youtube.com/watch?v=R0PFpJZEzcE"; //s1mple
        private string link_to_video2 = "https://www.youtube.com/watch?v=zAUqp_7VgDI"; //dose of internet
        private string link_to_video3 = "http://itsuhorukov.ru/2019/07/02/10-samyihsochnyih-ssyilok-dlya-razrabotchika-na-unity3d/"; //unity
        private string link_to_video4 = "https://vk.com/video-32292170_169127440"; //obladaet
        private string link_to_video5 = "https://vk.com";
        private string link_to_video6 = "https://vk.com/video109658801_456341028"; // mem video

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


        public override void Write_to_file(string name_file) //аналогичный виртуальный метод для класса YouTubeVideo из класса Data!!!
        {
            base.Write_to_file(name_file);

            try
            {
                string comp_name2 = Convert.ToString(Environment.UserName);

                StreamWriter sw = new StreamWriter($@"C:\Users\{comp_name2}\source\repos\ConsoleApp2\{name_file}.txt");

                sw.WriteLine(link_to_video1);
                sw.WriteLine(link_to_video2);
                sw.WriteLine(link_to_video3);
                sw.WriteLine(link_to_video4);
                sw.WriteLine(link_to_video5);
                sw.WriteLine(link_to_video6);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Данные записаны в текстовый файл(ссылки на видео)\n");
            }
        }
        public void LinkYouTube()
        {
            ProcessStartInfo prs = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
            Console.Write("Выберите цифру от 1 до 6: ");
            int tap = Convert.ToInt32(Console.ReadLine());
            
            switch (tap) // открытие выбранной ссылки в браузере
            {
                case 1:
                    prs.Arguments = link_to_video1;
                    Process.Start(prs);
                    break;
                case 2:
                    prs.Arguments = Link_to_video2;
                    Process.Start(prs);
                    break;
                case 3:
                    prs.Arguments = Link_to_video3;
                    Process.Start(prs);
                    break;
                case 4:
                    prs.Arguments = Link_to_video4;
                    Process.Start(prs);
                    break;
                case 5:
                    prs.Arguments = Link_to_video5;
                    Process.Start(prs);
                    break;
                case 6:
                    prs.Arguments = Link_to_video6;
                    Process.Start(prs);
                    break;
                default:
                    Console.WriteLine("\nЦифра не входит в диапазон\n");
                    break;
            }
        }

        // перегрузка метода, возвращающего значение
        public static int EndOfProgramm(int end)
        {
            Console.Write("Programm completed sucsessfuly: ");

            if (end == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static string EndOfProgramm(bool start1, bool end1)
        {
            if ((end1 == true) && (start1 == true))
            {
                return "Programm launched sucsessfuly";
            }
            else
            {
                return "Programm is running with errors sucsessfuly";
            }
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


        public void ReadSongName() //чтение названий песен из файла
        {
            string comp_name = Convert.ToString(Environment.UserName);

            using (TextReader reader = new StreamReader($@"C:\Users\{comp_name}\source\repos\ConsoleApp2\song_link.txt"))
            {
                getTrack = reader.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nСписок песен:\n\n  {getTrack}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"\nНайти песню в Google? [Y/n] ");
            string need_link = Convert.ToString(Console.ReadLine());
            if (((need_link == "Y") || (need_link == "y")) || (need_link == "Н") || (need_link == "н"))
            {
                PlaySong();
            }
            else
            {
                Console.WriteLine("\nОтмена\n\n");
            }
        }
        public void PlaySong() //поиск названий песен в браузере
        {
            ProcessStartInfo prs = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
            prs.Arguments = $"https://www.google.com/search?q={getTrack}";
            Process.Start(prs);
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
