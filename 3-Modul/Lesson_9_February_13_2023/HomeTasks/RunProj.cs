using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_9_February_13_2023.HomeTasks
{
    internal class RunProj
    {
        public static void Run()
        {
            Console.WriteLine("Enter Id: ");
            Console.Write(">> ");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Author: ");
            Console.Write(">> ");
            string? author = Console.ReadLine();
            Console.WriteLine("Enter Title: ");
            Console.Write(">> ");
            string? title = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            Console.Write(">> ");
            int price = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Description: ");
            Console.Write(">> ");
            string? description = Console.ReadLine();
            Xml_Class.AddElementToXml(id, author, title, price, description);

        }
    }
}
