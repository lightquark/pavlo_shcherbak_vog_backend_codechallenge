using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Domain;

namespace VogCodeChallenge.API.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        // to be honest, I'm not sure why we need two almost similar methods. IList implements IEnumerable.
        IList<Employee> ListAll();

        IEnumerable<Employee> GetAllByDepartmentId(Guid departmentId);

        // this method I added just to demonstrate how to get a specific employee by his ID
        Employee GetByEmployeeId(Guid employeeId);
    }
}
