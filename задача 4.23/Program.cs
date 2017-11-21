using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_4._23
{
    class Program
    {
        static bool IsSuch (int a, int b, int c)
        {
            return a != b && b != c && a != c;
        }

        static void Main(string[] args)
        {
            int sum = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        if (IsSuch(a, b, c))
                        {
                            sum += a * 100 + b * 10 + c; 
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}