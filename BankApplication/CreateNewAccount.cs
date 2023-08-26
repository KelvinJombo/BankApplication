using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class CreateNewAccount
    {
        public static void CreateCustomerAccount()
        {
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

            string accounttype = " ";


            if(acctype == "S")
            {
                accounttype = "SAVINGS";
            }
            if (acctype == "C")
            {
                accounttype = "CURRENT";
            }


            Customer customer = new Customer(firsName, lastname, phoneNumber, email, accounttype, password);


            string accountNumber = AccountNumberGenerator.GenerateNewAccountNumber();




            ListOfCustomers.AddCustomer(accountNumber, customer);

            Console.WriteLine("Account has been Successfully Created.\n Your Account Number is " +  accountNumber); 

        }



    }
}
