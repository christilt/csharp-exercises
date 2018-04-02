using System;
using System.Collections.Generic;
using System.Linq;

public class DNA
{
    private const string nucleotides = "ACGT";
    private string seq;

    public DNA(string seq)
    {
        this.seq = seq;
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return nucleotides.ToDictionary(x => x, Count);
        }
    }

    public int Count(char n)
    {
        if (!nucleotides.Contains(n))
            throw new InvalidNucleotideException();
        return seq.Where(x => x == n).Count();
    }
}

public class InvalidNucleotideException : Exception { }