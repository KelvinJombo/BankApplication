using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Customer
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string phoneNumber { get; set; }
        private string email { get; set; }

        private double balance { get; set; }

        private string accountType { get; set; }   

        private string password { get; set; }
        


        public Customer(string fname, string lname, string phone, string email, string accountType, string password)
        {
            this .firstName = fname;
            this .lastName = lname;
            this .phoneNumber = phone;
            this .email = email;
            this.balance = 0;
            this.accountType = accountType;
            this.password = password;
            

        }


        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetBalance(double amount)
        {
            balance = amount;
        }

        

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }


        public string GetEmail()
        {
            return email;
        }


        public string GetAccountType()
        {
            return accountType;
        }


        public double GetBalance()
        {
            return balance;
        }

        public string GetPassword()
        {
            return password;
        }

         


    }
}
