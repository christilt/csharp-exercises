using System;
using System.Linq;

public static class BinarySearch
{
    public static int Search(int[] input, int target)
    {
        var idxValPairs = Enumerable.Range(0, input.Length)
            .Zip(input, Tuple.Create)
            .OrderBy(iv => iv.Item2)
            .ToArray();
        while (idxValPairs.Length != 0)
        {
            var mid = idxValPairs.Length / 2;
            var midIdxVal = idxValPairs[mid];
            if (midIdxVal.Item2 == target) return midIdxVal.Item1;
            idxValPairs = target > midIdxVal.Item2
                  ? idxValPairs.Skip(mid+1).ToArray()
                  : idxValPairs.Take(mid).ToArray();
        }
        return -1;
    }
}