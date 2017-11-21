using System;

namespace SandBox
{
    class Program
    {

        static void Main()
        {

            int[] a = {30, -3, 2, 8, -6, 30, 5, 17, 21, -13, 30, -8 };
            int[] b = {1, 3, 5};
            /* Console.WriteLine(Solution.startIndex);
            Task7246 Solution = new Task7246(a);
            Console.WriteLine(Solution.elementsCount); */

            Printer();
        }

        // --------------------------------------------------------------------------------------------
       
        // последовательность 1,0,2,1,3,2,4,3... 50 элементов
        public static void Printer()
        {
            int position = 1;
            int odd = 1; // нечетный
            int even = 0; // четный

            while (position <= 50)
            {
                if (position % 2 == 1)
                {
                    Console.WriteLine("{0}", odd);
                    odd++;
                }
                else
                {
                    Console.WriteLine("{0}", even);
                    even++;
                }
                position++;
            }
        }

        // распечатывает последовательность двойки в степени n
        public static void PrintNumbers()
        {
            int output = 1;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}", output);
                output *= 2;
            }
        }

        // количество элементов, которые являются больше его соседних
        public static void IsBigger(int[] a)
        {
            int counter = 0;

            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1] && a[i] > a[i - 1])
                {
                    counter++;
                }
            }

            Console.WriteLine("{0}", counter);
        }

        // проверка на совпадения
        public static void IsInArray(int[] a)
        {
            int element = 0;

            for (int i = 0; i < a.Length; i++)
            {
                int j = 1;

                if (a[i] == a[j])
                {
                    element = 1;
                    break;
                }
                j++;
            }

            Console.WriteLine("{0}", element);
        }

        // индекс первого наибольшего среди четных элементов массива
        public static void IndexOfTheBiggest(int[] a)
        {
            int index = -1;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                int max = a[a.Length - 1];

                if (a[i] % 2 == 0)
                {
                    if (a[i] >= max)
                    {
                        max = a[i];
                        index = i;
                    }
                }
            }

            Console.WriteLine("{0}", index);
        }

        // печать равнобедренного треугольника с вершинами в виде звезд
        public static void PrintFigure1(int h)
        {
            int w = 2 * h - 1;
            int ai = h - 1;
            int bi = h - 1;

            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < w; col++)
                {
                    // вывод вершины пирамиды
                    if (row == 0)
                    {
                        if (col == h - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }

                    // вывод основания пирамиды
                    if (row == h - 1)
                    {
                        if (col == 0 || col == w - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('-');
                        }
                    }

                    if (row > 0 && row != h - 1)
                    {
                        if (col == ai)
                        {
                            Console.Write('/');

                        }
                        else if (col == bi)
                        {
                            Console.Write('\\');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }

                }

                Console.WriteLine();
                ai--;
                bi++;
            }
        }

        // печать треугольника из звезд
        public static void PrintFigure2(int h)
        {
            int a = h - 1;

            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < h; col++)
                {
                    if (row == 0)
                    {
                        Console.Write('*');
                    }

                    if (row == 1 && col != h - 1)
                    {
                        Console.Write('*');
                    }

                    if (row > 1)
                    {
                        if (col == 0)
                        {
                            Console.Write('*');
                        }

                        else if (col == a)
                        {
                            Console.Write('*');
                        }

                        else
                        {
                            Console.Write(' ');
                        }
                    
                    }
                    
                }

                Console.WriteLine();
                a--;
            }
        }

        // печать прямоугольного треугольника с вершинами в виде звезд
        public static void PrintFigure3(int h)
        {
            int a = 0;

            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < h; col++)
                {
                    if (row == 0)
                    {
                        if (col == 0 || col == h - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('-');
                        }
                    }

                    if (row > 0)
                    {
                        if (row != h - 1 && col == h - 1)
                        {
                            Console.Write('|');
                        }

                        else if (col == a && col != h - 1)
                        {
                            Console.Write('\\');
                        }

                        else if (row == h - 1 && col == h - 1)
                        {
                            Console.Write('*');
                        }

                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }

                Console.WriteLine();
                a++;
            }
        }

        // функция, которая распечатывает первые k отрицательных элементов массива
        static void PrintNegative(int[] a, int k)
        {
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] < 0 && k > 0)
                {
                    Console.WriteLine("{0}", a[i]);
                    k--;
                }
                if (k == 0)
                {
                    break;
                }
            }
        }

        // функция, которая распечатывает два первых рядомстоящих элемента
        // массива, сумма которых является четной
        static void PrintElements(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {

                if ((a[i] + a[i + 1]) % 2 == 0)
                {
                    Console.WriteLine("{0}", a[i]);
                    Console.WriteLine("{0}", a[i + 1]);
                    return;
                }

            }
        }

    }
}