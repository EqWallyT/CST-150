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
    public partial class Search : Form
    {
        InventoryManager im;
        public Search(InventoryManager im)
        {
            this.im = im;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var i = im.searchItemByName(textBox1.Text);
                if (i == null)
                {
                    MessageBox.Show("Item not Found!");
                }
                else
                {
                    MessageBox.Show($"Name: {i.Name}; Price: {i.Price}; Quantity: {i.Qty}");
                }
            }
            else
            {
                try
                {
                    var price = double.Parse(textBox2.Text);
                    var i = im.searchItemByPrice(price);
                    if (i == null)
                    {
                        MessageBox.Show("Item not Found");
                    }
                    else
                    {
                        MessageBox.Show($"Name: {i.Name}; Price: {i.Price}; Quantity: {i.Qty}");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Price");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
