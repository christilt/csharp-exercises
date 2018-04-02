using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class PatternReplacement
{
    public string Pattern;
    public string Replacement;
}

public static class Markdown
{
    static PatternReplacement Paragraph
        = new PatternReplacement
        {
            Pattern = @"^(?!#|\*)(.*)$",
            Replacement = @"<p>$1</p>"
        };
    static PatternReplacement Italics
        = new PatternReplacement
        {
            Pattern = @"(?<!_)_(?!_)(.*)(?<!_)_(?!_)",
            Replacement = @"<em>$1</em>"
        };
    static PatternReplacement Bold
        = new PatternReplacement
        {
            Pattern = @"(?<!_)__(?!_)(.*)(?<!_)__(?!_)",
            Replacement = @"<strong>$1</strong>"
        };
    static PatternReplacement H1
        = new PatternReplacement
        {
            Pattern = @"^#(?!#)\s(((?!(\n)).)*)($|\n)",
            Replacement = @"<h1>$1</h1>"
        };
    static PatternReplacement H2
        = new PatternReplacement
        {
            Pattern = @"^##(?!#)\s(.*)$",
            Replacement = @"<h2>$1</h2>"
        };
    static PatternReplacement H6
        = new PatternReplacement
        {
            Pattern = @"^######(?!#)\s(.*)$",
            Replacement = @"<h6>$1</h6>"
        };
    static PatternReplacement Lists
        = new PatternReplacement
        {
            Pattern = @"\*\s(((((?!(\n)).)*)(\n|$)))",
            Replacement = @"<li>$3</li>"
        };
    static PatternReplacement UnorderedLists
        = new PatternReplacement
        {
            Pattern = @"((<li>((?!(<\/li>)).)*<\/li>)+)",
            Replacement = @"<ul>$1</ul>"
        };

    static List<PatternReplacement> MarkdownPatternReplacements
        = new List<PatternReplacement>
        {
            Paragraph, Italics, Bold, H1, H2, H6, Lists
        };

    static List<PatternReplacement> HtmlPatternReplacements
        = new List<PatternReplacement>
        {
            UnorderedLists
        };

    public static string Parse(string s)
    {
        MarkdownPatternReplacements
            .ForEach(pr => 
                s = Regex.Replace(s, pr.Pattern, pr.Replacement));
        HtmlPatternReplacements
            .ForEach(pr =>
                s = Regex.Replace(s, pr.Pattern, pr.Replacement));
        return s;
    }
}