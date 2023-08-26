using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Initiation
    {
        public void Welcomeuser()
        {
            Console.WriteLine("WELCOME TO .NET BANK INTERNATIONAL");
            Console.WriteLine("Pres 1 to Create An Account With Us\n Press 2 to Log into Your Account");
            Console.WriteLine("Press 3 To Deposite Money\n Press 4 To Withraw Some Money");
            Console.WriteLine("Press 5 To Transfer Money\n Press 6 To Print Account Statement");
            Console.WriteLine("Press 7 To Exit\n Press 8 To Exit");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Functions.CreateCustomerAccount();
                    break;

                    case "2":
                    Functions.LoginCustomer(); 
                    break;
            }
        }
    }
}
