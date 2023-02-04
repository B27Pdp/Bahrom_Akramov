using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_Modul.Lesson_2_February_3_2023.Delegates;

namespace _3_Modul.Lesson_2_February_3_2023.LessonTasks
{
    internal class AnonymDelegate
    {
        public void anonymDel()
        {
            anonymDelegate aninymD = delegate (int a, int b)
            {
                Console.WriteLine(a * b);
            };

            aninymD += (a, b) =>
            {
                Console.WriteLine(a+b);
            };

            aninymD(5, 15);
        }
        
    }
}
