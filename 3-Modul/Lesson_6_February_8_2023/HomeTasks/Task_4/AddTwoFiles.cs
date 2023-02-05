using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_4
{
    internal class AddTwoFiles
    {
        public static void Run()
        {
            string pathOne = @"e:\ProGraM\DotNet\VisualStudio_Programms\Bahrom_Akramov\3-Modul\Lesson_6_February_8_2023\HomeTasks\FilePath\FolderA\SubFolderA\subTextFileA.txt";
            string pathTwo = @"e:\ProGraM\DotNet\VisualStudio_Programms\Bahrom_Akramov\3-Modul\Lesson_6_February_8_2023\HomeTasks\FilePath\text.txt";
            GetAddFiles.AddFiles(pathOne, pathTwo);
        }
    }
}
