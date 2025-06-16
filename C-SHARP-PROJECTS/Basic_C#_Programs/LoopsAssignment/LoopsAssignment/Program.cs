using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WHILE STATEMENT ASSIGNMENT

            // Asks the user to enter a number and stores it as an integer variable
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            // Creates a boolean and sets it to false
            bool goodGuess = false;

            // While loop to keep asking the user for a number and a switch statement to look for the number 42
            while (!goodGuess)
            {
                switch (number)
                {
                    case 42:
                        Console.WriteLine("Wow! If you know, you know.\n");
                        goodGuess = true;
                        break;
                    default:
                        Console.WriteLine("That's a neat number!");
                        Console.WriteLine("Please enter another number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();

            Console.WriteLine("Let's play another game!\n");


            // DO/WHILE STATEMENT ASSIGNMENT

            // Asks the user to guess a number and stores it as an integer variable
            Console.WriteLine("Guess a number between 1 and 3");
            int guess = Convert.ToInt32(Console.ReadLine());
            // Creates a boolean based off the condition: is the guess equal to 2?
            bool isGuessed = guess == 2;

            // Do/While loop to keep asking the user for a number and a switch statement to look for the correct number
            // Using a do/while loop here because a guess of 2 would set the condition to false and a regular while loop would never run
            do
            {
                switch (guess)
                {
                    case 1:
                        Console.WriteLine("1 is not the correct number!");
                        Console.WriteLine("Guess again...");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("2 is the correct number!");
                        isGuessed = true;
                        break;
                    case 3:
                        Console.WriteLine("3 is not the correct number!");
                        Console.WriteLine("Guess again...");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("That number is not between 1 and 3!");
                        Console.WriteLine("Guess again...");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.ReadLine();            
        } 
    }
}
