using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This writes the specified string to the console
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            
            // This block asks for the user's name and stores it as a string variable
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // This block asks for the user's course and stores it as a string variable
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // This block asks for the user's page number, converts it into an interger, and stores it as a variable
            Console.WriteLine("What page number?");
            int pgNum = Convert.ToInt32(Console.ReadLine());

            // This block asks if the user needs help, converts the answer into a boolean, and stores it as a variable
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            // This block asks the user for their experiences and stores it as a string variable
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();

            // This block asks the user for their feedback and stores it as a string variable
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // This block asks for the user's hours, converts it into an interger, and stores it as a variable
            Console.WriteLine("How many hours did you study today?");
            int hoursStudy = Convert.ToInt32(Console.ReadLine());

            // This writes a thank you message to the user after they have submitted their answers
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            
            // This keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
