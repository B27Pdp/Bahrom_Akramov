using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_2_February_3_2023.HomeTasks
{
    internal class PredicateExample
    {
        public void start()
        {
            Predicate<int> number = s => s.Equals(5);

            List<int> list = new() { 1, 5, 6, 5, 2, 5 };

            List<int> a = list.FindAll(number);

            Console.WriteLine($"5 ga teng qiymatlar soni = {a.Count}");
        }
    }
}
