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

namespace задача_6._2._46
{
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int c = 0;
            double E = double.Parse(inputE.Text);
            double x = double.Parse(inputX.Text);
            int n = int.Parse(inputN.Text);

            Calculator calculator = new Calculator(x);

            string answer = "ответ:" + Environment.NewLine +
                "Точная сумма: " + calculator.CalculateFunctionExactly() + Environment.NewLine;

            answer+= "Сумма n слагаемых: " + 
                calculator.CalculateFunctionApproximately(n, 0, out c) + Environment.NewLine;

            answer += "Сумма n слагаемых: " +
    calculator.CalculateFunctionApproximately(n, E, out c) +
    ", слагаемых, больших E: " + c + Environment.NewLine;


            answer += "Сумма n слагаемых: " +
    calculator.CalculateFunctionApproximately(n, E/10, out c) +
    ", слагаемых, больших E/10: " + c + Environment.NewLine;

            output.Text = answer;


        }
    }
}
