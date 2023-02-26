using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_12_February_16_2023.HomeTasks.Threads
{
    internal class ThreadExample
    {
        static object lock1 = new object();
        public static void Run()
        {
            
            Console.WriteLine("Starting point...");
             
            Thread countDownThread = new Thread(() => CountDown("Count Down"));
            Thread countUpThread = new Thread(() => CountDown("Count Up"));

            countDownThread.Start();
            //countDownThread.Join();
            countUpThread.Start();

            Console.WriteLine("Main thread has finished");

        }

        static void CountDown(string name)
        {
            
            lock (lock1)
            {
                for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{name} {i}");
                Thread.Sleep(50);
            }
            }
            Console.WriteLine($"{name} has finished");
        }

        static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{name} {i}");
                Thread.Sleep(50);
            }
            Console.WriteLine($"{name} has finished");
        }

    }
}