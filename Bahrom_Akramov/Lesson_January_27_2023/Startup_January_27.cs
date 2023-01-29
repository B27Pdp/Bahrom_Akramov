using Bahrom_Akramov.Lesson_January_27_2023.HomeTasks;
using Bahrom_Akramov.Lesson_January_27_2023.HomeTasks.Dictionary;

namespace Bahrom_Akramov.Lesson_January_27_2023
{
    internal class Startup_January_27
    {
        public static void T_N()
        {
            //Tuple_Nullable.tupleOne();
            //Dictionary<int, int> dict1 = new() { { 1, 111 }, { 2, 222 } };
            //PrintDict.PrintDictionary(dict1);

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //LastItem.lastItem(array);

            TripleDictionary<int, Person, Person> triple = new();
            triple.Add(1, new Person(2, 25, "Boltavoy"), new Person(5, 30, "Boltaxon"));
            triple.Add(5, new Person(8, 52, "Polonchi"), new Person(3, 39, "Pistonchixon"));
            triple.Add(3, new Person(3, 32, "Ali"), new Person(7, 32, "Vali"));
            triple.Add(11, new Person(5, 15, "Khan"), new Person(1, 12, "Xon"));

            var printItem = triple.OrderBy();
            foreach (var item in printItem)
            {
                Console.WriteLine($"{item.TProp}, {item.UProp.Name}, {item.VProp.Name}");
            }

            var printItem2 = triple.OrderByDesc();
            foreach (var item in printItem2)
            {
                Console.WriteLine($"{item.TProp}, {item.UProp.Name}, {item.VProp.Name}");
            }



        }

    }
}
