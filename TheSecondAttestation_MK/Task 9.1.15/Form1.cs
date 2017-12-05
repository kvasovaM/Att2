using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MKLibrary;

namespace Task_9._1._15
{
    public partial class Form1 : Form
    {
        public ArraysHelper helper;

        public Form1()
        {
            InitializeComponent();
            helper = new ArraysHelper();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Читаем содержимое выбранного файла и преобразуем его в массив
                    string arrText = FilesUtils.Read(openFileDialog.FileName);
                    int[,] arr = helper.StrToArray2D<int>(arrText);

                    // Копируем полученный массив в DataGridView
                    DataGridViewUtils.Array2ToGrid(inputGrid, arr);

                    MessagesUtils.Show("Данные загружены. Можем начинать!");
                }
                catch 
                {
                    MessagesUtils.ShowError("Ошибка загрузки данных");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Задаём начальные пути для диалогов открытия/сохранения файла
            this.openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            // Инициализируем наши DataGridView (задаём им начальные свойства)
            DataGridViewUtils.InitGridForArr(inputGrid, 40, false, true, true, true, true);
        }

        private void Сlose_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            try
            {
                // Преобразуем содержимое нашего DataGridView в массив
                int[,] arr = DataGridViewUtils.GridToArray2<int>(inputGrid);

                // Создаём объект класса Array2DUtils для выполнения
                // различных операций над двумерными массивами
                WorkWith2DArrays arrayUtils = new WorkWith2DArrays(arr);

                // Преобразуем результат выполнения метода IncreaseElementsValue
                // в содержимое DataGridView
                DataGridViewUtils.Array2ToGrid(inputGrid, arrayUtils.LeftBottomTransfer());
            }
            catch (Exception exc)
            {
                // Если во время выполнения действий с массивом произошла ошибка,
                // то выводим её текст
                MessagesUtils.ShowError(exc.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Преобразуем содержимое DataGridView в массив
                    int[,] arr = DataGridViewUtils.GridToArray2<int>(inputGrid);

                    // Записываем полученный массив в файл, предварительно
                    // преобразовав его в строку
                    FilesUtils.Write(saveFileDialog.FileName, helper.Array2DToStr<int>(arr));

                    //MessagesUtils.Show("Данные сохранены");
                }
                catch
                {
                    MessagesUtils.ShowError("Ошибка сохранения данных");
                }
            }

        }
    }
}
