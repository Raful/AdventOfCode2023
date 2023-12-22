using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using static Day10;
using UnityEngine.Windows;
using System.Linq;
using System.Text;

public class Day14 : MonoBehaviour
{
    string _input = "....#.#....O...OO..#..#....OO...#.#..OO#.#O.#.O.#.....O....O......O..........O.....O....#..#O..#O...\r\nO#....O..#O........O.#...OO....#O...O#.#.....O.....O.O....##...O.O..O.#.O......#....O.O.....###....#\r\n....#.#O..........O...............O.O..#....#..O#.#.........#..#......#..O..O.OO..O.O#O.OO..O..OO..#\r\n...#OO....O.......O#.OO#.O#..O#.O..O#OO..#OO.O.#..OO......O...##.....#..O##O.#O.......OO.#......#...\r\n.#..#.O..#....#O....#O..OO...#O.#..O..#.....O#....OO......OOO#.#.....#..O.##.OO....#...O.#.O#....#O.\r\n..#.#OO#..#.O..O.#..#O.......O...###......#.#.O..#.O.#...O.....O.O#...OO...#..O..#...O....#....#.O#.\r\n......OO....OO...#O.......O##..#........#O....O.........#.###..O...O.O........OO#.....O#.#.##......O\r\n..#....#.#...O...#..##...#O....##..#..#....O..O...O.#.....O.#.......O.OO....#OOOO.#.....O#.#..OOO...\r\n.O..##.#O...#...O......OOO.......#O.O..#.#....#.....OO.O...OO#.O.O....#.#.............O##....##O##..\r\nO#..O........#..#...#.....#..#O.#O....###...#....#..#OOO.....O.O###.O..#O...O...##..O....O..O....O.#\r\n...O....#..O.....O..O...O....#.O...#.#....OO..O.##....#.OO..O...##....#..#OOO.#O#...O#O#.....#..OO..\r\n.....#.##.#..OO..#..#O#O#OO.O......O....#.O..##O....#..#..#...O#O.#.O..O....O.......##.O#...O..#...#\r\n.....OO.....#.....OO........#.OOO.O.#OO......#.#....#....#.##..O..###.....#....O.O.......OO.OO.#.#..\r\n#.............OO......OO.OO#.#...#.##.......#.#..O#..#.O.#.....#.O..O...O.O........#O..O..O..O....#.\r\nO..O.O..OO#O...OO...O...#.O....#...O...O#...#.........O...#.#OO..OO..O.O........#OO.##.O#..O......OO\r\n..##.##.O.##O.O...O.OO#...........#O...O..O..#O...........#.#.###.#.#.O.O....##..#.O.OO...#.....O#..\r\n....O......OO.O..#.......O..O.#.#O....O..O.#....O..##.O#...#..O#.#.##..O...#O...#.O.....#.O...O#....\r\n.#.O.O.#....##...#..##..#.#.O.#..O.....#..##..#..O.......#....O......O.O.........OO.#...#.#O...O.O.O\r\n....O#..#....OO#..OO.OO.O..#OO#.O.......#OO.#O..O.#..#..#OO...O.....#...O........#..#..O...O..O.O#..\r\n#.O..........OO#O...........OO....##.#.O.....OOO.#.......#.......O...#..OO....#....#.......O.O....#.\r\n..O#......O.OO......O##......O#O....#OO...#.OO....OO#.O#.O.#O..O.....O......O.....#.#O...#OO#..O.#O.\r\n.#...#OOO...O....O...OO..#OO.#.O.OO.O.O.O.O...#..O.....O.#O#.O.O.....O##...#....O##.#.O....#..O...OO\r\n...........#..........O#...#.....O#..O.....#O.O.....O.O..O.#.OO.O...O#......O....O#......OO..O.O..#.\r\n#..#.OO..#.O.##O.O..#....#O#O#..#...#OO..O....O...O..##....OOO.....O#..O..##O..O.O##.OO..#.........O\r\nO.O.##......#...#O.##.#.OO..O....O.O.O#..O..####........O......O....O.......O#.....O.O.#.O#.O.#OO#..\r\n.....OO.#..OO..O..O.#.#....#..OO..OO.....O#......O.#.#........#...........#....#......O....O..OO.#.O\r\nO##..O.#...OO#..#..##O...O##.#O##.O.........O...OO#..O.#.....#O.#.O.....#...##..#O.#...OO.#O.#.#.#..\r\n...#..O..O....OOOOO..#..#OO..O.#...#....#...O........#.#........O.....O..O....OOO.....#.O..##..O.##O\r\n.O.#O.....#O.O#...#..#.OOO.O#.O....#.O...........#.....#...#...O....O.#...O..#...O#.......O..O......\r\n..........O##...O....##.....O..#.......##.....#..##.#O....#..O..##O...OO...O.....#.O..#..###O.##..O#\r\n..###O.O.#.#O....O#.##..O.#..##.##O.O.#..O#.#.O#.O.##...O.......#...O.#.......#..##.O...#..O....O.O.\r\n...O..O#.##O.....O.O.#O..O#.O##.O.#....O#.#O.O..#......#..###.O#O.##.........O...O...O#....O........\r\n.O....O.#....#.OO#..#O...#.......#......OOO.#OO.O#.#.O......#O#OO..#O.O..#..#.O.............O#.OO#.#\r\n#O.O.....#.O.O#...OO.......O...O..O.#..........O......O.O..#O.#.......O..#O#...O...OO.#..#.#...#...O\r\n.....#....#.....#O..O...O...#.....#OO....#..#O.O.#OO..#.O.O#...#.O.O..#..#..#OO#..#..#..O...#..O#..O\r\n....O..OOO.##...#.O#......#O.O.O....#O..#.O..#........O#.O...O........#O#O..#..#.O...O.##.O.O.....O#\r\n.O..O#.O..#.....###..#......#OO..........O.#.O#..OOO.###.....#..OO.#O...O...OOOO...O.........O......\r\nO...O.........O......OO...#..O.##..#..#..O.....O..O.........O.O..OO....#..O.#..##OO#.#....#.###.....\r\n.OO.O.#......#.O.......##..O.O.O#..O.OO...O#..#.......#.........OO#.....#..O..O...O.O....#.O..O#....\r\nO...#..O.OO..O.#.O...#.......#.O.O.O.....#.....O..OOO#...O.#O.O#..O...O#...........O#..O........O...\r\nO#O.#O..#.......#..O.#..#....#..O..#..O.#......O.OO.O.....#.O.#....O.#.......O......O#.O...#.#.#.O..\r\n..O#O.OO..#......#.#.#....#..#...#..O.#..#O.O.......O.##...O.O.O.#O...O.O.O##O..#..O...O..OO.#..#.#.\r\n...O.#.....#O...O....O....O....OO..........O.O#O.O.O###...##O.#O...#O.#.OO...#..#..O##...O......#...\r\n.##.##..O..O#...#O...OO.#...O..##....O....#.OO...#O.O..#..O.#.....O.O.#.##O..O..O.O.......O...O...#.\r\nO.OO.O.##.O..##OO.............#.....O....#O..O#...#.##.#.#.........OO..OO..O....OO.#O.O..O..........\r\n#..O.O....OO..O..#...O.....O.#.O#.O.#.#OO#......O.O..O.O...#.OO.#.O#..#O.#..OO.#..#.##.....#OO...OO.\r\n..OO##.#........OOO..O.##....O.O#...OOO......O...O..O.#......#.O...O.#..O.O..O.O..O.O...#O.....OO.#O\r\nO..#..O.#.O...#OO##......O.O.....#O.#O#O.#..#..#.OO..#.O##......O.#O....#.....#...#...O#...O.O....#.\r\nO.........O#O#.#.#......#.O##.O.O#......O.#...OO....#...#..#O#.OO#.###.O.#.#..O..#..#OOO#O#.O...#O.#\r\n.O#.O....O..OO..OO#...#O........O.OO.O#O##.O#O#....#...#O#........#.#O.O#..#..O##..##.........#.O##.\r\n...##...O.#O.##....#.....O....#..OO..O...#.O.O......OO#..O#..#####.#O..#.#....O.#...O...........#O..\r\n.O.#.O..OO.O...#.#....#...O#....#O..#O.#.O.O.O..#..O#.O...O..O.O#O.....O......#O......#O..#.#O.O..OO\r\n......#........O.#O.OO.#...O...##.....#......OO...#O#OO..OOO....#......#..##..#.O...OOOO.#....O...#.\r\nO...#O..OO.....OO.OOOOO#.O....#...#...O..#..#O....##.OO.#OO.OO..#O..#O.O#.OOO.............#OOO....##\r\n.#.O.O..O.....#..#....#...OO...#...OO.#........O.O....##..........#.#O...OO###OOO..#...#..OOO..O..O#\r\nO#...OO..O.#........##......#O....#.........#....O#.#....#..O...O#..O.#......OOO.#....O..OO...O##.OO\r\n....#O#.O..O.O..#O.O#....O.#.O...OO...O..OOO..O.O.O#.#...#.......O.O..#....O...#O.##.....#.#O#.OOO#.\r\n.O###...#...OO.O.....O.....#..OOO.##O....OO.O.............O......O..#.O..#....#..#...#..#O..O...#OO.\r\n...O...#..........#.O..O.........O.O.....#..#....O#O...#.O.#OO.##O...OO..........#O..#....#O....O...\r\n..O..O.#.....O#O..#O##O.#O.O##.#.....O.O.O.#.O.....OO..OOO.O#.OO.#...O..O...#.O.OO#..OO.#..OO####OO.\r\nO.......O#..O.O.#.#...O.OOO...#O....#O.O.O.O...#......O.##...#........#..#..#.#.O##..O.OO.#O..O.....\r\n..O..OO..#....O..OO.#.##....#.......#..#.#..O#..#.#OO#..........#O#O...O.OO...O..#....O...#.......O.\r\n....#.#.#O..O........#.O#.O#..#.......#.#...##OOOOO.OO.O#..#....OO..OOO.O......O.........#..OO.O.#.O\r\nO...O.....#O###..O.OO.O...O...#...#O.....OO...#.....O.O.O..#...O.O..#O..O.O.#...#O.O..#..O....#OO..#\r\n...#..#......#.O#....#O#.O....O..O..O..O....O...#..#O..#.....#...O.....OOO..OO.#O#.......#.O...OOOOO\r\nOOO#.O.O.#O....O..#...O..O#O..O#...#...#..O#..O..O.O#......O...#O..O#.O...#.O.#...O...OO.#....O.....\r\nO..#O...O#..#...O.#.O......#.#..#.O...##.O..#O...O#.#.O.....O...OO.OOO.O.#..#.O....##.#.#O..OO...#OO\r\n...O.O..O.OO.O..O.OOO.O#.#..O.....OO#..OOO.#.#....O.#O.#.O.OO....O..#..O#O###OO#.......##........#..\r\n#...#..O.###.O.#O......OO#......O.O..#O......OO.O.#....#....O...OO##OO#O...O.........O#OOO..........\r\n..O.O..............O.....OOOO#.OO..O#..O.###.O..O.#.O.O.....O.#O.OOO..OO#..OO.#.....#.......O#...O..\r\nO...#.OOO....OO......O..O......O.....O....O..#O..#.O.............O.#..............#....#O....#O#O...\r\n.OO.OOO.........OOO#.OO....#...#....OO...O..O.....#...#O..#O.O.#.O.#O......O.O.O#..O.O.#...#O....O#.\r\nO.....#OO......#.#..OO.O.##O#......#......O..#...#O#..#O..O..#.........O..##.O..##O.#.#.O.#..OOO#..O\r\n...O....#..#....OO.O.##...OO#.O##..........##.#..OO.#..O#.#.O..#...O..#..O..#....O..#....O..#.###O..\r\n.O....O...O#....O#O..O..OO...#O.O.....#...#.......#...##.O..#...#.....O......O..##...##......O.#...O\r\nO#.O#OO.O.#O.#.#O..#.O..O..#O#O.#O...........O#.O...O...O....O......O.OO......O..O##..O....OO#...##O\r\n..O..O.OOO....#O#..O#...#.O....#....#O..O#..##.O.....O.O#O..O.....##...#..#............#....O.O.#.O#\r\n.....O.#..O..#.OO.....O...O..#.......O....#.##.O#O....O.O...#.OO....##O....O....#OO#O.......O#..#O.O\r\n#O.O.#......#.O....O....#..O##......O.#.#....#OO.....O.OOO...#.O.....O#.O.O#..O#..#.....#.OO...OO.O.\r\n..#O........O.O.O.O.....O..#...O.O.#O.OO....O...#.......##...O.......OO.#O.O.O..O.##...O.O#..##..#O.\r\nO#O....O.O.O#.###O...#.....O..#....#.#.O.....O..####.O.O..#..OO.#..O....##..#O.##.....O...O.....OO..\r\n#...OO.#.#.#...O.#O....#O#.............###.O..O.O.O.#...##O..O#...OO#OO.....###.O..#.#...O.....O..O.\r\n.O.OO#..O..OO#.O#.O..##....O#...O...O....OO.....#.#O.....O......O##......#....#..#......O##.#....#O#\r\n.#O#O..#....##.OO.............O..##....O......#.........#.......#O..O##....#.....#..#......#O.OOO...\r\n.O.O#OO..#..........O.#O.OO......##....#..O###O..OO..O..O.##O..#.......#..O..#..#.#......O...#....#.\r\n.#.O....OO.O....#O..OOO.#....O.....OO..O..O...O...#..O....O......O...........#.O.....#...##..O.O#.OO\r\n.O.O..O#O.OO..OO#.OO.#O.....O...#.OOO....O#......O.OO..#.#..O.....#..O.O#O.O#..O##O..O....O....O....\r\n..OO......#..#O...OO..O.#..#O##....O..#.#.O...O..#O....#.O.....OO.O.OO...OO...O#.O.....OOO...#....#.\r\n#OO..#.....#OO...O.......O....#...O...O.#O....O....O....#.......O....#..O.....#....OO.##.OO#O.O#....\r\n#..#O....O#...#.#OO..............#OO#OO#.O....O..OO.O.O#...O...#..#O.#.......O....#O..#..#O.....##O.\r\n...#.....#.#..#OOOO..O.O#O..O..#..O..O.............OO...#.....#O.OO..#..#.....OO.....#O....#..O#....\r\n...O.#.O.#O.O.O##..O..O.O......O#O##...........O..#..#...........O.O.O...O..#.....OO.O.......#O.....\r\n#.O#O.....#O......O#.......OO.O.O..#..#..#O....#......#.O..O..#O#.###.#..#..#...O.OO....#.#O#..O...#\r\n#..O..#.O.O......#...#......#..#......O...O..#....O#.O.O..O...O..#..#O.OOO..O...#.......O..OO.O....#\r\n...O..OO#O..#....#....###O...O#.#OO..O...O....O#.#....#.O......#..#...#..#.O......O..O...#.O....#.O.\r\nOO..#..O##.O..O...O..#O....#....#.O.O....O#....OO.#.OO..O..OO..O#...O....OO..#.OOOO.#..O.O.....#..##\r\n.OO.O....O...O#O.....##....O..#O##....O.....##....O.#..#O#O.OOOO..O..O.O.......OO..O.#....O.....O..O\r\n.O.O..O#..#OO..O.O.....OO..OO..##.#..O...........#.O..#.O.#...O...O..OOO..O.#O.#....O.#.OO..O#......\r\n..O#..O#.O...##..#.#.###....O#..O.O##.O.#.O....OO.#..O.OO.#....O..O#O.#...##...OO#.OO..O.....#.....O\r\n...#OO#.......O.O.##...#O..O#.O#O#..OO..O..O#O..O.#.OO#.....#.....O...O.O.....#O#.OO.O...O.O#..#O..#";

    const char ROLLING_STONE_SYMBOL = 'O';
    const char STATIC_STONE_SYMBOL = '#';
    const char NO_STONE_SYMBOL = '.';

    private async void Awake()
    {
        Debug.Log("Day 14 part 1: " + await Execute(_input, false, 1));
        Debug.Log("Day 14 part 2: " + await Execute(_input, true, 1_000_000_000));
    }

    public static async Task<long> Execute(string input, bool allDirections, int cycleCount)
    {
        StringBuilder[] lines = Common.SplitLines(input).Select(s => new StringBuilder(s)).ToArray();

        Dictionary<long, List<int>> loadIndices = new();

        for (int cycles = 0; cycles < cycleCount; cycles++)
        {
            if (allDirections)
                CycleOnce(ref lines);
            else
                RollNorth(ref lines);

            long load = CalculateLoad(lines);
            if (!loadIndices.ContainsKey(load))
                loadIndices.Add(load, new List<int>());

            loadIndices[load].Add(cycles);

            if (loadIndices[load].Count == 2)
            {
                int periodLength = loadIndices[load][1] - loadIndices[load][0];

                int firstCorrectCycle = (cycleCount - loadIndices[load][0] - 1) % periodLength + loadIndices[load][0];

                Debug.Log($"{cycles} cycles completed.");

                return loadIndices.First(kvp => kvp.Value.Contains(firstCorrectCycle)).Key;
            }

            if (cycles % 100 == 0)
            {
                Debug.Log($"{cycles} cycles completed.");
                //Debug.Log($"Current load: {CalculateLoad(lines)}");
                await Task.Yield();
            }
        }
        Debug.Log($"{cycleCount} cycles completed");

        return CalculateLoad(lines);
    }

    public static long CalculateLoad(StringBuilder[] lines)
    {
        long load = 0;

        for (int i = 0; i < lines.Length; i++)
        {
            for (int x = 0; x < lines[i].Length; x++)
            {
                if (lines[i][x] == ROLLING_STONE_SYMBOL)
                    load += lines.Length - i;
            }
        }

        return load;
    }

    public static void CycleOnce(ref StringBuilder[] lines)
    {
        RollNorth(ref lines);
        RollWest(ref lines);
        RollSouth(ref lines);
        RollEast(ref lines);
    }

    public static void RollNorth(ref StringBuilder[] lines)
    {
        for (int y = 1; y < lines.Length; y++)
        {
            for (int x = 0; x < lines[y].Length; x++)
            {
                if (lines[y][x] == ROLLING_STONE_SYMBOL)
                {
                    int nextFreeLine = y;
                    for (int i = 1; y - i >= 0; i++)
                    {
                        if (lines[y - i][x] == ROLLING_STONE_SYMBOL || lines[y - i][x] == STATIC_STONE_SYMBOL)
                        {
                            nextFreeLine = y - i + 1;
                            break;
                        }
                        else if (y - i == 0)
                        {
                            nextFreeLine = 0;
                        }
                    }

                    if (nextFreeLine != y)
                    {
                        lines[nextFreeLine][x] = ROLLING_STONE_SYMBOL;
                        lines[y][x] = NO_STONE_SYMBOL;
                    }
                }
            }
        }
    }
    public static void RollEast(ref StringBuilder[] lines)
    {
        bool stonesMoved = false;
        do
        {
            stonesMoved = false;
            for (int y = 0; y < lines.Length; y++)
            {
                for (int x = lines[y].Length - 2; x >= 0; x--)
                {
                    if (lines[y][x] == ROLLING_STONE_SYMBOL)
                    {
                        int nextFreeColumn = x;
                        for (int i = 1; x + i < lines[y].Length; i++)
                        {
                            if (lines[y][x + i] == ROLLING_STONE_SYMBOL || lines[y][x + i] == STATIC_STONE_SYMBOL)
                            {
                                nextFreeColumn = x + i - 1;
                                break;
                            }
                            else if (x + i == lines[y].Length - 1)
                            {
                                nextFreeColumn = lines[y].Length - 1;
                            }
                        }

                        if (nextFreeColumn != x)
                        {
                            lines[y][nextFreeColumn] = ROLLING_STONE_SYMBOL;
                            lines[y][x] = NO_STONE_SYMBOL;
                        }
                    }
                }
            }
        } while (stonesMoved);
    }
    public static void RollSouth(ref StringBuilder[] lines)
    {
        bool stonesMoved = false;
        do
        {
            stonesMoved = false;
            for (int y = lines.Length - 2; y >= 0; y--)
            {
                for (int x = 0; x < lines[y].Length; x++)
                {
                    if (lines[y][x] == ROLLING_STONE_SYMBOL && lines[y + 1][x] != ROLLING_STONE_SYMBOL && lines[y + 1][x] != STATIC_STONE_SYMBOL)
                    {
                        lines[y + 1][x] = ROLLING_STONE_SYMBOL;
                        lines[y][x] = NO_STONE_SYMBOL;
                        stonesMoved = true;
                    }
                }
            }
        } while (stonesMoved);
    }
    public static void RollWest(ref StringBuilder[] lines)
    {
        bool stonesMoved = false;
        do
        {
            stonesMoved = false;
            for (int y = 0; y < lines.Length; y++)
            {
                for (int x = 1; x < lines[y].Length; x++)
                {
                    if (lines[y][x] == ROLLING_STONE_SYMBOL && lines[y][x - 1] != ROLLING_STONE_SYMBOL && lines[y][x - 1] != STATIC_STONE_SYMBOL)
                    {
                        lines[y][x - 1] = ROLLING_STONE_SYMBOL;
                        lines[y][x] = NO_STONE_SYMBOL;
                        stonesMoved = true;
                    }
                }
            }
        } while (stonesMoved);
    }
}
