using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Domain;
using Microsoft.EntityFrameworkCore;

namespace VogCodeChallenge.API.Services
{
    public class DbEmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext dbContext;

        public DbEmployeeRepository(EmployeeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Employee> GetAll()
        {
            return dbContext.Employees;
        }

        public IList<Employee> ListAll()
        {
            return dbContext.Employees.ToList();
        }

        public IEnumerable<Employee> GetAllByDepartmentId(Guid departmentId)
        {
            Department department = dbContext.Departments.ToList().Find(x => x.Id.Equals(departmentId));
            return department != null ? department.Employees : Enumerable.Empty<Employee>();
        }

        public Employee GetByEmployeeId(Guid employeeId)
        {
            return dbContext.Employees.ToList().Find(x => x.Id.Equals(employeeId));
        }

        public void setEmployees(List<Employee> employees) 
        {
            this.dbContext.Employees.RemoveRange(this.dbContext.Employees);
            this.dbContext.Employees.AddRange(employees);
            this.dbContext.SaveChanges();
        }

        public void setDepartments(List<Department> departments) 
        {
            this.dbContext.Departments.RemoveRange(this.dbContext.Departments);
            this.dbContext.Departments.AddRange(departments);
            this.dbContext.SaveChanges();
        }

        public void setCompany(Company company) 
        {
            this.dbContext.Companies.RemoveRange(this.dbContext.Companies);
            this.dbContext.Companies.Add(company);
            this.dbContext.SaveChanges();
        }
    }
}
