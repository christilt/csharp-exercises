using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string input)
    {
        var s = String.Concat(input.Where(Char.IsLetter)).ToLower();
        return s.All(c1 => s.Count(c2 => c1 == c2) == 1);
    }
}