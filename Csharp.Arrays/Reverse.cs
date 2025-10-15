using System;

namespace ReverseArrayApp
{
    public static class Reverse
    {
        // Method to reverse an array
        public static int[] ReverseArray(int[] array)
        {
            int length = array.Length;
            int[] reversed = new int[length];

            for (int i = 0; i < length; i++)
            {
                reversed[i] = array[length - 1 - i];
            }

            return reversed;
        }

        // Method to print an array
        public static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Method to parse user input (e.g., "1 2 3 4 5") into int[]
        public static int[] ParseInput(string input)
        {
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            return numbers;
        }
    }
}