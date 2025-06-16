using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcomes the user to the application
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Asks the user for package weight and stores it as an integer variable
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            // Determines if the package weight is over 50 and, if true, let's the user know and exits the program
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            // Asks the user for the package width and stores it as an integer variable
            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            // Asks the user for the package height and stores it as an integer variable
            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            // Asks the user for the package length and stores it as an integer variable
            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            // Adds the package dimensions together and stores it as an integer variable
            int packageTotal = packageWidth + packageHeight + packageLength;
            // Determines if the package dimensions total is greater than 50 and, if true, let's the user know and exits the program
            if (packageTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Multiplies the dimensions by the weight and divides by 100 to determine the quote and displays it to the user
            int quote = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
            Console.WriteLine($"Your estimated total for shipping this package is: {quote:C}");
            Console.WriteLine("Thank you!");

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
