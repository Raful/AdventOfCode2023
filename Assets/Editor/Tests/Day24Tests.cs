using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Linq;
using static Day24;

public class Day24Tests
{
    [Test]
    public void ParseOneHailstone()
    {
        Day24.Hailstone expected = new Day24.Hailstone(new Vector2(5, -3), new Vector2(-1, 2));
        string input = "5, -3, 4 @ -1, 2, -2";

        Day24.Hailstone actual = Day24.ParseInput(new string[] { input })[0];

        Assert.AreEqual(expected.position, actual.position);
        Assert.AreEqual(expected.velocity, actual.velocity);
    }
    [Test]
    public void ParseTwoHailstones()
    {
        Day24.Hailstone[] expected = new Day24.Hailstone[]
        { 
            new Day24.Hailstone(new Vector2(5, -3), new Vector2(-1, 2)),
            new Day24.Hailstone(new Vector2(2, 2), new Vector2(8, 14)),
        };
        string input = 
            "5, -3, 4 @ -1, 2, -2\r\n" +
            "2, 2, 2 @ 8, 14, 4";

        Day24.Hailstone[] actual = Day24.ParseInput(Common.SplitLines(input));

        Assert.AreEqual(expected.Length, actual.Length);
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i].position, actual[i].position);
            Assert.AreEqual(expected[i].velocity, actual[i].velocity);
        }
    }
    [Test]
    public void IntersectingInArea()
    {
        Vector2 expected = new Vector2(5, 5);

        Day24.Hailstone input1 = new Day24.Hailstone(new Vector2(0, 0), new Vector2(1, 1));
        Day24.Hailstone input2 = new Day24.Hailstone(new Vector2(10, 0), new Vector2(1, -1));

        Assert.IsTrue(Day24.GetIntersectionPoint(input1, input2, out Vector2 actual));
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void RectContainsMin()
    {
        Day24.RectLong input = new Day24.RectLong(7, 7, 20, 20);

        Assert.IsTrue(input.Contains(new Vector2(7, 7)));
    }
    [Test]
    public void RectContainsMax()
    {
        Day24.RectLong input = new Day24.RectLong(7, 7, 20, 20);

        Assert.IsTrue(input.Contains(new Vector2(27, 27)));
    }
    [Test]
    public void RectNotContainsUnderMin()
    {
        Day24.RectLong input = new Day24.RectLong(7, 7, 20, 20);

        Assert.IsFalse(input.Contains(new Vector2(6, 6)));
    }
    [Test]
    public void RectNotContainsOverMax()
    {
        Day24.RectLong input = new Day24.RectLong(7, 7, 20, 20);

        Assert.IsFalse(input.Contains(new Vector2(28, 28)));
    }

    [Test]
    public void ProvidedExample()
    {
        long expected = 2;

        string input = "19, 13, 30 @ -2,  1, -2\r\n18, 19, 22 @ -1, -1, -2\r\n20, 25, 34 @ -2, -2, -4\r\n12, 31, 28 @ -1, -2, -1\r\n20, 19, 15 @  1, -5, -3";
        Day24.RectLong inputArea = new Day24.RectLong(7, 7, 20, 20);

        Assert.AreEqual(expected, Day24.ExecutePart1(input, inputArea));
    }
}
