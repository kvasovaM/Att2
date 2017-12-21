using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N(размерность одномерного массива):");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Полученный массив:");
            Array(N);
        }

        static void Array(int N)
        {
            double[] arr = new double[N];

            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = i * i;
                    Console.WriteLine(arr[i]);
                }

                if (i % 2 != 0)
                {
                    arr[i] = 1.0 / i;
                    Console.WriteLine(arr[i]);
                }
            }
        }

    }
}
