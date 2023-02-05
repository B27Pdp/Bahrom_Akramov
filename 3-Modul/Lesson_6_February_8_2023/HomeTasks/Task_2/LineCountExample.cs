using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_2
{
    internal class LineCountExample
    {
        public static void Run()
        {
            string path = @"e:\ProGraM\DotNet\VisualStudio_Programms\Bahrom_Akramov\3-Modul\Lesson_6_February_8_2023\HomeTasks\FilePath\text.txt";
            int result = GetLine.GetLineCount(path);
            Console.WriteLine(result);
        }
    }
}
