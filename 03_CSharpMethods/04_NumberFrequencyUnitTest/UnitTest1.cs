using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethodAll()
    {
        int[] array = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        int testNumber = 1;
        int expectedCount = array.Length;
        int realCount = NumberInArray.NumberFrequency(testNumber, array);
        Assert.AreEqual(expectedCount, realCount);
    }
    [TestMethod]
    public void TestMethodNone()
    {
        int[] array = new int[] { 5, 1, 2, 4, 2, 5, 7, 9, 10, 11, 5 };
        int testNumber = 3;
        int expectedCount = 0;
        int realCount = NumberInArray.NumberFrequency(testNumber, array);
        Assert.AreEqual(expectedCount, realCount);
    }
    [TestMethod]
    public void TestMethodSome()
    {
        int[] array = new int[] { 5, 1, 2, 4, 2, 5, 7, 9, 10, 11, 5 };
        int testNumber = 5;
        int expectedCount = 3;
        int realCount = NumberInArray.NumberFrequency(testNumber, array);
        Assert.AreEqual(expectedCount, realCount);
    }
}

