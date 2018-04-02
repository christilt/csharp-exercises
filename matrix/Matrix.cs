using System;
using System.Linq;

public class Matrix
{
    public int[][] ByRow { get; }
    public int[][] ByCol { get; }

    public int Rows { get => ByRow.Length; }

    public int Cols { get => ByCol.Length; }

    public Matrix(string input)
    {
        ByRow = RowsFrom(input);
        ByCol = Invert(ByRow);
    }

    int[][] RowsFrom(String s)
    {
        return s.Split('\n')
            .Select(line => ValsFrom(line))
            .ToArray();
    }

    int[] ValsFrom(String s)
    {
        return s.Split(' ')
            .Select(int.Parse)
            .ToArray();
    }

    int[][] Invert(int[][] matrix)
    {
        var noCols = matrix[0].Length;
        return Enumerable.Range(0, noCols)
            .Select(colIdx => ToRow(matrix, colIdx))
            .ToArray();
    }

    int[] ToRow(int[][] matrix, int colIdx)
    {
        var noRows = matrix.Length;
        return Enumerable.Range(0, noRows)
            .Select(rowIdx => matrix[rowIdx][colIdx])
            .ToArray();
    }

    public int[] Row(int i) => ByRow[i];

    public int[] Col(int i) => ByCol[i];
}