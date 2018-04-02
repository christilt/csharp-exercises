using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string x)
    {
        var abbreviation = Enumerable.Range(0, x.Length)
            .Where(i => i == 0 || isCapitalIndex(i))
            .Select(i => x.ToUpper()[i]);
        return String.Concat(abbreviation);

        bool isCapitalIndex(int i)
        {
            var split = x.Substring(i - 1, 2);
            return Regex.IsMatch(split, "[^a-zA-Z][a-zA-Z]") ||
                Regex.IsMatch(split, "[a-z][A-Z]");
        }
    }
}