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
    public partial class EditRestock : Form
    {
        InventoryManager im;
        public EditRestock(InventoryManager im)
        {
            this.im = im;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var qty = int.Parse(textBox2.Text);
                var name = textBox1.Text;
                im.editItem(name, qty);
                MessageBox.Show("Item Quantity Updated");
            }
            catch
            {
                MessageBox.Show("Invalid Quantity");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
