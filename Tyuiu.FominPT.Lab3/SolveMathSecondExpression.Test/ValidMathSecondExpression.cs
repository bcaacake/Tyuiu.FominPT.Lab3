using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestCalculateSecondExpression()
        {
            MathSecondExpression se = new MathSecondExpression();
            double x = 3;
            double y = 2;
            double a = 1;
            double wait = 22.578;
            var res = se.CalculateSecondExpression(x, y, a);
            Assert.AreEqual(wait, res);
        }
    }
}
