using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CommonTests
{
    [Test]
    public void TestGetNumbersInLine()
    {
        int[] actual = Common.GetNumbersInLine("hej 1 48   123 tja! 2 er4 * -43");
        int[] expected = new int[]
        {
            1, 48, 123, 2, -43
        };

        for (int i = 0; i < actual.Length; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }
    [Test]
    public void TestGetNumbersInLineLong()
    {
        long[] actual = Common.GetNumbersInLineLong("hej 1 48   123 tja! 2 er4 * -43");
        long[] expected = new long[]
        {
            1, 48, 123, 2, -43
        };

        for (int i = 0; i < actual.Length; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }
    [Test]
    public void TestGetNumbersInLineUlong()
    {
        ulong[] actual = Common.GetNumbersInLineUlong("hej 1 48   123 tja! 2 er4 * 43");
        ulong[] expected = new ulong[]
        {
            1, 48, 123, 2, 43
        };

        for (int i = 0; i < actual.Length; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }

    [Test]
    public void TestSplitLines()
    {
        string[] actual = Common.SplitLines("0 3 6 9 12 15\r\n1 3 6 10 15 21\r\n10 13 16 21 30 45");
        string[] expected = new string[]
        {
            "0 3 6 9 12 15",
            "1 3 6 10 15 21",
            "10 13 16 21 30 45",
        };

        for (int i = 0; i < actual.Length; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }
}
