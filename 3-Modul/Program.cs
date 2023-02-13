using _3_Modul.Lesson_1_February_2_2023;
using _3_Modul.Lesson_2_February_3_2023;
using _3_Modul.Lesson_3_February_4_2023;
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

            Lesson_2_Startup.Start();


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