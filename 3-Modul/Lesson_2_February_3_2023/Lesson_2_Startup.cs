using _3_Modul.Lesson_2_February_3_2023.HomeTasks;
using _3_Modul.Lesson_2_February_3_2023.LessonTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_Modul.Lesson_2_February_3_2023.HomeTasks.Task1;

namespace _3_Modul.Lesson_2_February_3_2023
{
    internal class Lesson_2_Startup
    {
        public static void Start()
        {
            //AnonymDelegate anonym = new();
            //anonym.anonymDel();

            //FuncitonDel funcitonDel = new();
            //funcitonDel.funcDel();

            //ActionDel actionDel = new();
            //actionDel.actionDel();

            // HomeTasks

            Task1 task = new();
            task.printInfo();

            Task_3_Function.start();
           

        }
        
    }
}
