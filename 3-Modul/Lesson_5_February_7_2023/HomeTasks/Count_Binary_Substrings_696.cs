using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_5_February_7_2023.HomeTasks
{
    internal class Count_Binary_Substrings_696
    {
        public static int CountBinarySubstrings(string s)
        {
            int i = 0;
            int j = 0;
            int count1 = 0;
            int count2 = 0;
            int result = 0;
            while (i < s.Length)
            {
                if (s[i++] == '0')
                {
                    if (count1 > count2 && s[i - 1] == '1')
                    {
                        i -= count2-1;
                        count1 = 0;
                    }
                    else
                    {
                        count1++;
                    }
                }
                else
                {
                    if (count2 > count1 && s[i-1] == '0')
                    {
                        i -= count1-1;
                        count2 = 0;
                    }
                    else
                    {
                        count2++;
                    }
                }
                if (count1 == count2)
                {
                    if (count1 > 1)
                    {
                        result += count1;
                        i = count1;
                    }
                    else
                    {
                        result++;
                        i = j++;
                    }
                    count1 = 0;
                    count2 = 0;
                }
            }
            return result;
        }
    }
}
