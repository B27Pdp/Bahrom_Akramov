using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_13_February_20_2023.HomeTasks
{
    internal class Task_1
    {
        public static void Run()
        {
            Console.WriteLine("Run method started...");
            SomeMethod();
            Console.WriteLine("Run method finished...");
            Console.ReadKey();
        }

        public async static void SomeMethod()
        {
            Console.WriteLine("SomeMethod started...");
            await Wait();
            Console.WriteLine("SomeMethod finished...");
        }

        private async static Task Wait()
        {
            await Task.Delay(2000);
            Console.WriteLine("\n2 Seconds wait compleated");
        }
    }
}
