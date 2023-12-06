using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System;

public class Day5 : MonoBehaviour
{
    [SerializeField, TextArea(3, 10)]
    string _input;

    private async void Awake()
    {
        Debug.Log("Day 5 part 1: " + ExecutePart1(_input));

        Debug.Log("Day 5 part 2 disabled. It takes a loooooooooooooong time...");
        //ulong part2 = await ExecutePart2(_input);
        //Debug.Log("Day 5 part 2: " + part2);
    }

    public static ulong ExecutePart1(string input)
    {
        ulong[] seedNumbers = GetSeeds(input);

        ulong[] soilNumbers = ProcessData(input, "seed-to-soil map:", seedNumbers);
        ulong[] fertilizerNumbers = ProcessData(input, "soil-to-fertilizer map:", soilNumbers);
        ulong[] waterNumbers = ProcessData(input, "fertilizer-to-water map:", fertilizerNumbers);
        ulong[] lightNumbers = ProcessData(input, "water-to-light map:", waterNumbers);
        ulong[] temperatureNumbers = ProcessData(input, "light-to-temperature map:", lightNumbers);
        ulong[] humidityNumbers = ProcessData(input, "temperature-to-humidity map:", temperatureNumbers);
        ulong[] locationNumbers = ProcessData(input, "humidity-to-location map:", humidityNumbers);

        return locationNumbers.Min();
    }

    public static async Task<ulong> ExecutePart2(string input)
    {
        ulong[] seeds = GetSeeds(input);
        ulong[] seedNumbers = new ulong[seeds.Length / 2];
        ulong[] seedRanges = new ulong[seeds.Length / 2];

        ulong[] seedBuffer = new ulong[1];

        ulong lowest = ulong.MaxValue;

        DateTime nextYield = DateTime.Now.AddMinutes(1);

        for (int i = 0; i < seedNumbers.Length; i++)
        {
            ulong seedNumber = seeds[i * 2];
            ulong seedRange = seeds[i * 2 + 1];

            for (ulong j = 0; j < seedRange; j++)
            {
                seedBuffer[0] = seedNumber + j;

                ulong[] soilNumbers = ProcessData(input, "seed-to-soil map:", seedBuffer);
                ulong[] fertilizerNumbers = ProcessData(input, "soil-to-fertilizer map:", soilNumbers);
                ulong[] waterNumbers = ProcessData(input, "fertilizer-to-water map:", fertilizerNumbers);
                ulong[] lightNumbers = ProcessData(input, "water-to-light map:", waterNumbers);
                ulong[] temperatureNumbers = ProcessData(input, "light-to-temperature map:", lightNumbers);
                ulong[] humidityNumbers = ProcessData(input, "temperature-to-humidity map:", temperatureNumbers);
                ulong[] locationNumbers = ProcessData(input, "humidity-to-location map:", humidityNumbers);

                for (int k = 0; k < locationNumbers.Length; k++)
                {
                    if (locationNumbers[k] < lowest)
                    {
                        lowest = locationNumbers[k];
                        Debug.Log("New lowest: " + lowest);
                    }
                }
                if (DateTime.Now > nextYield)
                {
                    await Task.Yield();
                    nextYield = DateTime.Now.AddMinutes(1);
                }
            }

            Debug.Log($"Seed no {seedNumber} done");
        }

        return lowest;
    }

    static ulong[] GetSeeds(string input)
    {
        string inputLine = input.Split('\n', 2)[0];

        return inputLine.Split(' ').Where(i => i != "seeds:").Select(i => ulong.Parse(i)).ToArray();
    }

    static ulong[] ProcessData(string rawInput, string mapName, ulong[] inputValues)
    {
        string rawInputMap = rawInput.Split("\r\n\r\n").First(m => m.StartsWith(mapName));

        string[] inputLines = rawInputMap.Split("\n").Where(l => !l.StartsWith(mapName)).ToArray();

        ulong[] sourceStarts = new ulong[inputLines.Length];
        ulong[] destinationStarts = new ulong[inputLines.Length];
        ulong[] lengths = new ulong[inputLines.Length];

        for (int i = 0; i < inputLines.Length; i++)
        {
            ulong[] values = inputLines[i].Split(" ").Select(i => ulong.Parse(i)).ToArray();

            ulong destination = values[0];
            ulong source = values[1];
            ulong length = values[2];

            sourceStarts[i] = source;
            destinationStarts[i] = destination;
            lengths[i] = length;
        }

        ulong[] output = inputValues.Select(value =>
        {
            for (int i = 0; i < sourceStarts.Length;i++)
            {
                if (value >= sourceStarts[i] && value < sourceStarts[i] + lengths[i])
                    return destinationStarts[i] + (value - sourceStarts[i]);
            }

            return value;

        }).ToArray();

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(mapName).Append(": ");
        for (int i = 0; i < output.Length; i++)
        {
            stringBuilder.Append(output[i]).Append(" ");
        }

        //Debug.Log(stringBuilder.ToString());

        return output;
    }
}
