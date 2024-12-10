using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestCalculateFirstExpression()
        {
            MathFirstExpression fe = new MathFirstExpression();
            double x = 3;
            double y = 2;
            double a = 1;
            double wait = 18.692;
            var res = fe.CalculateFirstExpression(x, y, a);
            Assert.AreEqual(wait, res);
        }
    }
}
