using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_1
{
    internal class FileExample
    {
        public static void Run()
        {
            string path = @"e:\ProGraM\DotNet\VisualStudio_Programms\Bahrom_Akramov\3-Modul\Lesson_6_February_8_2023\HomeTasks\FilePath";
            string result = GetFolderContents.GetFolder(path);
            Console.WriteLine(result);
        }
    }
}
