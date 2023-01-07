using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // clear the panel
            panel1.Refresh();
            // clear text of labels
            lblDate.Text = "";
            lblName.Text = "";
            // Instantiate Graphics instance
            Graphics graphics = this.panel1.CreateGraphics();
            // instantiate Pen instance
            Pen pen = new Pen(Color.Red, 5);
            // Instantiate Solid Brush instance
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            // if selected shape is Circle
            if (lstShapes.SelectedIndex == 0)
            {

                if (rbOutline.Checked)
                {
                    graphics.DrawEllipse(pen, 20, 20, 150, 150);
                }
                else if (rbFill.Checked)
                {
                    graphics.FillEllipse(solidBrush, 20, 20, 150, 150);
                }
            } // if selected shape is Triangle
            else if (lstShapes.SelectedIndex == 1)
            {
                // create 3 points
                PointF point1 = new PointF(30, 160);
                PointF point2 = new PointF(150, 160);
                PointF point3 = new PointF(100, 20);
                if (rbOutline.Checked)
                {
                    graphics.DrawPolygon(pen, new PointF[] { point1, point2, point3 });
                }
                else if (rbFill.Checked)
                {
                    graphics.FillPolygon(solidBrush, new PointF[] { point1, point2, point3 });
                }
            } // if selected shape is Rectangle
            else if (lstShapes.SelectedIndex == 2)
            {
                if (rbOutline.Checked)
                {
                    graphics.DrawRectangle(pen, 20, 20, 150, 100);
                }
                else if (rbFill.Checked)
                {
                    graphics.FillRectangle(solidBrush, 20, 20, 150, 100);
                }
            } // if selected shape is Pentagon
            else if (lstShapes.SelectedIndex == 3)
            {
                // create 5 points
                PointF point1 = new PointF(30, 80);
                PointF point2 = new PointF(65, 160);
                PointF point3 = new PointF(150, 160);
                PointF point4 = new PointF(170, 80);
                PointF point5 = new PointF(100, 20);

                // add points to array
                PointF[] curvePoints = { point1, point2, point3, point4, point5 };
                if (rbOutline.Checked)
                {
                    // draw outline of Polygon
                    graphics.DrawPolygon(pen, curvePoints);
                }
                else if (rbFill.Checked)
                {
                    // Fill polygon
                    graphics.FillPolygon(solidBrush, curvePoints);
                }
            } // if selected shape is Hexagon
            else if (lstShapes.SelectedIndex == 4)
            {
                // Get the middle of the panel
                float xCoord = panel1.Width / 2;
                float yCoord = panel1.Height / 2;

                PointF[] shape = new PointF[6];

                int value = 80;

                // Create 6 points
                for (int index = 0; index < 6; index++)
                {
                    shape[index] = new PointF(
                        xCoord + value * (float)Math.Cos(index * 60 * Math.PI / 180f),
                        yCoord + value * (float)Math.Sin(index * 60 * Math.PI / 180f));
                }
                if (rbOutline.Checked)
                {
                    graphics.DrawPolygon(pen, shape);
                }
                else if (rbFill.Checked)
                {
                    graphics.FillPolygon(solidBrush, shape);
                }
            }
            // if name check box is selected
            if (cbName.Checked)
            {
                // set the name on label name
                lblName.Text = getShapeName(lstShapes.SelectedIndex);
            }
            // if date check box is selected
            if (cbDate.Checked)
            {
                // set the name on label name
                lblDate.Text = DateTime.Now.ToString("d");
            }
        }
        /// <summary>
        /// Clear contents of Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear panel
            panel1.Refresh();
            // clear list box selection
            lstShapes.SelectedIndex = 0;
            // clear radio boxes
            rbFill.Checked = false;
            rbOutline.Checked = false;
            // clear check boxes
            cbName.Checked = false;
            cbDate.Checked = false;
            // clear text of labels
            lblDate.Text = "";
            lblName.Text = "";
        }
        /// <summary>
        /// Method to return the shape name based on selected list index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>shape name</returns>
        private string getShapeName(int index)
        {
            if (index == 0)
            {
                return "Circle";
            }
            else if (index == 1)
            {
                return "Triangle";
            }
            else if (index == 2)
            {
                return "Rectangle";
            }
            else if (index == 3)
            {
                return "Pentagon";
            }
            else if (index == 4)
            {
                return "Hexagon";
            }
            return "";
        }
    }
}
