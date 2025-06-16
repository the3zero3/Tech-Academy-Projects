using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    internal class Program
    {
        // Creates an enum for the days of the week
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            // Asks the user for the current day of the week and stores the response as a string variable
            Console.WriteLine("Please enter the current day of the week:");
            string day = Console.ReadLine();

            // Tries to assign the string value to a variable of the DaysOfTheWeek enum data type
            try
            {
                // Parses the enum for the string value and ignores the case
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day, ignoreCase: true);
            }
            // Catches any errors and prints a message to the console
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
