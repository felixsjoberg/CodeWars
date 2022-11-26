/* Description Kata:
 * Welcome.

In this kata you are required to, given a string,
replace every letter with its position in the alphabet.

If anything in the text isn't a letter, ignore it and don't return it.
"a" = 1, "b" = 2, etc.

Example
Kata.AlphabetPosition("The sunset sets at twelve o' clock.")

Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"
( as a string )
*/

using System;
using System.Text.RegularExpressions;
public static class Kata
{
    public static string AlphabetPosition(string text)
    {

        if (text == string.Empty)
        {
            return string.Empty;
        }
        string result = "";

        text = Regex.Replace(text, @"[^a-zA-Z]", " ");
        var charArray = new char[] { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n'
                                            ,'o','p','q','r','s','t','u','v','w','x','y','z' };
        foreach (var c in text)
        {
            if (c == ' ')
            {
                continue;
            }
            result += char.ToUpper(c) - 64 + " ";
        }

        return String.Join(" ", result).TrimEnd();
    }
}