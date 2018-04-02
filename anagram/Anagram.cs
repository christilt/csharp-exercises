using System;
using System.Linq;

public class Anagram
{
    public string Word { get; }

    public Anagram(string word)
    {
        Word = word;
    }

    public string[] Anagrams(string[] inputs)
    {
        return inputs
            .Where(IsNotIdentical)
            .Where(IsAnagram)
            .ToArray();
    }

    private bool IsNotIdentical(string input)
    {
        return Word.ToLower() != input.ToLower();
    }

    private bool IsAnagram(string input)
    {
        return LetterCountsMatch(Word, input)
            && LetterCountsMatch(input, Word);

        bool LetterCountsMatch(string a, string b)
        {
            a = a.ToLower();
            b = b.ToLower();
            return a.All(c => a.Count(ac => c == ac)
                           == b.Count(bc => c == bc));
        }
    }
}