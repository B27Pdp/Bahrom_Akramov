using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_3
{
    internal class GetCopy
    {
        public static void GetCopyMethod(string currentPath, string copyPath)
        {
			try
			{
                File.Copy(currentPath, copyPath, true);
                Console.WriteLine("Fayl muvaffaqiyatli nusxalandi");
            }
			catch (Exception exception)
			{
                Console.WriteLine("Fayl nusxalashda xatolik yuz berdi:\n" + exception.Message);
			}
        }
    }
}
