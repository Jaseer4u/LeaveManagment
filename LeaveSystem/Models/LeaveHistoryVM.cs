using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Models
{
    public class LeaveHistoryVM
    {
        public int Id { get; set; }
       
        public EmployeeVM employee { get; set; }
        public int EmployeeId { get; set; }
       
        public DetailsLeaveTypeVM leaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? Approved { get; set; }
        
        public EmployeeVM ApprovedBy { get; set; }
        public int ApprovedById { get; set; }
    }
}
