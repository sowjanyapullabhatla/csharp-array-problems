namespace ArraySumAverage
{
    public class ArrayHelper
    {
        // Method to calculate sum and average
        public (int sum, double avg) Sumavg(int[] arr)
        {
            int total = 0; // avoid 'sum' here to prevent conflict

            // Calculate sum
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            // Calculate average
            double average = (double)total / arr.Length;

            return (total, average); // tuple with names sum and avg
        }
    }
}
