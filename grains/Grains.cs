using System;
using System.Linq;

public static class Grains
{
    public static ulong Square(int n)
    {
        return (ulong)Math.Pow(2, n-1);
    }

    public static ulong Total()
    {
        return Enumerable.Range(1, 64)
            .Select(Square)
            .Aggregate((a, b) => a + b);
    }
}