using _3_Modul.Lesson_1_February_2_2023;
using _3_Modul.Lesson_2_February_3_2023;
using _3_Modul.Lesson_3_February_4_2023;
using _3_Modul.Lesson_4_February_6_2023;
using _3_Modul.Lesson_5_February_7_2023;
using _3_Modul.Lesson_6_February_8_2023;
using _3_Modul.Lesson_8_February_10_2023;
using _3_Modul.Lesson_8_February_10_2023.LessonTasks;
using System;
using System.Text.RegularExpressions;

namespace _3_Modul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer.playMusic("ptr.wav");

            Console.WriteLine("<==== W E L K O M E ====>");
            Console.WriteLine();
            TimeSpan timeSpan = new TimeSpan(0, 0, 1);
            Thread.Sleep(timeSpan);
            int threeTime = 0;
            while (threeTime < 3)
            {
                Console.Clear();
                Console.WriteLine("<==== W E L K O M E ====>");
                //Thread.Sleep(timeSpan);
                Console.Write("\n.");
                Thread.Sleep(timeSpan);
                Console.Write(".");
                Thread.Sleep(timeSpan);
                Console.Write(".");
                Thread.Sleep(timeSpan);
                threeTime++;
            }


            //Lesson_1_Startup.Start();

            //Lesson_2_Startup.Start();

            //Lesson_3_Startup.Start();

            //Lesson_4_Sturtup.Run();

            //Lesson_5_Startup.Run();

            //Lesson_6_Sturtup.Run();

            Lesson_8_Startup.Run();








            //var ts1 = TimeSpan.FromDays(2.7);
            //Console.WriteLine(ts1);
            //TimeSpan timeSpan = new TimeSpan(0, 0, 3);
            //Thread.Sleep(timeSpan);
            //var ts2 = TimeSpan.FromHours(4.5);
            //Console.WriteLine(ts2);

            //var ts3 = TimeSpan.FromMinutes(12.5);
            //Console.WriteLine(ts3);

            //var res = ts1 + ts2 + ts3;
            //Console.WriteLine(res);

            //Console.WriteLine(doubleSwap("aaaaabbbbbccc", 'a', 'c'));




            /*
            //string satr = File.ReadAllText("text.txt");
            //string satr = "     salom     as     dallllll    helll ooooo   ";
            //Console.WriteLine(satr);
            //satr.Last();



            //string InputString = Console.ReadLine() ?? "salom";
            //Console.WriteLine(Regex.IsMatch(InputString, "^[a-g]{1,3}$"));


            //List<char> list = new List<char>() { 'a', 'd', 'r', 'w' };
            //Console.WriteLine(list);
            //string s = "fdcqkmxwholhytmhafpesaentdvxginrjlyqzyhehybknvdmfrfvtbsovjbdhevlfxpdaovjgunjqlimjkfnqcqnajmebeddqsgl";
            //Console.WriteLine(s.Length);
            */
        }

        public static string doubleSwap(string satr, char a, char b)
        {
            List<char> charList = new List<char>(satr);
            for (int i = 0; i < charList.Count; i++)
            {
                if (charList[i] == a)
                    charList[i] = b;

                else if (charList[i] == b)
                    charList[i] = a;
            }
            return string.Join("", charList);
        }
    }
}