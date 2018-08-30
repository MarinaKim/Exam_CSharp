using LibraryControl.Admin.Lib.Model;
using LibraryControl.BookStock.Lib.Model;
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
            List<Administrator> admins = new List<Administrator>();

            Console.WriteLine("Choose:");
            Console.WriteLine("1.Administrator");
            Console.WriteLine("2.User");

            int k = Int32.Parse(Console.ReadLine());
            if (k == 1) //admin
            {
                Console.WriteLine("New admin? 1/0:");
                int n = Int32.Parse(Console.ReadLine());
                if (n == 1)//new admin
                {
                    ServiceAdminXmLDocument service = new ServiceAdminXmLDocument(@"C:\Users\Марина\Source\Repos\Exam_CSharp\LIBRARY\Admin");
                    try
                    {
                        Administrator admin = new Administrator();
                        admin.GetInfoAdmin();

                        //проверка на наличие admina с таким name b pass
                        if () //не существует
                        {
                            service.CreateAdmin(admin);
                            admins.Add(admin);
                            Console.WriteLine("Администратор успешно добавлен");
                        }                       
                        else
                        {
                            Console.WriteLine("Администратор уже существует.");  
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (n == 0)
                {
                    Administrator admin = new Administrator();
                    admin.GetInfoAdmin();
                    //проверка на наличие admina с таким name b pass
                    if ()
                    {
                        Console.WriteLine("Выберите: ");
                        Console.WriteLine("1. Удалить пользователя.");
                        Console.WriteLine("2. Добавить книгу.");
                        Console.WriteLine("3. Добавить пользователя.");
                        Console.WriteLine("4. Сменить пароль.");
                    }
                    else
                    {
                        Console.WriteLine("Администратор с тиким именем не существует.");
                    }
                }
            }
            else if (k == 2) //user
            {
                Console.WriteLine("New user? 1/0:");
                int n = Int32.Parse(Console.ReadLine());
                if (n == 1) //new user
                {
                    ServiceXmLDocument service = new ServiceXmLDocument(@"C:\Users\Марина\Source\Repos\Exam_CSharp\LIBRARY\Users");

                    try
                    {
                        Users user = new Users();
                        user.GetFirstInfoUser();

                        //проверка на наличие пользователя с таким email
                        if () //не существует
                        {
                            user.GetSecondInfoUser();
                            service.CreateUser(user);
                            users.Add(user);
                            Console.WriteLine("пользователь успешно добавлен");
                        }
                        else
                        { 
                            Console.WriteLine("Пользователь с таким email уже существует.");                         
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else if (n == 0)
                {
                    Users user = new Users();

                    user.GetFirstInfoUser();

                    //проверка на наличие пользователя с таким email
                    if ()// если есть
                    {
                        Console.WriteLine("Выберите: ");
                        Console.WriteLine("1. сдать книгу");
                        Console.WriteLine("2. выбрать книгу");
                        Console.WriteLine("3. сменить пароль");
                        int v = Int32.Parse(Console.ReadLine());
                        if (v == 1)
                        {
                            Book book = new Book();
                            Console.WriteLine("Введите название книги: {0}",book.name);
                        }
                        else if (v == 2)
                        {
                            Book book = new Book();
                            Console.WriteLine("Введите название книги: {0}", book.name);
                        }
                        else if (v == 3)
                        {
                            Console.WriteLine("Введите новый пароль: {0}",user.password);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого пользователя не существует.");
                    }

                }
            }
        }
    }
}
