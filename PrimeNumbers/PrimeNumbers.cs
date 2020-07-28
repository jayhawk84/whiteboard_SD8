using System;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        public static bool PrimeTest(int num)
        {
            for (int i = 2; i < num; i++ )
            {
                if (num % i != 0)
                { return false; }
            }
            return true;
        }

        public static void Main()
        {
            Console.WriteLine(PrimeNumbers.PrimeTest(5));
        }
    }
}
