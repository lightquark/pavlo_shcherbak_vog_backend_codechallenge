using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Domain;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private Company company;
        private List<Department> departments;
        private List<Employee> employees;

        public EmployeeRepository()
        {
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public IList<Employee> ListAll()
        {
            return employees;
        }

        public IEnumerable<Employee> GetAllByDepartmentId(Guid departmentId)
        {
            Department department = departments.Find(x => x.Id.Equals(departmentId));
            return department != null ? department.Employees : Enumerable.Empty<Employee>();
        }

        public Employee GetByEmployeeId(Guid employeeId)
        {
            return employees.Find(x => x.Id.Equals(employeeId));
        }

        public void setEmployees(List<Employee> employees) { this.employees = employees; }
        public void setDepartments(List<Department> departments) { this.departments = departments; }
        public void setCompany(Company company) { this.company = company; }
    }
}
