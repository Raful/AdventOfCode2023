using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Numerics;

public class Day3 : MonoBehaviour
{
    [SerializeField, TextArea(3, 10)]
    string _input;

    struct FoundNumber
    {
        public int value;
        public bool[,] searchBitmap;
    }

    private void Awake()
    {
        Debug.Log(_input.Split('\n')[^1]);
        Debug.Log("Day 3 part 1: " + ExecutePart1(_input));
        Debug.Log("Day 3 part 2: " + ExecutePart2(_input));
    }

    public static int ExecutePart1(string input)
    {
        string[] inputLines = input.Split('\n');

        bool[,] symbolBitmap = new bool[inputLines[0].Length, inputLines.Length];
        List<FoundNumber> foundNumbers = new List<FoundNumber>();
        List<Vector2Int> _ = new();

        for (int y = 0; y < inputLines.Length; y++)
        {
            ParseSingleLine(inputLines[y], y, symbolBitmap.GetLength(0), symbolBitmap.GetLength(1), ref symbolBitmap, ref foundNumbers, ref _);
        }

        int sum = 0;

        foreach (FoundNumber number in foundNumbers)
        {
            if (NumberHasNeighbor(symbolBitmap, number))
            {
                sum += number.value;
            }
        }

        return sum;
    }

    static bool NumberHasNeighbor(bool[,] symbolBitmap, FoundNumber number)
    {

        for (int y = 0; y < symbolBitmap.GetLength(1); y++)
        {
            for (int x = 0; x < symbolBitmap.GetLength(0); x++)
            {
                if (symbolBitmap[x, y] && number.searchBitmap[x, y])
                    return true;
            }
        }

        return false;
    }

    static void ParseSingleLine(string inputLine, int y, int width, int height, ref bool[,] symbolBitmap, ref List<FoundNumber> foundNumbers, ref List<Vector2Int> stars)
    {
        char[] numbers = new[]
        {
            '0',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
        };

        string currentNumberString = "";
        for (int x = 0; x < inputLine.Length; x++)
        {
            char c = inputLine[x];
            if (numbers.Contains(c))
            {
                //Add to numbers
                currentNumberString += c;
            }
            else
            {
                if (currentNumberString != "")
                {
                    //Parse number and store.
                    foundNumbers.Add(new FoundNumber()
                    {
                        value = int.Parse(currentNumberString),
                        searchBitmap = GetSearchBitmap(width, height, y, (x - 1) - (currentNumberString.Length - 1), (x - 1))
                    });

                    currentNumberString = "";
                }

                if (c == '*')
                {
                    stars.Add(new Vector2Int(x, y));
                }

                if (c != '.')
                {
                    //Add to symbols
                    symbolBitmap[x, y] = true;
                }
            }

            if (currentNumberString != "" && x == inputLine.Length - 1)
            {
                if (currentNumberString != "")
                {
                    //Parse number and store.
                    foundNumbers.Add(new FoundNumber()
                    {
                        value = int.Parse(currentNumberString),
                        searchBitmap = GetSearchBitmap(width, height, y, (x) - (currentNumberString.Length - 1), (x))
                    });

                    currentNumberString = "";
                }
            }
        }
    }

    static bool[,] GetSearchBitmap(int bitmapWidth, int bitmapHeight, int numberY, int numberStartX, int numberEndX)
    {
        bool[,] retValue = new bool[bitmapWidth, bitmapHeight];

        //Row above
        if (numberY > 0)
        {
            int startX = Mathf.Max(numberStartX - 1, 0);
            int endX = Mathf.Min(numberEndX + 1, bitmapWidth - 1);
            for (int i = startX; i <= endX; i++)
            {
                retValue[i, numberY - 1] = true;
            }
        }

        //Current row
        if (numberStartX > 0)
            retValue[numberStartX - 1, numberY] = true;

        if (numberEndX < bitmapWidth - 1)
            retValue[numberEndX + 1, numberY] = true;

        //Row below
        if (numberY < bitmapHeight - 1)
        {
            int startX = Mathf.Max(numberStartX - 1, 0);
            int endX = Mathf.Min(numberEndX + 1, bitmapWidth - 1);
            for (int i = startX; i <= endX; i++)
            {
                retValue[i, numberY + 1] = true;
            }
        }

        return retValue;
    }

    public static int ExecutePart2(string input)
    {
        string[] inputLines = input.Split('\n');

        bool[,] symbolBitmap = new bool[inputLines[0].Length, inputLines.Length];
        List<FoundNumber> foundNumbers = new List<FoundNumber>();
        List<Vector2Int> stars = new List<Vector2Int>();

        for (int y = 0; y < inputLines.Length; y++)
        {
            ParseSingleLine(inputLines[y], y, symbolBitmap.GetLength(0), symbolBitmap.GetLength(1), ref symbolBitmap, ref foundNumbers, ref stars);
        }

        int value = 0;
        foreach (Vector2Int starCoordinate in stars)
        {
            var neighboringNumbers = foundNumbers.Where(n => n.searchBitmap[starCoordinate.x, starCoordinate.y] == true).ToArray();

            if (neighboringNumbers.Length == 2)
            {
                value += (neighboringNumbers[0].value * neighboringNumbers[1].value);
            }
        }

        return value;
    }
}
