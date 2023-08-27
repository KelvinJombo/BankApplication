using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{


    internal class ListOfCustomers
    {
        public static Dictionary<string, Customer> customerList = new Dictionary<string, Customer>();


        public static void AddCustomer(string accountnumber, Customer customer)
        {
            customerList.Add(accountnumber, customer);
        }
    }
}
