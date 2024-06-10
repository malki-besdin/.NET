using Organization.Core.Entities;
using Organization.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Data.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext _context;
        public RoleRepository(DataContext context)
        {
            _context = context;
        }

        public List<Role> GetList()
        {
            return _context.Roles.ToList();
        }
        public Role GetById(int id)
        {
            return _context.Roles.FirstOrDefault(r => r.Id == id);
        }
        public async Task<Role> postAsync(Role r)
        {
            _context.Roles.Add(r);
            await _context.SaveChangesAsync();
            return r;
        }
        public async Task<Role> putAsync(int id, Role role)
        {
            Role existingRole = _context.Roles.FirstOrDefault(r => r.Id == id);
            if (existingRole != null)
            {
                existingRole = role;
                await _context.SaveChangesAsync();
            }
            return existingRole;
        }
        public async Task<Role> deleteAsync(int id)
        {
            Role role = GetById(id);
            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
            return role;
        }
    }
}
