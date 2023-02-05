namespace _3_Modul.Lesson_3_February_4_2023.HomeTasks.Chat_App
{
    internal class Main_Chat
    {
        public static ContactUser contactUser = new();
        public static void MainChat()
        {
            contactUser.defaultUsers();
            Console.WriteLine("*************************************************");
            Console.WriteLine("******* \"Chatting Room\"ga hush kelibsiz *********");
            Console.WriteLine("*************************************************\n");
            Console.WriteLine(">> 1. Ro'yxatdan o'tish");
            Console.WriteLine(">> 2. Kirish");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Clear();
                Console.WriteLine("To'g'ri formatta kiriting");
                MainChat();
            }
            switch (a)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Ismingizni kiriting: ");
                        Console.Write(">> ");
                        string name = Console.ReadLine() ?? "No name";
                        Console.WriteLine("Telefon raqamingizni kiriting: ");
                        Console.Write(">> ");
                        string phone = Console.ReadLine() ?? "No phone";
                        contactUser.addNewUser(name, phone);
                        Console.Clear();
                        Console.WriteLine("Ro'yxatdan o'tish muvaffaqiyatli amalga oshirildi");
                        MainChat();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Telefon raqamingizni kiriting");
                        Console.Write(">> ");
                        string phone = Console.ReadLine() ?? "No phone";
                        if (contactUser.enterUser(phone) == 1)
                        {
                            Console.Clear();
                            Console.WriteLine($"Hush Kelibsiz");
                            StartChatting();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Siz oldin ro'yxatdan o'tishingiz kerak");
                            MainChat();
                        }
                    }
                    break;
                default:
                    Console.Clear();
                    MainChat();
                    break;
            }
        }

        public static void StartChatting()
        {
            key1:
            //ContactUser contactUser = new();
            Console.WriteLine("1. Dostlarni qidirish");
            Console.WriteLine("2. Xabarni ko'rish");
            Console.WriteLine("0. Chiqish");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Clear();
                Console.WriteLine("To'g'ri formatda kiriting");
                StartChatting();
            }
            switch (a)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Kim bilan suhbatlashmoqchisiz? ");
                        Console.Write(">> ");
                        string name = Console.ReadLine() ?? "No name";
                    key:
                        if (contactUser.chatting(name) == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Yana habar yuborasizmi?");
                            Console.Write("y / n : >> ");
                            string yn = Console.ReadLine();
                            switch (yn)
                            {
                                case "y":
                                    {
                                        Console.Clear();
                                        goto key;
                                    }
                                    break;
                                case "n":
                                    {
                                        Console.Clear();
                                        goto key1;
                                    }
                                    break;
                                default:

                                    break;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Bunday foydalanuvchi mavjud emas");
                            StartChatting();
                        }
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        contactUser.showM();
                        StartChatting();
                    }
                    break;
                case 0:
                    {
                        Console.Clear();
                        MainChat();
                    }
                    break;
                default:
                    Console.Clear();
                    MainChat();
                    break;
            }
        }

    }
}
