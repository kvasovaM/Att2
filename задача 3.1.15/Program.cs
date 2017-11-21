using System;
using System.Globalization;
using System.Threading;
using MKLibrary;

namespace Task_3_1_15
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
            double coordinate = 0;
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
            return Geometry.IsPointAboveParabolaY(x, y, 6, -2, 0.125);
        }

        static bool IsPointRightOfParabolaX(double x, double y)
        {
            return Geometry.IsPointRightOfParabolaX(x, y, 4, 5, 1);
        }

        static bool IsPointInCircle(double x, double y)
        {
            return Geometry.IsPointInCircle(x, y, -3, 7, 5);
        }

        static bool IsPointInRect(double x, double y)
        {
            return Geometry.IsPointInRect(x, y, -6, 7, 8, 4);
        }
         
        static bool IsPointUnderRect(double x, double y)
        {
            return Geometry.IsPointUnderRect(x, y, -6, 7, 8, 4);
        }

        static SimpleColor GetColor(double x, double y)
        {
            // выше параболы Y, в круге, в прямоугольнике
            // не выше параболы Y, в круге, не в прямоугольнике, не ниже прямоугольника
            if (
                (IsPointAboveParabolaY(x, y) && IsPointInCircle(x, y) && IsPointInRect(x, y))
                || (!IsPointAboveParabolaY(x, y) && IsPointInCircle(x, y) && !IsPointInRect(x, y) && !IsPointUnderRect(x, y))
                )
            {
                return SimpleColor.Blue;
            }

            // справа от параболы X 
            // выше параболы Y, в круге, не в прямоугольнике
            // не выше параболы Y, в прямоугольнике, в круге
            else if ((IsPointRightOfParabolaX(x, y)) || (IsPointAboveParabolaY(x, y) && IsPointInCircle(x, y) && !IsPointInRect(x, y)) || (!IsPointAboveParabolaY(x, y) && IsPointInRect(x, y) && IsPointInCircle(x, y)))
            {
                return SimpleColor.White;
            }

            // выше параболы Y, не справа от параболы X, не пренадлежит прямоугольнику, не пренадлежит кругу
            else if (IsPointAboveParabolaY(x, y) && !IsPointRightOfParabolaX(x, y) && !IsPointInRect(x, y) && !IsPointInCircle(x, y))
            {
                return SimpleColor.Yellow;
            }

            // не выше параболы Y, в круге, ниже прямоугольника
            // выше параболы Y, не в круге, в прямоугольнике
            else if ((!IsPointAboveParabolaY(x, y) && IsPointInCircle(x, y) && IsPointUnderRect(x, y)) 
                || (IsPointAboveParabolaY(x, y) && !IsPointInCircle(x, y) && IsPointInRect(x, y)))
            {
                return SimpleColor.Green;
            }

            //  иначе
            else return SimpleColor.Orange;
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

        static 
            
            void PrintDemoPoints()
        {
            PrintColorForPoint(6, 0); // Yellow
            PrintColorForPoint(0, 5); // Blue
            PrintColorForPoint(-6, 9); // Blue
            PrintColorForPoint(0, 9); // White
            PrintColorForPoint(-4, 5); // White
            PrintColorForPoint(8, 5); // White
            PrintColorForPoint(-3, 2.5); // Green
            PrintColorForPoint(1.5, 3.5); // Green
            PrintColorForPoint(-3, -10); // Orange
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
