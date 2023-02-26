using _3_Modul.Lesson_10_February_14_2023;
using _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Classes;
using _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Enumlar;
using _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Serializing_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Person = _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Classes.Person;

namespace _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka
{
    internal class RunClass
    {
        public static void Run()
        {
            Task.Run(() =>
            {
                Parallel.Invoke(
                    ClassSerializing.IIVSerializing,
                    ClassSerializing.DSQSerializing,
                    ClassSerializing.CostumerSerializing,
                    ClassSerializing.ProductSerializing
                );
            });

            Console.WriteLine("1. Kirish");
            Console.WriteLine("2. Ro'yxatdan o'tish");
            Console.WriteLine("3. Davlat xizmatlari");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int chooseOne))
            {
                Console.Clear();
                Run();
            }
            switch (chooseOne)
            {
                case 1:
                    {
                        Console.Clear();
                        Kirish();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        RoyxatdanOtish();
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        DavlatXizmatlari();
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
        public static async void Kirish()
        {
            Console.WriteLine("Emailni kiriting:");
            Console.Write(">> ");
            string? email = Console.ReadLine() ?? "No Email";
            Console.WriteLine("Parolni kiriting:");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int pass))
            {
                Console.Clear();
                Run();
            }
            bool boolEmailAndPass = await MainClass.FindEmailAnsPass(email, pass);
            if (!boolEmailAndPass)
            {

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Email yoki Parol xato");
                Run();
            }
        }
        public static async void RoyxatdanOtish()
        {
            Console.WriteLine("PassportId kiriting: ");
            Console.Write(">> ");
            string passId = Console.ReadLine() ?? "No PassportId";
            Task<Classes.Person> task = MainClass.IIVPerson(passId);
            Classes.Person person = await task;
            if (person != null)
            {
                Console.WriteLine("CardId kiriting: ");
                Console.Write(">> ");
                string cardId = Console.ReadLine() ?? "No PassportId";
                Card card = await MainClass.FindCard(cardId);
                if (card != null)
                {
                keyEmail:
                    Console.WriteLine("Email kiriting: ");
                    Console.Write(">> ");
                    string email = Console.ReadLine() ?? "No Email";
                    Console.WriteLine("Password kiriting: ");
                    Console.Write(">> ");
                    if (!int.TryParse(Console.ReadLine(), out int pass))
                    {
                        Console.Clear();
                        Run();
                    }
                    bool boolEmail = await MainClass.FindEmail(email);
                    if (boolEmail)
                    {
                        Costumer costumer = new()
                        {
                            Person = person,
                            Card = card,
                            Email = email,
                            Password = pass
                        };
                        ClassSerializing.AddCostumer(costumer);
                        Console.Clear();
                        Console.WriteLine("Ro'yxatdan o'tish muvaffaqiyatli amalga oshirildi");
                        Run();
                    }
                    else
                    {
                        Console.WriteLine("Bunday email allaqachon mavjud");
                        Console.WriteLine("Qaytadan kiritasizmi?");
                        Console.WriteLine("1. Ha");
                        Console.WriteLine("2. Yo'q");
                        Console.Write(">> ");
                        if (!int.TryParse(Console.ReadLine(), out int YesNo))
                        {
                            Console.Clear();
                            Run();
                        }
                        switch (YesNo)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    goto keyEmail;
                                }
                            case 2:
                                {
                                    Console.Clear();
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
                else
                {
                    Console.Clear();
                    Console.WriteLine("Bunday Card mavjud emas");
                    Run();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bunday Card mavjud emas");
                Run();
            }
        }

        public static void DavlatXizmatlari()
        {
            Console.WriteLine("1. Passport olish");
            Console.WriteLine("2. Ishga joylashish");
            if (!int.TryParse(Console.ReadLine(), out int chooseTwo))
            {
                Console.Clear();
                Run();
            }
            switch (chooseTwo)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Id kiriting: ");
                        Console.Write(">> ");
                        if (!int.TryParse(Console.ReadLine(), out int enId))
                        {
                            Console.Clear();
                            Run();
                        }
                        Console.WriteLine("Name kiriting: ");
                        Console.Write(">> ");
                        string name = Console.ReadLine() ?? "No Name";
                        Console.WriteLine("PassportId kiriting: ");
                        Console.Write(">> ");
                        string passId = Console.ReadLine() ?? "No PassportId";
                        Console.WriteLine("Uylanganmisiz? ");
                        Console.WriteLine("1. Ha");
                        Console.WriteLine("2. Yo'q");
                        Console.Write(">> ");
                        if (!int.TryParse(Console.ReadLine(), out int isMarried))
                        {
                            Console.Clear();
                            Run();
                        }
                        bool married = false;
                        switch (isMarried)
                        {
                            case 1:
                                {
                                    married = true;
                                }
                                break;
                            case 2:
                                {
                                    married = false;
                                }
                                break;
                            default:
                                Console.Clear();
                                Run();
                                break;
                        }
                        ClassSerializing.AddPerson(new Classes.Person()
                        {
                            Id = enId,
                            Name = name,
                            PassportId = passId,
                            IsMarried = married
                        });
                        Console.Clear();
                        Console.WriteLine("Passport olindi");
                        Run();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("PassportId kiriting: ");
                        Console.Write(">> ");
                        string passId = Console.ReadLine() ?? "No PassportId";
                        var empPassId = ClassSerializing.EmployeeList.FirstOrDefault(x => x.Person.PassportId == passId);
                        if (empPassId?.Workplace == null)
                        {
                            Console.WriteLine("Ish joyini tanlang: ");
                            Console.WriteLine("1. PDP");
                            Console.WriteLine("2. Najot Talim");
                            Console.WriteLine("3. TATU");
                            Console.WriteLine("4. GITA");
                            Console.Write(">> ");
                            if (!int.TryParse(Console.ReadLine(), out int choosEnum))
                            {
                                Console.Clear();
                                Run();
                            }
                            switch (choosEnum)
                            {
                                case 1:
                                    {
                                        empPassId.Workplace = WorkPlase.PDP;
                                    }
                                    break;
                                case 2:
                                    {
                                        empPassId.Workplace = WorkPlase.Najot_Talim;
                                    }
                                    break;
                                case 3:
                                    {
                                        empPassId.Workplace = WorkPlase.TATU;
                                    }
                                    break;
                                case 4:
                                    {
                                        empPassId.Workplace = WorkPlase.GITA;
                                    }
                                    break;
                                default:
                                    {
                                        Console.Clear();
                                        Run();
                                    }
                                    break;
                            }
                            Console.WriteLine("Maoshni kiriting: ");
                            if (!double.TryParse(Console.ReadLine(), out double maosh))
                            {
                                Console.Clear();
                                Run();
                            }
                            empPassId.Salary = maosh;
                            MainClass.Employment(empPassId);
                            Console.Clear();
                            Console.WriteLine("Siz ishga Muvaffaqiyatli joylandingiz");
                            Run();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Siz {empPassId.Workplace} da ishlaysiz");
                            Run();
                        }
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
