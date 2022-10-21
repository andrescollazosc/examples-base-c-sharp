using Newtonsoft.Json;

public class Program
{
    public static void Main(string[] args) {
        
        // string elements = "13 DUP 4 POP 5 DUP + DUP + -";
        string elements = "23 DUP 4 POP 5 DUP -";
        string[] arrElements = elements.Split(' ');

        Stack<int> stack = new Stack<int>();

        for (int i=0; i< arrElements.Length;i++)
        {
            int isNumeric;
            if (int.TryParse(arrElements[i], out isNumeric))
            {
                stack.Push(isNumeric);
            }else
            {
                switch (arrElements[i])
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
        Console.Write(JsonConvert.SerializeObject(stack));
    }
}