using System;

namespace LetterCountInString
{
    class Program
    {

		// 3 - 'S's
		// given: name of Movie and character to search for
		// return how manyh of the given character are needed

		public string LetterCountInString(string title, char searchCharacter)
		{
			int letterCount = 0;

			for (int i = 0; i < title.Length; i++)
			{
				if (title[i] == searchCharacter)
				{
					letterCount++;
				}

			}

			return Convert.ToString(letterCount);



		}
		static void Main(string[] args)
        {
            //Console.WriteLine(LetterCountInString("Resovoir Dogs", 's'));		

        }
    }
}
