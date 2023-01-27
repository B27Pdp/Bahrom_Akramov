using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_26_January_2023.HomeTasks
{
    internal class Design_HashSet_705
    {
        private Dictionary<int, int> dict;
        public Design_HashSet_705()
        {
            dict = new Dictionary<int, int>();
        }

        public void Add(int key)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, 0);
            }
        }

        public void Remove(int key)
        {
            dict.Remove(key);
        }

        public bool Contains(int key)
        {
            return dict.ContainsKey(key);
        }
    }
}
