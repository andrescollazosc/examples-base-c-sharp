/*
Write a program that parses a sentence and replaces each word with the following: 
1) The first letter of the word
2) The number of distinct characters between first and last character
3) The last letter of the word. 
For example, Smooth would become S3h. 
Words are separated by spaces or non-alphabetic characters and these separators should be maintained in their original form and location in the answer. 
A few of the things we will be looking at is accuracy, efficiency, solution completeness. 
*/
public class Program
{
    public static string WordParser(string input)
    {
        foreach (var word in input.Split(" "))
        {
            foreach (var letter in word.Split(""))
            {
                Console.WriteLine(letter);
            }
        }
        return null;
    }

    public static void Main()
    {
        string output = WordParser("Creativity is thinking-up new things. Innovation is doing new things!");
        Console.WriteLine(output);
        // expected: C6y is t4g-up n1w t4s. I6n is d3g n1w t4s!
    }
}