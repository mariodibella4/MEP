using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMEP
{

    
    class Manager : Employee
    {
        private bool employeeInfoAccess = true;
        public Manager(string employeeID, string employeeName, string employeeAge, string employeeBirth, string employeePosition, string employeeSalary,bool employeeInfoAccess) : base(employeeID, employeeName, employeeAge, employeeBirth, employeePosition, employeeSalary)
        {
            EmployeeInfoAccess = employeeInfoAccess;
        }

        public bool EmployeeInfoAccess { get => employeeInfoAccess; set => employeeInfoAccess = value; }
    }
}
