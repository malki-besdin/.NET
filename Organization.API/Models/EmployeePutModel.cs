using Organization.Core.Entities;

namespace Organization.API.Models
{
    //רק מה שאני רוצה שישלח  לעדכון : 
    //ללא  אידי וססטוס וללא אופציה לשנות ערכים נוספים כמו זכר/נקבה וכו 
    public class EmployeePutModel{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<RoleToEmployee> Roles { get; set; }
    }
}