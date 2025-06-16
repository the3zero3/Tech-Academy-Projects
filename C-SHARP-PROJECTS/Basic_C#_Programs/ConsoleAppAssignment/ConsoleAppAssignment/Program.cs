using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// ASSIGNMENT PART 1

            // Creates a one-dimensional array of strings
            string[] greetings = { "Hello, ", "Howdy! ", "Wassup? ", "Yooooo " };

            // Asks the user for their name and saves it as a string variable
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Loop to iterate through each string in the array and add the user's text to the end of each array element
            for (int i = 0; i < greetings.Length; i++)
            {
                greetings[i] = greetings[i] + name;

                //// ASSIGNMENT PART 2
                // Removed line of code causing an infinite loop here
                // i = i - 1;
            }

            // Loop to print off each string in the array one at a time
            for (int j = 0; j < greetings.Length; j++)
            {
                Console.WriteLine(greetings[j]);
            }


            //// ASSIGNMENT PART 3

            // Loop where the comparison that’s used to determine whether to continue iterating the loop is a "<" operator
            for (int k = 0; k < greetings.Length; k++)
            {
                Console.WriteLine(greetings[k] + ", How are ya doing?");
            }

            // Loop where the comparison that’s used to determine whether to continue iterating the loop is a "<=" operator
            int count = 0;
            while (count <= greetings.Length-1)
            {
                Console.WriteLine(greetings[count] + ", How you going?");
                count++;
            }


            //// ASSIGNMENT PART 4

            // Creates a list of strings where each item in the list is unique
            List<string> f1Teams = new List<string>() { "ferrari", "mclaren", "mercedes", "red bull" };

            // Asks the user for a search term and saves it as a string variable
            Console.WriteLine("Please enter an F1 manufacturer:");
            string teamSearch = Console.ReadLine();

            // If statement to determine if the list contains the search term
            if (f1Teams.Contains(teamSearch))
            {
                // Loop to iterate through the list and then display the index of the list item that contains matching text on the screen
                foreach (string team in f1Teams)
                {
                    if (team == teamSearch)
                    {
                        Console.WriteLine(f1Teams.IndexOf(team));
                    }
                }
            }
            // Tells the user their input is not on the list
            else
            {
                Console.WriteLine("I'm sorry, that team is not on the list");
            }


            //// ASSIGNMENT PART 5

            // Creates a list of strings that has at least two identical strings in the list
            List<string> colors = new List<string>() { "blue", "green", "yellow", "red", "blue", "orange", "purple", "red", "blue" };

            // Asks the user for a search term and saves it as a string variable
            Console.WriteLine("Please enter a color:");
            string colorSearch = Console.ReadLine();

            // If statement to determine if the list contains the search term
            if (colors.Contains(colorSearch))
            {
                // Loop to iterate through the list and then display the index of any list items that contain matching text on the screen
                for (int i = 0; i < colors.Count; i++)
                {
                    if (colors[i] == colorSearch)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            // Tells the user their input is not on the list
            else
            {
                Console.WriteLine("I'm sorry, that color is not on the list");
            }


            //// ASSIGNMENT Part 6

            // Creates a list of strings that has at least two identical strings in the list
            List<string> places = new List<string>() { "new york", "paris", "san francisco", "seattle", "paris", "tokyo", "bejing", "seattle", "sydney" };
            
            // Creates a list of strings to store the list of unique places
            List<string> uniquePlaces = new List<string>();

            // Loop to evaluate each item in the list, and display a message showing the string and whether or not it has already appeared in the list
            foreach (string place in places)
            {
                if (uniquePlaces.Contains(place))
                {
                    Console.WriteLine(place + " - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine(place + " - this item is unique");
                    uniquePlaces.Add(place);
                }
            }


            // Keeps the console window open after the program runs
            Console.ReadLine();
        }
    }
}
