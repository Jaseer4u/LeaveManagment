using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(300)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(300)")]
        public string TaxId { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateofJoin { get; set; }
      
    }
}
