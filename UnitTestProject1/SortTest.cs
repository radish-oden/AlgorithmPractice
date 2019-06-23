using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void SelectionTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            SelectionSort selection = new SelectionSort();
            int[] i = selection.Selection();

            CollectionAssert.AreEqual(i, numbers);
        }

        [TestMethod]
        public void BubbleTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            BubbleSort bubbleSort = new BubbleSort();
            int[] i = bubbleSort.Bubble();

            CollectionAssert.AreEqual(i, numbers);
        }

        [TestMethod]
        public void InPlaceTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            InPlaceSort inPlaceSort = new InPlaceSort();
            int[] i = inPlaceSort.InPlace();

            CollectionAssert.AreEqual(i, numbers);
        }


    }
}
