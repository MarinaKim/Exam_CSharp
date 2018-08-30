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
        
    }
}
