using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_4_February_6_2023.HomeTasks.Task_1
{
    internal class RegexClass
    {
        public static void Run()
        {
            List<string> list = new List<string>() { "Bahrom", "Sobir", "Abbos", "Sassiq", "salim" };
            foreach (string item in list)
            {
                if (Regex.IsMatch(item.ToUpper(), "^S"))
                {
                    Console.Write(item +", ");
                }
            }
        }
    }
}
