using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Day9Tests
{
    [Test]
    public void GetPreviousValueExample1()
    {
        long[] input = new long[] { 0, 3, 6, 9, 12, 15 };

        long expected = -3;
        long actual = Day9.ContinueSequence(input).First();

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void GetPreviousValueExample2()
    {
        long[] input = new long[] { 1, 3, 6, 10, 15, 21 };

        long expected = 0;
        long actual = Day9.ContinueSequence(input).First();

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void GetPreviousValueExample3()
    {
        long[] input = new long[] { 10, 13, 16, 21, 30, 45 };

        long expected = 5;
        long actual = Day9.ContinueSequence(input).First();

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void GetNextValueExample1()
    {
        long[] input = new long[] { 0, 3, 6, 9, 12, 15 };

        long expected = 18;
        long actual = Day9.ContinueSequence(input).Last();

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void GetNextValueExample2()
    {
        long[] input = new long[] { 1, 3, 6, 10, 15, 21 };

        long expected = 28;
        long actual = Day9.ContinueSequence(input).Last();

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void GetNextValueExample3()
    {
        long[] input = new long[] { 10, 13, 16, 21, 30, 45 };

        long expected = 68;
        long actual = Day9.ContinueSequence(input).Last();

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void GetDifferencesExample1()
    {
        long[] input = new long[] { 0, 3, 6, 9, 12, 15 };

        long[] expected = new long[] { 3, 3, 3, 3, 3 };
        long[] actual = Day9.GetDifferences(input);

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void GetDifferencesExample2()
    {
        long[] input = new long[] { 1, 3, 6, 10, 15, 21 };

        long[] expected = new long[] { 2, 3, 4, 5, 6 };
        long[] actual = Day9.GetDifferences(input);

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void GetDifferencesExample3()
    {
        long[] input = new long[] { 10, 13, 16, 21, 30, 45 };

        long[] expected = new long[] { 3, 3, 5, 9, 15 };
        long[] actual = Day9.GetDifferences(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ProvidedExamplePart1()
    {
        string input = "0 3 6 9 12 15\r\n1 3 6 10 15 21\r\n10 13 16 21 30 45";

        long expected = 114;
        long actual = Day9.ExecutePart1(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void NegativePart1()
    {
        string input = "-1 -2 -3";

        long expected = -4;
        long actual = Day9.ExecutePart1(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void NegativePart2()
    {
        string input = "-1 -2 -3";

        long expected = 0;
        long actual = Day9.ExecutePart2(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ProvidedExamplePart2()
    {
        string input = "0 3 6 9 12 15\r\n1 3 6 10 15 21\r\n10 13 16 21 30 45";
    
        long expected = 2;
        long actual = Day9.ExecutePart2(input);
    
        Assert.AreEqual(expected, actual);
    }
}
