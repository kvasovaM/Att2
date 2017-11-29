using System;
using System.Drawing;
using System.Windows.Forms;
using MKLibrary;

namespace Task_7_1_15
{
    public partial class Task7_2_76 : Form
    {
        public Task7_2_76()
        {
            InitializeComponent();
            Samples.Items.AddRange(new string[] {

                " ", // массив не введен
                "1", // 0, 1
                "1, 2, 3, 4", // 0, 4
                "1 2 3 4", // 0, 4
                "1, 2, 3, 3", // 0, 4
                "4, 3, 2, 1", // -1, 0
                "1, 3, 5, 4", // 0, 3
                "1, 2, 0, 2, 3", // 2, 3
                "6, 5, 4, 3, 2, 3, 4, 5, 6", // 4, 5
                "0.2, 1, 2, 3", // на вход принимаются только целые числа
                "text" // на вход принимаются только целые числа
            });
        }

        private void CheckCondition_Click(object sender, EventArgs ex)
        {
            try
            {
                if (AcceptedData.Text.Trim().Length == 0)
                    throw new Exception("Массив не введен!");

                int[] array = new ArraysHelper().StrToArray<int>(AcceptedData.Text);
                WorkWithArrays arr = new WorkWithArrays(array);

                int size, index;
                arr.SizeAndIndex(out size, out index);

                Result(index.ToString() + ", " + size.ToString(), Color.Black );
            }
            catch (FormatException e)
            {
                Result("На вход принимаются только целые числа!", Color.Red);
                return;
            }
            catch (Exception e)
            {
                Result(e.Message, Color.Red);
                return;
            }

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
