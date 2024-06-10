using Organization.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Core.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetList();
        Employee GetById(int id);
        Task<Employee> postAsync(Employee e);
        Task<Employee> putAsync(int id, Employee employee);
        Task<Employee> deleteAsync(int id);
    }
}