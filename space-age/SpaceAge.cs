using System;
using System.Collections.Generic;

public class SpaceAge
{
    private double earthYears;

    static Dictionary<string, double> years =
        new Dictionary<string, double>()
    {
        { "Mercury", 0.2408467 },
        { "Venus", 0.61519726 },
        { "Mars", 1.8808158 },
        { "Jupiter", 11.862615 },
        { "Saturn", 29.447498 },
        { "Uranus", 84.016846 },
        { "Neptune", 164.79132 }
    };

    public SpaceAge(long seconds)
    {
        earthYears = seconds / 31557600.0;
    }

    public double OnEarth()
    {
        return Math.Round(earthYears, 2);
    }

    public double OnMercury()
    {
        return Math.Round(earthYears / years["Mercury"], 2);
    }

    public double OnVenus()
    {
        return Math.Round(earthYears / years["Venus"], 2);
    }

    public double OnMars()
    {
        return Math.Round(earthYears / years["Mars"], 2);
    }

    public double OnJupiter()
    {
        return Math.Round(earthYears / years["Jupiter"], 2);
    }

    public double OnSaturn()
    {
        return Math.Round(earthYears / years["Saturn"], 2);
    }

    public double OnUranus()
    {
        return Math.Round(earthYears / years["Uranus"], 2);
    }

    public double OnNeptune()
    {
        return Math.Round(earthYears / years["Neptune"], 2);
    }
}