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
    public class SKURepository : ISKU
    {
        private readonly PContext _context;

        public SKURepository(PContext context)
        {
            _context = context;

        }

        public SKU Create(SKU SKU)
        {
            _context.Skus.Add(SKU);
            _context.SaveChanges();
            return SKU;
        }

        public SKU Delete(SKU SKU)
        {
            _context.Skus.Attach(SKU);
            _context.Entry(SKU).State = EntityState.Deleted;
            _context.SaveChanges();
            return SKU;
        }

        public SKU Edit(SKU SKU)
        {
            _context.Skus.Attach(SKU);
            _context.Entry(SKU).State = EntityState.Modified;
            _context.SaveChanges();
            return SKU;
        }

        public SKU GetSKU(int id)
        {
            SKU SKU = _context.Skus.Where(u => u.Id == id).FirstOrDefault();
            return SKU;
           
        }

        public List<SKU> GetItems()
        {
            List<SKU> SKUs = _context.Skus.ToList();

            return (SKUs);
        }
  
    }
}
