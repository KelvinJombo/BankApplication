using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Transaction : Logged 
    {
         
        static Dictionary<string, Customer> customerList = ListOfCustomers.customerList;


        public string GenerateTransactionID()
        {
            Guid newGuid = Guid.NewGuid();
            return newGuid.ToString();
        }
        public static void Deposit(double amount)
        {

            foreach (var item in customerList)
            {
                if (item.Key == LoggedAccount)
                {
                    Customer customer = item.Value;
                    double balance = customer.GetBalance();
                    double currentBalance = balance + amount;
                    customer.SetBalance(currentBalance);
                    break;
                }
            }
        }


        public static void Withdraw(double amount)
        {
            foreach (var item in customerList)
            {
                if (item.Key == LoggedAccount)
                {
                    Customer customer = item.Value;
                    double balance = customer.GetBalance();
                    double currentBalance = balance - amount;
                    customer.SetBalance(currentBalance);
                    break;
                   
                }
            }


        }


        public void Transfer()
        {
            
        }


        public static double CheckBalance()
        {
            double bal = 0;
            foreach (var item in customerList)
            {
                if (item.Key == LoggedAccount)
                {
                    Customer customer = item.Value;
                    bal = customer.GetBalance();
                }
            }
            return bal;
        }

        public void GetStatementOfAccountod()
        {

        }

        public static string GetAccountType()
        {
            string accountType = " ";

            foreach (var item in customerList)
            {
                if (item.Key == LoggedAccount)
                {
                    Customer customer = item.Value;
                    accountType = customer.GetAccountType();
                   

                }
                 
            }
            return accountType;
        }
}   }           

