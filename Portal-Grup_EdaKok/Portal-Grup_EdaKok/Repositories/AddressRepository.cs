using Microsoft.EntityFrameworkCore;
using Portal_Grup_EdaKok.Data;
using Portal_Grup_EdaKok.Interfaces;
using Portal_Grup_EdaKok.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Repositories
{
    public class AddressRepository : IAddress
    {
        private readonly PContext _context;

        public AddressRepository(PContext context)
        {
            _context = context;

        }

        public Address Create(Address Address)
        {
            _context.Addresses.Add(Address);
            _context.SaveChanges();
            return Address;
        }

        public Address Delete(Address Address)
        {
            _context.Addresses.Attach(Address);
            _context.Entry(Address).State = EntityState.Deleted;
            _context.SaveChanges();
            return Address;
        }

        public Address Edit(Address Address)
        {
            _context.Addresses.Attach(Address);
            _context.Entry(Address).State = EntityState.Modified;
            _context.SaveChanges();
            return Address;
        }

        public Address GetAddress(int id)
        {
            Address Address = _context.Addresses.Where(u => u.Id == id).FirstOrDefault();
            return Address;
           
        }

        public List<Address> GetItems()
        {
            List<Address> Addresss = _context.Addresses.ToList();

            return (Addresss);
        }
  
    }
}
