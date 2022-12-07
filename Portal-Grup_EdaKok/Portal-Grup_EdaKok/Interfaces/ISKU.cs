using Portal_Grup_EdaKok.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Interfaces
{
   public interface ISKU
    {
        List<SKU> GetItems();
        SKU GetSKU(int id);
        SKU Create(SKU SKU);
        SKU Edit(SKU SKU);
        SKU Delete(SKU SKU);
    }
}
