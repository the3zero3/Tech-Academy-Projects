using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiates a new Employee object and calls the SayName() method from the Employee class
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();

            // Instantiates an object of type IQuittable and calls the Quit() method from the Employee class
            IQuittable quittable = new Employee() { firstName = "Sample", lastName = "Teacher" };
            quittable.Quit();

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
