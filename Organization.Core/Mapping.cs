using Organization.Core.Dtos;
using Organization.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Core
{
    public class Mapping
    {
        public Employee ToEmployee(EmployeeDto e)
        {
            return new Employee
            {
                idEmployee = e.idEmployee,
                FirstName = e.FirstName,
                LastName = e.LastName,
                StartWorksDate = e.StartWorksDate,
                DateOfBirth = e.DateOfBirth,
                SexFM = e.SexFM
            };
        }
        //
        public EmployeeDto ToDto(Employee e)
        {
            return new EmployeeDto
            {
                idEmployee = e.idEmployee,
                FirstName = e.FirstName,
                LastName = e.LastName,
                StartWorksDate = e.StartWorksDate,
                DateOfBirth = e.DateOfBirth,
                SexFM = e.SexFM
            };
        }
    }
}