using System;
using System.Collections.Generic;
using System.Linq;

namespace MKLibrary
{
    /* =============================================================================
     * РАБОТА С МАССИВАМИ
     * ============================================================================= */

    public class ArraysHelper
    {

        // Функция конвертирует строку в значение T
        // (при невозможности конвертации происходит ошибка)
        public static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }


        public static T[] StrToArray1<T>(string str)
        {
            return Array.ConvertAll(
               str.Split(new char[] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries),
               (s) => StrToValue<T>(s)
           );
        }
        // Функция конвертирует массив элементов T в строку
        // (вторым параметром можно указать разделитель, по умолчанию ", ")
        public string ArrayToStr<T>(T[] arr, string separator = ", ")
        {
            return arr == null ? "null" : String.Join(separator, arr);
        }

        public List<T> StrToList<T>(string str)
        {
            return new List<T>(Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            ));
        }

        // Функция конвертирует список элементов T в строку
        // (вторым параметром можно указать разделитель, по умолчанию ", ")
        public string ListToStr<T>(IList<T> list, string separator = ", ")
        {
            return list.Count == 0 ? "null" : string.Join(separator, list.ToArray());
        }

        // Функция конвертирует двумерный массив в строку
        public static string Array2DToStr1<T>(T[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int columnsCount = matrix.GetLength(1);

            string result = "";

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    result += matrix[i, j];

                    if (j != columnsCount - 1)
                        result += " ";
                }

                if (i != rowsCount - 1)
                    result += Environment.NewLine;
            }

            return result;
        }

        // Функция конвертирует строку в двумерный массив, если это возможно.
        // В случае некорректных данных бросается исключение
        public static T[,] StrToArray2D<T>(string str)
        {
            string[] lines = str.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (lines.Length == 0)
                throw new Exception();

            int rowsCount = lines.Length;
            int columnsCount = StrToArray1<T>(lines[0]).Length;

            T[,] matrix = new T[rowsCount, columnsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                T[] tempArray = StrToArray1<T>(lines[i]);

                if (tempArray.Length != columnsCount)
                    throw new Exception();

                for (int j = 0; j < tempArray.Length; j++)
                {
                    matrix[i, j] = tempArray[j];
                }
            }

            return matrix;
        }
        
        // Функция конвертирует строку в массив элементов T
        // (при невозможности конвертации происходит ошибка)
        public T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
               str.Split(new char[] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries),
               (s) => StrToValue<T>(s)
           );
        }

        // Функция конвертирует двумерный массив в строку
        public string Array2DToStr<T>(T[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int columnsCount = matrix.GetLength(1);

            string result = "";

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    result += matrix[i, j];

                    if (j != columnsCount - 1)
                        result += " ";
                }

                if (i != rowsCount - 1)
                    result += Environment.NewLine;
            }

            return result;
        }

    }
}