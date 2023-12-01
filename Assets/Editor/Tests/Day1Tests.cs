using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Day1Tests
{
    [Test]
    public void Test1abc2()
    {
        Assert.AreEqual(12, Day1.ParseSingleLine("1abc2"));
    }
    [Test]
    public void Testpqr3stu8vwx()
    {
        Assert.AreEqual(38, Day1.ParseSingleLine("pqr3stu8vwx"));
    }
    [Test]
    public void Testa1b2c3d4e5f()
    {
        Assert.AreEqual(15, Day1.ParseSingleLine("a1b2c3d4e5f"));
    }
    [Test]
    public void Testtreb7uchet()
    {
        Assert.AreEqual(77, Day1.ParseSingleLine("treb7uchet"));
    }
    [Test]
    public void TestProvidedExample()
    {
        string input = 
            "1abc2\n" +
            "pqr3stu8vwx\n" +
            "a1b2c3d4e5f\n" +
            "treb7uchet";

        Assert.AreEqual(142, Day1.Execute(input));
    }

    [Test]
    public void Testtwo1nine()
    {
        Assert.AreEqual(29, Day1.ParseSingleLine("two1nine"));
    }
    [Test]
    public void Testeightwothree()
    {
        Assert.AreEqual(83, Day1.ParseSingleLine("eightwothree"));
    }
    [Test]
    public void Testabcone2threexyz()
    {
        Assert.AreEqual(13, Day1.ParseSingleLine("abcone2threexyz"));
    }
    [Test]
    public void Testxtwone3four()
    {
        Assert.AreEqual(24, Day1.ParseSingleLine("xtwone3four"));
    }
    [Test]
    public void Test4nineeightseven2()
    {
        Assert.AreEqual(42, Day1.ParseSingleLine("4nineeightseven2"));
    }
    [Test]
    public void Testzoneight234()
    {
        Assert.AreEqual(14, Day1.ParseSingleLine("zoneight234"));
    }
    [Test]
    public void Test7pqrstsixteen()
    {
        Assert.AreEqual(76, Day1.ParseSingleLine("7pqrstsixteen"));
    }
    [Test]
    public void TestProvidedExample2()
    {
        string input =
            "two1nine\n" +
            "eightwothree\n" +
            "abcone2threexyz\n" +
            "xtwone3four\n" +
            "4nineeightseven2\n" +
            "zoneight234\n" +
            "7pqrstsixteen\n";

        Assert.AreEqual(281, Day1.Execute(input));
    }

    [Test]
    public void TestNoNumbers()
    {
        Assert.AreEqual(Day1.ParseSingleLine("abcde"), 0);
    }
}
