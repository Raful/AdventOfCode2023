using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Day14Tests
{
    [Test]
    public void RollNorthExample()
    {
        StringBuilder[] expected = Common.SplitLines(
            "OOOO.#.O..\r\n" +
            "OO..#....#\r\n" +
            "OO..O##..O\r\n" +
            "O..#.OO...\r\n" +
            "........#.\r\n" +
            "..#....#.#\r\n" +
            "..O..#.O.O\r\n" +
            "..O.......\r\n" +
            "#....###..\r\n" +
            "#....#....").Select(i => new StringBuilder(i)).ToArray();

        string[] input = Common.SplitLines(
            "O....#....\r\n" +
            "O.OO#....#\r\n" +
            ".....##...\r\n" +
            "OO.#O....O\r\n" +
            ".O.....O#.\r\n" +
            "O.#..O.#.#\r\n" +
            "..O..#O..O\r\n" +
            ".......O..\r\n" +
            "#....###..\r\n" +
            "#OO..#....");

        StringBuilder[] actual = input.Select(i => new StringBuilder(i)).ToArray();
        Day14.RollNorth(ref actual);

        Assert.AreEqual(expected.Length, actual.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i].ToString(), actual[i].ToString());
        }
    }
    [Test]
    public void RollWestExample()
    {
        StringBuilder[] expected = Common.SplitLines(
            "O....#....\r\n" +
            "OOO.#....#\r\n" +
            ".....##...\r\n" +
            "OO.#OO....\r\n" +
            "OO......#.\r\n" +
            "O.#O...#.#\r\n" +
            "O....#OO..\r\n" +
            "O.........\r\n" +
            "#....###..\r\n" +
            "#OO..#....").Select(i => new StringBuilder(i)).ToArray();

        string[] input = Common.SplitLines(
            "O....#....\r\n" +
            "O.OO#....#\r\n" +
            ".....##...\r\n" +
            "OO.#O....O\r\n" +
            ".O.....O#.\r\n" +
            "O.#..O.#.#\r\n" +
            "..O..#O..O\r\n" +
            ".......O..\r\n" +
            "#....###..\r\n" +
            "#OO..#....");

        StringBuilder[] actual = input.Select(i => new StringBuilder(i)).ToArray();
        Day14.RollWest(ref actual);

        Assert.AreEqual(expected.Length, actual.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i].ToString(), actual[i].ToString());
        }
    }
    [Test]
    public void RollSouthExample()
    {
        StringBuilder[] expected = Common.SplitLines(
            ".....#....\r\n" +
            "....#....#\r\n" +
            "...O.##...\r\n" +
            "...#......\r\n" +
            "O.O....O#O\r\n" +
            "O.#..O.#.#\r\n" +
            "O....#....\r\n" +
            "OO....OO..\r\n" +
            "#OO..###..\r\n" +
            "#OO.O#...O").Select(i => new StringBuilder(i)).ToArray();

        string[] input = Common.SplitLines(
            "O....#....\r\n" +
            "O.OO#....#\r\n" +
            ".....##...\r\n" +
            "OO.#O....O\r\n" +
            ".O.....O#.\r\n" +
            "O.#..O.#.#\r\n" +
            "..O..#O..O\r\n" +
            ".......O..\r\n" +
            "#....###..\r\n" +
            "#OO..#....");

        StringBuilder[] actual = input.Select(i => new StringBuilder(i)).ToArray();
        Day14.RollSouth(ref actual);

        Assert.AreEqual(expected.Length, actual.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i].ToString(), actual[i].ToString());
        }
    }
    [Test]
    public void RollEastExample()
    {
        StringBuilder[] expected = Common.SplitLines(
            "....O#....\r\n" +
            ".OOO#....#\r\n" +
            ".....##...\r\n" +
            ".OO#....OO\r\n" +
            "......OO#.\r\n" +
            ".O#...O#.#\r\n" +
            "....O#..OO\r\n" +
            ".........O\r\n" +
            "#....###..\r\n" +
            "#..OO#....").Select(i => new StringBuilder(i)).ToArray();

        string[] input = Common.SplitLines(
            "O....#....\r\n" +
            "O.OO#....#\r\n" +
            ".....##...\r\n" +
            "OO.#O....O\r\n" +
            ".O.....O#.\r\n" +
            "O.#..O.#.#\r\n" +
            "..O..#O..O\r\n" +
            ".......O..\r\n" +
            "#....###..\r\n" +
            "#OO..#....");

        StringBuilder[] actual = input.Select(i => new StringBuilder(i)).ToArray();
        Day14.RollEast(ref actual);

        Assert.AreEqual(expected.Length, actual.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i].ToString(), actual[i].ToString());
        }
    }
    [Test]
    public void OneCycleExample()
    {
        StringBuilder[] expected = Common.SplitLines(
            ".....#....\r\n" +
            "....#...O#\r\n" +
            "...OO##...\r\n" +
            ".OO#......\r\n" +
            ".....OOO#.\r\n" +
            ".O#...O#.#\r\n" +
            "....O#....\r\n" +
            "......OOOO\r\n" +
            "#...O###..\r\n" +
            "#..OO#....").Select(i => new StringBuilder(i)).ToArray();

        string[] input = Common.SplitLines(
            "O....#....\r\n" +
            "O.OO#....#\r\n" +
            ".....##...\r\n" +
            "OO.#O....O\r\n" +
            ".O.....O#.\r\n" +
            "O.#..O.#.#\r\n" +
            "..O..#O..O\r\n" +
            ".......O..\r\n" +
            "#....###..\r\n" +
            "#OO..#....");

        StringBuilder[] actual = input.Select(i => new StringBuilder(i)).ToArray();
        Day14.CycleOnce(ref actual);

        Assert.AreEqual(expected.Length, actual.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i].ToString(), actual[i].ToString());
        }
    }
    [Test]
    public void TwoCyclesExample()
    {
        StringBuilder[] expected = Common.SplitLines(
            ".....#....\r\n" +
            "....#...O#\r\n" +
            ".....##...\r\n" +
            "..O#......\r\n" +
            ".....OOO#.\r\n" +
            ".O#...O#.#\r\n" +
            "....O#...O\r\n" +
            ".......OOO\r\n" +
            "#..OO###..\r\n" +
            "#.OOO#...O").Select(i => new StringBuilder(i)).ToArray();

        string[] input = Common.SplitLines(
            "O....#....\r\n" +
            "O.OO#....#\r\n" +
            ".....##...\r\n" +
            "OO.#O....O\r\n" +
            ".O.....O#.\r\n" +
            "O.#..O.#.#\r\n" +
            "..O..#O..O\r\n" +
            ".......O..\r\n" +
            "#....###..\r\n" +
            "#OO..#....");

        StringBuilder[] actual = input.Select(i => new StringBuilder(i)).ToArray();
        Day14.CycleOnce(ref actual);
        Day14.CycleOnce(ref actual);

        Assert.AreEqual(expected.Length, actual.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i].ToString(), actual[i].ToString());
        }
    }
    [Test]
    public void ThreeCyclesExample()
    {
        StringBuilder[] expected = Common.SplitLines(
            ".....#....\r\n" +
            "....#...O#\r\n" +
            ".....##...\r\n" +
            "..O#......\r\n" +
            ".....OOO#.\r\n" +
            ".O#...O#.#\r\n" +
            "....O#...O\r\n" +
            ".......OOO\r\n" +
            "#...O###.O\r\n" +
            "#.OOO#...O").Select(i => new StringBuilder(i)).ToArray();

        string[] input = Common.SplitLines(
            "O....#....\r\n" +
            "O.OO#....#\r\n" +
            ".....##...\r\n" +
            "OO.#O....O\r\n" +
            ".O.....O#.\r\n" +
            "O.#..O.#.#\r\n" +
            "..O..#O..O\r\n" +
            ".......O..\r\n" +
            "#....###..\r\n" +
            "#OO..#....");

        StringBuilder[] actual = input.Select(i => new StringBuilder(i)).ToArray();
        Day14.CycleOnce(ref actual);
        Day14.CycleOnce(ref actual);
        Day14.CycleOnce(ref actual);

        Assert.AreEqual(expected.Length, actual.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i].ToString(), actual[i].ToString());
        }
    }
    [UnityTest]
    public IEnumerator ExecuteThreeCycles()
    {
        long expected = 69;

        string input = ".....#....\r\n....#...O#\r\n.....##...\r\n..O#......\r\n.....OOO#.\r\n.O#...O#.#\r\n....O#...O\r\n.......OOO\r\n#...O###.O\r\n#.OOO#...O";

        Task<long> executeTask = Day14.Execute(input, allDirections: true, 3); 

        while (!executeTask.IsCompleted)
        {
            yield return null;
        }

        Assert.AreEqual(expected, executeTask.Result);
    }
}
