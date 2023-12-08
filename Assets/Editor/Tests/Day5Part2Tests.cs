using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Day5Tests
{
    [Test]
    public void CreateConversionMapFirstSource()
    {
        ulong expected = 98;
        ulong actual = new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48").Maps[0].Source;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void CreateConversionMapSecondSource()
    {
        ulong expected = 50;
        ulong actual = new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48").Maps[1].Source;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void CreateConversionMapFirstDestination()
    {
        ulong expected = 50;
        ulong actual = new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48").Maps[0].Destination;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void CreateConversionMapSecondDestination()
    {
        ulong expected = 52;
        ulong actual = new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48").Maps[1].Destination;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void CreateConversionMapFirstLength()
    {
        ulong expected = 2;
        ulong actual = new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48").Maps[0].Length;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void CreateConversionMapSecondLength()
    {
        ulong expected = 48;
        ulong actual = new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48").Maps[1].Length;

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void ReverseConvertExisting()
    {
        ulong expected = 58;
        ulong actual = new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48").ReverseConvert(60);

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void ReverseConvertNonexisting()
    {
        ulong expected = 14;
        ulong actual = new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48").ReverseConvert(14);

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void OutputToInput74()
    {
        ulong expected = 79;
        Day5Part2.ConversionMap[] maps = new[]
        {
            new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48"),
            new Day5Part2.ConversionMap("soil-to-fertilizer map:\r\n0 15 37\r\n37 52 2\r\n39 0 15"),
            new Day5Part2.ConversionMap("fertilizer-to-water map:\r\n49 53 8\r\n0 11 42\r\n42 0 7\r\n57 7 4"),
            new Day5Part2.ConversionMap("water-to-light map:\r\n88 18 7\r\n18 25 70")
        };

        Assert.AreEqual(expected, Day5Part2.OutputToInput(74, maps));
    }
    [Test]
    public void OutputToInput42()
    {
        ulong expected = 14;
        Day5Part2.ConversionMap[] maps = new[]
        {
            new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48"),
            new Day5Part2.ConversionMap("soil-to-fertilizer map:\r\n0 15 37\r\n37 52 2\r\n39 0 15"),
            new Day5Part2.ConversionMap("fertilizer-to-water map:\r\n49 53 8\r\n0 11 42\r\n42 0 7\r\n57 7 4"),
            new Day5Part2.ConversionMap("water-to-light map:\r\n88 18 7\r\n18 25 70")
        };

        Assert.AreEqual(expected, Day5Part2.OutputToInput(42, maps));
    }
    [Test]
    public void OutputToInput46()
    {
        ulong expected = 55;
        Day5Part2.ConversionMap[] maps = new[]
        {
            new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48"),
            new Day5Part2.ConversionMap("soil-to-fertilizer map:\r\n0 15 37\r\n37 52 2\r\n39 0 15"),
            new Day5Part2.ConversionMap("fertilizer-to-water map:\r\n49 53 8\r\n0 11 42\r\n42 0 7\r\n57 7 4"),
            new Day5Part2.ConversionMap("water-to-light map:\r\n88 18 7\r\n18 25 70")
        };

        Assert.AreEqual(expected, Day5Part2.OutputToInput(46, maps));
    }
    [Test]
    public void OutputToInput34()
    {
        ulong expected = 13;
        Day5Part2.ConversionMap[] maps = new[]
        {
            new Day5Part2.ConversionMap("seed-to-soil map:\r\n50 98 2\r\n52 50 48"),
            new Day5Part2.ConversionMap("soil-to-fertilizer map:\r\n0 15 37\r\n37 52 2\r\n39 0 15"),
            new Day5Part2.ConversionMap("fertilizer-to-water map:\r\n49 53 8\r\n0 11 42\r\n42 0 7\r\n57 7 4"),
            new Day5Part2.ConversionMap("water-to-light map:\r\n88 18 7\r\n18 25 70")
        };

        Assert.AreEqual(expected, Day5Part2.OutputToInput(34, maps));
    }
    [Test]
    public void IsInInputs14()
    {
        ulong[] seedInputs = new ulong[] { 14, 7 };
        ulong[] seedLengths = new ulong[] { 3, 4 };

        Assert.IsTrue(Day5Part2.IsInInputs(14, seedInputs, seedLengths));
    }
    [Test]
    public void IsInInputs8()
    {
        ulong[] seedInputs = new ulong[] { 14, 7 };
        ulong[] seedLengths = new ulong[] { 3, 4 };

        Assert.IsTrue(Day5Part2.IsInInputs(8, seedInputs, seedLengths));
    }
    [Test]
    public void IsInInputs17()
    {
        ulong[] seedInputs = new ulong[] { 14, 7 };
        ulong[] seedLengths = new ulong[] { 3, 4 };

        Assert.IsTrue(Day5Part2.IsInInputs(16, seedInputs, seedLengths));
    }
    [Test]
    public void IsInInputs30()
    {
        ulong[] seedInputs = new ulong[] { 14, 7 };
        ulong[] seedLengths = new ulong[] { 3, 4 };

        Assert.IsFalse(Day5Part2.IsInInputs(30, seedInputs, seedLengths));
    }

    [Test]
    public void ProvidedExample()
    {
        string input = "seeds: 79 14 55 13\r\n\r\nseed-to-soil map:\r\n50 98 2\r\n52 50 48\r\n\r\nsoil-to-fertilizer map:\r\n0 15 37\r\n37 52 2\r\n39 0 15\r\n\r\nfertilizer-to-water map:\r\n49 53 8\r\n0 11 42\r\n42 0 7\r\n57 7 4\r\n\r\nwater-to-light map:\r\n88 18 7\r\n18 25 70\r\n\r\nlight-to-temperature map:\r\n45 77 23\r\n81 45 19\r\n68 64 13\r\n\r\ntemperature-to-humidity map:\r\n0 69 1\r\n1 0 69\r\n\r\nhumidity-to-location map:\r\n60 56 37\r\n56 93 4";

        ulong expected = 46;
        ulong actual = Day5Part2.Execute(input);

        Assert.AreEqual(expected, actual);
    }
}
