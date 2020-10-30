using System;
using System.Text;

namespace PascalConversion
{
    class Program
    {
        public static string ConvertedToPascalString(string[] input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i].ToLower();
                StringBuilder modWord = new StringBuilder();

                for (int j = 0; j < word.Length; j++)
                {
                    if (j == 0) modWord.Append(Char.ToUpper(word[j]));
                    else if (word[j] >= 'a' && word[j] <= 'z' || word[j] >= '0' && word[j] <= '9')
                    { modWord.Append(word[j]); }

                }

                result.Append(modWord.ToString());
                modWord.Clear();

            }

            return result.ToString();
        }



        public static string PascalConvert1(string[] input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i].ToLower();
                StringBuilder modWord = new StringBuilder();
                bool nextCap = true;

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == ' ') nextCap = true;

                    else if (word[j] >= 'a' && word[j] <= 'z' && nextCap == true)
                    {
                        modWord.Append(Char.ToUpper(word[j]));
                        nextCap = false;
                    }
                    else if (word[j] >= 'a' && word[j] <= 'z') modWord.Append(word[j]);
                }

                result.Append(modWord.ToString());
                modWord.Clear();
            }

            return result.ToString();

        }

        public static string ConvertedToPascalString2(string[] input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i].ToLower();
                StringBuilder modWord = new StringBuilder();
                bool nextCap = false;

                for (int j = 0; j < word.Length; j++)
                {
                    //if (j == 0) modWord.Append(Char.ToUpper(word[j]));
                    if (word[j] == ' ') nextCap = true;
                    else if (word[j] >= 'a' && word[j] <= 'z' && nextCap == true)
                    {
                        modWord.Append(Char.ToUpper(word[j]));
                        nextCap = false;
                    }
                    else if (word[j] >= 'a' && word[j] <= 'z') modWord.Append(word[j]);

                }

                result.Append(modWord.ToString());
                modWord.Clear();

            }

            return result.ToString();
        }
        static void Main(string[] args)
        {
            string[] sample = new string[] { "The", "HUNGRY", "34hippo", "waNts", "your", "dinner right now" };
            Console.WriteLine(  PascalConvert1(sample));
            Console.WriteLine(ConvertedToPascalString2(sample));
            Console.WriteLine("Hello World!");
        }
    }
}
