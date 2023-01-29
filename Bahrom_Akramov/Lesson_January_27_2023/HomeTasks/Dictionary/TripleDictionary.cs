using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_January_27_2023.HomeTasks.Dictionary
{
    internal class TripleDictionary<T, U, V>
        where T : struct
        where U : class, IPerson<int>
        where V : Person
    {
        public T? TProp { get; set; }
        public U? UProp { get; set; }
        public V? VProp { get; set; }

        public TripleDictionary(T? tProp, U? uProp, V? vProp)
        {
            TProp = tProp;
            UProp = uProp;
            VProp = vProp;
        }
        public TripleDictionary()
        {

        }

        List<TripleDictionary<T, U, V>> tripleDictionaries = new();
        public void Add(T tProp, U uProp, V vProp)
        {
            TripleDictionary<T, U, V> a = new(tProp, uProp, vProp);
            tripleDictionaries.Add(a);
        }

        public List<TripleDictionary<T, U, V>> OrderBy()
        {
            tripleDictionaries = tripleDictionaries.OrderBy(x => x.TProp).ToList();
            return tripleDictionaries;
        }

        public List<TripleDictionary<T, U, V>> OrderByDesc()
        {
            tripleDictionaries = tripleDictionaries.OrderByDescending(x => x.TProp).ToList();
            return tripleDictionaries;
        }
    }
}
