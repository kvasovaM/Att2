using System;
using System.Globalization;
using System.Threading;
using MKLibrary;

namespace Task3
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

        static bool IsPointAboveParabola(double x, double y)
        {
            return Geometry.IsPointAboveParabolaY(x, y, -6, 1, -0.25);
        }

        static bool IsPointInCircle(double x, double y)
        {
            return Geometry.IsPointInCircle(x, y, -3, 3, 5);
        }

        static bool IsPointInRect(double x, double y)
        {
            return Geometry.IsPointInRect(x, y, -1, 1, 6, 2);
        }

        static SimpleColor GetColor(double x, double y)
        {
            // в прямоугольнике, но не в окружности
            if (IsPointInRect(x, y) && !IsPointInCircle(x, y))
            {
                return SimpleColor.Blue;
            }
            // в окружности, не в прямоугольнике и выше параболы
            else if (IsPointInCircle(x, y) && !IsPointInRect(x, y) && IsPointAboveParabola(x, y))
            {
                return SimpleColor.Orange;
            }
            // в прямоугольнике, но не в круге 
            // не в круге и ниже параболы
            else if ((IsPointInRect(x, y) && IsPointInCircle(x, y)) || (!IsPointAboveParabola(x, y) && !IsPointInCircle(x, y)))
            {
                return SimpleColor.White;
            }
            else
            {
                // иначе
                return SimpleColor.Yellow;
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
            PrintColorForPoint(-5, 0); // Yellow
            PrintColorForPoint(4, 0); // Blue
            PrintColorForPoint(-5, 5); // Orange
            PrintColorForPoint(0, 0); // White
            PrintColorForPoint(-5, -7); // White
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
