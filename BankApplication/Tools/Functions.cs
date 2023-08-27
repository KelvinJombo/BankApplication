using BankApplication.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankApplication
{
    internal class Functions
    {
        public static void LoginCustomer()
        {
            Login.LoginUser();
        }


        public static void CreateCustomerAccount()
        {
            CreateNewAccount.CreateCustomerAccount();
        }


        public static void DepositFunds(double amount)
        {
            if (amount > 0)
            {
                Transaction.Deposit(amount);
                Logger.Log($"{amount} has been Successfully credited to Your Account");
            }

            else
            {
                Console.Clear();
                Logger.Log(" Transaction Failed. Invalid Amount");
            }

        }


        public static void Withdraw(double amount)
        {
            if (amount > 0)
            {
                double bal = Transaction.CheckBalance();
                string accountType = Transaction.GetAccountType();

                if (accountType == "SAVINGS")
                {
                    bal -= 1000;

                }

                if (bal >= amount)
                {
                    Transaction.Withdraw(amount);
                    Console.Clear();
                    Logger.Log("Withdrawal Successful");
                }
                else
                {
                    Logger.Log("Insufficient Funds");

                }
            }
            else
            {
                Console.Clear();
                Logger.Log("Invalid Withdrawal Amount");
                Initiation.Options();

            }
        }
    }
}
