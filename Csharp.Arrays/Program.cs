using ArraySumAverage;
using System;
using ReverseArrayApp;
using InsertArray;
using System.ComponentModel.Design;

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

            //if (1 == 0)
            //{
            //    Console.WriteLine("Enter numbers separated by spaces:");
            //    string input = Console.ReadLine();

            //    // Convert input string to int array
            //    int[] numbers = Reverse.ParseInput(input);

            //    Console.WriteLine("\nOriginal array:");
            //    Reverse.PrintArray(numbers);

            //    int[] reversed = Reverse.ReverseArray(numbers);

            //    Console.WriteLine("\nReversed array:");
            //    Reverse.PrintArray(reversed);
            //}

        //    if (1 == 0)
        //    {

        //        int[] numbers = { 2, 3, 4, 5 };

        //        Console.WriteLine("Original Array: " + string.Join(", ", numbers));
        //        Console.Write("Enter a number to insert: ");
        //        int newNumber = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine($"Enter position (FIRST / MIDDLE / LAST / or a number 0-–{numbers.Length}):");
        //        Console.Write("Enter input word: ");
        //        string input = Console.ReadLine();
        //        int[] updatedArray;
        //        switch (input)
        //        {
        //            case "FIRST":
        //                updatedArray = Insert.InsertAtFirstPosition(numbers, newNumber);
        //                break;
        //            case "MIDDLE":
        //                updatedArray = Insert.InsertAtMiddlePosition(numbers, newNumber);
        //                break;
        //            case "LAST":
        //                updatedArray = Insert.InsertAtLastPosition(numbers, newNumber);
        //                break;
        //            default:
        //                // 🧠 If user entered a number, try to parse it
        //                if (int.TryParse(input, out int userPosition))
        //                {
        //                    // Convert user position (1-based) to array index (0-based)
        //                    int index = userPosition - 1;
        //                    updatedArray = Insert.InsertAtGivenPosition(numbers, newNumber, index + 1);
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Invalid input! Please enter FIRST, MIDDLE, LAST, or a number.");
        //                    return;
        //                }
        //                break;

        //        }

        //        Console.WriteLine("\nUpdated Array: " + string.Join(", ", updatedArray));
        //    //}
        }
    }
}
