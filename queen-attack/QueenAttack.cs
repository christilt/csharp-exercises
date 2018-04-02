using System;
using System.Linq;

public struct Queen
{
    private static int[] Squares = { 0, 1, 2, 3, 4, 5, 6, 7 };
    public int R { get; }
    public int C { get; }
    public Queen(int r, int c)
    {
        if (!(Squares.Any(s => r==s) && Squares.Any(s => c==s)))
            throw new ArgumentException();
        R = r; C = c;
    }
}

public static class Queens
{
    public static bool CanAttack(Queen w, Queen b)
    {
        if (w.Equals(b)) throw new ArgumentException();
        return w.R == b.R ||
               w.C == b.C ||
               Math.Abs(w.R - b.R) == Math.Abs(w.C - b.C);
    }
}