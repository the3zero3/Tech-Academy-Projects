using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a list of 10 employees with at least two employees having the first name "Joe"
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, FirstName = "Peter", LastName = "Griffin" });
            employees.Add(new Employee() { Id = 2, FirstName = "Joe", LastName = "Swanson" });
            employees.Add(new Employee() { Id = 3, FirstName = "Glen", LastName = "Quagmire" });
            employees.Add(new Employee() { Id = 4, FirstName = "Cleavland", LastName = "Brown" });
            employees.Add(new Employee() { Id = 5, FirstName = "Brian", LastName = "Griffin" });
            employees.Add(new Employee() { Id = 6, FirstName = "Stewie", LastName = "Griffin" });
            employees.Add(new Employee() { Id = 7, FirstName = "Chris", LastName = "Griffin" });
            employees.Add(new Employee() { Id = 8, FirstName = "Meg", LastName = "Griffin" });
            employees.Add(new Employee() { Id = 9, FirstName = "Joe", LastName = "Johnson" });
            employees.Add(new Employee() { Id = 10, FirstName = "Adam", LastName = "West" });

            // Creates a new list of all employees with the first name "Joe"
            // Uses a lambda expression to do the comparison and build the list
            List<Employee> employeesNamedJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            // Uses a foreach loop to do the comparison and build the list
            //foreach (var employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        employeesNamedJoe.Add(employee);
            //    }
            //}

            // Lambda expression to make a list of all employees with an Id number greater than 5
            List<Employee> employeeIdsGreaterThanFive = employees.Where(x => x.Id > 5).ToList();

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
