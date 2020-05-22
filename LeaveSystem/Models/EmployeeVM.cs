using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        [Required]
       
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
       
        public string TaxId { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateofJoin { get; set; }

    }
}
