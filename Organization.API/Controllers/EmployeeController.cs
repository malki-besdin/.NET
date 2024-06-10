using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Organization.API.Models;
using Organization.Core;
using Organization.Core.Dtos;
using Organization.Core.Entities;
using Organization.Core.Services;
using Organization.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Organization.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        // GET: api/<Employee>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _employeeService.GetAll();
            var listDto = _mapper.Map<IEnumerable<EmployeeDto>>(list);
            return Ok(listDto);
        }

        // GET api/<Employee>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var employee = _employeeService.GetById(id);
            var employeeDto = _mapper.Map<EmployeeDto>(employee);
            return Ok(employeeDto);
        }

        // POST api/<Employee>
        [HttpPost]
        public async Task<Employee> PostAsync(EmployeePostModel e)
        {
            Employee employee = new Employee
            {
                idEmployee = e.idEmployee,
                FirstName = e.FirstName,
                LastName = e.LastName,
                StartWorksDate = e.StartWorksDate,
                DateOfBirth = e.DateOfBirth,
                Roles = e.Roles,
                SexFM = e.SexFM,
                Status = true
            };
            return await _employeeService.postAsync(employee);
        }

        // PUT api/<Employee>/5
        [HttpPut("{id}")]
        public async Task<Employee> PutAsync(int id, EmployeePutModel e)
        {
            Employee employee = new Employee
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Roles = e.Roles
            };
            return await _employeeService.putAsync(id, employee);
        }

        [HttpDelete("{id}")]
        public async Task<Employee> deleteAsync(int id)
        {
            return await _employeeService.deleteAsync(id);
        }
    }
}
