using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_January_27_2023.HomeTasks
{
    internal static class LastItem
    {
        public static void lastItem<T>(T[] array)
        {
            Console.WriteLine(array.Last());
        }
    }
}
