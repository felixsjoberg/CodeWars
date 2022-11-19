/*
 * A pangram is a sentence that contains every single letter of the alphabet at least once. 
 * For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, 
 * because it uses the letters A-Z at least once (case is irrelevant).
 * 
Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace codeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("ABCD45EFGH,IJK,LMNOPQR56STUVW3XYZ"));
        }
        public static bool IsPangram(string str)
        {
            var k = str.ToLower().ToHashSet();
            List<char> strabc = new List<char>() {'a','b','c','d','e','f','g','h','i',
                'j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };

            int count = 0;

            for (int i = 0; i < strabc.Count; i++)
            {
                // If not duplicate, add to result.
                if (k.Contains(strabc[i]))
                {
                    count++;
                }
            }
            return count >= 26 ? true : false;

        }

    }
}