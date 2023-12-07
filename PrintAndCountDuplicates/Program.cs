public class Program
{
    public static void Main(string[] args) {
        var res = GetDuplicatesAndCounts("abbccdeff");

        Console.WriteLine($"{res.Item1} - {res.Item2}");
    }

    public static (string, int) GetDuplicatesAndCounts(string text)
    {
        var charCounts = new Dictionary<char, int>();
        var duplicatedChars = new HashSet<char>();

        foreach (var c in text)
        {
            if (!charCounts.ContainsKey(c))
            {
                charCounts.Add(c, 0);
            }

            charCounts[c]++;

            if (charCounts[c] > 1)
            {
                duplicatedChars.Add(c);
            }
        }

        return (new string(duplicatedChars.ToArray()), duplicatedChars.Count);
    }
}
