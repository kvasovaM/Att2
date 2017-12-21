using System;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string a = Console.ReadLine();
            Check(a);
        }

        static void Check(string a)
        {
            string str = "аб";
            bool result = a.Contains(str);
            string c = null;

            if (result) c = "содержится";
            else c = "не содержится";

            Console.WriteLine("Символы 'а' и 'б' в строке: {0}", c);
        }

    }
}
