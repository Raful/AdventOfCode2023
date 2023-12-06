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
}
