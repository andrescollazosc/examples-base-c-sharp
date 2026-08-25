internal class Program
{
    private static void Main(string[] args)
    {
        var arr = new int[] { 1, 2, 3, 4, 5, 6 };

        var resSum = arr.Sum();
        int sum = 0;

        foreach (int i in arr) {
            sum = sum + i;
        }
          
        foreach (int i in arr) { 
            sum = resSum - i;
            Console.WriteLine(sum);
        }
    }
}