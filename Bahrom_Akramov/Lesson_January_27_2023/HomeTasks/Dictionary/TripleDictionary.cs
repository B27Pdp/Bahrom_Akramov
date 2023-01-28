using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_January_27_2023.HomeTasks.Dictionary
{
    internal class TripleDictionary<T, U, V>
        where T : struct
        where U : IPerson<int>
        where V : Person
    {
        public T? TProp { get; set; }
        public U? UProp { get; set; }
        public V? VProp { get; set; }
        
        public List<T> OrderBy(List<T> listName)
        {
            listName.Sort();
            return listName;
        }

        public List<T> OrderByDesc(List<T> listName)
        {
            listName.Sort();
            listName.Reverse();
            return listName;
        }
    }
}
