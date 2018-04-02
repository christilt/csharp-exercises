using System;

public static class Bob
{
    public static string Hey(string input)
    {
        var s = input.Trim();
        if (s == "")
        {
            return "Fine. Be that way!";
        }
        else if (s.ToLower() != s.ToUpper() && s == s.ToUpper())
        {
            return "Whoa, chill out!";
        }
        else if (s.EndsWith("?"))
        {
            return "Sure.";
        }
        else
        {
            return "Whatever.";
        }
    }
}