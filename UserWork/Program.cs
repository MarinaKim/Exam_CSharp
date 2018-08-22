using LibraryControl.User.Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UserWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Users> listUsers = new List<Users>();

            Users user=new Users(Guid.NewGuid().ToString(),"Ivanov B.N.", "gfhywetr76457","Abaya 23","222-34-56","Ivanov@mail.ru", "Harry Potter 3");
              
                
                XmlSerializer formatter = new XmlSerializer(typeof(Users));

            using (FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, user);
                Console.WriteLine("объект сериализирован");
            }
        }
    }
}
