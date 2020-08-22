using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Invoice
    {
        [Key]
        public Guid Uid { get; set; }
        [Display(Name = "Company")]
        public Guid CompanyUid { get; set; }
        public string Number { get; set; } = DateTime.Now.ToString("yyyy-MM-dd-hh-mm");
        [DataType(DataType.Date)]
        [Display(Name = "Invoice Date")]
        public DateTime InvDate { get; set; } = DateTime.Now;
        public int Type { get; set; }
        [Required] 
        public double Total { get; set; }
        public Company Company { get; set; }
    }
}
