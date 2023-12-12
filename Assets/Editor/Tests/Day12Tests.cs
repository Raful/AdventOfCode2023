using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Day12Tests
{
    [Test]
    public void IsValidSequence1()
    {
        string inputSequence = "#.#.###";
        int[] inputVerification = new int[] { 1, 1, 3 };

        Assert.IsTrue(Day12.IsValidSequence(inputSequence, inputVerification));
    }
    [Test]
    public void IsValidSequence2()
    {
        string inputSequence = ".#...#....###.";
        int[] inputVerification = new int[] { 1, 1, 3 };

        Assert.IsTrue(Day12.IsValidSequence(inputSequence, inputVerification));
    }
    [Test]
    public void IsValidSequence3()
    {
        string inputSequence = ".#.###.#.######";
        int[] inputVerification = new int[] { 1, 3, 1, 6 };

        Assert.IsTrue(Day12.IsValidSequence(inputSequence, inputVerification));
    }
    [Test]
    public void IsValidSequence4()
    {
        string inputSequence = "####.#...#...";
        int[] inputVerification = new int[] { 4, 1, 1 };

        Assert.IsTrue(Day12.IsValidSequence(inputSequence, inputVerification));
    }
    [Test]
    public void IsValidSequence5()
    {
        string inputSequence = "#....######..#####.";
        int[] inputVerification = new int[] { 1, 6, 5 };

        Assert.IsTrue(Day12.IsValidSequence(inputSequence, inputVerification));
    }
    [Test]
    public void IsValidSequence6()
    {
        string inputSequence = ".###.##....#";
        int[] inputVerification = new int[] { 3, 2, 1 };

        Assert.IsTrue(Day12.IsValidSequence(inputSequence, inputVerification));
    }
    [Test]
    public void IsNotValidSequence1()
    {
        string inputSequence = "#.#.###";
        int[] inputVerification = new int[] { 1, 2, 3 };

        Assert.IsFalse(Day12.IsValidSequence(inputSequence, inputVerification));
    }
    [Test]
    public void IsNotValidSequence2()
    {
        string inputSequence = "#.#.#.#";
        int[] inputVerification = new int[] { 1, 2, 1 };

        Assert.IsFalse(Day12.IsValidSequence(inputSequence, inputVerification));
    }

    [Test]
    public void ExampleLine1()
    {
        string input = "#.#.### 1,1,3";

        long expected = 1;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void ExampleLine2()
    {
        string input = ".#...#....###. 1,1,3";

        long expected = 1;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void ExampleLine3()
    {
        string input = "?#?#?#?#?#?#?#? 1,3,1,6";

        long expected = 1;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void ExampleLine4()
    {
        string input = "????.#...#... 4,1,1";

        long expected = 1;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void ExampleLine5()
    {
        string input = "????.######..#####. 1,6,5";

        long expected = 4;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void ExampleLine6()
    {
        string input = "?###???????? 3,2,1";

        long expected = 10;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void RealLine10_1_3()
    {
        string input = "#?#?#?#?#???????# 10,1,3";

        long expected = 2;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void RealLineReduced()
    {
        string input = "????????? 9";

        long expected = 1;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void RealLineReduced2()
    {
        string input = "??????? 7";

        long expected = 1;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ProvidedExample()
    {
        string input = "???.### 1,1,3\r\n.??..??...?##. 1,1,3\r\n?#?#?#?#?#?#?#? 1,3,1,6\r\n????.#...#... 4,1,1\r\n????.######..#####. 1,6,5\r\n?###???????? 3,2,1";

        long expected = 21;
        long actual = Day12.ExecutePart1(input).Result;

        Assert.AreEqual(expected, actual);
    }
}
