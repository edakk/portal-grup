using Portal_Grup_EdaKok.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Interfaces
{
   public interface IAddress
    {
        List<Address> GetItems();
        Address GetAddress(int id);
        Address Create(Address Address);
        Address Edit(Address Address);
        Address Delete(Address Address);
    }
}
