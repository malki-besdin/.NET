using Microsoft.AspNetCore.Mvc;
using Organization.Core.Entities;
using Organization.Core.Services;
using Organization.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Organization.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // GET: api/<RoleController>
        [HttpGet]
        public List<Role> Get()
        {
            return _roleService.GetAll();
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public Role Get(int id)
        {
            return _roleService.GetById(id);
        }

        // POST api/<RoleController>
        [HttpPost]
        public async Task<Role> Post(Role role)
        {
            return await _roleService.postAsync(role);
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public async Task<Role> putAsync(int id, Role role)
        {
            return await _roleService.putAsync(id, role);
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task<Role> DeleteAsync(int id)
        {
            return await _roleService.deleteAsync(id);
        }
    }
}
