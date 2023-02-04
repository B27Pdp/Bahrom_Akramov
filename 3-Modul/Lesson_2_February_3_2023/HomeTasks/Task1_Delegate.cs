using _3_Modul.Lesson_1_February_2_2023.LessonTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_2_February_3_2023.HomeTasks
{
    internal class Task1
    {
        public delegate void DelegateName(List<int> list);
        
        public delegate void DelegatePustoy();

        public delegate void DelegateTwo(List<int> list, DelegatePustoy d);

        public static void ExampleName(List<int> list)
        {
            var sum = list.Sum();
            Console.WriteLine(sum);

        }

        public static void actionMethod()
        {
            List<int> list = new List<int>() { -1, -5, 7, -8, 6, -3, 12 };
            Action<List<int>> action = list =>
            {
                var a = list.FindAll(x => x > 0);
                foreach (var item in a)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            };
            action.Invoke(list);
        }

        public static void Mixer(List<int> list, DelegatePustoy d)
        {
            var a = list.FirstOrDefault(x => (x % 2 == 0 && x % 3 == 0));
            Console.WriteLine(a);
            d.Invoke();
        }
        

        public void printInfo()
        {
            List<int> list = new List<int>() { 1, 5, 7, 8, 6, 3, 12 };
            DelegateName name = ExampleName;
            name.Invoke(list);

            DelegatePustoy pustoy = actionMethod;
            pustoy.Invoke();

            DelegateTwo two = Mixer;
            two.Invoke(list, pustoy);
        }
    }
}
