using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        return year.isMultipleOf(4) && year.isNotMultipleOf(100)
            || year.isMultipleOf(400);
    }
}

public static class Extension
{
    public static bool isMultipleOf(this int a, int b)
    {
        return a % b == 0;
    }

    public static bool isNotMultipleOf(this int a, int b)
    {
        return a % b != 0;
    }
}