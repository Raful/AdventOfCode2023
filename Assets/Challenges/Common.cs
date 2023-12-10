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

    public static Vector2 WithX(this Vector2 v, float x)
    {
        return new Vector2(x, v.y);
    }
    public static Vector2 WithY(this Vector2 v, float y)
    {
        return new Vector2(v.x, y);
    }
    public static Vector3 WithX(this Vector3 v, float x)
    {
        return new Vector3(x, v.y, v.z);
    }
    public static Vector3 WithY(this Vector3 v, float y)
    {
        return new Vector3(v.x, y, v.z);
    }
    public static Vector3 WithZ(this Vector3 v, float z)
    {
        return new Vector3(v.x, v.y, z);
    }

    public static Vector2Int WithX(this Vector2Int v, int x)
    {
        return new Vector2Int(x, v.y);
    }
    public static Vector2Int WithY(this Vector2Int v, int y)
    {
        return new Vector2Int(v.x, y);
    }
    public static Vector3Int WithX(this Vector3Int v, int x)
    {
        return new Vector3Int(x, v.y, v.z);
    }
    public static Vector3Int WithY(this Vector3Int v, int y)
    {
        return new Vector3Int(v.x, y, v.z);
    }
    public static Vector3Int WithZ(this Vector3Int v, int z)
    {
        return new Vector3Int(v.x, v.y, z);
    }
}
