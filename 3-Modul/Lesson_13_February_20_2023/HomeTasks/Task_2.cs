using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_13_February_20_2023.HomeTasks
{
    internal class Task_2
    {

    }

    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public static List<CreditCard> GenerateCreditCards(int number)
        {
            List<CreditCard> creditCards = new List<CreditCard>();
            for (int i = 0; i < number; i++)
            {
                CreditCard creditCard = new() {
                    CardNumber = "10000000" + i,
                    Name = "CreditCard-" + i
                };
                creditCards.Add(creditCard);
            }
            return creditCards;
        }
    }
}
