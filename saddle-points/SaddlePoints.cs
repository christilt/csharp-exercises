using System;
using System.Collections.Generic;
using System.Linq;

public class SaddlePoints
{
    public int[,] Values { get; set; }

    public SaddlePoints(int[,] values)
    {
        Values = values;
    }

    public IEnumerable<Tuple<int, int>> Calculate()
    {
        return Enumerable.Range(0, Values.GetLength(0))
            .SelectMany(TuplesForRow);
    }

    private IEnumerable<Tuple<int, int>> TuplesForRow(int y)
    {
        return Enumerable.Range(0, Values.GetLength(1))
            .Where(x => ValidRow(y, x) && ValidCol(y, x))
            .Select(x => Tuple.Create(y, x));
    }

    private bool ValidRow(int y1, int x1)
    {
        return Values[y1, x1] == Enumerable.Range(0, Values.GetLength(1))
            .Select(x2 => Values[y1, x2])
            .Max();
    }

    private bool ValidCol(int y1, int x1)
    {
        return Values[y1, x1] == Enumerable.Range(0, Values.GetLength(0))
            .Select(y2 => Values[y2, x1])
            .Min();
    }
}