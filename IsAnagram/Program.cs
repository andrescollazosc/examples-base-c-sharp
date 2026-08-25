/*
Create a function that takes two strings and returns either true or false depending on whether they're perfect anagrams or not.

An anagram is a word or phrase formed by rearranging the letters of a different word or phrase.
A perfect anagram uses all the letters, no more, no less.
Examples



Notes

    Should be case insensitive.
    The strings can be of different length.
    Take into account best practices, validations, error handling and performance.

*/

using System.Linq;

public class Program{

    public static void Main (string [] args){
        
        var result1 = IsAnagram("William Shakespeare", "I am a weakish speller");//true
        var result2 = IsAnagram("A gentleman", "elegant man");//true
        var result3 = IsAnagram("apple", "peal");//false
        var result4 = IsAnagram("Nope", "Note");//false
        
        Console.WriteLine($"{result1}, {result2}, {result3}, {result4}");
        //Console.WriteLine($"{result4}");
    }

    private static bool IsAnagram(string firstPhrase, string secondPhrase){
        var firstPhraseCleaned = firstPhrase.Replace(" ", "").ToLower();
        var secondPhraseCleaned = secondPhrase.Replace(" ", "").ToLower();
        
        if (firstPhraseCleaned.Length != secondPhraseCleaned.Length)
        {
            return false;
        }
        
        var firstPhraseArray = firstPhraseCleaned.ToCharArray().Order();
        var secondPhraseArray = secondPhraseCleaned.ToCharArray().Order();
        
        return string.Join("", firstPhraseArray) == string.Join("", secondPhraseArray);
    }
}