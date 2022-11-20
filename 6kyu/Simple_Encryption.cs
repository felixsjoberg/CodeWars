/*
 * Implement a pseudo-encryption algorithm which given a string S and an integer N
 concatenates all the odd-indexed characters of S with all the even-indexed characters of S,
this process should be repeated N times.

Examples:

encrypt("012345", 1)  =>  "135024"
encrypt("012345", 2)  =>  "135024"  ->  "304152"
encrypt("012345", 3)  =>  "135024"  ->  "304152"  ->  "012345"

encrypt("01234", 1)  =>  "13024"
encrypt("01234", 2)  =>  "13024"  ->  "32104"
encrypt("01234", 3)  =>  "13024"  ->  "32104"  ->  "20314"

Together with the encryption function,
you should also implement a decryption function which reverses the process.

If the string S is an empty value or the integer N is not positive,
return the first argument without changes.
*/
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string Encrypt(string text, int n)
    {
        // Exceptions: without decryption if null or negative n value
        if (n <= 0) { return text; }
        if (text == null) { return null; }
        // Encryption:
        // After avoiding the exception, we know it will encrypt atleast ones.
        // therefore the first time will be creating the variables,
        // and all the times n>0 we will manipulate this variables to multiply.
        else if (n >= 1)
        {
            var uneven = text.Where((text, index) => index % 2 != 0).ToArray();
            var even = text.Where((text, index) => index % 2 == 0).ToArray();
            var encryptedMessage = String.Join("", uneven) + String.Join("", even);
            encryptedMessage = String.Join("", uneven) + String.Join("", even);

            int i = 1;
            while (i < n)
            {
                uneven = encryptedMessage.Where((encryptedMessage, index) => index % 2 != 0).ToArray();
                even = encryptedMessage.Where((encryptedMessage, index) => index % 2 == 0).ToArray();
                encryptedMessage = String.Join("", uneven) + String.Join("", even);
                i++;
            }
            return encryptedMessage;
        }
        return null;

    }

    public static string Decrypt(string encryptedText, int n)
    {
        if (n <= 0) { return encryptedText; }
        if (encryptedText == null) { return null; }
        var list = new List<char>();
        var middle = encryptedText.Length / 2;



        for (int i = 0; i < n; i++)
        {
            var Even = encryptedText.Where((encryptedText, index) => index >= middle).ToArray();
            var unEven = encryptedText.Where((encryptedText, index) => index < middle).ToArray();

            if (encryptedText.Length % 2 == 0)
            {
                for (int j = 0; j < encryptedText.Length / 2; j++)
                {
                    list.Add(Even[j]);
                    list.Add(unEven[j]);
                }

            }
            else
            {
                for (int j = 0; j < encryptedText.Length / 2; j++)
                {
                    list.Add(Even[j]);
                    list.Add(unEven[j]);
                    if (j == (encryptedText.Length / 2) - 1)
                        list.Add(Even[encryptedText.Length / 2]);
                }
            }
            encryptedText = String.Join("", list);
            list.Clear();

        }
        return encryptedText;
    }
}