using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_Calculator;
using System;

namespace StringCalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calculate = new Calculator();

        [TestMethod]
        public void TestAddForEmptyString()
        {
            var result = calculate.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAddForSingleNumber()
        {
            var result = calculate.Add("10");
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestAddForTwoNumbers()
        {
            var result = calculate.Add("15,35");
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestAddForNewLine()
        {
            var result = calculate.Add("\n");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAddForNewLineWithNumbers()
        {
            var result = calculate.Add("1\n2,3");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestAddForDelimiters()
        {
            var result = calculate.Add("//;\n1;2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void TestAddForSingleNegativeNumber()
        {
            var result = calculate.Add("-10");
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void TestAddForMultipleNegativeNumber()
        {
            var result = calculate.Add("-7,-15");
        }
    }
}
