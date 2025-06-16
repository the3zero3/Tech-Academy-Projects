using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class Maths
    {
        public Maths(int number)
        {
            // Squares the number and assigns it to the Squared method
            Squared = number * number;

            // Factorials the number and assigns it to the Factorial method
            int results = 1;
            for (int i = number; i > 0; i--)
            {
                results *= i;
            }
            Factorial = results;

            // Uses Math.Pow() to find the total for the number to it's own power and assigns it to the Power method
            Power = (int)Math.Pow(number, number);
        }
        public int Squared { get; set; }
        public int Factorial { get; set; }
        public int Power { get; set; }
    }
}
