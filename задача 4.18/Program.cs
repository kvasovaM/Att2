using System;
using MKLibrary;

namespace задача_4._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 1000;
            int counter = 0;
            double leo;
            int i = 0;
            do
            {
                leo = Mathematic.Leonardo(i);
                if (leo >= a && leo <= b)
                {
                    counter++;
                }
                i++;
            } while (leo <= b);

            Console.WriteLine("количество чисел Леонардо на отрезке от a до b есть: {0}", counter);

        }
    }
}
