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

namespace Task_8_1_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Lists lists = new Lists(inputList.Text);
            List<int> newlist = lists.CreateNewList(int.Parse(inputN.Text));
            output.Text = Lists.ListToStr(newlist);
        }
    }
}
