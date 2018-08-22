using LibraryControl.BookStock.Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> listBook = new List<Book>();
            listBook.Add(new Book(1, "Harry Potter 1", Guid.NewGuid().ToString(), "j.K. Rowling", DateTime.Parse("01.01.14"), "Mahaon", "free"));
            listBook.Add(new Book(2, "Harry Potter 2", Guid.NewGuid().ToString(), "j.K. Rowling", DateTime.Parse("01.07.14"), "Mahaon", "free"));

            listBook.Add(new Book(3, "Harry Potter 3", Guid.NewGuid().ToString(), "j.K. Rowling", DateTime.Parse("22.05.14"), "Mahaon", "busy"));

            listBook.Add(new Book(4, "Harry Potter 4", Guid.NewGuid().ToString(), "j.K. Rowling", DateTime.Parse("11.01.15"), "Mahaon", "free"));

            listBook.Add(new Book(5, "Harry Potter 5", Guid.NewGuid().ToString(), "j.K. Rowling", DateTime.Parse("01.01.11"), "Mahaon", "free"));

            listBook.Add(new Book(6, "Harry Potter 6", Guid.NewGuid().ToString(), "j.K. Rowling", DateTime.Parse("01.01.13"), "Mahaon", "busy"));


            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));


            using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, listBook);
                Console.WriteLine("объект сериализирован");
            }

        }
    }
}
