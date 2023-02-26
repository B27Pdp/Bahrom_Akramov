using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_14_February_23_2023.LessonTasks
{
    internal class CaseVSOfType
    {
        public static void Run()
        {
            // OsType kalit so'zi IEnumerable tipidagi ma'lumotlarni berilgan toifa bo'yicha filtrlaydi
            //var DataSource = new List<object>() { 'a', "Jasur", "Xondamir", 1, 2, 3, 4 };
            //var selected = DataSource.OfType<string>();
            //foreach (var item in selected)
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine("\n#__________#__________#__________#");
            //var querySyn = from x in DataSource
            //               where x is string
            //               select x;
            //foreach (var item in selected)
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine("\n#__________#__________#__________#");
            //IEnumerable<object> objList = new List<object> { 1, "two", 3.0, "four", 5 };
            //var intList = from o in objList.OfType<int>()
            //              where o > 2
            //              select o;
            //foreach (var item in intList)
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine("\n#__________#__________#__________#");
            ////var ints = new ArrayList { 1.2, 2.5, 3, 4, 5, 6 };
            ////var doubles = ints.Cast<double>();
            ////foreach (var item in doubles)
            ////{
            ////    Console.Write(item + ", ");
            ////}
            //Console.WriteLine("\n#__________#__________#__________#");
            //string satr = "salom 12 Dunyo56 888Hello44 Wo4ld0";
            //var str = satr.Where(char.IsDigit).Select(c => int.Parse(c.ToString()));
            //Console.WriteLine(string.Join("", str));

            List<double> doubles = new List<double>() { 15.5, 20, 30.0, 5.5};
            var ints = doubles.Select(x => (int)Math.Floor((double)x));
            Console.WriteLine(string.Join("", ints));
        }
    }
}
