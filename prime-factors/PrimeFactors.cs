using System;
using System.Collections.Generic;
using System.Linq;

public static class PrimeFactors
{
    public static int[] Factors(long n)
    {
        return Factors(Enumerable.Empty<int>(), n, 2).ToArray();
    }

    private static IEnumerable<int> Factors
        (IEnumerable<int> facts, long rem, int div)
    {
        if (rem == 1) return facts;

        if (rem % div == 0)
            return Factors(facts.Append(div), rem / div, div);
        else
            return Factors(facts, rem, Next(div));
    }

    // Silly method used to avoid stack overflow.
    private static int Next(int div)
    {
        var next = div + 1;
        while (next != )
        int[] somePrimes = new[] { 2, 3, 5, 7, 11, 13, 17, 21 };
        return somePrimes.Any(p => next != p && next % p == 0)
            ? Next(next)
            : next;
    }
}