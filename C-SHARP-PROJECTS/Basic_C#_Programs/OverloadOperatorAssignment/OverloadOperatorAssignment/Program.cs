using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiates two Employee objects and assigns values to their properties
            Employee employeeOne = new Employee() { Id = 001, FirstName = "Jimbo", LastName = "Johnson" };
            Employee employeeTwo = new Employee() { Id = 002, FirstName = "Billy", LastName = "Wilson" };

            // Compares the two Employee objects using the overloaded operators and displays the results
            if (employeeOne == employeeTwo)
            {
                Console.WriteLine("Employees have the same ID number");
            }
            else
            {
                Console.WriteLine("Employees do not have the same ID number");
            }

            // Keeps the console window open after the program runs
            Console.ReadLine();
        }
    }
}
