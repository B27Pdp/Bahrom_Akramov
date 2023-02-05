using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_1
{
    internal class GetFolderContents
    {
        public static string GetFolder(string path)
        {
			try
			{
				bool hasFiles = false;
				bool hasFolders = false;

				string[] files = Directory.GetFiles(path);
				if (files.Length > 0)
					hasFiles = true;

				string[] folders = Directory.GetDirectories(path);
				if (folders.Length > 0)
					hasFolders = true;

				if (hasFiles && hasFolders)
					return "Papka va fayllar bor";

				else if (hasFiles)
					return "Fayllar bor";

				else if (hasFolders)
					return "Papkalar bor";

				else
					return "Papka bo'sh";

            }
			catch (Exception exception)
			{
				return exception.Message;
			}
        }
    }
}
