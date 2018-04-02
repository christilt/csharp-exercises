using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class WordCount
{
    public static IDictionary<string, int> Countwords(string p)
    {
        var words = Regex.Matches(p, @"\w+\'*\w+|\w+")
                         .Select(m => m.Value.ToLower());

        return words
            .Distinct()
            .ToDictionary(w => w, 
                          w => words.Count(w2 => w == w2));
    }
}