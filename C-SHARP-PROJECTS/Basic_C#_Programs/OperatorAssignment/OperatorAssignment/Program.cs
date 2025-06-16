using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints the program's name at top of console
            Console.WriteLine("Anonymous Income Comparison Program");

            // Gathers details for Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());

            // Gathers details for Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            // Determines Person 1 and Person 2's annual salaries and prints them to the console
            int annualSalary1 = hourlyRate1 * hoursWorked1 * 52;
            int annualSalary2 = hourlyRate2 * hoursWorked2 * 52;
            Console.WriteLine("Annual salary of Person 1: \n" + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: \n" + annualSalary2);

            // Compares the two salaries to determine if Person 1 makes more money than Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2);

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
