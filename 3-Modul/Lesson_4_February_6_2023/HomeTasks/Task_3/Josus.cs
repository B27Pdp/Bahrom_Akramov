using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_4_February_6_2023.HomeTasks.Task_3
{
    internal class Josus
    {
        public void EnterMessage(object sender, EventHandler handler)
        {
            Console.WriteLine("Josus ishini bajardi");
            handler.Invoke(null, EventArgs.Empty);
        }
    }
}
