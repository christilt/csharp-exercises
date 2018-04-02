using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        var primes = new List<int>();
        var composites = new HashSet<int>();
        for (int factor = 2; factor <= limit; factor++)
        {
            if (composites.Contains(factor)) continue;
            primes.Add(factor);
            for (int product = factor * 2; product <= limit; product += factor)
            {
                composites.Add(product);
            }
        }
        return primes.ToArray();
    }
}