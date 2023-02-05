using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3_February_4_2023.HomeTasks.Task2
{
    internal class Card
    {
        private string currency;
        public string Currensy
        {
            get { return currency; }
            init { currency = value; }
        }

        private int id;
        public int Id 
        {
            get { return id; }
            set { id = value; } 
        }

        private string owner;
        public string Owner 
        {
            get { return owner; }
            set { owner = value; } 
        }

        private int balance;
        public int Balance 
        { 
            get { return balance; } 
            set { balance = value; }
        }

        private CardType type;
        public CardType Type
        {
            get { return type; }
            set { type = value; } 
        }

        public Card(int id, string owner, int balance, CardType type, string currency)
        {
            this.id = id;
            this.owner = owner;
            this.balance = balance;
            this.type = type;
            this.currency = currency;
        }

        public void showBalanc()
        {
            Console.WriteLine(balance);
        }
    }
}
