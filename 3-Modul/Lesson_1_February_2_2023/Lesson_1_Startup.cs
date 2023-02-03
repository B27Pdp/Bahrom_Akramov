using _3_Modul.Lesson_1_February_2_2023.HomeTasks;
using _3_Modul.Lesson_1_February_2_2023.HomeTasks.Task2;
using _3_Modul.Lesson_1_February_2_2023.LessonTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_Modul.Lesson_1_February_2_2023.HomeTasks.Delegates;
using static _3_Modul.Lesson_1_February_2_2023.HomeTasks.Delegates;
using static _3_Modul.Lesson_1_February_2_2023.LessonTasks.Delegates;

namespace _3_Modul.Lesson_1_February_2_2023
{
    internal static class Lesson_1_Startup
    {
        public static void Start()
        {
            //ExampleDelegateWithDelegate pointer = Delegate_Class.PrintConsole;
            //public static void PrintConsole(Delegate example)
            //public delegate void ExampleDelegateWithDelegate(Delegate @delegate);
            //Example_Class.PrintWithParametr(51, 15, Delegate_Class.PrintConsole);

            Mathematics math = new();
            Mathematic mathematic = math.sum;
            mathematic += math.substract;
            mathematic += math.multiply;
            mathematic += math.devide;
            mathematic.Invoke(15, 25);

            //MinMaxList<int> minMaxList = new(); 
            List<int> list = new List<int> { 2, 5, 4, 9, 1, 4, 8, 7 };
            MinAndMaxValues pointer = MinMaxList<int>.minAndMax;
            Console.WriteLine("\nEng katta va Eng kichik elementlar => " + pointer.Invoke(list));
        }
    }
}
