using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Att_Eliza
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Введите трехзначное число: ");
                a = int.Parse(Console.ReadLine());
            }
            while (a < 100 || a > 999);

            IsGeometricProgression(a);
        }

        static void IsGeometricProgression(int a)
        {
            int first_num = a / 100;
            int second_num = (a / 10) % 10;
            int third_num = a % 10;
            if ((third_num / second_num != 0) && (second_num / first_num) != 0 
                && (third_num / second_num == second_num / first_num))
            {
                Console.WriteLine("Цифры данного трехзначного числа образуют геометрическую прогрессию.");
            }
            else
            {
                Console.WriteLine("Цифры данного трехзначного числа не образуют геометрическую прогрессию.");
            };
        }

    }
}
