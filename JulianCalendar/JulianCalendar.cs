using System;

namespace JulianCalendar
{
    class JulianCalendar
    {

        static int getJulian(DateTime input)
        {
            int inputYear = input.Year;
            DateTime Jan01 = new DateTime(inputYear, 01, 01);
            TimeSpan dateDifference = input.Subtract(Jan01);
            int dateDiff = dateDifference.Days + 1;
            
            return dateDiff;
        }
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(getJulian(today));
        }
    }
}
