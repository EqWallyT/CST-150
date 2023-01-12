using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_click(object sender, EventArgs e)
        {
            //Create a new object and Create a space in memory for the object then give the object some properties.
            OpenFileDialog newFileDialogBox = new OpenFileDialog();
            newFileDialogBox.FileName = "Funny.png";
            newFileDialogBox.ShowDialog();
        }

        private void projectsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void createEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Changes the label to match the combobox input.
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Simple MESSAGE WHEN CLICKING THE BUTTON
            MessageBox.Show("Welcome to my Activity 1 for CST-150");
        }
    }
}
