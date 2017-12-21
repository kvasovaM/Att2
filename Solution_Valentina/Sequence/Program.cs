using System;

namespace Sequence
{
    public class Program
    {
        static int Sequence() // получение измененной последовательности в обратном порядке
        {
            int n = Convert.ToInt32(Console.ReadLine());    
            if (n == 0) { return 0; }
            Console.Write(Convert.ToString(n + Sequence()) + " ");
            return n;
        }

        static void Main()
        {
            Console.Write("Введите последовательность вещественных чисел: ");
            Sequence(); 
        } 
    }    
}
