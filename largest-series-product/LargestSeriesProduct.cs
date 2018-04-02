using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string s, int range) 
    {
        if (Regex.IsMatch(s, @"\D+") || range < 0 || range > s.Length)
            throw new ArgumentException();

        return Enumerable.Range(0, s.Length - range + 1)
            .Select(SeriesProduct)
            .Max();

        long SeriesProduct(int n)
        {
            return s.Substring(n, range)
                .Select(c => (long)Char.GetNumericValue(c))
                .Aggregate(1L, (acc, v) => acc * v);
        }
    }
}