using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Palindrome
{
    class Palindrome
    {
        public static bool isPalindrome(string inputString)
        {
            int start = 0;
            for (int end = inputString.Length - 1; end > 0; end--)
            {

                if (inputString[end] == (inputString[start]))
                {
                    start++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isPal(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                char last = char.ToUpper(inputString[inputString.Length - i - 1]);
                char first = char.ToUpper(inputString[i]);
                if (first != last) return false;
            }
            return true;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome.Palindrome.Main()");

            string testString = "racecar";
            string testString2 = "cat";

            Console.WriteLine(isPalindrome(testString));

        }
    }
}
