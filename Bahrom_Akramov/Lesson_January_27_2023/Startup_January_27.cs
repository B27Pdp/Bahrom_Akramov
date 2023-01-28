using Bahrom_Akramov.Lesson_January_27_2023.HomeTasks;
using Bahrom_Akramov.Lesson_January_27_2023.HomeTasks.Dictionary;
using Bahrom_Akramov.Lesson_January_27_2023.LessonTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_January_27_2023
{
    internal class Startup_January_27
    {
        public static void T_N()
        {
            //Tuple_Nullable.tupleOne();
            Dictionary<int, int> dict1 = new() { { 1, 111 }, { 2, 222 } };
            PrintDict.PrintDictionary(dict1);

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            LastItem.lastItem(array);

            TripleDictionary<int, Person, Person> triple = new();
            List<int> ints = new List<int> { 8, 2, 96, 6, 4, 5, 7, 12 };
            Console.WriteLine(triple.OrderByDesc(ints));


        }

    }
}
