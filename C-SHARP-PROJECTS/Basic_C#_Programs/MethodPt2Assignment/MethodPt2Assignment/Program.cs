using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPt2Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number and converts it to an integer
            Console.WriteLine("Please enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            // Instantiates the class and calls the first method, passing in the integer and displaying the result to the screen
            Calculator calc1 = new Calculator(number1);
            Console.WriteLine(calc1.Answer);


            // Asks the user for a number and converts it to a decimal
            Console.WriteLine("Please enter another number:");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());
            // Instantiates the class and calls the second method, passing in the decimal and displaying the result to the screen
            Calculator calc2 = new Calculator(number2);
            Console.WriteLine(calc2.Answer);


            // Asks the user for a number and passes it as a string
            Console.WriteLine("Please enter one more number:");
            // Instantiates the class and calls the third method, passing in the string and displaying the result to the screen
            Calculator calc3 = new Calculator(Console.ReadLine());
            Console.WriteLine(calc3.Answer);


            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
