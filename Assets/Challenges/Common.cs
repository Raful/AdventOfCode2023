using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class Common
{
    public static int[] GetNumbersInLine(string inputLine)
    {
        return inputLine.Split(' ').Where(i => int.TryParse(i, out int _)).Select(i => int.Parse(i)).ToArray();
    }
    public static long[] GetNumbersInLineLong(string inputLine)
    {
        return inputLine.Split(' ').Where(i => long.TryParse(i, out long _)).Select(i => long.Parse(i)).ToArray();
    }
    public static ulong[] GetNumbersInLineUlong(string inputLine)
    {
        return inputLine.Split(' ').Where(i => ulong.TryParse(i, out ulong _)).Select(i => ulong.Parse(i)).ToArray();
    }

    public static string[] SplitLines(string input)
    {
        return input.Split("\r\n", System.StringSplitOptions.RemoveEmptyEntries);
    }
}
