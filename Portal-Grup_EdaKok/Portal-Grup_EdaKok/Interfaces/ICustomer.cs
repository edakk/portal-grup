using Portal_Grup_EdaKok.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Interfaces
{
   public interface ICustomer
    {
        List<Customer> GetItems();
        Customer GetCustomer(int id);
        Customer Create(Customer customer);
        Customer Edit(Customer customer);
        Customer Delete(Customer customer);
    }
}
