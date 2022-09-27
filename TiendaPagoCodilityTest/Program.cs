public class Program
{
    public static void Main(string[] args) {
        Console.WriteLine(Solution("4 5 6 - 7 +"));
    }

    private static int Solution(string S)
    {
        var a = S.Split(' ');

        foreach (var item in a)
        {
            switch (item)
            {
                case "POP":
                    
                    break;
                case "DUP":// duplica el elemento anterior de la pila
                    //a.GetValue(a.)
                    break;
                case "+":
                    break;
                case "-":
                    break;
            }
        }

        return a.Length;
    }
}