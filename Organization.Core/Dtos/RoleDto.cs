using Organization.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Core.Dtos
{
    public class RoleDto
    {
        public bool Management { get; set; }
        public NameRole NameOfRole { get; set; } 
        public DateTime DateOfEntry { get; set; }
    }
}
