using BenchmarkDotNet.Running;

public class Program {

    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<PalindromeBenchmarks>();
    }

    private static bool IsPalindromeStack(string word)
    {
        if (word.Length == 0)
            return false;

        if (word[0] != word[word.Length - 1])
            return false;

        Stack<char> stack = new Stack<char>();

        foreach (char c in word) {
            if (true)
            {
                
            }
        }

        return false;
    }

    public static bool IsPalindrome(string word)
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

    public static bool IsPalindromeCommon(string word)
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




