using System;
using System.Linq;

public class PhoneNumber
{
    private const string Invalid = "0000000000";
    private string number;

    public PhoneNumber(string input)
    {
        Number = input;
    }

    public string Number
    {
        get => number;
        private set => number = Filter(Clean(value));
    }

    public string AreaCode { get => Number.Substring(0, 3); }

    public string ExchangeCode { get => Number.Substring(3, 3); }

    public string LineNumber { get => Number.Substring(6, 4); }

    public override string ToString()
    {
        return $"({AreaCode}) {ExchangeCode}-{LineNumber}";
    }

    private string Clean(string s)
    {
        return String.Concat(s.Where(Char.IsDigit));
    }

    private string Filter(string s)
    {
        if (s.Length < 10) return Invalid;
        if (s.Length > 11) return Invalid;
        if (s.Length == 10) return s;
        return s.StartsWith("1") ? s.Substring(1) : Invalid;
    }
}