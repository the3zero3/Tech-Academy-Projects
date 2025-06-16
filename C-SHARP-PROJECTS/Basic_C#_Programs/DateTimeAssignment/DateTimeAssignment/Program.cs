using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints the current date and time to the console
            Console.WriteLine("The current date and time is: " + DateTime.Now);

            // Asks the user for a number and stores it as an integer variable
            Console.WriteLine("\nPlease provide a number...");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Creates a new DateTime object with the user-provided number of hours added to it
            DateTime plusHours = DateTime.Now.AddHours(userInput);

            // Prints the new date and time to the console
            Console.WriteLine("\nAdding {0} hours: " + plusHours, userInput);

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
