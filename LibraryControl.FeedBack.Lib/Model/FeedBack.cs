using LibraryControl.BookStock.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryControl.FeedBack.Lib.Model
{
    public class FeedBack:Book
    {
        public int issueNo { get; set; }
        public string borrowName { get; set; }
        public DateTime issueDate { get; set; }
        public DateTime returnDate { get; set; }
    }
}
