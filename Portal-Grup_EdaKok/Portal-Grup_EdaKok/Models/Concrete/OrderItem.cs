using Portal_Grup_EdaKok.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Models.Concrete
{
    public class OrderItem:BaseEntity
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Skus")]
        public int SkuId { get; set; }
        public virtual SKU Skus { get; set; }

        [Required]
        [ForeignKey("Orders")]
        public int OrderID { get; set; }
        public virtual Order Orders { get; set; }

        [Required]
        [Column(TypeName = "decimal(16,2")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
