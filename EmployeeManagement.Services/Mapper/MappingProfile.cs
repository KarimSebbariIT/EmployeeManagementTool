using AutoMapper;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //entity to model
            CreateMap<Employee, EmployeeModel>();
            CreateMap<Employee, EmployeeCreateModel>();
            CreateMap<Employee, EmployeeUpdateModel>();

            //Model  to entity
            CreateMap<EmployeeModel, Employee>();
            CreateMap<EmployeeCreateModel, Employee>();
            CreateMap<EmployeeUpdateModel, Employee>();
        }
    }
}
