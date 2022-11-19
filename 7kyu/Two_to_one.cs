/*
  Take 2 strings s1 and s2 including only letters from a to z. 
  Return a new sorted string, the longest possible, 
  containing distinct letters - each taken only once - coming from s1 or s2.
Examples:

a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
longest(a, b) -> "abcdefklmopqwxy"

 */
using System.Linq;

public class TwoToOne
{

    public static string Longest(string s1, string s2)
    {
        var hs1 = s1.ToHashSet();
        var hs2 = s2.ToHashSet();
        hs1.UnionWith(hs2);
        var lista = hs1.ToList();
        lista.Sort();
        return string.Join("", lista);
    }
}