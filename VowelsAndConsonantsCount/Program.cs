using System;
using System.Linq;

namespace VowelsAndConsonantsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CountVowelsAndConsonants("what is going on with this");
            CountVowelsAndConsonants("shorter ex");

        }

        public static void CountVowelsAndConsonants(string input)
        {

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //string[] vowels = new string[] { "a", "e", "i", "o", "u" };

            int vowelCount = 0;
            int consonantCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool consonantAdd = true;
                char thisChar = input[i];
                foreach (char x in vowels)
                {
                    if (thisChar == x)
                    {
                        vowelCount++;
                        consonantAdd = false;
                    }
                }
                if (consonantAdd == true && thisChar != ' ') { consonantCount++; }
            }
            Console.WriteLine(vowelCount);
            Console.WriteLine(consonantCount);

        }
    }
}
