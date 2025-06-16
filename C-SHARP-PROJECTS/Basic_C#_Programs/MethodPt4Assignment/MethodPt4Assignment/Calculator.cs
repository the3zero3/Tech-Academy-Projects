using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPt4Assignment
{
    internal class Calculator
    {
        // Void method that takes two integers as parameters and does a math operation on the first integer and displays the second integer to the screen
        public void NumberMachine(int num1, int num2)
        {
            int ans = num1 * 100;
            //Console.WriteLine(ans); // Quick check to verify variable ans is being created with the correct value
            Console.WriteLine(num2);
        }
    }
}
