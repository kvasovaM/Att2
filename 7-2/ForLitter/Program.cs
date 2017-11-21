using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLitter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = {4, 3, 2, 1};
            int[] a = {0, 2, 4, 8, 3, 4, 7, 5, 6, 6, 7, 11};
            SizeAndIndex(a);
        }

        static void SizeAndIndex(int[] a)
        {
           int size = 0; // максимальная длина подмножества
           int index = -1; 

           for (int i = 0; i < a.Length; i++)
           {
                int counter = 1;

                for (int j = i; j < a.Length - 1; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        i = i + counter - 1;
                        break;
                    }
                    else
                    {
                        counter++;
                    }

                    if (counter >= size)
                    {
                        size = counter;
                        index = i;  
                    }
                }
           }

           Console.WriteLine("число элементов {0}, индекс первого {1}", size, index);
        }
    }
}
