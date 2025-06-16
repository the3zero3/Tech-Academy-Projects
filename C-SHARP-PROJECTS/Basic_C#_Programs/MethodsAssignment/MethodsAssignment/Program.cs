using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number to do some different math operations on
            Console.WriteLine("Please enter a number to do some maths:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Calls the Maths class and passes the provided number
            Maths maths = new Maths(number);
            
            // Prints the results from the different methods in the Maths class
            Console.WriteLine(number + " squared is: " + maths.Squared);
            Console.WriteLine(number + "! is: " + maths.Factorial);
            Console.WriteLine(number + " to the power of " + number + " is: " + maths.Power);

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
