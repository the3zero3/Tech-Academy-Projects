using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    internal class Calculator
    {
        public int Answer { get; set; }

        // Method to divide data passed to it by 2 and output the result
        public void DivideByTwo(int number)
        {
            Answer = number / 2;
        }

        // Overload method to divide data passed to it by 2 again and output the result
        public void DivideByTwo(int number, out int number2)
        {
            number2 = (number / 2) / 2;
        }

        // Static class used to greet the user
        public static void Greeting()
        {
            Console.WriteLine("Welcome to the Calculator!\n");
        }
    }
}
