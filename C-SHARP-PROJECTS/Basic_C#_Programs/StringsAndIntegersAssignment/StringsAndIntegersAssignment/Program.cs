using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creates a list of integers
                List<int> numbers = new List<int>() { 23, 57, 63, 98, 10, 27, 71, 33, 84, 42 };
                // Asks the user for a number to divide each number in the list by
                Console.WriteLine("Please provide a number: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                // Loop to take each integer in the list, divide it by the number the user entered, and display the result to the screen
                foreach (int number in numbers)
                {
                    int quotient = number / divisor;
                    Console.WriteLine(quotient);
                }
            }
            // Catches when the user tries to enter things other than whole numbers
            catch (FormatException)
            {
                Console.WriteLine("What the heck are you doing? Please enter a whole number.");
            }
            // Catches when the user tries to divide by zero
            catch (DivideByZeroException)
            {
                Console.WriteLine("You have created a blackhole by dividing by zero. Please don't do that.");
            }
            // Catches all other exceptions and prints the error message to the screen
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            // Prints a message to the screen to let the user know the program has emerged from the try/catch block and keeps the window open after the program has run
            finally
            {
                Console.WriteLine("We have emerged from the try/catch block, Captian!");
                Console.ReadLine();
            }            
        }
    }
}
