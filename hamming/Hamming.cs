using System;
using System.Linq;

public static class Hamming
{
    public static int Compute(string a, string b)
    {
        if (a.Length != b.Length) throw new ArgumentException();
        return a.Zip(b, (a1, b1) => a1 == b1 ? 0 : 1).Sum();
    }
}