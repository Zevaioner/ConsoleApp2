using System;
using System.IO;

namespace Fish
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            {
                string path = @"D:/leaderboard.txt";
                string text = "Приветствую. Это ваш лидерборд.";
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(text);
                    }
                    Console.WriteLine(" Все данные в норме");
                }
                Console.WriteLine(" Приветствую! Это меню игр; \r\n" +
                       " а)Крестики-нолики; \r\n" +
                       " б)Шашки \r\n" +
                       " в)Кораблики \r\n" +
                       " г)Выход из программы.");

            }//INTRO
            string menu = Console.ReadLine();
            if (menu == "а")
            {
                bool win = false;
                string m1 = "1";
                string m2 = "2";
                string m3 = "3";
                string m4 = "4";
                string m5 = "5";
                string m6 = "6";
                string m7 = "7";
                string m8 = "8";
                string m9 = "9";
                Console.WriteLine(" Если случилась ничья - просто введите любую букву");
                do
                {
                    Console.WriteLine(m1 + "|" + m2 + "|" + m3 + "|" + "\r\n" + m4 + "|" + m5 + "|" + m6 + "|" + "\r\n" + m7 + "|" + m8 + "|" + m9 + "|" + "\r\n");
                    Console.WriteLine(" Введиде цифру на которую хотите ходить");
                    int menu1 = Convert.ToInt32(Console.ReadLine());
                    if (menu1 == 1)
                    {
                        m1 = "x";
                    }
                    if (menu1 == 2)
                    {
                        m2 = "x";
                    }
                    if (menu1 == 3)
                    {
                        m3 = "x";
                    }
                    if (menu1 == 4)
                    {
                        m4 = "x";
                    }
                    if (menu1 == 5)
                    {
                        m5 = "x";
                    }
                    if (menu1 == 6)
                    {
                        m6 = "x";
                    }
                    if (menu1 == 7)
                    {
                        m7 = "x";
                    }
                    if (menu1 == 8)
                    {
                        m8 = "x";
                    }
                    if (menu1 == 9)
                    {
                        m9 = "x";
                    }
                    Console.WriteLine(" Ход белых!");
                    Console.WriteLine(" Введиде цифру на которую хотите ходить");
                    Console.WriteLine(m1 + "|" + m2 + "|" + m3 + "|" + "\r\n" + m4 + "|" + m5 + "|" + m6 + "|" + "\r\n" + m7 + "|" + m8 + "|" + m9 + "\r\n");
                    int menu2 = Convert.ToInt32(Console.ReadLine());
                    if (menu2 == 1)
                    {
                        m1 = "o";
                    }
                    if (menu2 == 2)
                    {
                        m2 = "o";
                    }
                    if (menu2 == 3)
                    {
                        m3 = "o";
                    }
                    if (menu2 == 4)
                    {
                        m4 = "o";
                    }
                    if (menu2 == 5)
                    {
                        m5 = "o";
                    }
                    if (menu2 == 6)
                    {
                        m6 = "o";
                    }
                    if (menu2 == 7)
                    {
                        m7 = "o";
                    }
                    if (menu2 == 8)
                    {
                        m8 = "o";
                    }
                    if (menu2 == 9)
                    {
                        m9 = "o";
                    }
                    //Cheking x
                    if (m1 == "x" && m2 == "x" && m3 == "x")
                    {
                        win = true;
                        Console.WriteLine("Победа крестиков");
                    }
                    if (m4 == "x" && m5 == "x" && m6 == "x")
                    {
                        win = true;
                        Console.WriteLine("Победа крестиков");
                    }
                    if (m7 == "x" && m8 == "x" && m9 == "x")
                    {
                        win = true;
                        Console.WriteLine("Победа крестиков");
                    }
                    if (m1 == "x" && m4 == "x" && m7 == "x")
                    {
                        win = true;
                        Console.WriteLine("Победа крестиков");
                    }
                    if (m2 == "x" && m5 == "x" && m8 == "x")
                    {
                        win = true;
                        Console.WriteLine("Победа крестиков");
                    }
                    if (m3 == "x" && m6 == "x" && m9 == "x")
                    {
                        win = true;
                        Console.WriteLine("Победа крестиков");
                    }
                    if (m1 == "x" && m5 == "x" && m9 == "x")
                    {
                        win = true;
                        Console.WriteLine("Победа крестиков");
                    }
                    if (m3 == "x" && m5 == "x" && m7 == "x")
                    {
                        win = true;
                        Console.WriteLine("Победа крестиков");
                    }
                    //Cheking o
                    if (m1 == "o" && m2 == "o" && m3 == "o")
                    {
                        win = true;
                        Console.WriteLine("Победа ноликов");
                    }
                    if (m4 == "o" && m5 == "o" && m6 == "o")
                    {
                        win = true;
                        Console.WriteLine("Победа ноликов");
                    }
                    if (m7 == "o" && m8 == "o" && m9 == "o")
                    {
                        win = true;
                        Console.WriteLine("Победа ноликов");
                    }
                    if (m1 == "o" && m4 == "o" && m7 == "o")
                    {
                        win = true;
                        Console.WriteLine("Победа ноликов");
                    }
                    if (m2 == "o" && m5 == "o" && m8 == "o")
                    {
                        win = true;
                        Console.WriteLine("Победа ноликов");
                    }
                    if (m3 == "o" && m6 == "o" && m9 == "o")
                    {
                        win = true;
                        Console.WriteLine("Победа ноликов");
                    }
                    if (m1 == "o" && m5 == "o" && m9 == "o")
                    {
                        win = true;
                        Console.WriteLine("Победа ноликов");
                    }
                    if (m3 == "o" && m5 == "o" && m7 == "o")
                    {
                        win = true;
                        Console.WriteLine("Победа ноликов");
                    }
                } while (win == false);//готово
                Console.WriteLine(win);
            }
            if (menu == "б")
            {
                //bool win = false;
                //string m1 = "1";
                //string m2 = "2";
                //string m3 = "3";
                //string m4 = "4";
                //string m5 = "5";
                //string m6 = "6";
                //string m7 = "7";
                //string m8 = "8";
                //string m9 = "9";
                //string m10 = "10";
                //string m11 = "11";
                //string m12 = "12";
                //string m13 = "13";
                //string m14 = "14";
                //string m15 = "15";
                //string m16 = "16";
                //string m17 = "17";
                //string m18 = "18";
                //string m19 = "19";
                //string m20 = "20";
                //string m21 = "21";
                //string m22 = "22";
                //string m23 = "23";
                //string m24 = "24";
                //Console.WriteLine("|1 |x |2 |x |3 |x |4 |x |5 |");
                //Console.WriteLine("|x |6 |x |7 |x |8 |x |9 |x |");
                //Console.WriteLine("|10|x |11|x |12|x |13|x |14|");
                //Console.WriteLine("|x |15|x |16|x |17|x |18|x |");
                //Console.WriteLine("|19|20|21|22|23|24|25|26|27|");
                //Console.WriteLine("|28|29|30|31|32|33|34|35|36|");
                //Console.WriteLine("|37|o |38|o |39|o |40|o |41|");
                //Console.WriteLine("|o |41|o |42|o |43|o |44|o |");
                //Console.WriteLine("|45|o |46|o |47|o |48|o |49|");
                //Console.WriteLine("|o |50|o |51|o |52|o |53|o |");
                Console.WriteLine("");
            }
            if (menu == "в")
            {
                bool setup = false;
                string s1 = "1|а|б|в|г|д|е|ж|з|и|к|";
                string s2 = "2|а|б|в|г|д|е|ж|з|и|к|";
                string s3 = "3|а|б|в|г|д|е|ж|з|и|к|";
                string s4 = "4|а|б|в|г|д|е|ж|з|и|к|";
                string s5 = "5|а|б|в|г|д|е|ж|з|и|к|";
                string s6 = "6|а|б|в|г|д|е|ж|з|и|к|";
                string s7 = "7|а|б|в|г|д|е|ж|з|и|к|";
                string s8 = "8|а|б|в|г|д|е|ж|з|и|к|";
                string s9 = "9|а|б|в|г|д|е|ж|з|и|к|";
                string s0 = "0|а|б|в|г|д|е|ж|з|и|к|";
                Console.WriteLine(" Приветствую! \r\n Это игра в Морской бой или Кораблики");
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                Console.WriteLine(s3);
                Console.WriteLine(s4);
                Console.WriteLine(s5);
                Console.WriteLine(s6);
                Console.WriteLine(s7);
                Console.WriteLine(s8);
                Console.WriteLine(s9);
                Console.WriteLine(s0);
                Console.WriteLine(" Кораблики: >(4шт) =>(3шт) ==>(2шт) <==>(1шт)");
                Console.WriteLine(" Это ваше поле и Корабли,Генерал! " +
                                    "\r\n Расставляйте с умом! " +
                                    "\r\n Последовательно указывайте расположение маленьких,средних,больших и линкора");

                Console.WriteLine("Посследовательно вводите цифру и букву координат соответсвенно");
                for (int i = 1; i < 5; i++)
                {
                    string boat_settings_01 = Console.ReadLine();
                    string boat_settings_02 = Console.ReadLine();
                    if (boat_settings_01 == "1")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s1 = s1.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s1 = s1.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s1 = s1.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s1 = s1.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s1 = s1.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s1 = s1.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s1 = s1.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s1 = s1.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s1 = s1.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s1 = s1.Replace("к", ">");
                        }
                    }
                    if (boat_settings_01 == "2")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s2 = s2.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s2 = s2.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s2 = s2.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s2 = s2.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s2 = s2.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s2 = s2.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s2 = s2.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s2 = s2.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s2 = s2.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s2 = s2.Replace("к", ">");
                        }
                    }
                    if (boat_settings_01 == "3")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s3 = s3.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s3 = s3.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s3 = s3.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s3 = s3.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s3 = s3.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s3 = s3.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s3 = s3.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s3 = s3.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s3 = s3.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s3 = s3.Replace("к", ">");
                        }
                    }
                    if (boat_settings_01 == "4")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s4 = s4.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s4 = s4.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s4 = s4.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s4 = s4.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s4 = s4.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s4 = s4.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s4 = s4.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s4 = s4.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s4 = s4.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s4 = s4.Replace("к", ">");
                        }
                    }
                    if (boat_settings_01 == "5")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s5 = s5.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s5 = s5.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s5 = s5.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s5 = s5.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s5 = s5.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s5 = s5.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s5 = s5.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s5 = s5.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s5 = s5.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s5 = s5.Replace("к", ">");
                        }
                    }
                    if (boat_settings_01 == "6")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s6 = s6.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s6 = s6.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s6 = s6.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s6 = s6.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s6 = s6.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s6 = s6.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s6 = s6.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s6 = s6.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s6 = s6.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s6 = s6.Replace("к", ">");
                        }
                    }
                    if (boat_settings_01 == "7")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s7 = s7.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s7 = s7.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s7 = s7.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s7 = s7.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s7 = s7.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s7 = s7.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s7 = s7.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s7 = s7.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s7 = s7.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s7 = s7.Replace("к", ">");
                        }
                    }
                    if (boat_settings_01 == "8")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s8 = s8.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s8 = s8.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s8 = s8.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s8 = s8.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s8 = s8.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s8 = s8.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s8 = s8.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s8 = s8.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s8 = s8.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s8 = s8.Replace("к", ">");
                        }
                    }
                    if (boat_settings_01 == "9")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s9 = s9.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s9 = s9.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s9 = s9.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s9 = s9.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s9 = s9.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s9 = s9.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s9 = s9.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s9 = s9.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s9 = s9.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s9 = s9.Replace("к", ">");
                        }
                    }
                    if (boat_settings_01 == "0")
                    {
                        if (boat_settings_02 == "a")
                        {
                            s0 = s0.Replace("а", ">");
                        }
                        if (boat_settings_02 == "б")
                        {
                            s0 = s0.Replace("б", ">");
                        }
                        if (boat_settings_02 == "в")
                        {
                            s0 = s0.Replace("в", ">");
                        }
                        if (boat_settings_02 == "г")
                        {
                            s0 = s0.Replace("г", ">");
                        }
                        if (boat_settings_02 == "д")
                        {
                            s0 = s0.Replace("д", ">");
                        }
                        if (boat_settings_02 == "е")
                        {
                            s0 = s0.Replace("е", ">");
                        }
                        if (boat_settings_02 == "ж")
                        {
                            s0 = s0.Replace("ж", ">");
                        }
                        if (boat_settings_02 == "з")
                        {
                            s0 = s0.Replace("з", ">");
                        }
                        if (boat_settings_02 == "и")
                        {
                            s0 = s0.Replace("и", ">");
                        }
                        if (boat_settings_02 == "к")
                        {
                            s0 = s0.Replace("к", ">");
                        }
                    }
                }
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                Console.WriteLine(s3);
                Console.WriteLine(s4);
                Console.WriteLine(s5);
                Console.WriteLine(s6);
                Console.WriteLine(s7);
                Console.WriteLine(s8);
                Console.WriteLine(s9);
                Console.WriteLine(s0);
                for(int )
                if (menu == "г")
                {
                    System.Environment.Exit(1);
                } //готово
            }

        }
    }
}