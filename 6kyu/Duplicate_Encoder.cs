/* Description Kata:
 * The goal of this exercise is to convert a string to a new string where each character in the new string is 
 * "(" if that character appears only once in the original string, or ")" 
 * if that character appears more than once in the original string. 
 * Ignore capitalization when determining if a character is a duplicate.
Examples:

"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 
*/

using System.Linq;
public class Kata
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();
        var result = "";
        foreach (var ord in word)
        {
            var occurrence = word.Count(ord.ToString().Contains);
            if (occurrence > 1)
            {
                result += ")";
            }
            else
            {
                result += "(";
            }
        }
        return result;
    }
}