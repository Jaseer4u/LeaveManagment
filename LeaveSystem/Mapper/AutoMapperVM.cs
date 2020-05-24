
using AutoMapper;
using LeaveSystem.Data;
using LeaveSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Mapper
{
    public class AutoMapperVM : Profile 
    {
        public AutoMapperVM()
        {
            CreateMap<LeaveTypeVM, LeaveType>().ReverseMap();
            
        }
    }
}
