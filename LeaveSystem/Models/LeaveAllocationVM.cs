using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        public int NumberofDays { get; set; }
        public DateTime DateCreated { get; set; }
       
        public EmployeeVM employee { get; set; }
        public int EmployeeId { get; set; }
        
        public DetailsLeaveTypeVM leaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
