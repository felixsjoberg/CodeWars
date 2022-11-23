/* Description Kata:
 * Write a function that takes in a string of one or more words, 
 * and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). 
 * Strings passed in will consist of only letters and spaces. 
 * Spaces will be included only when more than one word is present.

Examples:
spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
spinWords( "This is a test") => returns "This is a test"
*/

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        var annan = "";
        var result = "";
        string[] words = sentence.Split(' ');

        foreach (var word in words)
        {
            if (word.Count() > 4)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    annan += word[i];
                }
                result += ' ' + annan;
                annan = "";
            }
            else
                result += ' ' + word;

        }
        return result.TrimStart();
    }
}