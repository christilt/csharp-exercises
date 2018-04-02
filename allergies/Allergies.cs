using System;
using System.Collections.Generic;
using System.Linq;

public class Allergies
{
    private static Dictionary<string, int> bits =
        new Dictionary<string, int>
        {
            { "eggs", 0 }, { "peanuts", 1 }, { "shellfish", 2 },
            { "strawberries", 3 }, { "tomatoes", 4 },
            { "chocolate", 5 }, { "pollen", 6 }, { "cats", 7 }
        };

    private int mask;

    public Allergies(int mask) { this.mask = mask; }

    public bool AllergicTo(string a) => bitIsOne(mask, bits[a]);

    public IList<string> List()=> bits.Keys.Where(AllergicTo).ToList();

    private static bool bitIsOne(int i, int b) => ((i >> b) & 1) == 1;
}