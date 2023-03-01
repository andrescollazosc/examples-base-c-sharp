public class Program
{
    public static void Main(string[] args)
    {
        var a = SearchPage(6, 4);
    }

    public int SearchPage(int n, int p)
    {
        int left = 0;
        int right = 1;

        var pages = new List<Page>();
        while ((IsPair(n) ? left : right) <= n)
        {
            pages.Add(new Page { Left = left, Rigth = right });
            left = left + 2;
            right = right + 2;
        }

        // int[] arrLeft;
        // int[] arrRight;

        // for (int i = 0; i < n; i++)
        // {
        //     if (true)
        //     {
                
        //     }
        // }


        //var step = IsPair(n) ? left : right;

        
    }

    private static bool IsPair(int n){
        return n % 2 == 0;
    }
}

class Page
{
    public int Left { get; set; }
    public int Rigth { get; set; }
}