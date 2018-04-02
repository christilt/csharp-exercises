using System;
using System.Collections.Generic;
using System.Linq;

public class Triplet : IEquatable<Triplet>
{
    public int A { get; private set; }
    public int B { get; private set; }
    public int C { get; private set; }

    public Triplet(int a, int b, int c) { A = a; B = b; C = c; }

    public int Sum() => A + B + C;

    public int Product() => A * B * C;

    public bool IsPythagorean() => (A * A) + (B * B) == C * C;

    public static IEnumerable<Triplet> Where(int max, int min = 1, int sum = 0)
    {
        return AllTripletsWhere(max, min, sum).Distinct();
    }

    public override int GetHashCode()
    {
        return this.Product();
    }

    public bool Equals(Triplet other)
    {
        return this.Product() == other.Product();
    }

    private static IEnumerable<Triplet> AllTripletsWhere(int max, int min = 1, int sum = 0)
    {
        for (int a = min; a <= max; a++)
        {
            for (int b = min; b <= max; b++)
            {
                for (int c = min; c <= max; c++)
                {
                    var t = new Triplet(a, b, c);
                    if (t.IsPythagorean() && ((sum == 0) || (t.Sum() == sum)))
                    {
                        yield return t;
                    }
                }
            }
        }
    }
}