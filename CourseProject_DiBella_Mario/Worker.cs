using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMEP
{
    class Worker : Employee
    {
        public Worker(string employeeID, string employeeName, string employeeAge, string employeeBirth, string employeePosition, string employeeSalary) : base(employeeID, employeeName, employeeAge, employeeBirth, employeePosition, employeeSalary)
        {
            
        }
    }
}
