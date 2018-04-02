using System;
using System.Linq;
using System.Collections.Generic;

public static class BookStore
{
    public static double Total(IEnumerable<int> books)
    {
        var groupings = _Total(books);
        return 7;
    }

    private static IEnumerable<object> _Total(IEnumerable<int> books)
    {
        return books
            .GroupBy(i => i)
            .Select(g => new { Metric = g.Key, Count = g.Count() })
            .OrderBy(g => g.Metric);
    }
}