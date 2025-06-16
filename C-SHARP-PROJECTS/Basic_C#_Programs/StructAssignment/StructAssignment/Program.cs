using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    internal class Program
    {
        // Creates a struct called Number and gives it the property "Amount" of data type decimal
        public struct Number
        {
            public decimal Amount { get; set; }
        }

        static void Main(string[] args)
        {
            // Creates an object of data type Number and assigns an amount to it
            Number number = new Number();
            number.Amount = 100;
            // Print the amount to the console
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
