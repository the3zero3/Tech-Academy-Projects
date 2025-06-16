using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to simply write the Person's name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
