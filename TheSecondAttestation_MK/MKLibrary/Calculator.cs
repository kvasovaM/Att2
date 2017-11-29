using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKLibrary
{
    public class Calculator
    {
        private double X;

        public Calculator(double x)
        {
            this.X = x;
        }

        public double CalculateFunctionExactly()
        {
            return Math.Cosh(X);
        }

        public double CalculateFunctionApproximately(int n, double e, out int c)
        {
            c = 0;
            double result = 1; // Сумма n слагаемых
            double lastTerm = 1;

            if (lastTerm > e)
                c++;

            for (int i = 1; i < n; i++)
            {
                lastTerm *= (X * X) / ((2 * i)*(2*i-1));

                if (Math.Abs(lastTerm) > e)
                {
                    result += lastTerm;
                    c++;
                }
            }

            return result;
        }
    }
}
