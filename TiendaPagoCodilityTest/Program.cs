public class Program
{
    public static void Main(string[] args) {
        Console.WriteLine(Solution("4 5 6 - 7 + POP"));
    }

    private static int Solution(string S)
    {
        var a = S.Split(' ');
        Stack<string> inputStack = new Stack<string>();
        
        foreach (var item in a)
        {
            inputStack.Push(item);
        }

        foreach (var item in inputStack)
        {
            switch (item)
            {
                case "POP":// Elimina el elemento anterior de la pila
                    inputStack.Pop();
                    break;
                case "DUP":// Duplica el elemento anterior de la pila
                    //a.GetValue(a.)
                    break;
                case "+":// Suma los ultimos 2
                    break;
                case "-":// Resta(Saca la diferencia) los ultimos 2
                    break;
            }
        }

        Console.WriteLine($"Resultant stack: {string.Join(' ', inputStack)}");

        return a.Length;
    }
}