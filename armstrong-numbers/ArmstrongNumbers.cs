using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int n)
    {
        return n == ArmstrongNumber(n);
    }

    private static double ArmstrongNumber(int n)
    {
        return DigitsOf(n)
            .Select(d => Pow(d, NoDigits(n)))
            .Sum();
    }

    private static IEnumerable<double> DigitsOf(int n)
    {
        return n.ToString()
            .Select(c => double.Parse(c.ToString()));
    }

    private static double NoDigits(int n) => Floor(Log10(n)) + 1;
}