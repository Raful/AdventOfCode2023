using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Day8Tests
{
    [Test]
    public void TestLRDirectionsConstructor()
    {
        var lrDir = new Day8.LRDirection("(ABC, DEF)");

        Assert.AreEqual("ABC", lrDir.Left);
        Assert.AreEqual("DEF", lrDir.Right);
    }
    [Test]
    public void TestLRDirectionsLInput()
    {
        var actual = new Day8.LRDirection("(ABC, DEF)").GetDirection('L');

        Assert.AreEqual("ABC", actual);
    }
    [Test]
    public void TestLRDirectionsRInput()
    {
        var actual = new Day8.LRDirection("(ABC, DEF)").GetDirection('R');

        Assert.AreEqual("DEF", actual);
    }

    [Test]
    public void ProvidedExample1()
    {
        string input = "RL\r\n\r\nAAA = (BBB, CCC)\r\nBBB = (DDD, EEE)\r\nCCC = (ZZZ, GGG)\r\nDDD = (DDD, DDD)\r\nEEE = (EEE, EEE)\r\nGGG = (GGG, GGG)\r\nZZZ = (ZZZ, ZZZ)";

        int expected = 2;
        var actual = Day8.ExecutePart1(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void LCM23()
    {
        int expected = 6;
        var actual = Day8.LowestCommonMultiplier(new int[] {2, 3});

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void LCM24()
    {
        int expected = 4;
        var actual = Day8.LowestCommonMultiplier(new int[] { 2, 4 });

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void LCM234()
    {
        int expected = 12;
        var actual = Day8.LowestCommonMultiplier(new int[] { 2, 3, 4 });

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ProvidedExample2()
    {
        string input = "LLR\r\n\r\nAAA = (BBB, BBB)\r\nBBB = (AAA, ZZZ)\r\nZZZ = (ZZZ, ZZZ)";

        int expected = 6;
        var actual = Day8.ExecutePart1(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void LCM235()
    {
        int expected = 30;
        var actual = Day8.LowestCommonMultiplier(new int[] { 2, 3, 5 });

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ProvidedExamplePart2()
    {
        string input = "LR\r\n\r\n11A = (11B, XXX)\r\n11B = (XXX, 11Z)\r\n11Z = (11B, XXX)\r\n22A = (22B, XXX)\r\n22B = (22C, 22C)\r\n22C = (22Z, 22Z)\r\n22Z = (22B, 22B)\r\nXXX = (XXX, XXX)";

        long expected = 6;
        long actual = Day8.ExecutePart2(input);

        Assert.AreEqual(expected, actual);
    }
}
