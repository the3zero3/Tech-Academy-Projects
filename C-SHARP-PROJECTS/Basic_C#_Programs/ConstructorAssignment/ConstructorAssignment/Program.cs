using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a const variable
            const string Greeting = "Hello! What is your favorite car brand?";

            // Prints the variable to the console window
            Console.WriteLine(Greeting);
            
            // Creates a variable using the keyword "var"
            var userInput = Console.ReadLine();

            // Creates a new Car object targeting the chained constructor
            Car car = new Car(userInput);

            // Tells the user how cool their favorite car brand is
            Console.WriteLine(car.Brand + car.Model + " are cool!");

            // Keeps the console window open after the program has run
            Console.Read();
        }

        // Car class to show off chained constructors
        class Car
        {
            // Properties of the Car class
            public string Brand { get; set; }
            public string Model { get; set; }

            // Chains two constructors together
            public Car(string Brand) : this(Brand, "s")
            {
            }

            // Car constructor that takes two strings as arguements
            public Car(string Brand, string Model)
            {
                this.Brand = Brand;
                this.Model = Model;
            }
        }
    }
}
