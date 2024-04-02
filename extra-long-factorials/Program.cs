using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        int n = 25;

        extraLongFactorials(n);
    }

    public static void extraLongFactorials(int n)
    {
        BigInteger factorial = CalculateFactorial(n);
        Console.WriteLine(factorial);
    }

    public static BigInteger CalculateFactorial(int n) {

        if (n == 0 || n == 1)
            return 1;
        else
        {
            return CalculateFactorial(n - 1)*n;
        }
    } 
}