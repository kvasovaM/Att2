using System;

namespace MKLibrary
{
    /* =============================================================================
     * МАТЕМАТИЧЕСКИЕ РАССЧЕТЫ
     * ============================================================================= */

    public class Mathematic
    {
        /// <summary>
        /// является ли число n простым
        /// </summary>
        public static bool IsSimple(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// поиск n числа Леонардо
        /// </summary>
        public static double Leonardo(int n)
        {
            double fi = (1 + Math.Sqrt(5))/2;
            return 2 / Math.Sqrt(5) * (Math.Pow(fi, n + 1) - Math.Pow(1 - fi, n + 1)) - 1;
        }
    }

}