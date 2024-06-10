using Organization.Core.Entities;
using Organization.Core.Repositories;
using Organization.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Service
{
    public class EmployeeService : IEmployeeService

    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetList();
        }
        public Employee GetById(int id)
        {
            return _employeeRepository.GetById(id);
        }
        public async Task<Employee >postAsync(Employee e)//add
        {
            return await _employeeRepository.postAsync(e);
        }
        public async Task<Employee> putAsync(int id, Employee employee)//update
        {
            return await _employeeRepository.putAsync(id, employee);
        }
        public  async Task<Employee> deleteAsync(int id)
        {
            return await _employeeRepository.deleteAsync(id);
        }
    }
}