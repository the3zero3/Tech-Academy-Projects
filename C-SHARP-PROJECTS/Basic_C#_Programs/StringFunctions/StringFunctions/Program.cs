using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jimbo";
            string quote = "The man said \"Hello\" \nHello on the new line. \n \tHello on a tab.";
            string fileName = @"C:\Users\Jimbo";

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("s");

            int length = name.Length;

            name = name.ToUpper();

            Console.WriteLine(name);
            Console.ReadLine();

            // StringBuilder removes the expensive overhead of building new strings in memory
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jimbo");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
