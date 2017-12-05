using System.Windows.Forms;

namespace MKLibrary
{
    public class MessagesUtils
    {
        // Отображает окно с произвольным сообщением
        public static void Show(string message)
        {
            MessageBox.Show(message);
        }

        // Отображает окно с текстом ошибки и кнопкой "Ок"
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
