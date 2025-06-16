using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a one-dimensional Array of strings
            string[] stringArray = { "hello", "hola", "bonjour", "guten tag", "ciao", "ni hao", "konnichiwa" };
            // Asks the user to select an index of the Array
            Console.WriteLine("Please select an index of the Array:");
            int selectString = Convert.ToInt32(Console.ReadLine());
            // Determines if the user selected an index that doesn’t exist
            if (selectString >= stringArray.Length)
            {
                Console.WriteLine("Index does not exist!");
            }
            // Displays the string at the index on the screen
            else
            {
                Console.WriteLine(stringArray[selectString]);
            }


            // Creates a one-dimensional Array of integers
            int[] intArray = { 1, 2, 3 };
            // Asks the user to select an index of the Array
            Console.WriteLine("Please select an index of another Array:");
            int selectInt = Convert.ToInt32(Console.ReadLine());
            // Determines if the user selected an index that doesn’t exist
            if (selectInt >= intArray.Length)
            {
                Console.WriteLine("Index does not exist!");
            }
            // Displays the integer at the index on the screen
            else
            {
                Console.WriteLine(intArray[selectInt]);
            }


            // Creates a List of strings
            List<string> stringList = new List<string>();
            stringList.Add("hello");
            stringList.Add("hola");
            stringList.Add("bonjour");
            stringList.Add("guten tag");
            stringList.Add("ciao");
            stringList.Add("ni hao");
            stringList.Add("konnichiwa");
            // Asks the user to select an index of the List
            Console.WriteLine("Please select an index of the List:");
            int selectList = Convert.ToInt32(Console.ReadLine());
            // Determines if the user selected an index that doesn’t exist
            if (selectList >= stringList.Count)
            {
                Console.WriteLine("Index does not exist!");
            }
            // Displays the string at the index on the screen
            else
            {
                Console.WriteLine(stringList[selectList]);
            }


            // Keeps the console window open after the program has run
            Console.ReadLine();
        }
    }
}
