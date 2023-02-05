using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3_February_4_2023.HomeTasks.Task1
{
    internal class LenthOfString
    {
        public static void lengthOfString(string satr)
        {
			try
			{
				if (satr == "")
				{
					throw new ArgumentException();
                }
				else
				{
					Console.WriteLine(satr.Length);
				}
			}
			catch (ArgumentException a)
			{
				Console.WriteLine(a.Message + "\nKiritilgan matn bo’sh bo’lmasligi kerak");
			}
        }
    }
}
