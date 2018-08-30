using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryControl.Admin.Lib.Model
{
    public class Administrator
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string adminRights { get; set; }
        public string libRight { get; set; }
        public string readerRights { get; set; }

        public void GetInfoAdmin()
        {            
            Console.WriteLine("Enter your name: {0}",name);           
            Console.WriteLine("Enter your password: {0}",password);            
        }

       
    }
}
