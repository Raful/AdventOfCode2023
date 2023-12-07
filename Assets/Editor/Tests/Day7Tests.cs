using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Day7Tests
{
    [Test]
    public void HandFiveOfAKind()
    {
        Dictionary<char, int> expected = new Dictionary<char, int>()
        {
            {'A', 5 }
        };

        Dictionary<char, int> actual = new Day7Part1.Hand("AAAAA 324").DistinctValues;

        for (int i = 0; i < expected.Count; i++)
        {
            Assert.AreEqual(expected[expected.Keys.ToArray()[i]], actual[actual.Keys.ToArray()[i]]);
        }
    }
    [Test]
    public void HandFourOfAKind()
    {
        Dictionary<char, int> expected = new Dictionary<char, int>()
        {
            {'A', 4 },
            {'8', 1 },
        };

        Dictionary<char, int> actual = new Day7Part1.Hand("AAA8A 234").DistinctValues;

        for (int i = 0; i < expected.Count; i++)
        {
            Assert.AreEqual(expected[expected.Keys.ToArray()[i]], actual[actual.Keys.ToArray()[i]]);
        }
    }
    [Test]
    public void HandTwoPair()
    {
        Dictionary<char, int> expected = new Dictionary<char, int>()
        {
            {'4', 2 },
            {'7', 1 },
            {'J', 2 },
        };

        Dictionary<char, int> actual = new Day7Part1.Hand("47JJ4 8764").DistinctValues;

        for (int i = 0; i < expected.Count; i++)
        {
            Assert.AreEqual(expected[expected.Keys.ToArray()[i]], actual[actual.Keys.ToArray()[i]]);
        }
    }

    [Test]
    public void HandFiveOfAKindValue()
    {
        int expected = 6;

        int actual = new Day7Part1.Hand("AAAAA 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandThreeOfAKindValue()
    {
        int expected = 3;

        int actual = new Day7Part1.Hand("8J8K8 235").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandFullHouseValue()
    {
        int expected = 4;

        int actual = new Day7Part1.Hand("8K8K8 32").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandHighCardValue()
    {
        int expected = 0;

        int actual = new Day7Part1.Hand("23456 123").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandHighCardBid()
    {
        int expected = 756;

        int actual = new Day7Part1.Hand("23456 756").Bid;

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandLowerTrue()
    {
        Assert.IsTrue(new Day7Part1.Hand("23456 756") < new Day7Part1.Hand("AAKK5 23456"));
    }
    [Test]
    public void HandLowerFalse()
    {
        Assert.IsFalse(new Day7Part1.Hand("AAKK5 23456") < new Day7Part1.Hand("23456 756"));
    }

    [Test]
    public void HandHigherTrue()
    {
        var higher = new Day7Part1.Hand("44444 756");
        var lower = new Day7Part1.Hand("AAKK5 23456");

        Assert.IsTrue(higher > lower);
    }

    [Test]
    public void HandHigherFalse()
    {
        var higher = new Day7Part1.Hand("44444 756");
        var lower = new Day7Part1.Hand("AAKK5 23456");

        Assert.IsFalse(lower > higher);
    }

    [Test]
    public void ProvidedExample()
    {
        long expected = 6440;

        string input = "32T3K 765\r\nT55J5 684\r\nKK677 28\r\nKTJJT 220\r\nQQQJA 483";
        long actual = Day7Part1.Execute(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandFiveOfAKindJokers()
    {
        int expected = 6;

        int actual = new Day7Part2.Hand("JAAJA 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandFourOfAKindJokers()
    {
        int expected = 5;

        int actual = new Day7Part2.Hand("AJ5JA 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandFullHouseJokers()
    {
        int expected = 4;

        int actual = new Day7Part2.Hand("TT44J 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandThreeOfAKindJokers()
    {
        int expected = 3;

        int actual = new Day7Part2.Hand("TT45J 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandPairJokers()
    {
        int expected = 1;

        int actual = new Day7Part2.Hand("3456J 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Hand32T3KJokers()
    {
        int expected = 1;

        int actual = new Day7Part2.Hand("32T3K 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandT55J5Jokers()
    {
        int expected = 5;

        int actual = new Day7Part2.Hand("T55J5 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandKK677Jokers()
    {
        int expected = 2;

        int actual = new Day7Part2.Hand("KK677 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandKTJJTJokers()
    {
        int expected = 5;

        int actual = new Day7Part2.Hand("KTJJT 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void HandQQQJAJokers()
    {
        int expected = 5;

        int actual = new Day7Part2.Hand("QQQJA 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void HandOnlyJokers()
    {
        int expected = 6;

        int actual = new Day7Part2.Hand("JJJJJ 8536").GetHandValue();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ProvidedExampleJokers()
    {
        long expected = 5905;

        string input = "32T3K 765\r\nT55J5 684\r\nKK677 28\r\nKTJJT 220\r\nQQQJA 483";
        long actual = Day7Part2.Execute(input);

        Assert.AreEqual(expected, actual);
    }
}
