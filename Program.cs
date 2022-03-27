using System;

namespace MethodOverloading
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isTrue)
        {
            var addition = num1 + num2;
            if (isTrue == true && addition == 1)
            {
                return $"{addition} dollar";
            }
            else if (isTrue == true && (addition > 1 || addition < 1))
            {
                return $"{addition} dollars";
            }
            else
            {
                return addition.ToString();
            }
            
        }
        static void Main(string[] args)
        {
            // Create a method named Add, that accepts two integers and returns the sum of those two integers.
            Console.WriteLine("This is the method overloading exercise.");
            Console.WriteLine($"Result from Add method with integers: {Add(6, 4)}");

            // Now create an overload of the Add method to account for being able to add two decimals together.

            Console.WriteLine($"Result from Add method with decimals: {Add(2.22m, 4.46m)}");

            // Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean.
            // If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
            // You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
            // For example: “5 dollars”, "1 dollar”, “16 dollars”.
            // If false, return only the sum.


            Console.WriteLine($"Result from Add Method with 3 parameters: {Add(3, 2,true)}");
            Console.WriteLine($"Result from Add Method with 3 parameters: {Add(0, 1, true)}");
            Console.WriteLine($"Result from Add Method with 3 parameters: {Add(0, 0, true)}");
            Console.WriteLine($"Result from Add Method with 3 parameters but false: {Add(7, 9, false)}");
        }
    }
}
