using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_February_8_2023.HomeTasks.Task_4
{
    internal class GetAddFiles
    {
        public static void AddFiles(string pathOne, string pathTwo)
        {
			try
			{
                string path = Directory.GetCurrentDirectory().ToString();
                DirectoryInfo? directoryInfo = new DirectoryInfo(path);
                directoryInfo = directoryInfo?.Parent?.Parent?.Parent;
                directoryInfo = new DirectoryInfo(directoryInfo?.FullName + @"\Lesson_6_February_8_2023\HomeTasks\Task_4");
                File.Create(directoryInfo.FullName + @"\newTextFile.txt").Dispose();
                directoryInfo = new DirectoryInfo(directoryInfo.FullName + @"\newTextFile.txt");
                string newPath = directoryInfo.FullName;
                //string newPath = @"e:\ProGraM\DotNet\VisualStudio_Programms\Bahrom_Akramov\3-Modul\Lesson_6_February_8_2023\HomeTasks\Task_4\newTextFile.txt";
                string pathOneAllText = File.ReadAllText(pathOne);
                string pathTwoAllText = File.ReadAllText(pathTwo);
                string combinedAllText = pathOneAllText + pathTwoAllText;
                File.WriteAllText(newPath, combinedAllText);
                Console.WriteLine("Done");
			}
			catch (Exception exception)
			{
                Console.WriteLine(exception.Message);
			}
        }
    }
}
