using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Day3Part1Tests
{
    [Test]
    public void SingleRow()
    {
        string input =
            "122.*432..";

        Assert.AreEqual(432, Day3.ExecutePart1(input));
    }
    [Test]
    public void SingleDigit()
    {
        string input =
            "....*5....";

        Assert.AreEqual(5, Day3.ExecutePart1(input));
    }
    [Test]
    public void SingleDigitMultiSymbol()
    {
        string input =
            "....*5_...";

        Assert.AreEqual(5, Day3.ExecutePart1(input));
    }
    [Test]
    public void SingleRowSummed()
    {
        string input =
            "122¤*432..";

        Assert.AreEqual(122+432, Day3.ExecutePart1(input));
    }
    [Test]
    public void Top2Rows()
    {
        string input = 
            "467..114..\n" +
            "...*......";

        Assert.AreEqual(467, Day3.ExecutePart1(input));
    }
    [Test]
    public void Ignore58()
    {
        string input =
            "617*......\n" +
            ".....+.58.\n" +
            "..592.....";

        Assert.AreEqual(617+592, Day3.ExecutePart1(input));
    }
    [Test]
    public void TestProvidedExample()
    {
        string input =
            "467..114..\n" +
            "...*......\n" +
            "..35..633.\n" +
            "......#...\n" +
            "617*......\n" +
            ".....+.58.\n" +
            "..592.....\n" +
            "......755.\n" +
            "...$.*....\n" +
            ".664.598..";

        Assert.AreEqual(4361, Day3.ExecutePart1(input));
    }
    [Test]
    public void TestRealCase()
    {
        string input =
            ".........398.............551.....................452..................712.996.................646.40...1.....875..958.553...................\n" +
            "..................................661..-844......*.../781...835..#163....*.......698.239.........*.....*.............*............*57.......\n" +
            ".....................&...............*......+..139..................................*.........-.......282......................301..........\n" +
            "........518..........918..-....472..172....776......207............38........................860..............274..945.....162..............\n" +
            "........@..........#.....845..*........................*.............*....896...+.....153................@......*...*.......#.........441...\n" +
            "..................740.21.....303...744.........190......173.395...729...-....&..925....@..5..............172...566..193...........#.........";

        int expected =
            452 + 712 + 996 + 646 + 40 + 1 + 958 + 553 +
            661 + 844 + 781 + 163 + 698 + 239 + 57 +
            139 + 282 + 301 +
            518 + 918 + 472 + 172 + 776 + 207 + 38 + 860 + 274 + 945 + 162 +
            845 + 896 + 153 + 
            740 + 303 + 173 + 729 + 925 + 172 + 566 + 193;

        Assert.AreEqual(expected, Day3.ExecutePart1(input));
    }
}
