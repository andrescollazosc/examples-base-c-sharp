using System.Diagnostics;

public class Program {

    public static void Main(String[] args) {
        Console.WriteLine("Ingresa un palindrome:");
        string word = Console.ReadLine();


        Stopwatch timeMeasure1 = new Stopwatch();
        timeMeasure1.Start();
        
        var resPal1 = IsPalindrome(word);
        Console.WriteLine(resPal1 ? "Es palindrome." : "No es palindrome.");

        timeMeasure1.Stop();
        Console.WriteLine($"Tardó {timeMeasure1.ElapsedTicks} Ticks");



        Stopwatch timeMeasure2 = new Stopwatch();
        timeMeasure2.Start();

        var resPal2 = IsPalindromeCommon(word);
        Console.WriteLine(resPal2 ? "Es palindrome." : "No es palindrome.");

        timeMeasure2.Stop();
        Console.WriteLine($"Tardó {timeMeasure2.ElapsedTicks} Ticks");
    }

    private static bool IsPalindrome(string word)
    {
        if (word.Length == 0)
            return false;

        if (word[0] != word[word.Length - 1])
            return false;

        int j = word.Length - 1;
        int steps = j / 2;
        int i = 0;

        for (int r = 0; r < steps; r++)
        {
            if (word[i] != word[j])
                return false;

            i++;
            j--;
        }

        return i == steps;
    }

    private static bool IsPalindromeCommon(string word)
    {
        int j = word.Length - 1;
        string result = "";

        for (int i = j; i >= 0; i--)
        {
            result+= word[i];
        }

        return result == word;
    }
}




