using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Core.Entities
{
    public class RoleToEmployee
    {
        public int Id { get; set; }
        public Employee IdEmployee { get; set; }
        public Role IdRole { get; set; }
        public DateTime DateOfEntry { get; set; }
    }
}