using BankApplication.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class CreateNewAccount : ListOfCustomers
    {
        public static void CreateCustomerAccount()
        {
            Console.WriteLine("Input Your BVN");
            string bvn = Console.ReadLine();

            Console.WriteLine("Type Your FirstName");
            string firsName = Console.ReadLine();
            

            Console.WriteLine("Input Your Last Name");
            string lastname = Console.ReadLine();

            Console.WriteLine("Input Phone Number");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Input your email");
            string email = Console.ReadLine();

            Console.WriteLine("Input Password");
            string password = Console.ReadLine();


            Console.WriteLine("What Type of account Do You Want?\n Press S for Savings and C for Current Account");
            string acctype = Console.ReadLine();

            Console.Clear();

            string accounttype = "";


            if(acctype == "S")
            {
                accounttype = "SAVINGS";
            }
            if (acctype == "C")
            {
                accounttype = "CURRENT";
            }



            bool found = false;

            foreach (var registeredUsers in customerList)
            {
                Customer user = registeredUsers.Value;
                if (user.GetBVN() == bvn)
                {
                    if (user.GetAccountType() == accounttype)
                    {
                        Logger.Log($"You already Have a {accounttype} account");
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {


                Customer customer = new Customer(firsName, lastname, phoneNumber, email, accounttype, password, bvn);

                string accountNumber = AccountNumberGenerator.GenerateNewAccountNumber();

                AddCustomer(accountNumber, customer);

                Console.WriteLine("Account has been Successfully Created.\n Your Account Number is " + accountNumber);

            }
            
            Login.LoginUser();


        }



    }
}
