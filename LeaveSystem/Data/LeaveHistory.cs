using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Data
{
    public class LeaveHistory
    {

        [Key]
        public int Id { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee employee { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType leaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? Approved { get; set; }
        [ForeignKey("ApprovedById")]
        public Employee ApprovedBy { get; set; }
        public int ApprovedById { get; set; }
    }
}
