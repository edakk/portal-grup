using Portal_Grup_EdaKok.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Models.Concrete
{
    public class Order:BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Customers")]
        public int CostumerId { get; set; }
        public virtual Customer Customers { get; set; }


        [Required]
        [ForeignKey("Addresses")]
        public int AdressId { get; set; }

        public virtual Address Addresses { get; set; }

        [Required]
        [Column(TypeName = "decimal(16,2")]
        public decimal TotalPrice { get; set; }
       
        
    }
}
