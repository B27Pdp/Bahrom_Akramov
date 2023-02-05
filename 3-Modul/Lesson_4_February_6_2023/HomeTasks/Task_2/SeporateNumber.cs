using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_4_February_6_2023.HomeTasks.Task_2
{
    internal class SeporateNumber
    {
        public static void Run()
        {
            string satr = "Salom Abbosali, 1234 nima 43245 gap234";
            var nums = Regex.Split(
                input: satr,
                pattern: @"\D+"
                );
            foreach (string item in nums)
            {
                if (item != "")
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
