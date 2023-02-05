using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_5
{
    internal class FileFinder
    {
        public static void Run()
        {
            string path = @"e:\M E D I A  Files";
            string searchText = "Bizni_ta_lim_qutqaradi_Umidjon_Ishmuhamedov_qgbbT_FdMGk_136.mp4";
            FindFilesFolders.FindFilesAndFolders(path, searchText);
        }
        
    }
}
