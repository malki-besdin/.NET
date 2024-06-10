using Microsoft.EntityFrameworkCore;
using Organization.Core.Entities;
using Organization.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetList()
        {
            return _context.Employees.Where(e => e.Status).Include(e => e.Roles).ToList();
        }
        public Employee GetById(int id)
        {
            return _context.Employees.Include(e => e.Roles).FirstOrDefault(e => e.Id == id);
        }
        public async Task<Employee> postAsync(Employee e)//add
        {
            Employee employee = GetById(e.Id);
            await _context.SaveChangesAsync();
            return employee;
        }
        public async Task<Employee> putAsync(int id, Employee e)
        {
            Employee existingEmployee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee != null)
            {
                existingEmployee = e;
                await _context.SaveChangesAsync();
            }
            return existingEmployee;
        }
        public async Task<Employee> deleteAsync(int id)
        {
            Employee employee = GetById(id);
            if (employee != null)
            {
                employee.Status = false;
                await _context.SaveChangesAsync();
            }
            return employee;
        }
    }
}