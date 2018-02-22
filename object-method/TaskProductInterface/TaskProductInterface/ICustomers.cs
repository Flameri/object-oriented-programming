using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProductInterface
{
    interface ICustomers
    {
        void AddCustomer(List<Customer> customer);
        void PrintCustomers();
    }
}
