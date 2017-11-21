using System;
using MKLibrary;

namespace Task4
{
    class Program
    {

        // ввод
        static int Input()
        {
            Console.WriteLine("Вычислить сумму первых n простых чисел, начиная с 1.");

            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            return n;
        }

        static void Main()
        {
            // ввести количество простых чисел
            int n = Input();
            // вывести сумму этих простых чисел
            Output(n, SumSimples(n));

        }

        // подсчет суммы первых n простых чисел
        static int SumSimples(int n)
        {
            int sum = 0;
            int founded = 0;
            int number = 1;

            while (founded < n)
            {
                if (Mathematic.IsSimple(number))
                {
                    founded++;
                    sum += number;
                }
                number++;
            }

            return sum;
        }

        // вывод 
        static void Output(int n, int sum)
        {
            Console.WriteLine("Сумма {0} простых чисел равна: {1}", n, sum);
        }

    }
}
