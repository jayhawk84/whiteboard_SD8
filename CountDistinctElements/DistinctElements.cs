using System;

namespace CountDistinctElements
{
    public class DistinctElements
    {

        //create a method that returns the count of distinct elements in an integer array
        // example : { 1, 1, 2, 2, 3, 4, 5, 6, 6} returns 6

        /*public static int CountDistinct( int[] numbers)
        {
            int result = 1;

            // Pick all elements one by one 
            for (int i = 1; i < numbers.Length; i++)
            {
                int j = 0;
                for (j = 0; j < i; j++)
                    if (numbers[i] == numbers[j])
                        break;

                // If not printed earlier, then print it 
                if (i == j)
                    result++;
            }
            return result;
        }*/

        public static int CountDistinct( int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isNew = true;
                for (int j = 0; j< i; j++)
                {
                    if (numbers[i] == numbers[j]) isNew = false;
                    if (isNew == false) break;
                }
                if (isNew) count++;
            }
            return count;
        }
        
        public static void Main(string[] args)
        {
            int[] myNumbers = { 4, 4, 6, 2, 4, 8, 0, 1, 3, 4, 6 };
            int total = CountDistinct(myNumbers);
            Console.WriteLine(total);
        }
        
    }
}
