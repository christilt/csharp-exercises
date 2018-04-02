using System;
using System.Collections.Generic;
using System.Linq;

public static class Complement
{
    static Dictionary<char, char> trans = new Dictionary<char, char>()
    {
        { 'G', 'C' },
        { 'C', 'G' },
        { 'T', 'A' },
        { 'A', 'U' }
    };

    public static string OfDna(string nucleotide)
    {
        return String.Concat(nucleotide.Select(x => trans[x]));
    }
}