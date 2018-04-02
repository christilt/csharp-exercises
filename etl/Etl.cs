using System;
using System.Collections.Generic;
using System.Linq;

public static class ETL
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> old)
    {
        return old
            .SelectMany(kv => kv.Value
                       .ToDictionary(v => v, v => kv.Key))
            .ToDictionary(kv => kv.Key.ToLower(), kv => kv.Value);
    }
}