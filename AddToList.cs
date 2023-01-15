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
   
    public partial class AddToList : Form
    {
        InventoryManager im;
        public AddToList(InventoryManager im)
        {
            this.im = im;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                var price = double.Parse(textBox2.Text);
                var quantity = int.Parse(textBox3.Text);
                var name = textBox1.Text;

                im.addItem(name, price, quantity);
                MessageBox.Show("Item has Been Added!");
            }
            catch
            {
                MessageBox.Show("invalid Input");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
