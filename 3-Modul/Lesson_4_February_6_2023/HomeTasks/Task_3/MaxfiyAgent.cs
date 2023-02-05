using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_4_February_6_2023.HomeTasks.Task_3
{
    internal class MaxfiyAgent
    {
        public event EventHandler<EventHandler> SecretMessage;
        EventHandler? BossOrder;
        Humans humans = new();
        EventHandler humanOrder;
        public void SendSecretMessage()
        {
            Console.WriteLine("Boss Order");
            BossOrder += humans.Client6!;
            BossOrder += humans.Client1!;
            BossOrder += humans.Client4!;
            SecretMessage.Invoke(this, BossOrder);
        }

    }
}
