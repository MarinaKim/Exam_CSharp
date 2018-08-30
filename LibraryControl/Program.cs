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

            Console.WriteLine("Choose:");
            Console.WriteLine("1.Administrator");
            Console.WriteLine("2.User");

            int k = Int32.Parse(Console.ReadLine());
            if (k == 1) //admin
            {
                Console.WriteLine("New admin? 1/0:");
                int n = Int32.Parse(Console.ReadLine());
                if (n == 1)
                {

                }
                else if (n == 0)
                {
                    Console.WriteLine("Enter your login: ");
                    Console.WriteLine("Enter your password: ");
                }
            }
            else if (k == 2) //user
            {
                Console.WriteLine("New user? 1/0:");
                int n = Int32.Parse(Console.ReadLine());
                if (n == 1)
                {
                    ServiceXmLDocument service = new ServiceXmLDocument(@"C:\Users\Марина\Source\Repos\Exam_CSharp\LIBRARY");

                    try
                    {
                        Users user = new Users();

                        Console.WriteLine("Enter your name: ");
                        user.name = Console.ReadLine();
                        Console.WriteLine("Enter your password: ");
                        user.password = Console.ReadLine();
                        Console.WriteLine("Enter your email: ");
                        user.email = Console.ReadLine();
                        Console.WriteLine("Enter your address: ");
                        user.address = Console.ReadLine();
                        Console.WriteLine("Enter your contuctNum: ");
                        user.contact = Console.ReadLine();

                        service.CreateUser(user);
                        Console.WriteLine("пользователь успешно добавлен");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else if (n == 0)
                {
                    Users user = new Users();

                    Console.WriteLine("Enter your name: ");
                    user.name = Console.ReadLine();
                    Console.WriteLine("Enter your password: ");
                    user.password = Console.ReadLine();

                    if ()
                    {

                    }
                    else
                    {

                    }

                }
            }
        }
    }
}
