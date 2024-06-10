using Organization.Core.Entities;

namespace Organization.API.Models
{
    public class EmployeePostModel
    {
        public string idEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartWorksDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Sex SexFM { get; set; }
        public List<RoleToEmployee> Roles { get; set; }
    }
}