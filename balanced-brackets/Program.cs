using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        //string s = "{{[[(())]]}}";
        //string s = "{[(])}";
        string s = "{{[[(())]]}}";

        string res = isBalanced(s);

        Console.WriteLine(res);
    }

    public static string isBalanced(string s)
    {
        Stack<char> chars = new Stack<char> ();

        foreach (var character in s)
        {
           if (character ==  '(' || character == '[' || character == '{' ) 
           {
            //Se llena la pila con los brackets de apertura 
            chars.Push (character);
           }
            else if (character == ')' || character == ']' || character == '}')
            {
                if (chars.Count == 0)
                {
                    return "NO"; //No hay un paréntesis de apertura correspondiente
                }

                char leftBracket = chars.Pop();

                if ((character == ')' && leftBracket != '(') || (character == '}' && leftBracket != '{') || (character == ']' && leftBracket != '['))
                {
                    return "NO"; //Los paréntesis no coinciden
                }
            
            }
        }

        return chars.Count == 0 ? "YES" : "NO";
    }
}