using System;
using System.Drawing;
using System.Windows.Forms;
using MKLibrary;

namespace Task_7_1_15
{
    public partial class Task7_1_15 : Form
    {
        public Task7_1_15()
        {
            InitializeComponent();
            Samples.Items.AddRange(new string[] {

                "XXL", // массив не введен
                "1", // 0
                "1, 2, 3, 4", // 0
                "1 2 3 4", // 0
                "4, 3, 2, 1", // 0
                "1, 2, 3, 3", // 4
                "1, 3, 5, 4", // 3
                "1, 0, 2, 3", // 2
                "6, 5, 4, 3, 2", // 1
                "0.2, 1, 2, 3", // на вход принимаются только целые числа
                "text" // на вход принимаются только целые числа
            });
        }

        private void CheckCondition_Click(object sender, EventArgs e)
        {
            if (AcceptedData.Text.Trim().Length == 0)
            {
                Result("Массив не введен!", Color.Red);
                return;
            }

            int[] array = { };
            try
            {
                array = new ArraysHelper().StrToArray<int>(AcceptedData.Text);
            }
            catch 
            {
                Result("На вход принимаются только целые числа!", Color.Red);
                return;
            }

            WorkWithArrays Array = new WorkWithArrays(array);
            int answer = Array.IsMix();

            Result(answer.ToString(), Color.Black );
        }

        private void Result(string text, Color color)
        {
            ResultOutput.Show();
            ResultOutput.Text = text;
            ResultOutput.ForeColor = color;

        } 

        private void AcceptedData_TextChanged(object sender, EventArgs e)
        {
            ResultOutput.Hide();
        }

        private void Samples_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Samples.SelectedIndex > -1)
            {   
            AcceptedData.Text = Samples.SelectedItem.ToString();
            Samples.SelectedIndex = -1;
            }        
        }
    }
}
