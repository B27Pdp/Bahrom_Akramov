using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_10_January_28_2023.HomeTasks
{
    internal class MyListCollection<T>
    {
        public List<T> list = new List<T>();

        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Delete(T item)
        {
            list.Remove(item);
        }

        public void GetListInfo()
        {
            foreach (T item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void ChengeItem(int index, T item)
        {
            list.RemoveAt(index);
            list.Insert(index, item);
        }

        public bool isHaveItem(T item)
        {
            return list.Contains(item);
        }
    }
}
