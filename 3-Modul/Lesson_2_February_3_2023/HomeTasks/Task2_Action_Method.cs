using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_2_February_3_2023.HomeTasks
{
    internal class Task2_Action_Method
    {
        public static void start()
        {
            Action action = () =>
            {
                Console.WriteLine("Empty Action Method");
            };
            action.Invoke();

            Action<int, string, Action> action2 = (age, name, act) =>
            {
                Console.WriteLine($"{name} {age}");
                act.Invoke();
            };
            action2.Invoke(24, "Bahrom", action);
        }
    }
}
