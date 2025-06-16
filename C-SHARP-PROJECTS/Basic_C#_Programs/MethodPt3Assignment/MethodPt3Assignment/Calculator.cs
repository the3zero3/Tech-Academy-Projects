using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPt3Assignment
{
    internal class Calculator
    {
        public Calculator(int number1, int number2 = 1)
        {
            Answer = number1 * number2;
        }
        public int Answer { get; set; }
    }
}
