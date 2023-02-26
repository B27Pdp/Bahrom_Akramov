using _3_Modul.Lesson_12_February_16_2023.HomeTasks.Threads.CRUD;
using _3_Modul.Lesson_12_February_16_2023.HomeTasks.Threads.Xml_Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_12_February_16_2023.HomeTasks.Threads
{
   public class Test
    {
        static Json_CRUD_Class json_CRUD_Class = new();
        static Xml_CRUD_Class xml_CRUD_Class = new();
        static readonly object LockMethod = new();
        public static void Run()
        {
            Console.WriteLine("1. User qo'shish");
            Console.WriteLine("2. Userlarni ko'rish");
            Console.WriteLine("3. Userni Tahrirlash");
            Console.WriteLine("4. Userni O'chirish");
            Console.WriteLine("5. Chiqish");
            if (!int.TryParse(Console.ReadLine(), out int choose))
            {
                Console.Clear();
                Console.WriteLine("To'g'ri formatda kiriting\n");
                Run();
            }
            switch (choose)
            {
                case 1:
                    {
                        AddUsers();
                    }
                    break;
                case 2:
                    {

                    }
                    break;
                case 3:
                    {

                    }
                    break;
                case 4:
                    {

                    }
                    break;
                case 5:
                    {

                    }
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Noto'g'ri kiritildi, qaytadan kiriting\n");
                        Run();
                    }
                    break;
            }
        }
        
        public static void AddUsers()
        {
            Console.WriteLine("\nUsername kiriting: ");
            Console.Write(">> ");
            string userName = Console.ReadLine() ?? "No Name";
            Console.WriteLine("Passwordni kiriting: ");
            Console.Write(">> ");
            string? pass = Console.ReadLine();
            Console.WriteLine("Emailni kiriting: ");
            Console.Write(">> ");
            string email = Console.ReadLine() ?? "No Email";
            Console.WriteLine("Phone numberni kiriting: ");
            Console.Write(">> ");
            string? phone = Console.ReadLine();
            User user = new()
            {
                UserName = userName,
                Password = pass,
                Email = email,
                PhoneNumber = phone
            };

            Thread threadJson = new Thread(AddJson);
            Thread threadXml = new Thread(AddXml);

            threadJson.Start();
            threadXml.Start();

            
            void AddJson()
            {
                lock(LockMethod)
                {
                    json_CRUD_Class.AddUser(user);
                    Thread.Sleep(1000);
                }
            }
            void AddXml()
            {
                lock(LockMethod)
                {
                    xml_CRUD_Class.AddUser(user);
                    Thread.Sleep(1000);
                }
            }
        }

    }
}
