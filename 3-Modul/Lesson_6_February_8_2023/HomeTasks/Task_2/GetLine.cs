using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_2
{
    internal class GetLine
    {
        public static int GetLineCount(string path)
        {
			try
			{
                int count = 0;
                StreamReader streamReader = new StreamReader(path);
                while (!streamReader.EndOfStream)
                {
                    streamReader.ReadLine();
                    count++;
                }
                return count;
            }
			catch (Exception exeption)
			{
                Console.WriteLine(exeption.Message);
                return 0;
			}
        }
    }
}
