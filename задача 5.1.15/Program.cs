using System;

namespace Task_5_1_15
{
    class Program
    {
        static void Draw(int h, int w)
        {
            char char1 = '!';
            char char2 = ' ';
            char currentchar = char1;
            int char1_count = 1;
            int char2_count = w - 2;
            int counter = 0;

            for (int row = 1; row <= h; row++)
            {
                for (int col = 1; col <= w; col++)
                {
                    if (row == 1 || row == h)
                    {
                        if (col == 1 || col == w)
                        {
                            Console.Write(' ');
                        }
                        else
                        {
                            Console.Write('-');
                        }
                    }
                    else
                    {
                        if (col == 1 || col == w)
                        {
                            Console.Write('|');
                        }
                        else
                        {
                            Console.Write(currentchar);
                            counter++;

                            if (currentchar == char1 && counter == char1_count)
                            {
                                currentchar = char2;
                                counter = 0;
                                char1_count++;
                            }
                            if (currentchar == char2 && counter == char2_count)
                            {
                                currentchar = char1;
                                counter = 0;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            int h, w;
            do
            {
                Console.Write("Введите высоту фигуры h >= 3 : ");
                h = int.Parse(Console.ReadLine());

            } while (h < 3);

            do
            {
                Console.Write("Введите ширину фигуры w >= 3 : ");
                w = int.Parse(Console.ReadLine());
            } while (w < 3);

            Draw(h, w);
        }
    }
}
