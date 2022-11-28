/* Description Kata:
Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.
You don't need to validate the form of the Roman numeral.

Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately,
starting with the leftmost digit and skipping any 0s.
So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII).
The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

Example:
RomanDecode.Solution("XXI") -- should return 21
Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000

*/

using System;
using System.Collections.Generic;
public class RomanDecode
{
    public static int Solution(string roman)
    {
        Dictionary<string, int> mydict = new Dictionary<string, int>() {
            { "I", 1},
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 }
            };
        int answer = 0;
        for (int i = 0; i < roman.Length; i++)
        {
            mydict.TryGetValue(roman[i].ToString(), out var result);
            try
            {
                for (int j = i; j <= i; j++)
                {
                    if (mydict.TryGetValue(roman[j + 1].ToString(), out var result2))
                    {
                        if (result >= result2)
                        {
                            answer += result;
                        }
                        else
                        {
                            answer -= result;
                        }
                    }
                    else
                    {
                        answer += result;
                    }
                }
            }
            catch (Exception ex)
            {
                answer += result;
            }
        }
        return answer;
    }
}