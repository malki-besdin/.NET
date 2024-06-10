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
    public class RoleService:IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public List<Role> GetAll()
        {
          return _roleRepository.GetList().ToList();
        }
        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }
        public async Task<Role> postAsync(Role r)
        {
            return await _roleRepository.postAsync(r);
        }
        public async Task<Role> putAsync(int id, Role role)
        {
            return await _roleRepository.putAsync(id, role);
        }
        public async Task<Role> deleteAsync(int id)
        {
            return await _roleRepository.deleteAsync(id);
        }
    }
}
