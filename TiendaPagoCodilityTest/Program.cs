using Newtonsoft.Json;

public class Program
{
    public static void Main(string[] args)
    {

        var resStack = Solution("23 DUP 4 POP 5 DUP -");

        Console.Write(JsonConvert.SerializeObject(resStack));
    }

    private static Stack<int> Solution(string inputOperations)
    {
        string[] arrElements = inputOperations.Split(' ');

        Stack<int> stack = new Stack<int>();

        foreach (string element in arrElements)
        {
            int isNumeric;
            if (int.TryParse(element, out isNumeric))
            {
                stack.Push(isNumeric);
            }
            else
            {
                switch (element)
                {
                    case "POP":
                        stack.Pop();
                        break;
                    case "DUP":
                        stack.Push(stack.First());
                        break;
                    case "+":
                        stack.Push(stack.Take(2).Sum());
                        break;
                    case "-":
                        int previous = stack.Take(new Range(1, 2)).FirstOrDefault();
                        stack.Push(stack.First() - previous);
                        break;
                }
            }
        }
        return stack;
    }
}