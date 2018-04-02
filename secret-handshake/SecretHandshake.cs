using System;
using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{

    private static Dictionary<int, string> code =
        new Dictionary<int, string>
        {
                { 0, "wink" },
                { 1, "double blink" },
                { 2, "close your eyes" },
                { 3, "jump" }
        };

    public static string[] Commands(int i)
    {
        string bin = String.Concat(Convert.ToString(i, 2).Reverse());
        var res = Enumerable.Range(0, bin.Length)
            .Take(4)
            .Where(idx => bin[idx] == '1')
            .Select(idx => code[idx]);
        return i < 16 ? res.ToArray() : res.Reverse().ToArray();
    }
}