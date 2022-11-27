/* Description Kata:
 Write Number in Expanded Form

You will be given a number and you will need to return it as a string in Expanded Form.
For example:

Kata.ExpandedForm(12); # Should return "10 + 2"
Kata.ExpandedForm(42); # Should return "40 + 2"
Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"

*/

using System;
using System.Linq;

public static class Kata
{
    public static string ExpandedForm(long num)
    {
        var numbers = num.ToString().ToArray();
        string otherNumbers = "";

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != '0')
            {
                otherNumbers += numbers[i] + new String('0', numbers.Length - i - 1) + " + ";
            }
        }
        return otherNumbers = otherNumbers.Remove(otherNumbers.Length - 2, 1).TrimEnd();
    }
}