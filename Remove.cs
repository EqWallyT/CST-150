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
    public partial class Remove : Form
    {
        InventoryManager im;
        public Remove(InventoryManager im)
        {
            this.im = im;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            im.removeItem(textBox1.Text);
            MessageBox.Show("Item has been Removed!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
