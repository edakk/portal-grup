using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal_Grup_EdaKok.Data;
using Portal_Grup_EdaKok.Interfaces;
using Portal_Grup_EdaKok.Models.Concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Controllers
{
    public class CustomerController : Controller
    {

        public IActionResult Index()
        {
            List<Customer> customers = _customerRepo.GetItems();
            return View(customers);
        }
        private readonly ICustomer _customerRepo;
        public CustomerController(ICustomer customerrepo)
        {
          
            _customerRepo = customerrepo;
        }
        public IActionResult Create()
        {
            Customer customer= new Customer();
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {
            try
            {

                customer = _customerRepo.Create(customer);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            Customer customer = _customerRepo.GetCustomer(id);
            return View(customer);
        }
        public IActionResult Edit(int id)
        {
            Customer customer = _customerRepo.GetCustomer(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            try
            {
                customer = _customerRepo.Edit(customer);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Customer customer = _customerRepo.GetCustomer(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            try
            {
                customer = _customerRepo.Delete(customer);


            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
       
       
    }
}
