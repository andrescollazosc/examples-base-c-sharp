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
        string output = string.Empty;
        foreach (var word in input.Split(' '))
        {
            char prevChar = '\0';
            var aux = new char[2];
            string[] splittedWord = null;

            foreach (var character in word) {
                if (!Char.IsLetter(character))
                {
                    aux[0] = prevChar;
                    aux[1] = character;
                    splittedWord = word.Split(character);
                }
                prevChar= character;
            }

            string resWord=string.Empty;

            if (splittedWord != null && splittedWord.Length > 0)
            {
                string additionalSpace=string.Empty;
                foreach (var subword in splittedWord)
                {
                    if (!string.IsNullOrEmpty(subword))
                    {
                        resWord += $"{subword.FirstOrDefault()}{GetCountUniqueLetters(subword)}{subword.LastOrDefault()} ";
                    }
                    else {
                        additionalSpace = " ";
                    }
                }
                if (aux.Count() > 0)
                {
                    resWord = resWord.Replace($"{aux[0]} ", $"{new string(aux)}{additionalSpace}");
                }
            }
            else
            {
                resWord = $"{word.FirstOrDefault()}{GetCountUniqueLetters(word)}{word.LastOrDefault()} ";
            }

            output += resWord;
        }

        return output.TrimEnd();
    }

    private static string GetCountUniqueLetters(string word) {
        string countUniqueLetters = word.Substring(1, word.Length - 2).Distinct().Count().ToString();
        return countUniqueLetters.Equals("0") ? string.Empty : countUniqueLetters; 
    }

    public static void Main()
    {
        string output = WordParser("Creativity is thinking-up new things. Innovation is doing new things!");
        Console.WriteLine(output);
        // expected: C6y is t4g-up n1w t4s. I6n is d3g n1w t4s!
    }
}