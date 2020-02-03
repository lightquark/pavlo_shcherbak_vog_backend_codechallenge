using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Domain
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
    }
}
