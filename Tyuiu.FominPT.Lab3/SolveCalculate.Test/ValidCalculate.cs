using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveCalculate.Lib;

namespace SolveCalculate.Test
{
    [TestClass]
    public class ValidCalculate
    {
        [TestMethod]
        public void TestCalculateSumma()
        {
            Calculate calculator = new Calculate();
            double a = 2, b = 3;
            double res = calculator.CalculateSumma(a, b);
            Assert.AreEqual(5, res);

        }

        [TestMethod]
        public void TestCalculateDifference()
        {
            Calculate calculator = new Calculate();
            double a = 2, b = 3;
            double res = calculator.CalculateDifference(a, b);
            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void TestCalculateMultiplication()
        {
            Calculate calculator = new Calculate();
            double a = 2, b = 3;
            double res = calculator.CalculateMultiplication(a, b);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestCalculateQuotient()
        {
            Calculate calculator = new Calculate();
            double a = 2, b = 1;
            double res = calculator.CalculateQuotient(a, b);
            Assert.AreEqual(2, res);
        }
    }
}
