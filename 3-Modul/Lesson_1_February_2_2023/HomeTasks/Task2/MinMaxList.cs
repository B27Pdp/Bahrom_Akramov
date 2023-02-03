using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_1_February_2_2023.HomeTasks.Task2
{
    internal static class MinMaxList<T>
    {
        public static Tuple<T, T> minAndMax(List<T> list)
        {
            T? min = list.Min();
            T? max = list.Max();
            var tuple = Tuple.Create(min, max);
            //Tuple<T, T> tuple = new Tuple<T, T>(min, max);
            return tuple;
        }
    }
}
