using Bogus;

namespace _3_Modul.Lesson_15_February_25_2023.HomeTasks.LINQ_30_Exercises
{
    internal class Exercises
    {
        public static Faker faker = new();
        public static void Run()
        {
            #region task1
            //List<int> ints = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            //var juftSonlar = (from num in ints
            //                 where num % 2 == 0
            //                 select num).ToList();
            //juftSonlar.ForEach(x => Console.Write(x + " "));
            #endregion

            #region task2
            //List<int> numbers = new List<int> { -2, 1, 3, -5, 6, 9, 0, 10, -3 };
            //var musbat = (from num in numbers
            //              where num > 0
            //             where num > 1 && num < 11
            //             select num).ToList();
            //musbat.ForEach(x => Console.Write(x + " "));
            #endregion

            #region task3
            //List<int> massiv = new List<int>() { 8, 2, 4, 6, 9, 1, 15, 5 };
            //var anonim = (from nums in massiv
            //             let kvadrat = nums * nums
            //             where kvadrat > 20
            //             select new
            //             {
            //                 Number = nums, SqrNo = kvadrat
            //             }).ToList();
            //anonim.ForEach(x => Console.WriteLine($"Number = {x.Number}, SqrNo = {x.SqrNo}"));
            #endregion

            #region task4
            //List<int> ints = new List<int>() { 1, 5, 2, 1, 4, 7, 8, 5, 6, 4, 5, 2, 3, 1, 5, 5, 7, 9 };
            //var countNumber = (from num in ints
            //                  group num by num into nums
            //                  select new
            //                  {
            //                      number = nums.Key, count = nums.Count()
            //                  }).ToList();
            //countNumber.ForEach(x => Console.WriteLine($"{x.number} soni {x.count} marta"));
            #endregion

            #region task5
            //string satr = "Salom dunyo, haloyiq qaleslar";
            //var resultStr = (from str in satr
            //                group str by str into s
            //                select new
            //                {
            //                    letter = s.Key, count = s.Count()
            //                }).ToList();
            //resultStr.ForEach(x => Console.WriteLine($"Character {x.letter}: {x.count} times"));
            #endregion

            #region task6
            //string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //var days = from day in dayWeek
            //           select day;
            //foreach (var item in days)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task7
            //List<int> ints = new List<int>() { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            //var result = (from num in ints
            //             group num by num into n
            //             select new
            //             {
            //                 number = n.Key, numFreq = n.Key * n.Count(), frequensy = n.Count()
            //             }).ToList();
            //result.ForEach(x => Console.WriteLine($"{x.number} {x.numFreq} {x.frequensy}"));

            //var result = ints.GroupBy(x => x).Select(g => new { number = g.Key, kopaytma = g.Key * g.Count(), count = g.Count() });
            //foreach (var x in result)
            //{
            //    Console.WriteLine($"{x.number} {x.kopaytma} {x.count}");
            //}
            #endregion

            #region task8
            //string[] cities = new string[] { "ROME", "ALONDONM", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //var result = (from city in cities
            //             where city.StartsWith('A') && city.EndsWith('M')
            //             select city).ToList();
            //result.ForEach(Console.WriteLine);
            #endregion

            #region task9
            //List<int> ints = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };
            //var bigFrom80 = (from num in ints
            //                where num > 80
            //                select num).ToList();
            //bigFrom80.ForEach(Console.WriteLine);
            #endregion

            #region task10
            //List<int> list = new List<int>();
            //Console.WriteLine("Listning uzunligini kiriting: ");
            //Console.Write(">> ");
            //int n = int.Parse(Console.ReadLine()!);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Clear();
            //    Console.Write($"{i+1} - element >> ");
            //    int a = int.Parse(Console.ReadLine()!);
            //    list.Add(a);
            //}
            //Console.WriteLine("Qaysi sondan kattalari chiqarilsin");
            //Console.Write(">> ");
            //int b = int.Parse(Console.ReadLine()!);
            //var result = (from num in list
            //             where num > b
            //             select num).ToList();
            //Console.WriteLine($"{b} dan katta sonlar");
            //result.ForEach(Console.WriteLine);
            #endregion

            #region task11
            //List<int> numbers = new List<int> { 5, 12, 7, 8, 4, 9 };
            //int n = 3;
            //var result = (from num in numbers
            //             orderby num descending
            //             select num).Take(n);
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region task12
            //string satr = "this IS a STRING";
            //var result = from str in satr.Split()
            //             where str == str.ToUpper()
            //             select str;
            //foreach (var item in result)
            //{
            //    Console.Write(item + ", ");
            //}
            #endregion

            #region task13
            //List<string> strList = new List<string>() { "cat", "dog", "rat" };
            ////string s = string.Join(", ", strList);
            //string s = string.Join(", ",
            //           from str in strList
            //           select str);
            //Console.WriteLine(s);
            #endregion

            #region task14
            //Random random = new();
            //List<Student2> students = new List<Student2>();
            //for (int i = 0; i < 15; i++)
            //{
            //    Student2 student = new(i + 1, faker.Name.FullName(), random.Next(700, 710));
            //    students.Add(student);
            //}

            //var ekran = from st in students
            //            orderby st.Ball descending
            //            select st;
            //foreach (var item in ekran)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.Write("n >> ");
            //int n = int.Parse(Console.ReadLine()!);
            //var list = (from student in students
            //            orderby student.Ball descending
            //            group student by student.Ball).Skip(n - 1).Take(1);

            //foreach (var item in list)
            //{
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}
            #endregion

            #region task15
            //List<string> fayl = new List<string>() { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            //var extension = from file in fayl
            //                group file by Path.GetExtension(file).ToLower() into f
            //                select new
            //                {
            //                    Extension = f.Key,
            //                    count = f.Count()
            //                };
            //foreach (var item in extension)
            //{
            //    Console.WriteLine($"{item.count} File(s) with {item.Extension} Extension");
            //}
            #endregion

            #region task16
            //string path = @"c:\Users\Akramov_Developer\Downloads\y2meta_com_Counting_Stars_OneRepublic_violin_cello_bass_cover_Simply.wav";
            //var bytes = File.ReadAllBytes(path);
            //Console.WriteLine((bytes.Count() / 1024 / 1024.0)+" MB");
            #endregion

            #region task17
            //List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            //chars.ForEach(x => Console.Write(x + ", "));
            //Console.WriteLine();
            //Console.WriteLine("Qaysi belgini o'chirmoqchisiz? ");
            //Console.Write(">> ");
            //char a = char.Parse(Console.ReadLine()!);
            //chars.Remove(a);
            //chars.ForEach(x => Console.Write(x + ", "));
            #endregion

            #region task18
            //List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            //chars.ForEach(x => Console.Write(x + ", "));
            //Console.WriteLine();
            //Console.WriteLine("Qaysi belgini o'chirmoqchisiz? ");
            //Console.Write(">> ");
            //char a = char.Parse(Console.ReadLine()!);
            //var deletChar = from del in chars
            //                where del != a
            //                select del;
            //foreach (var item in chars)
            //{
            //    Console.Write(item + ", ");
            //}
            #endregion

            #region task19
            //List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            //chars.ForEach(x => Console.Write(x + ", "));
            //Console.WriteLine();
            //chars.RemoveAll(x => x == 'o');
            #endregion

            #region task20
            //List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            //Console.WriteLine("Indeksni kiriting:");
            //Console.Write(">> ");
            //int index = Convert.ToInt32(Console.ReadLine()!);
            //chars.RemoveAt(index);
            #endregion

            #region task21
            //List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            //Console.WriteLine("Indeksni kiriting:");
            //Console.Write(">> ");
            //int index = Convert.ToInt32(Console.ReadLine()!);
            //Console.WriteLine("Oraliqni kiriting:");
            //Console.WriteLine(">> ");
            //int oraliq = Convert.ToInt32(Console.ReadLine()!);
            //chars.RemoveRange(index, oraliq);
            //chars.ForEach(x => Console.Write(x + " "));
            #endregion

            #region task22
            //List<string> myStrings = new List<string> { "this", "is", "a", "string" };
            //Console.WriteLine("Minimum uzunlikni kiriting: ");
            //Console.Write(">> ");
            //int n = int.Parse(Console.ReadLine());
            //var list = (from ll in myStrings
            //           where ll.Length > n
            //           select ll).ToList();
            //list.ForEach(x => Console.Write(x + ", "));
            #endregion

            #region task23
            //List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
            //List<int> numbers2 = new List<int> { 6, 7, 8, 9, 10 };
            //var crossJoin = from num1 in numbers1
            //                from num2 in numbers2
            //                select (num1, num2);
            //foreach (var item in crossJoin)
            //{
            //    Console.WriteLine(item + " ");
            //}
            #endregion

            #region task24
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //List<string> strings = new List<string> { "Jon", "Dev", "Ali", "Vali", "Boltavoy" };
            //List<char> letters = new List<char> { 'A', 'B', 'C' };
            //var crossJoin = from num1 in numbers
            //                from str in strings
            //                from lett in letters
            //                select (num1, str, lett);
            //foreach (var item in crossJoin)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task25
            //List<Order> orders = new List<Order>
            //{
            //    new Order { OrderId = 1, CustomerId = 1, Amount = 100.00M },
            //    new Order { OrderId = 2, CustomerId = 2, Amount = 50.00M },
            //    new Order { OrderId = 3, CustomerId = 3, Amount = 200.00M }
            //};

            //List<Customer> customers = new List<Customer>
            //{
            //    new Customer { CustomerId = 1, Name = "Alice" },
            //    new Customer { CustomerId = 2, Name = "Bob" },
            //    new Customer { CustomerId = 3, Name = "Charlie" },
            //    new Customer { CustomerId = 4, Name = "David" }
            //};

            //var innerJoin = from order in orders
            //                join customer in customers
            //                on order.CustomerId equals customer.CustomerId
            //                select new
            //                {
            //                    customer.CustomerId,
            //                    customer.Name,
            //                    order.Amount,
            //                    order.OrderId
            //                };
            //Console.WriteLine("Item Id\t\tItem Name\tPurchase Quantity");
            //foreach (var item in innerJoin)
            //{
            //    Console.WriteLine($"{item.CustomerId}\t\t{item.Name}\t\t{item.Amount}");
            //}
            #endregion

            #region task26
            //List<Item> items = new()
            //{
            //    new Item {itemId = 1, itemName = "Biscuit", itemPriceId = 1},
            //    new Item {itemId = 2, itemName = "Chocolate", itemPriceId = 2},
            //    new Item {itemId = 3, itemName = "Butter", itemPriceId = 1},
            //    new Item {itemId = 4, itemName = "Brade", itemPriceId = 3},
            //    new Item {itemId = 5, itemName = "Honey", itemPriceId = 5},
            //};
            //List<Purchase> purchases = new()
            //{
            //    new Purchase { id = 1, price = 12000 },
            //    new Purchase { id = 2, price = 25000 },
            //    new Purchase { id = 3, price = 5000 },
            //    new Purchase { id = 4, price = 6000 },
            //    new Purchase { id = 5, price = 78000 },
            //};
            //var leftJoin = from item in items
            //               join purchase in purchases
            //               on item.itemPriceId equals purchase.id
            //               into selectedItem
            //               from newItem in selectedItem.DefaultIfEmpty()
            //               select new
            //               {
            //                   id = item.itemId,
            //                   name = item.itemName,
            //                   price = newItem
            //               };
            //Console.WriteLine("Item ID\t\tItem Name\tItem Price");
            //Console.WriteLine("-------------------------------------------------");
            //foreach (var item in leftJoin)
            //{
            //    Console.WriteLine($"{item.id}\t\t{item.name}\t\t{item.price.price}");
            //}
            #endregion

            #region task27
            List<Purchase> purchases = new()
            {
                new Purchase { id = 1, price = 12000 },
                new Purchase { id = 2, price = 25000 },
                new Purchase { id = 3, price = 5000 },
                new Purchase { id = 4, price = 6000 },
                new Purchase { id = 5, price = 78000 },
            };
            List<Item> items = new()
            {
                new Item {itemId = 1, itemName = "Biscuit", itemPriceId = 1},
                new Item {itemId = 2, itemName = "Chocolate", itemPriceId = 2},
                new Item {itemId = 3, itemName = "Butter", itemPriceId = 1},
                new Item {itemId = 4, itemName = "Brade", itemPriceId = 3},
                new Item {itemId = 4, itemName = "Brade", itemPriceId = 4},
                new Item {itemId = 5, itemName = "Honey", itemPriceId = 5},
            };
            var rightJoin = from purchase in purchases
                            join item in items
                            on purchase.id equals item.itemPriceId
                            into purchItem
                            from newPurchItem in purchItem.DefaultIfEmpty()
                            select new
                            {
                                purchase.id,
                                purchase.price,
                                newPurchItem.itemName
                            };
            Console.WriteLine("Item ID\t\tItem Name\tItem Price");
            Console.WriteLine("-------------------------------------------------");
            foreach (var item in rightJoin)
            {
                Console.WriteLine($"{item.id}\t\t{item.itemName}\t\t{item.price}");
            }
            #endregion

            #region task28
            //List<string> cities = new List<string>()
            //{
            //    "ROME",
            //    "PARIS",
            //    "LONDON",
            //    "ZURICH",
            //    "NAIROBI",
            //    "ABU DHABI",
            //    "NEW DELHI",
            //    "CALIFORNIA",
            //    "AMSTERDAM",
            //};
            //var task28 = (from city in cities
            //              orderby city.Length
            //              select city).ThenBy(x => x);
            //foreach (var item in task28)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task29
            //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "NEW YORK" };
            //var groupOfCities = from city in cities
            //                    group city by Array.IndexOf(cities, city)/3
            //                    into groupCity
            //                    select groupCity;
            //foreach (var group in groupOfCities)
            //{
            //    foreach (var city in group)
            //    {
            //        Console.Write(city + "; ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region task30
            //List<string> cities = new List<string>()
            //{
            //    "LONDON",
            //    "ROME",
            //    "LONDON",
            //    "CALIFORNIA",
            //    "CALIFORNIA",
            //    "LONDON",
            //    "PARIS",
            //    "NEW DELHI",
            //    "AMSTERDAM",
            //    "PARIS",
            //    "NEW DELHI",
            //    "NEW DELHI",
            //};
            //var distinctList = (from city in cities
            //                   orderby city
            //                   select city).Distinct();
            //foreach (var item in distinctList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }

    class Item
    {
        public int itemId { get; set; }
        public string? itemName { get; set; }
        public int itemPriceId { get; set; }  
    }

    class Purchase  
    {
        public int id { get; set; }
        public int price { get; set; }
    }


    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
    }
    class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
    }


    record Student2(int Id, string Name, int Ball);
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ball { get; set; }
    }
}
