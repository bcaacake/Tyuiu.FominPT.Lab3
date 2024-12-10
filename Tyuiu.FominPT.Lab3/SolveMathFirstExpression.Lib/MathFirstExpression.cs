using System;

namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public double CalculateFirstExpression(double x, double y, double a)
        {
            double denominator = (3 - a) / (x + Math.Pow(y, 3));
            if (denominator == 0)
            {
                throw new Exception("Ошибка! Деление на ноль невозможно");
            }
            double res = 8 * a
                        + (2 * y + x - 3 * a) / (a * x - 8 * y)
                        + (((2 + a) / (3 * y) * 3 + (a / y))
                        / ((3 - a) / (x + Math.Pow(y, 3))));
            res = Math.Round(res, 3);
            return res;
        }
    }
}