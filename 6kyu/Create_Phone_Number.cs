/* Description Kata:
 * Write a function that accepts an array of 10 integers (between 0 and 9), 
 * that returns a string of those numbers in the form of a phone number.
Example:

Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
The returned format must be correct in order to complete this challenge.
Don't forget the space after the closing parentheses!
*/
using System.Linq;
public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        string result = "(";

        for (int i = 0; i < numbers.Length; i++)
        {
            if (result.Count() < 5)
            {
                result += numbers[i];
                if (result.Count() == 4)
                {
                    result += ") ";
                }
            }
            else if (result.Count() > 5 && result.Count() < 10)
            {
                result += numbers[i];
                if (result.Count() == 9)
                {
                    result += "-";
                }
            }
            else
            {
                result += numbers[i];
            }
        }
        return result;
    }
}

