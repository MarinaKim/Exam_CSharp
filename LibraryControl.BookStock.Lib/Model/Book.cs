using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibraryControl.BookStock.Lib.Model
{

    [Serializable]
    public class Book
    {
        public int No { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string authorName { get; set; }
        public DateTime publishDate { get; set; }
        public string edition { get; set; }
        public string status { get; set; }

        public Book() { }

        public Book(int No, string name, string code, string authorName, DateTime publishDate, string edition, string status)
        {
            this.No = No;
            this.name = name;
            this.code = code;
            this.authorName = authorName;
            this.publishDate = publishDate;
            this.edition = edition;
            this.status = status;
        }
        //public void SerializationBook(List<Book> listBook)
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();

        //    using (FileStream fs = new FileStream("listSerial.txt", FileMode.OpenOrCreate))
        //    {
        //        formatter.Serialize(fs, listBook);
        //        Console.WriteLine("Объект сериализрован");
        //    }
        //}
        //public void DeserializationBook(string pathDocument)
        //{
        //    BinaryFormatter bf = new BinaryFormatter();
        //    using (FileStream fs = new FileStream(pathDocument, FileMode.OpenOrCreate))
        //    {
        //        var t = (List<Book>)bf.Deserialize(fs);
        //        Console.WriteLine("Объект десериализирован");
        //        foreach (Book item in t)
        //        {
        //            Console.WriteLine(item.No + "\t" + item.name + "\t" + item.code + "\t" + item.authorName + "\t" + item.publishDate + "\t" + item.edition + "\t" + item.status);
        //        }

        //    }
        //}
    }
}
