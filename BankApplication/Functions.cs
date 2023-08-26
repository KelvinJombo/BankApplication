using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
