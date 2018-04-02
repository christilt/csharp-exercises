using System;
using System.Collections.Generic;
using System.Linq;
using ProteinTranslationExtensions;

public static class ProteinTranslation
{
    private static Dictionary<string, string> aminoMap = initMap();

    private static Dictionary<string, string> initMap()
    {
        var m = new Dictionary<string, string>();
        m.AddMany(new List<string> { "AUG" }, "Methionine");
        m.AddMany(new List<string> { "UUU", "UUC" }, "Phenylalanine");
        m.AddMany(new List<string> { "UUA", "UUG" }, "Leucine");
        m.AddMany(new List<string> {"UCU","UCC","UCA","UCG"},"Serine");
        m.AddMany(new List<string> { "UAU", "UAC" }, "Tyrosine");
        m.AddMany(new List<string> { "UGU", "UGC" }, "Cysteine");
        m.AddMany(new List<string> { "UGG" }, "Tryptophan");
        m.AddMany(new List<string> { "UAA", "UAG", "UGA" }, "STOP");
        return m;
    }

    public static string[] Translate(string input)
    {
        return input.SplitBy(3)
            .Select(TryGetAmino)
            .TakeWhile(s => s != "STOP")
            .ToArray();
    }

    private static string TryGetAmino(string codon)
    {
        if (aminoMap.TryGetValue(codon, out string a)) return a;
        else throw new Exception();
    }
}

namespace ProteinTranslationExtensions
{
    public static class Extension
    {
        public static void AddMany<T, U>(this Dictionary<T, U> d,
                                         List<T> ts,
                                         U u)
        {
            ts.ForEach(t => d.Add(t, u));
        }

        public static IEnumerable<string> SplitBy(this string s, int n)
        {
            return Enumerable.Range(0, s.Length / n)
                .Select(i => s.Substring(i * n, n));
        }
    }
}