using ArraySumAverage;
using System;
using ReverseArrayApp;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter SUMAVG for sum and average of numbers");

            //if (1 == 0)
            //{
            //    // Sum of n natural numbers
            //    Console.Write("Enter a positive integer: ");
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    if (n <= 0)
            //    {
            //        Console.WriteLine("Please enter a number greater than zero.");
            //        return;
            //    }

            //    // Create object of SumCalculator class
            //    SumCalculator calculator = new SumCalculator();

            //    // Call the renamed method
            //    int sum = calculator.NaturalAdd(n);

            //    Console.WriteLine($"\nSum of first {n} natural numbers is: {sum}");
            //}
            //if (1 == 0)
            //{
            //    Console.Write("Enter the number of elements in the array: ");
            //    int size = Convert.ToInt32(Console.ReadLine());

            //    if (size <= 0)
            //    {
            //        Console.WriteLine("Array size must be greater than zero.");
            //        return;
            //    }

            //    int[] numbers = new int[size];

            //    // Take input for the array
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter element {i + 1}: ");
            //        numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    // Create object of the helper class
            //    ArrayHelper helper = new ArrayHelper();

            //    // Call the method in separate file
            //    var result = helper.Sumavg(numbers); // store tuple in 'result'

            //    Console.WriteLine($"\nSum of array elements: {result.sum}");
            //    Console.WriteLine($"Average of array elements: {result.avg}");

            //}

            if (1 == 0)
            {
                Console.WriteLine("Enter numbers separated by spaces:");
                string input = Console.ReadLine();

                // Convert input string to int array
                int[] numbers = Reverse.ParseInput(input);

                Console.WriteLine("\nOriginal array:");
                Reverse.PrintArray(numbers);

                int[] reversed = Reverse.ReverseArray(numbers);

                Console.WriteLine("\nReversed array:");
                Reverse.PrintArray(reversed);
            }

        }
    }
}
