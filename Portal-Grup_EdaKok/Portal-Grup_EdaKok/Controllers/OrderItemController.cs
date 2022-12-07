using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal_Grup_EdaKok.Data;
using Portal_Grup_EdaKok.Interfaces;
using Portal_Grup_EdaKok.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Controllers
{
    public class OrderItemController : Controller
    {
        public IActionResult Index()
        {
            List<OrderItem> OrderItems = _OrderItemRepo.GetItems();
            return View(OrderItems);
        }
        private readonly IOrderItem _OrderItemRepo;
        public OrderItemController(IOrderItem OrderItemrepo)
        {
          
            _OrderItemRepo = OrderItemrepo;
        }
        public IActionResult Create()
        {
            OrderItem OrderItem= new OrderItem();
            return View(OrderItem);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrderItem OrderItem)
        {
            try
            {
                OrderItem = _OrderItemRepo.Create(OrderItem);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            OrderItem OrderItem = _OrderItemRepo.GetOrderItem(id);
            return View(OrderItem);
        }
        public IActionResult Edit(int id)
        {
            OrderItem OrderItem = _OrderItemRepo.GetOrderItem(id);
            return View(OrderItem);
        }
        [HttpPost]
        public IActionResult Edit(OrderItem OrderItem)
        {
            try
            {
                OrderItem = _OrderItemRepo.Edit(OrderItem);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            OrderItem OrderItem = _OrderItemRepo.GetOrderItem(id);
            return View(OrderItem);
        }
        [HttpPost]
        public IActionResult Delete(OrderItem OrderItem)
        {
            try
            {
                OrderItem = _OrderItemRepo.Delete(OrderItem);


            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }


       
    }
}
