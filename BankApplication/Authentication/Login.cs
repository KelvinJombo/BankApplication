﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace BankApplication
{
    internal class Login: Logged
    {
        public static void LoginUser()
        {
            Console.WriteLine("Enter Your Account Number to Login");
            string accountNo = Console.ReadLine();


            Console.WriteLine("Enter Your Password");
            string password = Console.ReadLine();


            if (accountNo == " " || password == " ")
            {
                Console.WriteLine("All Fields Are Required. Try Again");
                LoginUser();
            }
            else
            {
                Customer foundCustomer = null;
                var customerList = ListOfCustomers.customerList;
                bool found = false;

                foreach (var item in customerList)
                {
                    if (item.Key == accountNo)
                    {
                        Customer customer = item.Value;
                        string passwd = customer.GetPassword();

                        if (password == passwd)
                        {
                            found = true;   
                        }
                    }
                }
                if (found)
                {
                    LoggedAccount = accountNo;
                    loggedCustomer = foundCustomer;
                    Console.WriteLine("Login Successful!!!");
                    Initiation.Options();

                }
                else
                {
                    Console.WriteLine("Invalid Login Details");
                    LoginUser();
                }
            }
        }
    }
}
