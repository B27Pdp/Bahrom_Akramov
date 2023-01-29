using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_10_January_28_2023.LessonTasks
{
    internal class MyCollection<T>
    {
        public List<T> list = new();
        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }

        public void Add(T a)
        {
            if (!list.Contains(a))
            {
                list.Add(a);
            }
            else
            {
                Console.WriteLine("Bunday qiymat mavjud, yana qo'shishni hohlaysizmi?");
                Console.Write("y/n : ");
                string s = Console.ReadLine()!;
                switch (s)
                {
                    case "y": list.Add(a); break;
                    case "n": Console.WriteLine("qo'shilmadi"); break;
                }
            }
        }
        public void Delete(T a)
        {
            if (list.Contains(a))
            {
                list.Remove(a);
                Console.WriteLine($"{a} listdan o'chirildi");
            }
            else
            {
                Console.WriteLine("Bunday qiymat yo'q");
            }
        }

        public void getInfo()
        {
            foreach (T item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
