using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTestMethod()
        {
            Calculator calculator = new Calculator();
            double res = calculator.Add(4, 4);
            Assert.AreEqual(res, 8);
        }

        [TestMethod()]
        public void SubstractTestMethod()
        {
            Calculator calculator = new Calculator();
            double res = calculator.Substract(4, 3);
            Assert.AreEqual(res, 1);
        }

        [TestMethod()]
        public void divideTest()
        {
            Calculator calculator = new Calculator();
            double res = calculator.divide(4, 2);
            Assert.AreEqual(res, 2);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            double res = calculator.Multiply(5, 6);
            Assert.AreEqual(res, 30);
        }
    }
}