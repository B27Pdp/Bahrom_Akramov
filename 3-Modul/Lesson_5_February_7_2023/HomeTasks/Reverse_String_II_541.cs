using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_5_February_7_2023.HomeTasks
{
    internal class Reverse_String_II_541
    {
        public static string ReverseStr(string s, int k)
        {
            if (s.Length >= k && k != 1)
            {
                int k1 = s.Length / k;
                string s1 = s.Substring(0, k1*k);

                string result = "";
                int i = 0;
                while (i != s1.Length)
                {
                    char[] reverse = s1.Substring(i, k).ToCharArray();
                    Array.Reverse(reverse);
                    string arr = new string(reverse);
                    result += arr;
                    result += s1.Substring(i + k, (s1.Length - (i + k) > k ? k : s1.Length - (i + k)));
                    i += i + 2 * k <= s1.Length ? 2 * k : k;
                }
                if (k1 % 2 == 0)
                {
                    char[] reverse = s.Substring(s1.Length, s.Length - s1.Length).ToCharArray();
                    Array.Reverse(reverse);
                    string arr = new string(reverse);
                    result += arr;
                }
                else
                {
                    result += s.Substring(s1.Length, s.Length - s1.Length);
                }
                return result;
            }
            else if (k == 1)
            {
                return s;
            }
            else
            {
                char[] reverse = s.Substring(0, s.Length).ToCharArray();
                Array.Reverse(reverse);
                string arr = new string(reverse);
                return arr;
            }
        }
    }
}
