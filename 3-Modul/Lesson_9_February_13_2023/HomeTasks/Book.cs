using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_9_February_13_2023.HomeTasks
{
    internal class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Book(int id, string author, string title, int price, string description)
        {
            Id = id;
            Author = author;
            Title = title;
            Price = price;
            Description = description;
        }
    }
}
