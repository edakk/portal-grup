using Portal_Grup_EdaKok.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Models.Concrete
{
    public class Address:BaseEntity
    {

        [Key]
        public int Id { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Discrict { get; set; }
        public int ZipCode { get; set; }

        [Required]
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public virtual Customer Customers { get; set; }

    }
}
