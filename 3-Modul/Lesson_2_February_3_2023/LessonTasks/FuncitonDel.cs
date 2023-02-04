using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_2_February_3_2023.LessonTasks
{
    internal class FuncitonDel
    {
        public void funcDel()
        {
            Func<string> func = () =>
            {
                return $"Bu Function parametrsiz";
            };
            Console.WriteLine(func());
        }
        
    }
}
