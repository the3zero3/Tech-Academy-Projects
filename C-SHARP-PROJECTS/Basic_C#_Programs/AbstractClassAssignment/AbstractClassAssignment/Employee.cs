using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Inherits the Person class
    public class Employee : Person, IQuittable
    {
        // Overrides the SayName() method from the Person class
        public override void SayName()
        {
            // Writes the employee's name to the console
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Implements the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("I quit! Yelled: " + firstName + " " + lastName);
        }
    }
}
