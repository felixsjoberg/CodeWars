/*Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. 
 * However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

Your task is to write a function maskify, which changes all but the last four characters into '#'.
Examples

"4556364607935616" --> "############5616"
*/

public static class Kata
{
    // return masked string
    public static string Maskify(string cc)
    {
        var fourChar = "";
        string hastTag = "";

        if (cc.Length <= 4)
        {
            return cc;
        }
        for (int i = 0; i < cc.Length - 4; i++)
        {
            fourChar = cc.Substring(cc.Length - 4);
            hastTag = hastTag + "#";
        }
        return hastTag + fourChar;
    }
}