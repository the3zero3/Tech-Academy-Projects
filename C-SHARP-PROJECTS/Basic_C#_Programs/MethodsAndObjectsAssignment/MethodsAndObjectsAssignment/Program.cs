using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiates a new Employee (which inherits the Person class)
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            
            // Calls the superclass method on the Employee object
            employee.SayName();

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
