using Portal_Grup_EdaKok.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Interfaces
{
   public interface IOrderItem
    {
        List<OrderItem> GetItems();
        OrderItem GetOrderItem(int id);
        OrderItem Create(OrderItem OrderItem);
        OrderItem Edit(OrderItem OrderItem);
        OrderItem Delete(OrderItem OrderItem);
    }
}
