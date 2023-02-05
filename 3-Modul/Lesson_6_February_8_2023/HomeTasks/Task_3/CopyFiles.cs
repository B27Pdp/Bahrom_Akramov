using _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_3
{
    internal class CopyFiles
    {
        public static void Run()
        {
            string currentPath = @"e:\ProGraM\DotNet\VisualStudio_Programms\Bahrom_Akramov\3-Modul\Lesson_6_February_8_2023\HomeTasks\FilePath\text.txt";
            string CopyPath = @"e:\ProGraM\DotNet\VisualStudio_Programms\Bahrom_Akramov\3-Modul\Lesson_6_February_8_2023\HomeTasks\FilePath\FolderA\textFileA.txt";
            GetCopy.GetCopyMethod(currentPath, CopyPath);
        }
    }
}
