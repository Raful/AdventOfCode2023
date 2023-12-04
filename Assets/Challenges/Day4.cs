using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class Day4 : MonoBehaviour
{
    [SerializeField, TextArea(3, 10)]
    string _input;

    private void Awake()
    {
        Debug.Log("Day 4 part 1: " + ExecutePart1(_input));
        Debug.Log("Day 4 part 2: " + ExecutePart2(_input));
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
        Dictionary<int, int> totalTickets = new Dictionary<int, int>();
        string[] inputLines = input.Split("\n");

        for (int cardNo = 0; cardNo < inputLines.Length; cardNo++)
        {
            totalTickets.Add(cardNo, 1);
        }

        for (int cardNo = 0; cardNo < inputLines.Length; cardNo++)
        {
            int winningNumbers = ParseSingleLinePart2(inputLines[cardNo]);

            for (int i = 1; i <= winningNumbers; i++)
            {
                totalTickets[cardNo + i] += totalTickets[cardNo];
            }
        }

        return totalTickets.Sum(t => t.Value);
    }

    public static int ParseSingleLinePart1(string input)
    {
        string[] inputValues = input.Split(": ");

        string[] splitValues = inputValues[1].Split(" | ");

        int[] playerTickets = splitValues[0].Split(' ').Where(v => !string.IsNullOrEmpty(v)).Select(v => int.Parse(v)).ToArray();
        int[] winningTickets = splitValues[1].Split(' ').Where(v => !string.IsNullOrEmpty(v)).Select(v => int.Parse(v)).ToArray();

        int[] playerWinningTickets = playerTickets.Where(t => winningTickets.Contains(t)).ToArray();

        if (playerWinningTickets.Length == 0) 
        {
            return 0;
        }
        else
        {
            int sum = 1;

            for (int i = 1; i < playerWinningTickets.Length; i++)
            {
                sum *= 2;
            }

            return sum;
        }
    }

    public static int ParseSingleLinePart2(string input)
    {
        string[] inputValues = input.Split(": ");

        string[] splitValues = inputValues[1].Split(" | ");

        int[] playerTickets = splitValues[0].Split(' ').Where(v => !string.IsNullOrEmpty(v)).Select(v => int.Parse(v)).ToArray();
        int[] winningTickets = splitValues[1].Split(' ').Where(v => !string.IsNullOrEmpty(v)).Select(v => int.Parse(v)).ToArray();

        int[] playerWinningTickets = playerTickets.Where(t => winningTickets.Contains(t)).ToArray();

        return playerWinningTickets.Length;
    }
}
