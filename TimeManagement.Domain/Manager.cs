using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement.Domain
{
    public class Manager : Employee
    {
        public List<Employee> Employees { get; set; }

        public override string FullName()
        {
            return $"Manager : {base.FullName()}";
        }
    }
}
