using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var s = input.ToLower();
        return "abcdefghijklmnopqrstuvwxyz".All(s.Contains);
    }
}