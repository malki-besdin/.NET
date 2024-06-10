using Organization.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Core.Repositories
{
    public interface IRoleRepository

    {
        List<Role> GetList();
        Role GetById(int id);
        Task<Role> postAsync(Role r);
        Task<Role> putAsync(int id, Role role);
        Task<Role> deleteAsync(int id);
    }
}
