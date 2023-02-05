using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_5
{
    internal class FindFilesFolders
    {
        public static void FindFilesAndFolders(string path, string searchText)
        {
			try
			{
                string[] AllFiles = Directory.GetFiles(path);
                foreach (string file in AllFiles)
                {
                    if (Path.GetFileName(file).Equals(searchText))
                    {
                        Console.WriteLine("File: " + file);
                    }
                }
                string[] AllFolders = Directory.GetDirectories(path);
                foreach (string directory in AllFolders)
                {
                    if (Path.GetFileName(directory).Equals(searchText))
                    {
                        Console.WriteLine("Folder: " + directory);
                    }
                    FindFilesAndFolders(directory, searchText);
                }
            }
			catch (Exception exception)
			{
                Console.WriteLine(exception.Message);
			}
        }
    }
}
