using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_5_February_7_2023.HomeTasks
{
    internal class Find_the_Difference_389
    {
        public char FindTheDifference(string s, string t)
        {
            int i = 0;
            List<char> list = new List<char>(t);
            while (list.Count > 1)
                list.Remove(s[i++]);
            return list[0];
        }
    }
}
