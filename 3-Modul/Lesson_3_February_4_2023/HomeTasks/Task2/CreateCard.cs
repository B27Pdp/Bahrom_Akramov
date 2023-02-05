using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3_February_4_2023.HomeTasks.Task2
{
    internal class CreateCard
    {
        public List<Card> cardList { get; set; }

        public CreateCard()
        {
            cardList = new List<Card>();
        }

        public void addCard()
        {
            cardList.Add(new Card(1, "Ali", 25000, CardType.HUMO, "So'm"));
            cardList.Add(new Card(2, "Vali", 50000, CardType.UZCARD, "So'm"));
            cardList.Add(new Card(3, "Boltavoy", 550, CardType.VISA, "Dollar"));
            cardList.Add(new Card(4, "No name", 120, CardType.UNIONPAY, "Dollar"));
        }
        public void addNewCard(int id, string name, int balance, CardType type, string currensy)
        {
            cardList.Add(new Card(id, name, balance, type, currensy));
        }

        public void transferMoney(int id1, int id2, int summa)
        {
            var card1 = cardList.FirstOrDefault(x => x.Id.Equals(id1));
            var card2 = cardList.FirstOrDefault(x => x.Id.Equals(id2));

            try
            {
                
                if (card1.Currensy != card2.Currensy)
                {
                    throw new CardTypeNotMatch();
                }
                if (cardList[card1.Id-1].Balance < summa)
                {
                    throw new NotEnoughMoney();
                }
                card1.Balance -= summa;
                card2.Balance += summa;
                Console.WriteLine(card1.Balance);
                Console.WriteLine(card2.Balance);
                Console.ReadKey();
            }
            catch (CardTypeNotMatch a)
            {
                Console.WriteLine(a.Message+ "\nCartalar tiofasi mos bo’lmagan holatda pul o'tkazib bo'lmaydi");
                Console.ReadKey();
            }
            catch (NotEnoughMoney a)
            {
                Console.WriteLine(a.Message + "\nPul yetarli bo’lmagan holatda pul o'tkazib bo'lmaydi");
                Console.ReadKey();
            }
        }
        public void ShowBalance(int id)
        {
            var card = cardList.FirstOrDefault(x => x.Id.Equals(id));
            Console.WriteLine(card.Balance);
        }

    }
}
