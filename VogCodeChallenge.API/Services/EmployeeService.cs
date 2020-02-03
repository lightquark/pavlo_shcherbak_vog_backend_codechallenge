using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Domain;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        public IList<Employee> ListAll()
        {
            return employeeRepository.ListAll();
        }

        public Employee Get(Guid id)
        {
            return employeeRepository.Get(id);
        }

    }
}
