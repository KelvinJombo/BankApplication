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
    internal class Functions : Logged 
    {

        static Dictionary<string, Customer> customerList = ListOfCustomers.customerList;

        public static void DepositFunds(double amount)
        {
            if (amount > 0)
            {
                Transaction.Deposit(amount);
                Console.Clear();    
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
                   if ((bal - 1000) >= amount)
                    {
                        Transaction.Withdraw(amount);
                        Logger.Log("Withdraw Successful");
                    }
                    else
                    {
                        {
                            Logger.Log("Insufficient Funds");
                        }
                    }
                }
                else if (accountType == "CURRENT")
                {

                    if (bal >= amount)
                    {
                        Transaction.Withdraw(amount);
                        
                        Logger.Log("Withdrawal Successful");
                    }
                    else
                    {
                        Logger.Log("Insufficient Funds");

                    }

                }

                
            }
            else
            {
                Console.Clear();
                Logger.Log("Invalid Withdrawal Amount.");
                 

            }
        }


        public static void Transfer(double amount)
        {
            if (amount < 0)
            {
                Logger.Log("Invalid Transfer Amount. ");
            }
            else
            {
                Logger.Log("Input Beneficiary Account Number");
                string destinationAccNo = Console.ReadLine();

                if (destinationAccNo == LoggedAccount)
                {
                    Logger.Log("You Can't Transfer To Your Same Account");
                }
                else
                {
                    double balance = loggedCustomer.GetBalance();
                    if (loggedCustomer.GetAccountType() == "SAVINGS")
                    {
                        if((balance-1000) < amount)
                        {
                            Logger.Log("Insufficient balance");
                            return;
                        }
                    }

                    if (balance >= amount)
                    {
                        bool found = false;

                        foreach (var regUsers in customerList)
                        {
                            if (regUsers.Key == destinationAccNo)
                            {
                                double currentBalance = balance - amount;
                                loggedCustomer.SetBalance(currentBalance);

                                double beneficiaryBalance = regUsers.Value.GetBalance() + amount;
                                regUsers.Value.SetBalance(beneficiaryBalance);
                                found = true; 
                                break;
                            }
                        }
                        if (found)
                        {
                            Logger.Log("Transfer Successful");
                             
                        }
                        else
                        {
                            Logger.Log("Insufficient Balance");
                             
                        }

                    }
                    else
                    {
                        Logger.Log("Insufficient Funds");
                         
                    }
                   
                }

            }
        }




    }
}
