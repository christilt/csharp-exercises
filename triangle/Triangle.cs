using System;
using static TriangleKind;

public enum TriangleKind
{
    Equilateral, Isosceles, Scalene
}

public static class Triangle
{
    public static TriangleKind Kind(decimal a, decimal b, decimal c)
    {
        if (Illogical()) throw new TriangleException();
        if (a == b && b == c) return Equilateral;
        if (a == b || b == c || c == a) return Isosceles;
        else return Scalene;

        bool Illogical() => (a <= 0 || b <= 0 || c <= 0) ||
                (a + b <= c || b + c <= a || c + a <= b);
    }
}

public class TriangleException : Exception { }