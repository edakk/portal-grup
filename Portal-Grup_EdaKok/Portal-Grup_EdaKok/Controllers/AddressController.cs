using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
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
    public class AddressController : Controller
    {
        public IActionResult Index()
        {
            List<Address> Addresss = _AddressRepo.GetItems();
            return View(Addresss);
        }

        private readonly ICustomer _customerRepo;
        private readonly IAddress _AddressRepo;
        private readonly PContext _context;

        public AddressController(IAddress Addressrepo, ICustomer customer)
        {

            _customerRepo = customer;
            _AddressRepo = Addressrepo;
        }
        public IActionResult Create()
        {
            Address Address = new Address();

          // ViewBag();
            return View(Address);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Address Address)
        {
            try
            {
                Address = _AddressRepo.Create(Address);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            Address Address = _AddressRepo.GetAddress(id);
            return View(Address);
        }
        public IActionResult Edit(int id)
        {
            Address Address = _AddressRepo.GetAddress(id);
            return View(Address);
        }
        [HttpPost]
        public IActionResult Edit(Address Address)
        {
            try
            {
                Address = _AddressRepo.Edit(Address);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Address Address = _AddressRepo.GetAddress(id);
            return View(Address);
        }
        [HttpPost]
        public IActionResult Delete(Address Address)
        {
            try
            {
                Address = _AddressRepo.Delete(Address);


            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }



    }
}