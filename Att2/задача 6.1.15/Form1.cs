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

namespace Task6_1_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string str = inputS.Text;
            int k = int.Parse(inputK.Text);

            WorkWithStr workWithStr = new WorkWithStr(str);
            output.Text = workWithStr.WordN(k);
        }
        
    }
}
