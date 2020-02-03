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
        private List<Employee> allEmployees;

        public EmployeeRepository()
        {
            List<Employee> heroes = new List<Employee>()
            {
                new Employee() {
                    Id = new Guid("11111111-1111-1111-1111-111111111111"), 
                    FirstName = "Iron", 
                    LastName = "Man",
                    JobTitle = "Superhero", 
                    AddressOfResidence = "Unknown"},
                new Employee() {
                    Id = new Guid("22222222-2222-2222-2222-222222222222"), 
                    FirstName = "Spider",
                    LastName = "Man", 
                    JobTitle = "Superhero", 
                    AddressOfResidence = "Unknown"},
                new Employee() {
                    Id = new Guid("33333333-3333-3333-3333-333333333333"),
                    FirstName = "Captain", 
                    LastName = "America", 
                    JobTitle = "Superhero",
                    AddressOfResidence = "Unknown"}
            };
            List<Employee> villains = new List<Employee>()
            {
                new Employee() {
                    Id = new Guid("44444444-4444-4444-4444-444444444444"),
                    FirstName = "Yon",
                    LastName = "Rogg", 
                    JobTitle = "Evil Genius",
                    AddressOfResidence = "Unknown"},
                new Employee() {
                    Id = new Guid("55555555-5555-5555-5555-555555555555"),
                    FirstName = "Winter", 
                    LastName = "Soldier", 
                    JobTitle = "Evil Genius",
                    AddressOfResidence = "Unknown"}
            };

            allEmployees = new List<Employee>();
            allEmployees.AddRange(heroes);
            allEmployees.AddRange(villains);

            departments = new List<Department>() {
                new  Department() {
                    Id = new Guid("66666666-6666-6666-6666-666666666666"),
                    Name = "Villains",
                    Address = "Somewhere in the East",
                    Employees = villains },
                new  Department() {
                    Id = new Guid("77777777-7777-7777-7777-777777777777"),
                    Name = "Heroes",
                    Address = "Somewhere in the West",
                    Employees = heroes }
            };

            company = new Company() { 
                Id = new Guid("99999999-9999-9999-9999-999999999999"), 
                Name = "Marvel",
                Departments = departments };
        }

        public IEnumerable<Employee> GetAll()
        {
            return allEmployees;
        }

        public IList<Employee> ListAll()
        {
            return allEmployees;
        }

        public Employee Get(Guid id)
        {
            return allEmployees.Find(x => x.Id.Equals(id));
        }
    }
}
