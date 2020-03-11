using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class CustomerService : ICustomerService
    {
        public void AddCustomer()
        {
            Console.WriteLine("Add customer");
        }
    }
}
