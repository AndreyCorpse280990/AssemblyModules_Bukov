using AssemblyModules_Bukov;
using System;
using System.Reflection;

namespace LibraryTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Addition: " + calculator.Add(2, 3));
            Console.WriteLine("Multiplication: " + calculator.Multiply(4, 5));
            Console.WriteLine("Subtraction: " + calculator.Subtract(10, 7));

            StringUtilities stringUtilities = new StringUtilities();
            Console.WriteLine("Uppercase: " + stringUtilities.ToUpperCase("hello"));
            Console.WriteLine("Length: " + stringUtilities.GetLength("hello"));
            Console.WriteLine("Concatenation: " + stringUtilities.Concatenate("Hello, ", "World!"));

        }
    }
}