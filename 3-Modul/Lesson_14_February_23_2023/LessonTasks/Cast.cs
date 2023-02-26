using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_14_February_23_2023.LessonTasks
{
    internal class Cast
    {
        public static void Run()
        {
            ArrayList list = new ArrayList { 10, 20, 30 };
            IEnumerable<int> result = list.Cast<int>();
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("#_______#_______#_______#");
            list.Add("40");
            list = null;
            IEnumerable<int> res = list.Cast<int>();
            foreach (var item in res)
            {
                Console.Write(item + " ");
            }
        }
    }
}
