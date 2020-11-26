using leetcodeinterviewquestions.Sorting_and_Searching;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Sorting_and_Searching
{
    class SortColorsTest
    {
        private SortColorsSolution solution;

        [SetUp]
        public void Setup()
        {
            solution = new SortColorsSolution();
        }

        [Test]
        public void Test1()
        {
            var arr = new int[] { 1, 2, 0, 0, 0, 2, 1 };
            solution.SortColors(arr);
            Assert.AreEqual(arr[0], 0);
            Assert.AreEqual(arr[1], 0);
            Assert.AreEqual(arr[2], 0);
            Assert.AreEqual(arr[6], 2);
            Assert.AreEqual(arr[5], 2);
        }

        [Test]
        public void Test2()
        {
            var arr = new int[] { 2, 0, 2, 1, 1, 0 };
            solution.SortColors(arr);
            Assert.AreEqual(arr[0], 0);
            Assert.AreEqual(arr[1], 0);
            Assert.AreEqual(arr[2], 1);
            Assert.AreEqual(arr[3], 1);
            Assert.AreEqual(arr[4], 2);
            Assert.AreEqual(arr[5], 2);
        }
        [Test]
        public void Test3()
        {
            var arr = new int[] { 2, 0, 1 };
            solution.SortColors(arr);
            Assert.AreEqual(arr[0], 0);
            Assert.AreEqual(arr[1], 1);
            Assert.AreEqual(arr[2], 2);
        }

        [Test]
        public void Test4()
        {
            var arr = new int[] { };
            solution.SortColors(arr);
            Assert.AreEqual(arr.Length, 0);
        }

        [Test]
        public void Test5()
        {
            var arr = new int[] { 2, 2, 0, 0, 2, 0, 2, 1, 0 };
            solution.SortColors(arr);
            var max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i] >= max);
                max = Math.Max(arr[i], max);
            }
        }

        [Test]
        public void Test6()
        {
            var arr = new int[] { 0, 1, 0 };
            solution.SortColors(arr);
            var max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i] >= max);
                max = Math.Max(arr[i], max);
            }
        }

        [Test]
        public void Test7()
        {
            var arr = new int[] {0, 0, 2, 1, 1, 2, 1, 1, 1, 0, 2, 1, 0, 1, 2, 1, 0, 1, 1, 1, 2, 2, 1, 2, 0, 0, 1, 0, 2, 1, 2, 2, 2, 0 };
            solution.SortColors(arr);
            var max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i] >= max);
                max = Math.Max(arr[i], max);
            }
        }
    }
}
