using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_14_February_23_2023.LessonTasks
{
    internal class Prepend
    {
        public static void Run()
        {
            List<int> ints = new List<int> { 10, 20, 30, 40 };
            List<int> newInts = ints.Prepend(50).ToList();
            Console.WriteLine(string.Join(", ", newInts));

            Console.WriteLine("\n\n#_________#_________#__________#\n\n");

            int[] numbers = { 1, 2, 3, 4 };
            var modifiedNumbers = new int[] { 0, -1 }.Concat(numbers);

            foreach (int n in modifiedNumbers)
            {
                Console.Write(n + ", ");
            }

            Console.WriteLine("\n\n#_________#_________#__________#\n\n");

            List<string> names = new List<string>() { "John", "Mike", "Sarah" };
            var newNames = new List<string>() { "Emily", "Chris" }.Concat(names);
            var newNames1 = names.Prepend("Emily");

            foreach (string n in newNames)
            {
                Console.Write(n + ", ");
            }

            Console.WriteLine("\n\n#_________#_________#__________#\n\n");

            foreach (string n in newNames1)
            {
                Console.Write(n + ", ");
            }

            Console.WriteLine("\n\n#_________#_________#__________#\n\n");
        }
        
    }
}
