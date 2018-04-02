using System;
using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int key)
    {
        return String.Concat( text.Select(c => Shift(c, key)) );
    }

    private static char Shift(char c, int key)
    {
        return Char.IsLetter(c) ? ShiftLetter(c, key) : c;
    }

    private static char ShiftLetter(char c, int key)
    {
        return (char)(AsciiOffset() + AlphaPosition());

        int AsciiOffset() => Char.IsLower(c) ? 'a' : 'A';
        int AlphaPosition() => ( (c + key) - AsciiOffset() ) % 26;
    }
}