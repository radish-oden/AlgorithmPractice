using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithm;

namespace UnitTestProject1
{
    [TestClass]
    public class BubbleSortTest
    {

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        [TestMethod]
        public void TestMethod1()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] i = bubbleSort.Bubble();

            CollectionAssert.AreEqual(i, numbers);
        }
    }
}
