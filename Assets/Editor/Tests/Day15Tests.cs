using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Linq;

public class Day15Tests
{
    [Test]
    public void TestHash()
    {
        long expected = 214;
        string input = "pc=6";

        long actual = Day15.HashString(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestHashes()
    {
        long expected = 1320;
        string input = "rn=1,cm-,qp=3,cm=2,qp-,pc=4,ot=9,ab=5,pc-,pc=6,ot=7";

        long actual = Day15.Execute1(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestExecuteInstructionAdd()
    {
        Dictionary<long, List<Day15.Lens>> expected = new Dictionary<long, List<Day15.Lens>>()
        {
            { Day15.HashString("cm"), new List<Day15.Lens>(){ new Day15.Lens("cm", 1) } }
        };

        string input = "cm=1";

        Dictionary<long, List<Day15.Lens>> actual = new Dictionary<long, List<Day15.Lens>>(); 
        Day15.ExecuteInstruction(input, ref actual);

        AssertDictionary(expected, actual);
    }

    [Test]
    public void TestExecuteInstructionAddRemove()
    {
        Dictionary<long, List<Day15.Lens>> expected = new Dictionary<long, List<Day15.Lens>>()
        {
        };

        string input1 = "cm=1";
        string input2 = "cm-";

        Dictionary<long, List<Day15.Lens>> actual = new Dictionary<long, List<Day15.Lens>>();
        Day15.ExecuteInstruction(input1, ref actual);
        Day15.ExecuteInstruction(input2, ref actual);

        AssertDictionary(expected, actual);
    }

    void AssertDictionary(Dictionary<long, List<Day15.Lens>> expected, Dictionary<long, List<Day15.Lens>> actual)
    {
        //Currently not testing order of lenses within a box
        Assert.AreEqual(expected.Count, actual.Count);

        foreach (var expectedKvp in expected)
        {
            Assert.IsTrue(actual.Keys.Any(k => k == expectedKvp.Key));

            Assert.AreEqual(expectedKvp.Value.Count, actual[expectedKvp.Key].Count);

            foreach (var item in actual[expectedKvp.Key])
            {
                Assert.IsTrue(expectedKvp.Value.Any(l => l.label == item.label && l.focalLength == item.focalLength));
            }
        }
    }
}
