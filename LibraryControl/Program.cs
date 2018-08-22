using LibraryControl.User.Lib;
using LibraryControl.User.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Users> users = new List<Users>();

            Console.WriteLine("New user? 1/0: ");
            int k = Int32.Parse(Console.ReadLine());
            if (k == 1)
            {
                ServiceXmLDocument service = new ServiceXmLDocument(@"C:\Users\КимМ\Documents\Visual Studio 2015\Projects\LibraryControl\LibraryControl\WORK");

                try
                {
                    Users user = new Users();

                    //user.email = "jhsgd@jshd/ru";
                    //user.login = "jsagd";
                    //user.Password = "6454kjfk";

                    service.CreateUser(user);
                    Console.WriteLine("пользователь успешно добавлен");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
    }
}
