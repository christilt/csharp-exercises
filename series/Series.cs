using System;
using System.Linq;

public class Series
{
    public string Digits { get; private set; }

    public Series(string digits) { Digits = digits; }

    public int[][] Slices(int n)
    {
        if (n > Digits.Length) throw new ArgumentException();

        return Enumerable.Range(0, Digits.Length - n + 1)
            .Select(startIndex => Slice(startIndex, n))
            .ToArray();
    }

    private int[] Slice(int startIndex, int length)
    {
        return Digits.Substring(startIndex, length)
            .Select(c => (int)char.GetNumericValue(c))
            .ToArray();
    }
}