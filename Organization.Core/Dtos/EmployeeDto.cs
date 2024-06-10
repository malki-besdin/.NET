using Organization.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Core.Dtos
{
    public class EmployeeDto//רק מה שיציג
    {
        public string idEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartWorksDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Sex SexFM { get; set; }
    }
}