using System;

class Program
{
    static void Main(string[] args)
    {
        //https://www.hackerrank.com/challenges/day-of-the-programmer

        int InputYear = int.Parse(Console.ReadLine());
        Console.WriteLine(DayOfProgrammer(InputYear));
    }
    private static int FebNumberDays(int year){
        int febNumberDays = 28;
        if (year % 4 == 0)
        {
            Console.WriteLine("Julian's calendar leap year: Every year that is exactly divisible by four is a leap year, so...");
            febNumberDays = 29;
            if (year % 400 == 0)
            {
                Console.WriteLine("Gregorian's calendar leap year: Centurial years are leap years if they are exactly divisible by 400");
                febNumberDays = 29;
            }
            else if (year % 100 != 0)
            {
                Console.WriteLine("Gregorian's calendar leap year: Divisible by 4 and not divisible by 100");
                febNumberDays = 29;
            }
        }
        Console.WriteLine($"returning {febNumberDays} for february.");
        return febNumberDays;
    }
    private static string DayOfProgrammer(int year)
    {
        const int dayOfProgrammerOfYear = 256;
        int daysUntilAugust = 0;

        for (int month = 1; month <= 8; month++)
        {
            if (month==2)
            {
                daysUntilAugust += FebNumberDays(year);    
            }else
            {
                daysUntilAugust += DateTime.DaysInMonth(year, month);    
            }
        }

        int daysOfSeptember = dayOfProgrammerOfYear - daysUntilAugust;

        return $"{daysOfSeptember}.09.{year}";
    }
}