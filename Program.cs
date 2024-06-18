using System;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloarding {
    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();

            // Using the Add method for integers
            int intSum = calculator.Add(5, 10);
            Console.WriteLine("Sum of two integers: " + intSum); // Output: 15

            // Using the Add method for three integers
            int intTripleSum = calculator.Add(5, 10, 15);
            Console.WriteLine("Sum of three integers: " + intTripleSum); // Output: 30

            // Using the Add method for doubles
            double doubleSum = calculator.Add(5.5, 10.2);
            Console.WriteLine("Sum of two doubles: " + doubleSum); // Output: 15.7

            // Using the Add method for strings (concatenation)
            string concatenatedString = calculator.Add("Hello, ", "World!");
            Console.WriteLine("Concatenated string: " + concatenatedString); // Output: Hello, World!


            Test myAnimal = new Test();  // Create a Animal object
            Test myPig = new Test();  // Create a Pig object
            Test myDog = new Test();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }

}

