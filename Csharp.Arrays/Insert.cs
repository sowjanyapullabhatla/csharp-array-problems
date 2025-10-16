using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertArray
{
    internal class Insert
    {
        // Insert element at FIRST position
        public static int[] InsertAtFirstPosition(int[] originalArray, int newElement)
        {
            // Create a new array with one extra space
            int[] newArray = new int[originalArray.Length + 1];

            // Insert new element at the first position
            newArray[0] = newElement;

            // Copy the rest of the elements
            for (int i = 0; i < originalArray.Length; i++)
            {
                newArray[i + 1] = originalArray[i];
            }

            return newArray;
        }

        // Insert element at MIDDLE position
        public static int[] InsertAtMiddlePosition(int[] originalArray, int newElement)
        {
            int[] newArray = new int[originalArray.Length + 1];

            // Find the middle index
            int middleIndex = originalArray.Length / 2;

            // Copy elements before the middle
            for (int i = 0; i < middleIndex; i++)
            {
                newArray[i] = originalArray[i];
            }

            // Insert new element
            newArray[middleIndex] = newElement;

            // Copy remaining elements
            for (int i = middleIndex; i < originalArray.Length; i++)
            {
                newArray[i + 1] = originalArray[i];
            }

            return newArray;
        }
        // Insert element at LAST position
        public static int[] InsertAtLastPosition(int[] originalArray, int newElement)
        {
            int[] newArray = new int[originalArray.Length + 1];

            // Copy all elements
            for (int i = 0; i < originalArray.Length; i++)
            {
                newArray[i] = originalArray[i];
            }

            // Add the new element at the end
            newArray[newArray.Length - 1] = newElement;

            return newArray;
        }
        // 🔥 Generic method: Insert at any given position (0-based index)
        public static int[] InsertAtGivenPosition(int[] originalArray, int newElement, int position)
        {
            // Validate position (must be between 0 and array.Length)
            if (position < 0 || position > originalArray.Length)
            {
                Console.WriteLine("Invalid position! Position must be between 0 and " + originalArray.Length);
                return originalArray; // return original unchanged
            }

            int[] newArray = new int[originalArray.Length + 1];

            // Copy elements before position
            for (int i = 0; i < position; i++)
            {
                newArray[i] = originalArray[i];
            }

            // Insert new element
            newArray[position] = newElement;

            // Copy remaining elements
            for (int i = position; i < originalArray.Length; i++)
            {
                newArray[i + 1] = originalArray[i];
            }

            return newArray;
        }
    }
}
