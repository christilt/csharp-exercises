using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int To(IEnumerable<int> facts, int max)
    {
        return Enumerable.Range(1, max-1)
            .Where(mult => anyMultiplesOf(facts, mult))
            .Sum();
    }

    static bool anyMultiplesOf(IEnumerable<int> facts, int mult)
    {
        return facts.Any(fact => isMultipleOf(fact, mult));
    }

    static bool isMultipleOf(int fact, int mult)
    {
        return mult % fact == 0;
    }
}