using System;
using System.Collections.Generic;
using System.Linq;

public static class Scrabble
{
    private static Dictionary<char, int> Points
    {
        get
        {
            var points = new Dictionary<char, int>();
            points.AddMany("AEIOULNRST", 1);
            points.AddMany("DG", 2);
            points.AddMany("BCMP", 3);
            points.AddMany("FHVWY", 4);
            points.AddMany("K", 5);
            points.AddMany("JX", 8);
            points.AddMany("QZ", 10);
            return points;
        }
    }

    public static int Score(string input)
    {
        return clean(input).Sum(x => Points[x]);
    }

    static string clean(string input)
    {
        var s = input != null ? input.ToUpper() : "";
        return String.Concat(s.Where(Char.IsLetter));
    }
}

public static class DictionaryExtension
{
    public static void AddMany(
        this Dictionary<char, int> d,
        string keys,
        int v)
    {
        keys.ToList().ForEach(k => d.Add(k, v));
    }
}