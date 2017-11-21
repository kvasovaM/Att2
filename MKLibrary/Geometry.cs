using System;

namespace MKLibrary
{
    /* =============================================================================
     * ГЕОМЕТРИЧЕСКИЕ РАССЧЕТЫ
     * ============================================================================= */

    public class Geometry
    {
        /// <summary>
        /// Площадь круга
        /// </summary>
        public static double CircleS(double r)
        {
            // S = pi*r^2
            return Math.PI * r * r;
        }

        /// <summary>
        /// Катет прямоугольного треугольника
        /// </summary>
        public static double TriangleLeg(double hypotenuse, double leg)
        {
            // a = sqrt(c^2 - b^2)
            return Math.Sqrt(hypotenuse * hypotenuse - leg * leg);
        }

        /// <summary>
        /// Радиус окружности, вписанной в прямоугольный треугольник
        /// </summary>
        public static double CircleInTriangleR(double a, double b, double c)
        {
            // r = (a + b - c) / 2
            return (a + b - c) / 2;
        }

        /// <summary>
        /// проверяет, находится ли точка (х, у) внутри круга
        /// (х - х0) ^ 2 + (у - у0) ^ 2 = r ^ 2
        /// </summary>
        public static bool IsPointInCircle(double x, double y, double x0, double y0, double r)
        {
            return Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) < r * r;
        }

        /// <summary>
        /// проверяет, находится ли точка (х, у) внутри прямоугольника
        /// с вехним левым углом (х0, у0) шириной w и высотой h
        /// </summary>
        public static bool IsPointInRect(double x, double y, double x0, double y0, double w, double h)
        {
            return  x > x0 && x < x0 + w && y < y0 && y > y0 - h;
        }

        /// <summary>
        /// проверяет, находится ли точка ниже прямоугольника
        /// </summary>
        public static bool IsPointUnderRect(double x, double y, double x0, double y0, double w, double h)
        {
            return y < y0 - h;
        }



        /// <summary>
        /// проверяет, находится ли точка (х, у) справа от параболы
        /// x = а * Math.Pow(у - у0, 2) + x0
        /// </summary>
        public static bool IsPointRightOfParabolaX(double x, double y, double x0, double y0, double a)
        {
            return x > a * Math.Pow(y - y0, 2) + x0 ;
        }

        /// <summary>
        /// проверяет, находится ли точка (х, у) выше параболы
        /// y = а * Math.Pow(x - x0, 2) + y0
        /// </summary>
        public static bool IsPointAboveParabolaY(double x, double y, double x0, double y0, double a)
        {
            return y > a * Math.Pow(x - x0, 2) + y0;
        }

        /// <summary>
        /// проверяет, находится ли точка (х, у) ниже параболы
        /// y = а * Math.Pow(x - x0, 2) + y0
        /// </summary>
        public static bool IsPointUnderParabolaY(double x, double y, double x0, double y0, double a)
        {
            return y < a * Math.Pow(x - x0, 2) + y0;
        }

    }
}