using System;
using System.Collections.Generic;
using System.Linq;
using static Bearing;

public enum Bearing { North, East, South, West }

public struct Coordinate
{
    public Coordinate(int x, int y) { X = x; Y = y; }
    public int X { get; }
    public int Y { get; }
    public static Coordinate operator +(Coordinate a, Coordinate b)
    {
        return new Coordinate(a.X + b.X, a.Y + b.Y);
    } 
}

public class RobotSimulator
{
    private static Dictionary<Bearing, Coordinate> advances
        = new Dictionary<Bearing, Coordinate>
        {
            { North, new Coordinate(0, 1) },
            { East, new Coordinate(1, 0) },
            { South, new Coordinate(0, -1) },
            { West, new Coordinate(-1, 0) }
        };

    public Bearing Bearing { get; private set; }
    public Coordinate Coordinate { get; private set; }

    public RobotSimulator(Bearing bearing, Coordinate coordinate)
    {
        Bearing = bearing;
        Coordinate = coordinate;
    }

    public void TurnRight() => Bearing = (Bearing)(((int)Bearing+1)%4);

    public void TurnLeft() => Bearing = (Bearing)(((int)Bearing+3)%4);

    public void Advance() => Coordinate += advances[Bearing];

    public void Simulate(string instructions)
    {
        instructions.ToList().ForEach(Parse);
        void Parse(char c)
        {
            switch (c)
            {
                case 'R': TurnRight(); break;
                case 'L': TurnLeft(); break;
                case 'A': Advance(); break;
            }
        }
    }
}