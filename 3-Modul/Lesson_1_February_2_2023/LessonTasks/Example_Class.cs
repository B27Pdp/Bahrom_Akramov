using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_Modul.Lesson_1_February_2_2023.LessonTasks.Delegates;

namespace _3_Modul.Lesson_1_February_2_2023.LessonTasks
{
    internal class Example_Class
    {
        public static void PrintWithParametr(int a, int b, ExampleDelegateWithDelegate exam)
        {
            Console.WriteLine($"PrintWithParametr({a+b}, PrintConsole() ni chaqir)");
            //exam();
            //exam += Delegate_Class.PrintError;
            //exam();
        }

        
    }
}
