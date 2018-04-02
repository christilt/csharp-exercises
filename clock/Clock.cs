using System;

public struct Clock
{
    private int hh;
    private int mm;

    public Clock(int h) : this(h, 0) { }

    public Clock(int h, int m)
    {
        this.hh = (h + hhOf(m)) % 24;
        this.mm = mmOf(m);
    }

    public Clock Add(int mToAdd)
    {
        return new Clock(h: this.hh,
                         m: this.mm + mToAdd);
    }

    public Clock Subtract(int mToSubtract)
    {
        var delta = mInDay(mToSubtract);
        return new Clock(h: this.hh - hhOf(delta),
                         m: 1440 + this.mm - mmOf(delta));
    }

    public override string ToString() => $"{hh:00}:{mm:00}";

    private static int hhOf(int m) => m / 60;

    private static int mmOf(int m) => m % 60;

    private static int mInDay(int m) => m % 1440;
}