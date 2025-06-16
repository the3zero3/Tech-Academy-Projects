using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPt4Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiates the Calculator class
            Calculator calc = new Calculator();

            // Calls the method in the class, passing in two numbers
            calc.NumberMachine(2, 5);

            // Calls the method in the class, specifying the parameters by name
            calc.NumberMachine(num1:5, num2:2);

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
