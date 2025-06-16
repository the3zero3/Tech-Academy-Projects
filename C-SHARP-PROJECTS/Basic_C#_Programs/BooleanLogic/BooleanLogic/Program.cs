using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AND operator
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            // OR operator
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            // Equals operator
            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);

            // Does Not Equal operator
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);

            // Exclusive Or (XOR) operator
            // Will evaluate to true if one (but not both) are true
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            Console.ReadLine();
        }
    }
}
