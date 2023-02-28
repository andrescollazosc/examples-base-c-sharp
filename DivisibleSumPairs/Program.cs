public class Program
{
    public static void Main(string[] args) {
        var res = divisibleSumPairs(6, 5, new List<int> { 1, 2, 3, 4, 5, 6 });
        Console.WriteLine(res);
    }

    private static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int pairs = 0;
        
        for (int i = 0; i < ar.Count; i++)
        {
            for (int j = i + 1; j < ar.Count; j++)
            {
                int res = ar[i] + ar[j];
                if (res % k == 0)
                pairs++;  
            }
        }

        return pairs;
    }
}
