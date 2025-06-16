using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number and stores the answer as an integer variable
            Console.WriteLine("Please provide a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Writes what the user provided to the specified file
            using (StreamWriter file  = new StreamWriter(@"C:\Users\thedi\Documents\Chris\Coding\Logs\log2.txt", true))
            {
                file.WriteLine(userInput);
            }

            // Reads the specified file and prints it back to the user
            string fileText = File.ReadAllText(@"C:\Users\thedi\Documents\Chris\Coding\Logs\log2.txt");
            Console.WriteLine("The file contains:\n" + fileText);

            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
