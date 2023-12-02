using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class Day2 : MonoBehaviour
{
    [SerializeField, TextArea(3, 10)]
    string _input;

    private void Awake()
    {
        Debug.Log("Day 2 part 1: " + ExecutePart1(_input));
        Debug.Log("Day 2 part 2: " + ExecutePart2(_input));
    }

    public static int ExecutePart1(string input)
    {
        int result = 0;

        foreach (var inputLine in input.Split('\n')) 
        {
            result += ParseSingleLinePart1(inputLine);
        }

        return result;
    }

    public static int ExecutePart2(string input)
    {
        int result = 0;

        foreach (var inputLine in input.Split('\n'))
        {
            result += ParseSingleLinePart2(inputLine);
        }

        return result;
    }

    public static int ParseSingleLinePart1(string input)
    {
        string[] splitInput = input.Split(':');

        string idString = splitInput[0];
        string valuesString = splitInput[1].Trim();

        string[] splitValues = valuesString.Split(' ');

        int id = int.Parse(idString.Split(' ')[1]);

        bool valid = IsValid(splitValues);

        return valid ? id : 0;
    }

    public static int ParseSingleLinePart2(string input)
    {
        string[] splitInput = input.Split(':');

        string idString = splitInput[0];
        string valuesString = splitInput[1].Trim();

        string[] splitValues = valuesString.Split(' ');

        int id = int.Parse(idString.Split(' ')[1]);

        var highestValues = GetHighestValues(splitValues);

        return highestValues.highestRed * highestValues.highestGreen * highestValues.highestBlue;
    }

    static bool IsValid(string[] splitValues)
    {
        for (int i = 1; i < splitValues.Length; i += 2)
        {
            if (!splitValues[i].StartsWith("red") && !splitValues[i].StartsWith("blue") && !splitValues[i].StartsWith("green"))
                throw new System.Exception("Didn't find any colors.");

            if (splitValues[i].StartsWith("red") && int.Parse(splitValues[i - 1]) > 12)
                return false;
            if (splitValues[i].StartsWith("green") && int.Parse(splitValues[i - 1]) > 13)
                return false;
            if (splitValues[i].StartsWith("blue") && int.Parse(splitValues[i - 1]) > 14)
                return false;
        }

        return true;
    }

    static (int highestRed, int highestGreen, int highestBlue) GetHighestValues(string[] splitValues)
    {
        int highestRed = 0;
        int highestGreen = 0;
        int highestBlue = 0;

        for (int i = 1; i < splitValues.Length; i += 2)
        {
            if (!splitValues[i].StartsWith("red") && !splitValues[i].StartsWith("blue") && !splitValues[i].StartsWith("green"))
                throw new System.Exception("Didn't find any colors.");

            int numericValue = int.Parse(splitValues[i - 1]);
            if (splitValues[i].StartsWith("red") && numericValue > highestRed)
                highestRed = numericValue;
            if (splitValues[i].StartsWith("green") && numericValue > highestGreen)
                highestGreen = numericValue;
            if (splitValues[i].StartsWith("blue") && numericValue > highestBlue)
                highestBlue = numericValue;
        }

        return (highestRed, highestGreen, highestBlue);
    }
}
