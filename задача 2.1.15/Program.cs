using System;

namespace ConsoleApp2

{
    class Program
    {
        static void input(out int a, out int b, out int c, out int d)
        {
            Console.WriteLine("Даны четыре целых числа, одно из которых отлично от трех других, равных между собой. Вывести порядковый номер этого числа.");
            Console.WriteLine("введите числа:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int a, b, c, d;
            input(out a, out b, out c, out d);
            int index = condition(a, b, c, d);
            output(index);
        }

        static int condition(int a, int b, int c, int d)
        {
            if (a == b && b == c && c == d)
            {
                return 0;
            }
            else if (b == c && c == d)
            {
                return 1;
            }
            else if (a == c && c == d)
            {
                return 2;
            }
            else if (a == b && b == d)
            {
                return 3;
            }
            else if (a == b && b == c)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        static void output(int index)
        {
            Console.WriteLine("порядковый номер числа: {0}", index.ToString());
        }
    }
}

