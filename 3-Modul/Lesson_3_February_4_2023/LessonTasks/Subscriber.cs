using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3_February_4_2023.LessonTasks
{
    internal class Subscriber
    {
        public event ClickSendSMS? SendSMS;

        List<(object, string)> saveAllMassages = new List<(object, string)>();

        public void SendSmsToYer()
        {
            Console.WriteLine("Xabarni kiritng: ");
            Console.Write(">> ");
            string text = Console.ReadLine() ?? "No Text";
            SendSMS?.Invoke(this, text);
        }

        public void ShowMassages()
        {
            foreach (var item in saveAllMassages)
            {
                Console.WriteLine(item);
            }
        }

        public void EnterMassage(object obj, string text)
        {
            saveAllMassages.Add((obj, text));
        }
    }
}
