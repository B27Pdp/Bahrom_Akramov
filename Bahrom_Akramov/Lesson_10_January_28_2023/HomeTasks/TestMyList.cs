namespace Bahrom_Akramov.Lesson_10_January_28_2023.HomeTasks
{
    internal class TestMyList
    {
        public static void StartTestMyList()
        {
            MyListCollection<int> myListCollection = new MyListCollection<int>();
            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("---------M E N U------------------------");
                Console.WriteLine("----1 => Qo'shish-----------------------");
                Console.WriteLine("----2 => O'chirish----------------------");
                Console.WriteLine("----3 => Ekranga chiqarish--------------");
                Console.WriteLine("----4 => O'zgartirish-------------------");
                Console.WriteLine("----5 => Element borligini tekshirish---\n");
                Console.Write("Tanlang : ");
                string? choose = Console.ReadLine();
                if (byte.TryParse(choose, out byte choosen))
                {
                    switch (choosen)
                    {
                        case 1:
                            Qoshish();
                            break;
                        case 2:
                            Ochirish();
                            break;
                        case 3:
                            EkrangaChiqarish();
                            break;
                        case 4:
                            Ozgartirish();
                            break;
                        case 5:
                            ElementniTekshirish();
                            break;
                        default:
                            repeat = false;
                            break;
                    }
                }
                else
                {
                    repeat = false;
                }

                void Qoshish()
                {
                    bool add = true;
                    int counter = 0;
                    do
                    {
                        Console.Clear();
                        myListCollection.GetListInfo();
                        string s = counter == 0 ? "Elementni kiriting: " :
                            counter == 1 ? "Element qo'shildi, yangi element kiriting: " :
                            "Element qo'shilmadi, boshqa element kiriting: ";
                        Console.WriteLine(s);
                        if (int.TryParse(Console.ReadLine(), out int qiymat))
                        {
                            if (!myListCollection.list.Contains(qiymat))
                            {
                                myListCollection.Add(qiymat);
                                counter = 1;
                            }
                            else
                            {
                                Console.WriteLine("Bunday element mavjud, yana qo'shishni hohlaysizmi?");
                                Console.Write("y / n : ");
                                string? yn = Console.ReadLine();
                                switch (yn)
                                {
                                    case "y":
                                        myListCollection.Add(qiymat);
                                        counter = 1;
                                        break;
                                    case "n":
                                        counter = 2;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        else
                        {
                            add = false;
                        }
                    } while (add);
                }

                void Ochirish()
                {
                    Console.Clear();
                    bool add = true;
                    int counter = 0;
                    if (myListCollection.list.Count != 0)
                    {
                        do
                        {
                            if (myListCollection.list.Count != 0)
                            {
                                Console.Clear();
                                myListCollection.GetListInfo();
                                string s = counter == 0 ? "Qaysi elementni o'chirmoqchisiz? : " :
                                    counter == 1 ? "Element o'chirildi, yana o'chirmoqchi bo'lgan qiymatizni kiriting: " :
                                    "O'chirmoqchi bo'lgan elementizni kiriting: ";
                                Console.WriteLine(s);
                                if (int.TryParse(Console.ReadLine(), out int qiymat))
                                {
                                    if (myListCollection.list.Contains(qiymat))
                                    {
                                        int isHaving = qiymat;
                                        string ss = "";
                                        List<int> junkList = new List<int>(myListCollection.list);
                                        for (int i = 0; i < junkList.Count;)
                                        {
                                            if (junkList.Contains(isHaving))
                                            {
                                                i = junkList.IndexOf(isHaving);
                                                junkList[i] = isHaving + 1;
                                                ss += i + " - ";
                                                i++;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        if (ss.Length > 4)
                                        {
                                            int countIndex = 0;
                                            bool isTrueIndex = true;
                                            Console.WriteLine($"Kiritilgan element Listdan {ss}indexlarda topildi qaysi birini o'chirishni istaysiz?");
                                            do
                                            {
                                                Console.Write(countIndex == 0 ? "Indexni tanlang: " : "Noto'g'ri kiritdingiz qaytadan kiriting: ");
                                                string? sIndex = Console.ReadLine();
                                                if (ss.Contains(sIndex!))
                                                {
                                                    myListCollection.list.RemoveAt(Convert.ToInt32(sIndex));
                                                    isTrueIndex = false;
                                                }
                                                else
                                                {
                                                    countIndex = 1;
                                                }
                                            } while (isTrueIndex);
                                        }
                                        else
                                        {
                                            myListCollection.Delete(qiymat);
                                            counter = 1;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kiritilgan element listdan topilmadi, qo'shishni hohlaysizmi?");
                                        Console.Write("y / n : ");
                                        string? yn = Console.ReadLine();
                                        switch (yn)
                                        {
                                            case "y":
                                                myListCollection.Add(qiymat);
                                                counter = 1;
                                                break;
                                            case "n":
                                                counter = 2;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    add = false;
                                }
                            }
                            else
                            {
                                add = false;
                            }
                        } while (add);
                    }
                    else
                    {
                        Console.WriteLine("Listda element mavju emas.");
                        //Console.WriteLine("Menyuga qaytish uchun istalgan tugmani bosing : ");
                        Console.ReadKey();
                    }
                }

                void EkrangaChiqarish()
                {
                    Console.Clear();
                    if (myListCollection.list.Count != 0)
                    {
                        myListCollection.GetListInfo();
                        Console.WriteLine($"Listda {myListCollection.list.Count} ta element mavjud");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Listda element mavjud emas.");
                        Console.ReadKey();
                    }
                }

                void Ozgartirish()
                {
                    Console.Clear();
                    bool add = true;
                    int counter = 0;
                    if (myListCollection.list.Count != 0)
                    {
                        do
                        {
                            if (myListCollection.list.Count != 0)
                            {
                                Console.Clear();
                                myListCollection.GetListInfo();
                                string s = counter == 0 ? "Qaysi elementni o'zgartirmoqchisiz,\nIndexini kiriting: " :
                                    counter == 1 ? "eElement o'zgartirildi,\nO'zgarishi kerak bo'lgan element indexini kiriting: " :
                                    "O'zgarishi kerak bo'lgan element indexini kiriting: ";
                                Console.Write(s);
                                string? indexItem = Console.ReadLine();
                                Console.Write("Yangi element: ");
                                string? newItem = Console.ReadLine();
                                if (int.TryParse(indexItem, out int indexItemResult) && int.TryParse(newItem, out int newItemResult))
                                {
                                    if (myListCollection.list.Count > indexItemResult)
                                    {
                                        myListCollection.ChengeItem(Convert.ToInt32(indexItemResult), Convert.ToInt32(newItemResult));
                                        counter = 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kiritilgan indexda element mavjud emas, qo'shishni hohlaysizmi?");
                                        Console.Write("y / n : ");
                                        string? yn = Console.ReadLine();
                                        switch (yn)
                                        {
                                            case "y":
                                                myListCollection.Add(newItemResult);
                                                counter = 1;
                                                break;
                                            case "n":
                                                counter = 2;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    add = false;
                                }
                            }
                            else
                            {
                                add = false;
                            }
                        } while (add);
                    }
                    else
                    {
                        Console.WriteLine("Listda element mavjud emas.");
                        //Console.WriteLine("Menyuga qaytish uchun istalgan tugmani bosing : ");
                        Console.ReadKey();
                    }
                }

                void ElementniTekshirish()
                {
                    Console.Clear();
                    bool repeat = true;
                    int counter = 0;
                    if (myListCollection.list.Count > 0)
                    {
                        do
                        {
                            Console.Clear();
                            string s = counter == 0 ? "Qaysi elementni qidiryapsiz: " :
                                        counter == 1 ? "Element qo'shildi,\nyana qanday elementni qidirmoqchisiz: " :
                                        "Qidirayotgan elementingizni kiriting: ";
                            Console.WriteLine(s);
                            string? isHave = Console.ReadLine();
                            if (int.TryParse(isHave, out int isHaving))
                            {
                                string ss = "";
                                List<int> junkList = new List<int>(myListCollection.list);
                                for (int i = 0; i < junkList.Count;)
                                {
                                    if (junkList.Contains(isHaving))
                                    {
                                        i = junkList.IndexOf(isHaving);
                                        junkList[i] = isHaving + 1;
                                        ss += i + " - ";
                                        i++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (ss != "")
                                {
                                    myListCollection.GetListInfo();
                                    string sMany = ss.Length > 4 ? "indexlarda" : "indexda";
                                    Console.WriteLine($"Kiritilgan {isHaving} elementi {ss}{sMany} joylashgan");
                                    counter = 2;
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Kiritilgan element listda mavjud emas, qo'shishni hohlaysizmi?");
                                    Console.Write("y / n : ");
                                    string? yn = Console.ReadLine();
                                    switch (yn)
                                    {
                                        case "y":
                                            myListCollection.Add(isHaving);
                                            counter = 1;
                                            break;
                                        case "n":
                                            counter = 2;
                                            break;
                                        default:
                                            break;
                                    }
                                    //break;
                                }
                            }
                            else
                            {
                                repeat = false;
                            }
                        } while (repeat);
                    }
                    else
                    {
                        Console.WriteLine("Listda element mavjud emas.");
                        //Console.WriteLine("Menyuga qaytish uchun istalgan tugmani bosing : ");
                        Console.ReadKey();
                    }
                }

            }
        }
    }
}