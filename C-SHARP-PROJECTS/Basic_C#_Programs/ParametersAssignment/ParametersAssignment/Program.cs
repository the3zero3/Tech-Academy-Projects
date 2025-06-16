using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiates an Employee object with type "string" as its generic parameter and assigns a list of strings as the property value
            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string> { "monitor", "laptop", "phone", "docking station" };

            // Prints all of the Things to the Console
            foreach (string i in employeeString.Things)
            {
                Console.WriteLine(i);
            }

            // Instantiates an Employee object with type "integer" as its generic parameter and assigns a list of integers as the property value
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int> { 7, 6, 8, 3 };

            // Prints all of the Things to the Console
            foreach (int j in employeeInt.Things)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
