using System;
using MKLibrary;

namespace Task_9_2_46_Console
{
    class Program
    {
        static bool ConfirmAction(string question)
        {
            Console.Write(question + " (y/n): ");

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();
            } while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N);

            Console.WriteLine();

            return keyInfo.Key == ConsoleKey.Y;
        }

        // Читаем массив из файла
        static int[,] ReadArrFromFile()
        {
            while (true)
            {
                try
                {
                    string filePath = IOUtils.ReadValueFromConsole<string>("путь к входному файлу");

                    // Пытаемся считать данные из файла, преобразовать их в массив
                    // и вернуть вызывающему коду
                    string arrText = FilesUtils.Read(filePath);
                    return ArraysHelper.StrToArray2D<int>(arrText);
                }
                catch (Exception e)
                {
                    // Если во время считывания из файла ошибка, то выводим её,
                    // а затем просим ввести путь ещё раз
                    IOUtils.ShowError("Невозможно считать данные из этого файла");
                }
            }
        }

        static int[,] ReadArrFromConsole()
        {
            return IOUtils.ReadArray2DFromConsole<int>("массив чисел");
        }

        public static void SaveResultToFile(string answer)
        {
            while (true)
            {
                try
                {
                    string filePath = IOUtils.ReadValueFromConsole<string>("путь к выходному файлу");

                    // Пытаемся записать данные в файл и выйти из метода
                    FilesUtils.Write(filePath, answer);
                    return;
                }
                catch (Exception e)
                {
                    // Если во время считывания из файла ошибка, то выводим её,
                    // а затем просим ввести путь ещё раз
                    IOUtils.ShowError("Невозможно записать данные в этот файл");
                }
            }
        }

        static int Main(string[] args)
        {
            // Запускаем основной цикл приложения
            while (true)
            {
                Console.WriteLine("Добро пожаловать в программу \"Преобразователь массивов\"!" +
"" + Environment.NewLine + Environment.NewLine);

                // Объеявляем переменную для хранения массива
                int[,] arr;

                // Спрашиваем у пользователя, будет ли он читать данные из файла
                if (ConfirmAction("Желаете ли вы считать данные из файла?"))
                {
                    arr = ReadArrFromFile();
                }
                else
                {
                    arr = ReadArrFromConsole();
                }

                WorkWith2DArrays arrayUtils = new WorkWith2DArrays(arr);

                // Конвертируем результат преобразований из массива в строку
                // и выводим его
                string result = arrayUtils.AmountOfEven(arr);

                Console.WriteLine("==== Результат вычислений ====");
                Console.WriteLine(result);

                // Спрашиваем у пользователя, желает ли он также сохранить
                // резульат работы программы в файл
                if (ConfirmAction("Желаете ли вы сохранить резултат работы программы в файл?"))
                {
                    SaveResultToFile(result);
                }

                // Спрашиваем, будет ли пользователь продолжать работу с программой
                if (ConfirmAction("Продолжить работу с программой?"))
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }

            return 0;
        }
    }
}
