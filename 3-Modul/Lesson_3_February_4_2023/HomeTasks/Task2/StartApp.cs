using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3_February_4_2023.HomeTasks.Task2
{
    internal class StartApp
    {
        public static CreateCard createCard = new CreateCard();
        public static void Run()
        {
            createCard.addCard();
            Console.WriteLine("------Pay_me------");
            Console.WriteLine("1. Pul o'tkazish");
            Console.WriteLine("2. Hisobni ko'rish");
            Console.WriteLine("3. Karta qo'shish");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Clear();
                Console.WriteLine("To'g'ri formatda kiriting");
                Run();
            }
            else
            {
                switch (a)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Chiquvchi karta idsini kiriting: ");
                            Console.Write(">> ");
                            if (!int.TryParse(Console.ReadLine(), out int id1))
                            {
                                Console.Clear();
                                Console.WriteLine("To'g'ri formatda kiriting");
                                Run();
                            }
                            Console.WriteLine("Kiruvchi karta idsini kiriting: ");
                            Console.Write(">> ");
                            if (!int.TryParse(Console.ReadLine(), out int id2)) 
                            {
                                Console.Clear();
                                Console.WriteLine("To'g'ri formatda kiriting");
                                Run();
                            }
                            Console.WriteLine("Summani kiriting: ");
                            Console.Write(">> ");
                            if (!int.TryParse(Console.ReadLine(), out int summa))
                            {
                                Console.Clear();
                                Console.WriteLine("To'g'ri formatda kiriting");
                                Run();
                            }
                            createCard.transferMoney(id1, id2, summa);
                            Console.Clear();
                            Console.WriteLine("Pul muvaffaqiyatli o'tkazildi");
                            Run();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Karta idsini kiriting: ");
                            Console.Write(">> ");
                            if (!int.TryParse(Console.ReadLine(), out int id))
                            {
                                Console.Clear();
                                Console.WriteLine("To'g'ri formatda kiriting");
                                Run();
                            }
                            Console.Clear();
                            createCard.ShowBalance(id);
                            Run();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Carta ID sini kiriting:");
                            Console.Write(">> ");
                            int id = int.Parse(Console.ReadLine()!);
                            Console.WriteLine("Carta egasi ismini kiriting:");
                            Console.Write(">> ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Cartadagi summani kiriting:");
                            Console.Write(">> ");
                            int summa = int.Parse(Console.ReadLine()!);
                            Console.WriteLine("Carta turini kiriting:");
                            Console.Write(">> ");
                            int cardtype;
                            while (!int.TryParse(Console.ReadLine(), out  cardtype))
                            { Console.WriteLine("Togri kiritilmadi qaytadan kiriting:"); }
                            CardType type=(CardType)cardtype;
                            
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("To'g'ri formatda kiriting");
                        Run();
                        break;
                }
            }

        }
    }
}
