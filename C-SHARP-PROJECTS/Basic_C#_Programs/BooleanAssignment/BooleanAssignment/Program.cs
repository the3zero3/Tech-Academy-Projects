using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks the applicant about their age and stores it as an integer variable
            Console.WriteLine("What is your age?");
            int userAge =  Convert.ToInt32(Console.ReadLine());

            // Asks the applicant true/false about their DUIs and stores it as a boolean variable
            Console.WriteLine("Have you ever had a DUI?");
            bool drunk = Convert.ToBoolean(Console.ReadLine());

            // Asks the applicant about their speeding tickets and stores it as an integer variable
            Console.WriteLine("How many speeding tickets do you have?");
            int speeding = Convert.ToInt32(Console.ReadLine());

            // Determines if the applicant is qualified for insurance by comparing the applicant's answers to the qualification rules
            Console.WriteLine("Qualified?");
            Console.WriteLine(userAge > 15 && drunk == false && speeding <= 3);

            // Keeps the console window open after the program runs
            Console.ReadLine();
        }
    }
}
