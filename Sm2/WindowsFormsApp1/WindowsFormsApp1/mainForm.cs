using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interpr interpr = new Interpr();
            textBox2.Text = (interpr.Interpret(textBox1.Text)).ToString();
        }
    }
}
