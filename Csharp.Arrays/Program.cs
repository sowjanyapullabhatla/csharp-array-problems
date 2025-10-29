using ArraySumAverage;
using System;
using ReverseArrayApp;
using InsertArray;
using ArrayOperations;
using NameReverseArrays;
using System.ComponentModel.Design;


namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (1 == 0)
            //{
            //    console.writeline("enter sumavg for sum and average of numbers");

            //    // sum of n natural numbers
            //    console.write("enter a positive integer: ");
            //    int n = convert.toint32(console.readline());

            //    if (n <= 0)
            //    {
            //        console.writeline("please enter a number greater than zero.");
            //        return;
            //    }

            //    // create object of sumcalculator class
            //    //sumcalculator calculator = new sumcalculator();

            //    // call the renamed method
            //    //int sum = calculator.naturaladd(n);
            //    int sum = sumcalculator.naturaladd(n);

            //    console.writeline($"\nsum of first {n} natural numbers is: {sum}");
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
            //if (1 == 0)
            //{
            //    Console.Write("Enter how many numbers you want to store: ");
            //    int size = Convert.ToInt32(Console.ReadLine());

            //    int[] numbers = new int[size];

            //    Console.WriteLine("\nEnter the numbers:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Number {i + 1}: ");
            //        numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    Console.Write("\nEnter a number to check if it exists in the array: ");
            //    int searchNumber = Convert.ToInt32(Console.ReadLine());

            //    // Create object of the separate class
            //    ArrayNumberCheck numberSearch = new ArrayNumberCheck();

            //    bool exists = numberSearch.CheckNumber(numbers, searchNumber);

            //    if (exists)
            //        Console.WriteLine($"\nThe number {searchNumber} exists in the array.");
            //    else
            //        Console.WriteLine($"\nThe number {searchNumber} does NOT exist in the array.");

            //    Console.WriteLine("\nPress any key to exit...");
            //    Console.ReadKey();
            //}
            // Console.WriteLine("Enter any word: ");
            // String Word = Console.ReadLine();

            // // Create object for name reverse class
            //// string result = Revesestring(Word);

            // Console.WriteLine("\nPress any key to exit..");
            // Console.ReadKey();
            // Take string input from user
            // Take input string from user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Convert string to character array
            char[] chars = input.ToCharArray();

            // Boolean array to mark visited characters
            bool[] visited = new bool[chars.Length];

            Console.WriteLine("\nCharacter Frequency:");

            // To store duplicates at the end
            string duplicates = "";
            bool hasDuplicates = false;

            // Loop to count frequency of each character
            for (int i = 0; i < chars.Length; i++)
            {
                // Skip already visited characters
                if (visited[i])
                    continue;

                int count = 1;

                // Compare current char with remaining characters
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }

                // Print frequency
                Console.WriteLine($"{chars[i]} - {count}");

                // If this character appeared more than once, add to duplicate list
                if (count > 1)
                {
                    if (duplicates.Length > 0)
                        duplicates += ", ";

                    duplicates += chars[i];
                    hasDuplicates = true;
                }
            }

            // Display all duplicates at the end
            Console.WriteLine("\nDuplicate Characters:");
            if (hasDuplicates)
                Console.WriteLine(duplicates);
            else
                Console.WriteLine("No duplicate characters found.");

        }
        }

       // private static string Revesestring(string? word)
        //{
            // throw new NotImplementedException();
            //  int length_var = word.Length.
        //}
    }
