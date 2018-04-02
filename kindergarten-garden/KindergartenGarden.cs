using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets = 'V', Radishes = 'R', Clover = 'C', Grass = 'G'
}

public class Garden
{
    private List<string> Children;
    private string[] WindowSills;

    public Garden(IEnumerable<string> children, string windowSills)
    {
        Children = children.OrderBy(x => x).ToList();
        WindowSills = windowSills.Split('\n');
    }

    public IEnumerable<Plant> GetPlants(string child)
    {
        if (!Children.Contains(child)) return new List<Plant>();
        var index = Children.IndexOf(child) * 2;
        return new List<Plant>()
        {
            (Plant) WindowSills[0][index],
            (Plant) WindowSills[0][index+1],
            (Plant) WindowSills[1][index],
            (Plant) WindowSills[1][index+1],
        };
    }

    public static Garden DefaultGarden(string windowSills)
    {
        var children = new List<string>
        {
          "Alice", "Bob", "Charlie", "David", "Eve", "Fred",
          "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"
        };
        return new Garden(children, windowSills);
    }
}