using System;

public class Robot
{
    private static Random r = new Random();

    public string Name { get; private set; }

    public Robot() => Reset();

    public void Reset()
    {
        char randLetter() => "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[r.Next(26)];

        Name  = $"{randLetter()}{randLetter()}{r.Next(1000):000}";
    }
}