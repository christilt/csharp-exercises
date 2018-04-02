using System;
using System.Linq;

public static class BeerSong
{
    public static string Verse(int n) => $"{new Vs(n)}";

    public static string Verses(int begin, int end)
    {
        var verses = Enumerable.Range(end, begin - end + 1)
            .Select(i => i > end ? Verse(i) + "\n" : Verse(i))
            .Reverse();
        return String.Concat(verses);
    }
}

public class Vs
{
    protected int n;
    public Vs(int n) { this.n = n; }
    private FstLine fst() => FstLine.of(n);
    private SndLine snd() => SndLine.of(n);
    public override string ToString() => $"{fst()}{snd()}";
}

public abstract class Line { }

public abstract class FstLine : Line
{
    public static FstLine of(int n)
    {
        return n > 1 ? new ManyFst(n) 
             : n == 1 ? new SingFst() 
             : (FstLine) new ZeroFst();
    }
}

public class ManyFst : FstLine
{
    protected int n;
    public ManyFst(int n) { this.n = n; }
    public override string ToString() =>
        $"{n} bottles of beer on the wall, " +
        $"{n} bottles of beer.\n";
}

public class SingFst : FstLine
{
    public override string ToString() =>
        "1 bottle of beer on the wall, " +
        "1 bottle of beer.\n";
}

public class ZeroFst : FstLine
{
    public override string ToString() =>
        "No more bottles of beer on the wall, " +
        "no more bottles of beer.\n";
}

public abstract class SndLine : Line
{
    public static SndLine of(int n)
    {
        return n > 2 ? new ManySnd(n)
             : n == 2 ? new DoblSnd()
             : n == 1 ? new SingSnd()
             : (SndLine) new ZeroSnd();
    }
}

public class ManySnd : SndLine
{
    protected int n;
    public ManySnd(int n) { this.n = n; }
    public override string ToString() =>
        "Take one down and pass it around, " +
        $"{n - 1} bottles of beer on the wall.\n";
}

public class DoblSnd : SndLine
{
    public override string ToString() =>
        "Take one down and pass it around, " +
        "1 bottle of beer on the wall.\n";
}

public class SingSnd : SndLine
{
    public override string ToString() => 
        "Take it down and pass it around, " +
        "no more bottles of beer on the wall.\n";
}

public class ZeroSnd : SndLine
{
    public override string ToString() => 
        "Go to the store and buy some more, " +
        "99 bottles of beer on the wall.\n";
}