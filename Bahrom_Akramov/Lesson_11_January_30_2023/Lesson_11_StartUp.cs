using Bahrom_Akramov.Lesson_11_January_30_2023.LessonTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_11_January_30_2023
{
    internal static class Lesson_11_StartUp
    {
        public static void L11StartUp()
        {
            MyList<string> myList= new MyList<string>();
            myList.Add("Salom");
            myList.Add("Qale");
            myList.Add("Nima gap");
            myList.Add("Ishlar boluttimi");
            myList.Add("Nimalar");
            myList.Add("Qilyapsan");
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }

        }
    }
}
