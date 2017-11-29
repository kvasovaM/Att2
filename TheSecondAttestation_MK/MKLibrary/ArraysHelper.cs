using System;

namespace MKLibrary
{
    /* =============================================================================
     * РАБОТА С МАССИВАМИ
     * ============================================================================= */

    public class ArraysHelper
    {

        // Функция конвертирует строку в значение T
        // (при невозможности конвертации происходит ошибка)
        private T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
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

        // Функция конвертирует массив элементов T в строку
        // (вторым параметром можно указать разделитель, по умолчанию ", ")
        public string ArrayToStr<T>(T[] arr, string separator = ", ")
        {
            return arr == null ? "null" : String.Join(separator, arr);
        }

    }
}