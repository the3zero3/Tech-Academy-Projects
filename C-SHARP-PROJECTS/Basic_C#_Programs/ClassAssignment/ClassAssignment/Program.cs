using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calls the static class to welcome to user to the program
            Calculator.Greeting();

            // Asks the user for a number and stores it as an integer variable
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            // Instantiates the Calculator class
            Calculator calculator = new Calculator();

            // Calls the method and passes the provided number to it
            calculator.DivideByTwo(num);

            // Displays the output on the screen
            Console.WriteLine("Here's {0} divided by 2: " + calculator.Answer, num);

            // Calls the overload method, passes the provided number to it, and captures the output
            calculator.DivideByTwo(num, out int num2);
            Console.WriteLine("Here's {0} divided by 2: " + num2, calculator.Answer);

            // Keeps the console window open after the programs has run
            Console.ReadLine();
        }
    }
}
