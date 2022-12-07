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
    public class SKUController : Controller
    {
        public IActionResult Index()
        {
            List<SKU> SKUs = _SKURepo.GetItems();
            return View(SKUs);
        }
        private readonly ISKU _SKURepo;
        public SKUController(ISKU SKUrepo)
        {
          
            _SKURepo = SKUrepo;
        }
        public IActionResult Create()
        {
            SKU SKU= new SKU();
            return View(SKU);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SKU SKU)
        {
            try
            {
                SKU = _SKURepo.Create(SKU);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            SKU SKU = _SKURepo.GetSKU(id);
            return View(SKU);
        }
        public IActionResult Edit(int id)
        {
            SKU SKU = _SKURepo.GetSKU(id);
            return View(SKU);
        }
        [HttpPost]
        public IActionResult Edit(SKU SKU)
        {
            try
            {
                SKU = _SKURepo.Edit(SKU);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            SKU SKU = _SKURepo.GetSKU(id);
            return View(SKU);
        }
        [HttpPost]
        public IActionResult Delete(SKU SKU)
        {
            try
            {
                SKU = _SKURepo.Delete(SKU);


            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }


       
    }
}
