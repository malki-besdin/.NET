using Organization.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Core.Services
{
    public interface IRoleService
    {
        List<Role> GetAll();
        Role GetById(int id);
        Task<Role> postAsync(Role e);
        Task<Role> putAsync(int id, Role role);
        Task<Role> deleteAsync(int r);
    }
}
