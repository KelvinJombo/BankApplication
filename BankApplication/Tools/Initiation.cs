using BankApplication.Tools;
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




        public static void Options()
        {
            Console.WriteLine("Welcome User");
           
            Console.WriteLine("Press 1 To Deposit Money\n Press 2 To Withraw Some Money");
            Console.WriteLine("Press 3 To Transfer Money\n Press 4 To Print Account Statement");
            Console.WriteLine("Press 5 To Check balance\n Press 6 To Exit");
            Console.WriteLine("Press 7 to Create Another Account With Us\n Press 8 to login to another account");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Logger.Log("input Amount To Deposit");
                    string inputAmount = Console.ReadLine();
                    

                    double amount = Convert.ToDouble(inputAmount);

                    Functions.DepositFunds(amount);
                    Options();
                    break;

                case "2":
                    Logger.Log("input Amount To Withdraw");
                    string inputWithdrawAmount = Console.ReadLine();
                    double amountToWithdraw = Convert.ToDouble(inputWithdrawAmount);

                    Functions.Withdraw(amountToWithdraw);
                    Options();
                    break;

                case "5":
                    double bal = Transaction.CheckBalance();
                    Console.Clear();
                    Logger.Log($"Your Current Balance is {bal}");
                    Options();
                    break;
            }



        }
    }
}
