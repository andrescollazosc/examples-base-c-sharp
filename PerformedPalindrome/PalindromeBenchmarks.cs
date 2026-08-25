using BenchmarkDotNet.Attributes;

public class PalindromeBenchmarks {

    private readonly string _word = "tattarrattat";//anitalavalatina

    [Benchmark]
    public bool IsPalindrome()
    {
        return Program.IsPalindrome(_word);
    }

    [Benchmark]
    public bool IsPalindromeCommon()
    {
        return Program.IsPalindromeCommon(_word);
    }
}




