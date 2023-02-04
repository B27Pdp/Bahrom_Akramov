using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_2_February_3_2023.LessonTasks
{
    internal class ActionDel
    {
        public void actionDel()
        {
            Action action = () =>Console.WriteLine("Salom parametrsiz Action");
            //action();

            Action func = () =>
            {
                Console.WriteLine($"Bu Function parametrsiz");
            };

            func += action;
            func();
            
        }
        
    }
}
