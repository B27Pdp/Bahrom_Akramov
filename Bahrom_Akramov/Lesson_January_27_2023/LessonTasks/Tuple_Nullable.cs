using Bahrom_Akramov.Lesson_26_January_2023.HomeTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_January_27_2023.LessonTasks
{
    internal static class Tuple_Nullable
    {
        public static void tupleOne()
        {
            var t1 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            var t2 = (1, 2, 3, 4, 5, 6, 7, 8, 15,11);
            Console.WriteLine(t1);
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t1.CompareTo(t2));
        }

    }
}
