using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload operators to check if two Employee objects are equal by comparing their Id property
        public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        {
            return employeeOne.Id == employeeTwo.Id;
        }

        public static bool operator !=(Employee employeeOne, Employee employeeTwo)
        {
            return employeeOne.Id != employeeTwo.Id;
        }
    }
}
