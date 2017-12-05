using System;
using System.IO;

namespace MKLibrary

{
    public class FilesUtils
    {
        // Читает содержимое файла, лежащего по пути path
        public static string Read(string path)
        {
            return String.Join(Environment.NewLine, File.ReadAllLines(path));
        }

        // Записывает в файл, лежащий по пути path строку str
        // Если файла не существует, то создаётся новый
        // В случае, когда файл существует, его содержимое заменяется на новое
        public static void Write(string path, string str)
        {
            File.WriteAllLines(path, new string[] { str });
        }
    }
}
