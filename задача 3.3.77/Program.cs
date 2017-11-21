using System;
using System.Globalization;
using System.Threading;
using MKLibrary;

namespace Task_3_3_77
{
    enum SimpleColor
    {
        Black, White, Gray, Red, Orange, Yellow, Green, Blue
    };

    class Program
    {
        // проверка корректности введенных координат
        static double GetCoordinate(string prompt)
        {
            double coordinate;
            while (true)
            {
                Console.Write(prompt);

                try
                {
                    coordinate = double.Parse(Console.ReadLine().Replace(',', '.'));
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ошибка ввода. Для введенных данных допустимы только числовые значения");
                    continue;
                }

                if (Math.Abs(coordinate) <= 10)
                {
                    return coordinate;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Допустимый диапазон от -10 до 10");
                }
            }
        }

        static bool IsPointAboveParabolaY(double x, double y)
        {
            return Geometry.IsPointAboveParabolaY(x, y, -1, -6, 1);
        }

        static bool IsPointRightOfParabolaX1(double x, double y)
        {
            return Geometry.IsPointRightOfParabolaX(x, y, -4, 2, -0.125);
        }

        static bool IsPointRightOfParabolaX2(double x, double y)
        {
            return Geometry.IsPointRightOfParabolaX(x, y, 2, -5, -0.125);
        }

        static bool IsPointInCircle(double x, double y)
        {
            return Geometry.IsPointInCircle(x, y, -3, 8, 2);
        }

        static bool IsXRightOfVerticalOfParabolaY(double x)
        {
            return x > -1;
        }

        static SimpleColor GetColor(double x, double y)
        {
            if (!IsPointRightOfParabolaX2(x, y))
            {
                if (!IsPointRightOfParabolaX1(x, y))
                {
                    return SimpleColor.Blue;
                }
                if (IsPointAboveParabolaY(x, y))
                {
                    return SimpleColor.Gray;
                }
                return SimpleColor.White;
            }
            else
            {
                if (IsPointAboveParabolaY(x, y))
                {
                    return SimpleColor.Green;
                }
                if (!IsPointAboveParabolaY(x, y) && IsPointInCircle(x, y))
                {
                    return SimpleColor.Blue;
                }
                if (!IsXRightOfVerticalOfParabolaY(x))
                {
                    return SimpleColor.Green;
                }
                return SimpleColor.White;
            }
        }

        // вывод цвета точки по координатам
        static void PrintColorForPoint(double x, double y)
        {
            Console.WriteLine("({0}, {1}) -> {2}",
               Convert.ToString(x, CultureInfo.InvariantCulture),
               Convert.ToString(y, CultureInfo.InvariantCulture),
               GetColor(x, y)
           );
        }

        static void PrintDemoPoints()
        {
            PrintColorForPoint(6, 0); // White
            PrintColorForPoint(-6, 1.5); // Blue
            PrintColorForPoint(-1, -3); // Gray
            PrintColorForPoint(-8, 6); // Green
            PrintColorForPoint(0, 7); // Green
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            PrintDemoPoints();

            do
            {
                double x = GetCoordinate("Input X: ");
                double y = GetCoordinate("Input Y: ");
                PrintColorForPoint(x, y);
                Console.WriteLine("Для продолжения нажмите enter, чтобы завершить выполнение программы нажмите любую другую клавишу");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Enter);
        }
    }
}
