using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Asks the user for their age and stores it as an integer variable
                Console.WriteLine("Please provide your age...");
                int userAge = Convert.ToInt32(Console.ReadLine());

                // If statement to check if the age entered is zero or negative; throws a format exception to be caught below
                if (userAge < 1) throw new FormatException();

                // Creates a new DateTime object with today's year minus the age the user entered
                DateTime yearBorn = DateTime.Now.AddYears(-userAge);

                // Displays the year of the DateTime object to the console
                Console.WriteLine(yearBorn.Year);
            }
            // Catches the format exception and tells the user to only use positive numbers
            catch (FormatException)
            {
                Console.WriteLine("You can't be zero or negative years old. Please enter only positive numbers.");
            }
            // Catches all other exceptions the program may throw and displays the error message to the console
            catch (Exception)
            {
                Console.WriteLine("Wow you super, duper broke this program.");
            }
            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
