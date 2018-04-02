using System;
using System.Text;

public static class Raindrops
{
    public static string Convert(int n)
    {
        var sb = new StringBuilder();
        if (n % 3 == 0) sb.Append("Pling");
        if (n % 5 == 0) sb.Append("Plang");
        if (n % 7 == 0) sb.Append("Plong");
        return sb.Length == 0 ? n.ToString() : sb.ToString();
    }
}