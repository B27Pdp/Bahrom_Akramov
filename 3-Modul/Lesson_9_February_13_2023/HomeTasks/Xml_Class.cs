using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _3_Modul.Lesson_9_February_13_2023.HomeTasks
{
    internal class Xml_Class
    {
        public static void AddElementToXml(int id, string author, string title, int price, string description)
        {
            string fileName = @"..\..\..\Lesson_9_February_13_2023\HomeTasks\books.xml";

            using (XmlWriter xmlWriter = XmlWriter.Create(fileName))
            {
                Book book = new(id, author, title, price, description);
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("bookstore");

                xmlWriter.WriteStartElement("book");
                xmlWriter.WriteElementString("id", $"{book.Id}");
                xmlWriter.WriteElementString("author", book.Author);
                xmlWriter.WriteElementString("title", book.Title);
                xmlWriter.WriteElementString("price", $"{book.Price}");
                xmlWriter.WriteElementString("description", book.Description);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }

            Console.WriteLine("Xml faylga element qo'shildi");
        }


    }
}
