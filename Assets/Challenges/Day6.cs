using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class Day6 : MonoBehaviour
{
    [SerializeField, TextArea(3, 10)]
    string _input;

    [SerializeField]
    long _timePart2;

    [SerializeField]
    long _distancePart2;

    private void Awake()
    {
        Debug.Log("Day 6 part 1: " + Execute(_input));
        Debug.Log("Day 6 part 2: " + ExecutePart2(_timePart2, _distancePart2));
    }

    public static int Execute(string input)
    {
        string[] inputLines = input.Split("\n");

        int[] times = Common.GetNumbersInLine(inputLines[0]);
        int[] distances = Common.GetNumbersInLine(inputLines[1]);

        int winProduct = 1;

        for (int i = 0; i < times.Length; i++)
        {
            int betterCount = 0;

            for (int j = 1; j < times[i]; j++)
            {
                if ((times[i] - j) * j > distances[i])
                    betterCount++;
            }

            winProduct *= betterCount;
        }

        return winProduct;
    }

    public static long ExecutePart2(long time, long distance)
    {
        long middleTime = time / 2 + 1; //My input is odd.

        long currentHoldTime = middleTime;

        while (IsBetter(time, currentHoldTime, distance))
        {
            currentHoldTime /= 2;
        }

        for (; !IsBetter(time, currentHoldTime, distance); currentHoldTime++){ }

        return (middleTime - currentHoldTime) * 2;
    }

    static bool IsBetter(long totalTime, long holdTime, long distance)
    {
        return (totalTime - holdTime) * holdTime > distance;
    }
}
