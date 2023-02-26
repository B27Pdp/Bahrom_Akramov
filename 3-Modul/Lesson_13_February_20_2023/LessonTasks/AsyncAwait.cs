using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_13_February_20_2023.LessonTasks
{
    internal class AsyncAwait
    {
        public static void Run()
        {
            Console.WriteLine("Run method started");
            string passId = "AB1234567";
            Task<string> iiv = IIV(passId);
            Task<string> passTab = PasspordTable(passId);
            //Task.Run(async delegate
            //{
            //    await PrintTaskMethod();
            //}).Wait();
            Task.Run(() =>
            {
                Console.WriteLine(iiv.Result);
            });
            Task.Run(() =>
            {
                Console.WriteLine(passTab.Result);
            });
            Console.WriteLine("Run method finished");
            Console.ReadKey();
        }

        async static Task<string> IIV(string passpord)
        {
            Task<string> yuborish = new(() =>
            {
                Task.Delay(5000).Wait();
                return $"IIV {passpord}";
            });
            yuborish.Start();
            Console.WriteLine("IIV ga so'rov yuborildi");
            return await yuborish;
        }
        async static Task<string> PasspordTable(string passpord)
        {
            Task<string> yuborish = new(() =>
            {
                Task.Delay(3000).Wait();
                return $"Passposrd Id {passpord}";
            });
            yuborish.Start();
            Console.WriteLine("PasspordTable ga so'rov yuborildi");
            return await yuborish;
        }

        static Task<string> StringTask()
        {
            Task<string> stringName = new(() =>
            {
                Console.WriteLine("Salom");
                return "stringName";
            });
            stringName.Start();
            return stringName;
        }

        async static Task PrintTaskMethod()
        {
            Console.WriteLine("PrintTaskMethod started");
            Console.WriteLine(DateTime.Now.ToString());
            string s = await PrintVoidMethod();
            Console.WriteLine(s);
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("PrintTaskMethod finished");
        }

        async static Task<string> PrintVoidMethod()
        {
            Console.WriteLine("PrintVoidMethod started");
            await Task.Delay(2000);
            Console.WriteLine("PrintVoidMethod finished");
            return "Ishim tugadi";
        }
    }
}
