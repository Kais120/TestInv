using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Company
    {
        public Company()
        {
            Invoices = new HashSet<Invoice>();
        }

        [Key]
        public Guid Uid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Registration Date")]
        public DateTime RegDate { get; set; } = DateTime.Now;
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        public IEnumerable<Invoice> Invoices;
    }
}
