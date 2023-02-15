using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_10_February_14_2023.HomeTasks
{
    internal class RunProjCrud
    {
        static CrudClass crudClass = new();
        public static void Run()
        {
            Console.WriteLine("<===================>");
            Console.WriteLine("<1. Add user========>");
            Console.WriteLine("<2. Show users======>");
            Console.WriteLine("<3. Update user=====>");
            Console.WriteLine("<4. Delete user=====>");
            Console.WriteLine("<===================>");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int chooseOne))
            {
                Console.Clear();
                Console.WriteLine("To'g'ri formatda kiriting");
                Run();
            }
            switch (chooseOne)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Id ni kiriting: ");
                        Console.Write(">> ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.Clear();
                            Console.WriteLine("To'g'ri formatda kiriting");
                            Run();
                        }
                        Console.WriteLine("F.I.O ni kiriting: ");
                        Console.Write(">> ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Address ni kiriting: ");
                        Console.Write(">> ");
                        string address = Console.ReadLine();
                        Console.WriteLine("Email ni kiriting: ");
                        Console.Write(">> ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Telefon nomerni kiriting: ");
                        Console.Write(">> ");
                        string phone = Console.ReadLine();
                        Person person = new(id, name, address, email, phone);
                        crudClass.CreateJson(person);
                        Console.Clear();
                        Run();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        crudClass.ShowAllUsers();
                        Console.ReadKey();
                        Console.Clear();
                        Run();
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Id ni kiriting: ");
                        Console.Write(">> ");
                        if (!int.TryParse(Console.ReadLine(), out int upId))
                        {
                            Console.Clear();
                            Console.WriteLine("To'g'ri formatda kiriting");
                            Run();
                        }
                        Console.Clear();
                        crudClass.UpdateJsonById(upId);
                        Run();
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Id ni kiriting: ");
                        Console.Write(">> ");
                        if (!int.TryParse(Console.ReadLine(), out int delId))
                        {
                            Console.Clear();
                            Console.WriteLine("To'g'ri formatda kiriting");
                            Run();
                        }
                        Console.Clear();
                        crudClass.DeleteJsonById(delId);
                        Run();
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        Run();
                    }
                    break;
            }
        }
    }
}
