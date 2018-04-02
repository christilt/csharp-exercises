using System;

public static class CollatzConjecture
{
    public static int Steps(int n)
    {
        if (n < 1) throw new ArgumentException();
        var steps = 0;
        while (n != 1)
        {
            n = Next(n);
            steps++;
        }
        return steps;
    }

    private static int Next(int n)
    {
        return n % 2 == 0 ? n / 2 : 3 * n + 1;
    }
}