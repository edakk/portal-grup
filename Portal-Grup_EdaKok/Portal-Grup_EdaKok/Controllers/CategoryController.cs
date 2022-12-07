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
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            List<Category> Categorys = _CategoryRepo.GetItems();
            return View(Categorys);
        }

        private readonly ICustomer _customerRepo;
        private readonly ICategory _CategoryRepo;
       

        public CategoryController(ICategory Categoryrepo, ICustomer customer)
        {

            _customerRepo = customer;
            _CategoryRepo = Categoryrepo;
        }
        public IActionResult Create()
        {
            Category Category = new Category();

          // ViewBag();
            return View(Category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category Category)
        {
            try
            {
                Category = _CategoryRepo.Create(Category);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            Category Category = _CategoryRepo.GetCategory(id);
            return View(Category);
        }
        public IActionResult Edit(int id)
        {
            Category Category = _CategoryRepo.GetCategory(id);
            return View(Category);
        }
        [HttpPost]
        public IActionResult Edit(Category Category)
        {
            try
            {
                Category = _CategoryRepo.Edit(Category);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Category Category = _CategoryRepo.GetCategory(id);
            return View(Category);
        }
        [HttpPost]
        public IActionResult Delete(Category Category)
        {
            try
            {
                Category = _CategoryRepo.Delete(Category);


            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }



    }
}