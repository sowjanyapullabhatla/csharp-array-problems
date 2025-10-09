using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Please enter a number greater than zero.");
                return;
            }

            // Create object of SumCalculator class
            SumCalculator calculator = new SumCalculator();

            // Call the renamed method
            int sum = calculator.NaturalAdd(n);

            Console.WriteLine($"\nSum of first {n} natural numbers is: {sum}");
        }
    }
}
