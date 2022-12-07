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
    public class CategoryRepository : ICategory
    {
        private readonly PContext _context;

        public CategoryRepository(PContext context)
        {
            _context = context;

        }

        public Category Create(Category Category)
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
            return Category;
        }

        public Category Delete(Category Category)
        {
            _context.Categories.Attach(Category);
            _context.Entry(Category).State = EntityState.Deleted;
            _context.SaveChanges();
            return Category;
        }

        public Category Edit(Category Category)
        {
            _context.Categories.Attach(Category);
            _context.Entry(Category).State = EntityState.Modified;
            _context.SaveChanges();
            return Category;
        }

        public Category GetCategory(int id)
        {
            Category Category = _context.Categories.Where(u => u.Id == id).FirstOrDefault();
            return Category;
           
        }

        public List<Category> GetItems()
        {
            List<Category> Categorys = _context.Categories.ToList();

            return (Categorys);
        }
  
    }
}
