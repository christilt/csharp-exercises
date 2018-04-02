using System;
using System.Collections.Generic;
using System.Linq;

public struct Day
{
    public string Ordinal { get; set; }
    public string Gifts { get; set; }
}

public static class TwelveDaysSong
{
    private static Dictionary<int, Day> Days
        = new Dictionary<int, Day>
        {
            {
                1,
                new Day
                {
                    Ordinal = "first",
                    Gifts = "a Partridge in a Pear Tree"
                }
            },
            {
                2,
                new Day
                {
                    Ordinal = "second",
                    Gifts = "two Turtle Doves"
                }
            },
            {
                3,
                new Day
                {
                    Ordinal = "third",
                    Gifts = "three French Hens"
                }
            },
            {
                4,
                new Day
                {
                    Ordinal = "fourth",
                    Gifts = "four Calling Birds"
                }
            },
            {
                5,
                new Day
                {
                    Ordinal = "fifth",
                    Gifts = "five Gold Rings"
                }
            },
            {
                6,
                new Day
                {
                    Ordinal = "sixth",
                    Gifts = "six Geese-a-Laying"
                }
            },
            {
                7,
                new Day
                {
                    Ordinal = "seventh",
                    Gifts = "seven Swans-a-Swimming"
                }
            },
            {
                8,
                new Day
                {
                    Ordinal = "eighth",
                    Gifts = "eight Maids-a-Milking"
                }
            },
            {
                9,
                new Day
                {
                    Ordinal = "ninth",
                    Gifts = "nine Ladies Dancing"
                }
            },
            {
                10,
                new Day {
                    Ordinal = "tenth",
                    Gifts = "ten Lords-a-Leaping"
                }
            },
            {
                11,
                new Day
                {
                    Ordinal = "eleventh",
                    Gifts = "eleven Pipers Piping"
                }
            },
            {
                12,
                new Day
                {
                    Ordinal = "twelfth",
                    Gifts = "twelve Drummers Drumming"
                }
            }
        };

    public static string Sing()
    {
        return Verses(1, 12);
    }

    public static string Verse(int verseNo)
    {
        return String.Concat( Start(Days[verseNo]),
                              GiftsForDays(),
                              And(),
                              End(Days[1])          );

        string Start(Day day)
            => $"On the {day.Ordinal} day of Christmas " +
               $"my true love gave to me, ";
        string GiftsForDays()
            => String.Concat( Enumerable.Range(2, verseNo - 1)
                                        .Reverse()
                                        .Select(n => Days[n])
                                        .Select(Gifts)         );
        string Gifts(Day day)
            => $"{day.Gifts}, ";
        string And()
            => verseNo > 1 ? "and " : "";
        string End(Day day)
            => $"{day.Gifts}.\n";
    }

    public static string Verses(int start, int end)
    {
        return String.Concat( Enumerable.Range(start, end)
                                        .Select(Verse)
                                        .Select(v => $"{v}\n") );
    }
}