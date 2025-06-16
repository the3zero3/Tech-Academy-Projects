using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This block asks for a number, multiplies it by 50, and prints the result to the console
            Console.WriteLine("Please enter a number:");
            int mult = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is your number multiplied by 50: " + (mult * 50));

            // This block asks for a number, adds 25 to it, and prints the result to the console
            Console.WriteLine("Please enter another number:");
            int adds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is your number with 25 added to it: " + (adds + 25));

            // This block asks for a number, divides it by 12.5, and prints the result to the console
            Console.WriteLine("Please enter one more number:");
            int divides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is your number divided by 12.5: " + (divides / 12.5));

            // This block asks for a number, compares it to 50, and prints the result as a boolean to the console
            Console.WriteLine("Please enter a final number:");
            int greater = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is your number greater than 50? " + (greater > 50));

            // This block asks for a number, divides it by 7, and prints the remainder to the console
            Console.WriteLine("I lied, one more number please:");
            int modulus = (Convert.ToInt32(Console.ReadLine()) % 7);
            Console.WriteLine("The remainder of that number divided by 7 is: " + (modulus));

            Console.ReadLine();
        }
    }
}
