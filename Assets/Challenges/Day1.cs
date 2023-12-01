using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class Day1 : MonoBehaviour
{
    [SerializeField, TextArea(3, 10)]
    string _input;

    private void Awake()
    {
        Debug.Log("Day 1: " + Execute(_input));
    }

    public static int Execute(string input)
    {
        int result = 0;

        foreach (var inputLine in input.Split('\n')) 
        {
            result += ParseSingleLine(inputLine);
        }

        return result;
    }

    public static int ParseSingleLine(string input)
    {
        Dictionary<string, int> numbers = new()
        {
            { "0", 0},
            { "1", 1},
            { "2", 2},
            { "3", 3},
            { "4", 4},
            { "5", 5},
            { "6", 6},
            { "7", 7},
            { "8", 8},
            { "9", 9},
            { "zero", 0},
            { "one", 1},
            { "two", 2},
            { "three", 3},
            { "four", 4},
            { "five", 5},
            { "six", 6},
            { "seven", 7},
            { "eight", 8},
            { "nine", 9},
        };

        List<int> foundNumbers = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            foreach (var numberValue in numbers)
            {
                if (i + numberValue.Key.Length > input.Length)
                    continue;

                if (input.Substring(i, numberValue.Key.Length) == numberValue.Key)
                    foundNumbers.Add(numberValue.Value);
            }
        }

        if (foundNumbers.Count == 0)
            return 0;

        return int.Parse("" + foundNumbers[0] + foundNumbers[foundNumbers.Count - 1]);
    }
}
