using System;
using System.Text;

namespace ReverseAString
{
    class Program
    {

        public static string ReverseThisString()
        {
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();
            //StringBuilder output = new StringBuilder();
            string output = "";

            for (int i = input.Length-1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(ReverseThisString());
        }
    }
}
