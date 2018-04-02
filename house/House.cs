using System;
using System.Collections.Generic;
using System.Linq;

public static class House
{
    private static List<Line> lines = new List<Line>
    {
        new Line("house that Jack built.", "lay in"),
        new Line("malt", "ate"),
        new Line("rat", "killed"),
        new Line("cat", "worried"),
        new Line("dog", "tossed"),
        new Line("cow with the crumpled horn", "milked"),
        new Line("maiden all forlorn", "kissed"),
        new Line("man all tattered and torn", "married"),
        new Line("priest all shaven and shorn", "woke"),
        new Line("rooster that crowed in the morn", "kept"),
        new Line("farmer sowing his corn", "belonged to"),
        new Line("horse and the hound and the horn", null)
    };

    public static string Rhyme()
    {
        var rhyme = Enumerable.Range(0, lines.Count)
            .Select(i => i < lines.Count - 1 ? $"{Verse(i)}\n\n" : Verse(i));
        return String.Concat(rhyme);
    }

    private static string Verse(int n)
    {
        var verse = Enumerable.Range(0, n + 1)
            .Select(LineString)
            .Reverse();
        return String.Concat(verse);

        string LineString(int i)
        {
            var res = i == n ? lines[i].NounStr() : lines[i].VerbStr();
            return i > 0 ? $"{res}\n" : res;
        }
    }
}

struct Line
{
    public string Noun;
    public string Verb;
    public Line(string noun, string verb) { Noun = noun; Verb = verb; }
    public string NounStr() => $"This is the {Noun}";
    public string VerbStr() => $"that {Verb} the {Noun}";
}