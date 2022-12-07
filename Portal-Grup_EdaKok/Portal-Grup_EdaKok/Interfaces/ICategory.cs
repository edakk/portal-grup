using Portal_Grup_EdaKok.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Interfaces
{
   public interface ICategory
    {
        List<Category> GetItems();
        Category GetCategory(int id);
        Category Create(Category Category);
        Category Edit(Category Category);
        Category Delete(Category Category);
    }
}
