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
    public class OrderItemRepository : IOrderItem
    {
        private readonly PContext _context;

        public OrderItemRepository(PContext context)
        {
            _context = context;

        }

        public OrderItem Create(OrderItem OrderItem)
        {
            _context.OrderItems.Add(OrderItem);
            _context.SaveChanges();
            return OrderItem;
        }

        public OrderItem Delete(OrderItem OrderItem)
        {
            _context.OrderItems.Attach(OrderItem);
            _context.Entry(OrderItem).State = EntityState.Deleted;
            _context.SaveChanges();
            return OrderItem;
        }

        public OrderItem Edit(OrderItem OrderItem)
        {
            _context.OrderItems.Attach(OrderItem);
            _context.Entry(OrderItem).State = EntityState.Modified;
            _context.SaveChanges();
            return OrderItem;
        }

        public OrderItem GetOrderItem(int id)
        {
            OrderItem OrderItem = _context.OrderItems.Where(u => u.Id == id).FirstOrDefault();
            return OrderItem;
           
        }

        public List<OrderItem> GetItems()
        {
            List<OrderItem> OrderItems = _context.OrderItems.ToList();

            return (OrderItems);
        }
  
    }
}
