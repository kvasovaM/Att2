using System;

namespace task1_15
{
    class Program
    {
        static int input()
        {
            Console.WriteLine("Вычислить площадь окружности, вписанной в прямоугольный равнобедренный треугольник, если известна длина его гипотенузы.\n");
            Console.Write("Введите длину гипотенузы: ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        static void Main(string[] args)
        {
            int x;
            x =input();   
            output(GetS(x));
        
        }
        static double GetS(double x)
        {
            double r = (2 * x / Math.Sqrt(2) - x) / 2;
            return Math.PI * r * r;
        }
        static void output(double x)
        {
            Console.WriteLine("Площадь окружности равна: {0}", x);
        }
    }
}