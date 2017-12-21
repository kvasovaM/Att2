using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь заштрихованной фигуры равна: {0}", Square(a));
        }

        static double Square(double a)
        {
            double s_square = Math.Pow(a, 2);
            double s_circle = Math.PI * Math.Pow(a / 2, 2);
            return s_square / 4 + (s_square - s_circle) / 4;
        }
    }
}
