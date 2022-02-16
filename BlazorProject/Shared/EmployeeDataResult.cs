using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class EmployeeDataResult
    {
        public IEnumerable<Employee> Employees { get; set; }

        public int Count { get; set; }
    }
}
