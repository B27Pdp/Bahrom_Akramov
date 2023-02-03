using static _3_Modul.Lesson_1_February_2_2023.LessonTasks.Delegates;

namespace _3_Modul.Lesson_1_February_2_2023.LessonTasks
{
    internal class Delegate_Class
    {
        public static void PrintError() 
        { 
            Console.WriteLine("PrintError() Chaqirganakansiz"); 
        }
        public static void PrintConsole(ExampleDelegate example)
        {
            Console.WriteLine("PrintConsole() ishga tushdi, PrintError() ni chaqir");
            example();
        }

    }
}
