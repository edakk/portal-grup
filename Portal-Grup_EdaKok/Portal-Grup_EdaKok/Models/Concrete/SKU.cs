using Portal_Grup_EdaKok.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Models.Concrete
{
    public class SKU:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(16,2")]
        public decimal OldPrice { get; set; }


        [Required]
        [Column(TypeName = "decimal(16,2")]
        public decimal Price { get; set; }
        
        [Required]
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        public virtual Category Categories { get; set; }
    }
}
