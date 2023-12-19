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
    string _input = "O....#....\r\nO.OO#....#\r\n.....##...\r\nOO.#O....O\r\n.O.....O#.\r\nO.#..O.#.#\r\n..O..#O..O\r\n.......O..\r\n#....###..\r\n#OO..#....";

    const char ROLLING_STONE_SYMBOL = 'O';
    const char STATIC_STONE_SYMBOL = '#';
    const char NO_STONE_SYMBOL = '.';

    private async void Awake()
    {
        Debug.Log("Day 13 part 1: " + await Execute(_input, false, 1));
        Debug.Log("Day 13 part 2: " + await Execute(_input, true, 1_000_000_000));
    }

    public static async Task<long> Execute(string input, bool allDirections, int cycleCount)
    {
        StringBuilder[] lines = Common.SplitLines(input).Select(s => new StringBuilder(s)).ToArray();

        for (int cycles = 0; cycles < cycleCount; cycles++)
        {
            if (allDirections)
                CycleOnce(ref lines);
            else
                RollNorth(ref lines);

            if (cycles % 100 == 0)
            {
                Debug.Log($"{cycles} cycles completed");
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
