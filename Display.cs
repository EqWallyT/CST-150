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
    public partial class Display : Form
    {
        InventoryManager im;
        public Display(InventoryManager im)
        {
            this.im = im;
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            foreach (var i in im.getItems())
            {
                string[] row = { i.Name, i.Price.ToString(), i.Qty.ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
