using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveCalculate.Lib
{
    public class Calculate
    {
        public double CalculateSumma(double a, double b)
        {
            return a + b;
        }

        public double CalculateDifference(double a, double b)
        {
            return a - b;
        }

        public double CalculateMultiplication(double a, double b)
        {
            return a * b;
        }

        public double CalculateQuotient(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Ошибка! Деление на ноль невозможно");
            }
            else
            {
                return a / b;
            }
        }
    }
}
