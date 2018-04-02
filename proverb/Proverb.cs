using System;
using System.Collections.Generic;
using System.Linq;

public static class Proverb
{
    private static Dictionary<int, string> items = 
        new Dictionary<int, string>
    {
        { 0, "nail" }, { 1, "shoe" }, { 2, "horse" }, {3, "rider" },
        { 4, "message" }, { 5, "battle" }, {6, "kingdom" }
    };

    private static string initialLine(int n)
    {
        return $"For want of a {items[n - 1]} the {items[n]} was lost.";
    }

    private static string lastLine()
    {
        return "And all for the want of a horseshoe nail.";
    }

    public static string Line(int n)
    {
        return n < 7 ? initialLine(n) : lastLine();
    }

    public static string AllLines()
    {
        var initialLines = Enumerable
            .Range(1, 6)
            .Select(x => Line(x) + "\n");
        return String.Concat(initialLines) + lastLine();
    }
}