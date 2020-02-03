using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Domain;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeService employeeService;

        public EmployeesController(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }


        // GET api/employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return new ActionResult<IEnumerable<Employee>>(employeeService.GetAll());
        }

        // GET api/employees/department/77777777-7777-7777-7777-777777777777
        [HttpGet("department/{departmentId}")]
        public ActionResult<IEnumerable<Employee>> GetAllByDepartmentId(Guid departmentId)
        {
            return new ActionResult<IEnumerable<Employee>>(employeeService.GetAllByDepartmentId(departmentId));
        }

        // GET api/employees/11111111-1111-1111-1111-111111111111
        [HttpGet("{employeeId}")]
        public ActionResult<Employee> GetByEmployeeId(Guid employeeId)
        {
            return new ActionResult<Employee>(employeeService.GetByEmployeeId(employeeId));
        }

    }
}
