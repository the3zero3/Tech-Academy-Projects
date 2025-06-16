using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPt3Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number and stores it as an integer variable
            Console.WriteLine("Please enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Try/catch block to catch the Format Error when the user does not enter a second number
            try
            {
                // Asks the user for a second number and stores it as an integer variable
                Console.WriteLine("(Optional) Please enter another number to multiply {0} by:", num1);
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Instantiates a new Calculator, passing both integer variables
                Calculator calc = new Calculator(num1, num2);
                Console.WriteLine("{0} times {0} is: " + calc.Answer, num1, num2);
            }
            catch (FormatException)
            {
                // Instantiates a new Calculator, passing only the first variable
                Calculator calc = new Calculator(num1);
                Console.WriteLine("{0} times 1 is: " + calc.Answer, num1);
            }
            finally
            {
                // Keeps the console window open after the program has run
                Console.ReadLine();
            }
        }
    }
}
