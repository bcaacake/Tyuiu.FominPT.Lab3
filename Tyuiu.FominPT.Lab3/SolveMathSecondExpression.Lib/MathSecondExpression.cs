using System;

namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public double CalculateSecondExpression(double x, double y, double a)
        {
            double res = 16 * a
                        - (4 * x - 2 * a + a) / (a + 2 * x + y)
                        + 3 * x
                        + (((a - 4) / y) / (5 * a / (x + 1)));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
