using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_2_February_3_2023.HomeTasks
{
    internal class Task_3_Function
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

            Func<int, int> func = (x) =>
            {
                Console.WriteLine(x * x);
                return x * x;
            };

            Func<Func<int, int>, Action<int, string, Action>, string> GetFunc = (funcName, actName) =>
            {
                funcName.Invoke(5);
                actName.Invoke(15, "NoName", action);
                return "Tugadi";
            };

            GetFunc.Invoke(func, action2);
        }

        
    }
}
