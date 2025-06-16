using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPt2Assignment
{
    internal class Calculator
    {
        // Method that takes in an integer, multiplies the integer, and then returns the answer as an integer
        public Calculator(int number)
        {
            Answer = number * 2;
        }

        // Method that takes in a decimal, converts it to an integer, multiplies the integer, and then returns the answer as an integer
        public Calculator(decimal number)
        {
            Answer = (int)number * 3;
        }

        // Method that takes in a string, converts it to an integer, multiplies the integer, and then returns the answer as an integer
        public Calculator(string number)
        {
            Answer = Convert.ToInt32(number) * 4;
        }

        public int Answer { get; set; }
    }
}
