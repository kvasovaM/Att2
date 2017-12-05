using System;
using System.Collections.Generic;
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
            List<int> newlist = new List<int>();
            newlist = Lists.StrToList(inputList.Text);
            Lists lists = new Lists(newlist);
            newlist = lists.CreateNewList(int.Parse(inputN.Text));

            output.Text = Lists.ListToStr(newlist);
        }
        
    }
}
