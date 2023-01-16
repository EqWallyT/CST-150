using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class Main : Form
    {
        InventoryManager im;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            im = new InventoryManager();
            MessageBox.Show("Welcome To the Storage Application!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addform = new AddToList(im);
            addform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addform = new Display(im);
            addform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addform = new Remove(im);
            addform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var addform = new Search(im);
            addform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var addform = new EditRestock(im);
            addform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            im.sortData();
            MessageBox.Show("The inventory Has been Sorted by Alphabetical order");
        }
    }
}
