using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class AddCustomerCommand : ICommand
    {
        private readonly ICustomerService _customerService;
        public AddCustomerCommand(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}
