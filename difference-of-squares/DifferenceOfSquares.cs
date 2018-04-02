using System;
using System.Linq;

public static class Squares
{
    public static int SquareOfSums(int max)
    {
        return (int)Math.Pow(Enumerable.Range(1, max).Sum(), 2);
    }

    public static int SumOfSquares(int max)
    {
        return Enumerable.Range(1, max).Sum(x => x * x);
    }

    public static int DifferenceOfSquares(int max)
    {
        return SquareOfSums(max) - SumOfSquares(max);
    }
}