using Portal_Grup_EdaKok.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Grup_EdaKok.Models.Concrete
{
    public class Customer:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long TCID { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gsm { get; set; }
    }
}
