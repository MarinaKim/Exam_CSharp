﻿using LibraryControl.BookStock.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryControl.User.Lib.Model
{
    public class Users
    {
        public string id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string issueTag { get; set; }
        public List<Book> tagsUsed { get; set; }

        public Users() { }
        public Users( string id, string name, string password, string address, string contact, string email, string issueTag)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.address = address;
            this.contact = contact;
            this.email = email;
            this.issueTag = issueTag;
        }

        public void GetFirstInfoUser()
        {
            Console.WriteLine("Enter your email: {0}",email);
            Console.WriteLine("Enter your password: {0}", password);
        }

        public void GetSecondInfoUser()
        {
            Console.WriteLine("Enter your name: {0}", name);           
            Console.WriteLine("Enter your address: {0}",address);           
            Console.WriteLine("Enter your contuctNum: {0}",contact);            
        }
    }
}
