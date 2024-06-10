using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Core.Entities
{
    public enum Sex { F, M }
    public class Employee
    {
        public int Id { get; set; }
        public string idEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartWorksDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Sex SexFM { get; set; }
        public List<RoleToEmployee> Roles { get; set; }
        public bool Status { get; set; }
    }
}