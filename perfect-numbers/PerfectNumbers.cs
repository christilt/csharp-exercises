using System;
using System.Linq;
using static Classification;

public enum Classification
{
    Perfect, Abundant, Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int n)
    {
        if (n < 1) throw new ArgumentOutOfRangeException();
        var sum = aliquotSum(n);
        return sum == n ? Perfect : (sum > n ? Abundant : Deficient);
    }

    private static int aliquotSum(int n)
    {
        return Enumerable.Range(1, n - 1).Where(x => n % x == 0).Sum();
    }
}