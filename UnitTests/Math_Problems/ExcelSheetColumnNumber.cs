using leetcodeinterviewquestions.Math_Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Math_Problems
{
    public class TestExcelSheetColumnNumber
    {
        private ExcelSheetColumnNumber solution;
        [SetUp]
        public void Setup()
        {
            solution = new ExcelSheetColumnNumber();
        }

        [Test]
        public void Test1()
        {
            var result = solution.TitleToNumber("A");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test2()
        {
            var result = solution.TitleToNumber("AB");
            Assert.AreEqual(28, result);
        }

        [Test]
        public void Test3()
        {
            var result = solution.TitleToNumber("ZY");
            Assert.AreEqual(701, result);
        }

        [Test]
        public void Test4()
        {
            var result = solution.TitleToNumber("AAA");
            Assert.AreEqual(703, result);
        }
    }
}
