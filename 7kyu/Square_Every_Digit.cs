/* Description Kata:
Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out,
because 92 is 81 and 12 is 1.

Note: The function accepts an integer and returns an integer
 */
using System;
using System.Linq;

public class Kata
{
    public static int SquareDigits(int n)
    {
        var a = n.ToString().Select(x => int.Parse(x.ToString()));
        string result = "";
        foreach (var item in a)
        {
            result += (item * item);
        }
        return int.Parse(result);
    }
}