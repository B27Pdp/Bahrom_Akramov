using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_4_February_6_2023.HomeTasks.Task_3
{
    internal class MafiaStart
    {
        public static void Run()
        {
            MaxfiyAgent agent = new();
            Josus josus = new();
            agent.SecretMessage += josus.EnterMessage!;
            agent.SendSecretMessage();
        }
    }
}
