using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Graph11
{
    public partial class FormHead : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        Graph graph = new Graph();
        private Graphics graphics;

        public FormHead()
        {
            InitializeComponent();
        }

        private void buttonFindMinSumOfDists_Click(object sender, EventArgs e)
        {
            try
            {
                labelOutputRoute.Text = graph.FindMinSumOfDists();
            }
            catch (MyException exception)
            {

                MessageBox.Show(exception.Message);
            }
            catch
            {
                MessageBox.Show("");
            }
        }

        private string GenetareNodeId(string startName)
        {
            string str = String.Empty;

            int x = Convert.ToInt32(startName);
            x++;
            str = x.ToString();

            return str;
        }

        private void buttonSaveGraph_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            graph.SaveGraph(saveFileDialog.FileName);
        }

        private void buttonLoadGraph_Click(object sender, EventArgs e)
        {
            graphics = pictureBoxHead.CreateGraphics();
            graphics.Clear(Color.Gainsboro);
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            graph = graph.LoadGraph(openFileDialog.FileName);
            try
            {
                labelOutputRoute.Text = graph.FindMinSumOfDists();
            }
            catch (MyException exception)
            {

                MessageBox.Show(exception.Message);
            }
            catch
            {
                MessageBox.Show("");
            }
            graph.Draw(graphics);
        }

        private void FormHead_Load(object sender, EventArgs e)
        {
            openFileDialog.DefaultExt = ".txt";
            saveFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "(*.txt) | *.txt";
            saveFileDialog.Filter = "(*.txt) | *.txt";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Multiselect = false;

            groupBoxChecks.Controls.Add(radioButtonAddNode);
            groupBoxChecks.Controls.Add(radioButtonDelNode);
            groupBoxChecks.Controls.Add(radioButtonMoveNode);
            groupBoxChecks.Controls.Add(radioButtonAddEdge);
            groupBoxChecks.Controls.Add(radioButtonDelEdge);
            textBoxAddNode.MaxLength = 2;
            textBoxWeight.MaxLength = 3;
            textBoxAddNode.Text = "1";
            textBoxWeight.Text = "10";
        }

        private void pictureBoxMain_MouseClick(object sender, MouseEventArgs e)
        {
            graphics = pictureBoxHead.CreateGraphics();
            graphics.Clear(Color.Gainsboro);
            if (radioButtonAddNode.Checked)
            {
                if (textBoxAddNode.Text != "")
                {
                    int k = graph.GetNodesListCount();
                    graph.AddNode(e.X, e.Y, textBoxAddNode.Text);
                    if (k != graph.GetNodesListCount())
                    {
                        textBoxAddNode.Text = GenetareNodeId(textBoxAddNode.Text);
                    }
                    graph.Draw(graphics);
                }
            }

            if (radioButtonDelNode.Checked)
            {
                graph.DeleteNode(e.X, e.Y);
                graph.Draw(graphics);
            }

            if (radioButtonMoveNode.Checked)
            {
                graph.MoveNode(e.X, e.Y);
                graph.Draw(graphics);
            }

            if (radioButtonAddEdge.Checked)
            {
                try
                {
                    graph.AddEdge(e.X, e.Y, Convert.ToInt32(textBoxWeight.Text));
                }
                catch
                {
                    textBoxWeight.Clear();
                    MessageBox.Show("Введите вес корректно!");
                }
                graph.Draw(graphics);
            }

            if (radioButtonDelEdge.Checked)
            {
                graph.DeleteEdge(e.X, e.Y);
                graph.Draw(graphics);
            }
        }
    }
}
