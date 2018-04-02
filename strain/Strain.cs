using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach(T t in collection)
        {
            if (predicate(t)) yield return t;
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach(T t in collection)
        {
            if (!predicate(t)) yield return t;
        }
    }
}