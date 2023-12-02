using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Day2Tests
{
    [Test]
    public void Game1()
    {
        string input = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";

        Assert.AreEqual(1, Day2.ParseSingleLinePart1(input));
    }
    [Test]
    public void Game2()
    {
        string input = "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue";

        Assert.AreEqual(2, Day2.ParseSingleLinePart1(input));
    }
    [Test]
    public void Game3()
    {
        string input = "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red";

        Assert.AreEqual(0, Day2.ParseSingleLinePart1(input));
    }
    [Test]
    public void Game4()
    {
        string input = "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red";

        Assert.AreEqual(0, Day2.ParseSingleLinePart1(input));
    }
    [Test]
    public void Game5()
    {
        string input = "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";

        Assert.AreEqual(5, Day2.ParseSingleLinePart1(input));
    }
    [Test]
    public void RealGame2()
    {
        string input = "Game 2: 11 green, 7 blue, 15 red; 13 red, 6 green, 2 blue; 7 green, 9 red, 10 blue; 5 blue, 1 red, 11 green; 4 blue, 18 green; 4 red, 8 blue, 18 green";

        Assert.AreEqual(0, Day2.ParseSingleLinePart1(input));
    }
    [Test]
    public void MaxValues()
    {
        string input = "Game 2: 12 red, 13 green, 14 blue";

        Assert.AreEqual(2, Day2.ParseSingleLinePart1(input));
    }
    [Test]
    public void OverValues()
    {
        string input = "Game 2: 13 red, 14 green, 15 blue";

        Assert.AreEqual(0, Day2.ParseSingleLinePart1(input));
    }
    [Test]
    public void TestProvidedExample()
    {
        string input =
            "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\n" +
            "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\n" +
            "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\n" +
            "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\n" +
            "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";

        Assert.AreEqual(8, Day2.ExecutePart1(input));
    }
}
