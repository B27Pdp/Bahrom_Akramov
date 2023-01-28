using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_January_27_2023.HomeTasks
{
    internal static class PrintDict
    {
        public static void PrintDictionary<T, U>(Dictionary<T, U> dict)
        {
            foreach  (KeyValuePair<T, U> item in dict)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}
