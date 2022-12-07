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
    public class CustomerRepository : ICustomer
    {
        private readonly PContext _context;

        public CustomerRepository(PContext context)
        {
            _context = context;

        }

        public Customer Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer Delete(Customer customer)
        {
            _context.Customers.Attach(customer);
            _context.Entry(customer).State = EntityState.Deleted;
            _context.SaveChanges();
            return customer;
        }

        public Customer Edit(Customer customer)
        {
            _context.Customers.Attach(customer);
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
            return customer;
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = _context.Customers.Where(u => u.Id == id).FirstOrDefault();
            return customer;
           
        }

        public List<Customer> GetItems()
        {
            List<Customer> customers = _context.Customers.ToList();

            return (customers);
        }
  
    }
}
