using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace AlgebraMathCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void circle_submit_Click(object sender, EventArgs e)
        {
            // Gather all of the data from the text fields
            double diameter = 0;
            double radius = 0;
            double circumference = 0;

            if (diameter_textbox_circle.Text.Length > 0)
            {
                diameter = Convert.ToDouble(diameter_textbox_circle.Text);
            }
            if (radius_textbox_circle.Text.Length > 0)
            {
                radius = Convert.ToDouble(radius_textbox_circle.Text);
            }
            if (circumference_textbox_circle.Text.Length > 0)
            {
                circumference = Convert.ToDouble(circumference_textbox_circle.Text);
            }
            
                       
            /*
             * 0 = area
             * 1 = circumference
             * 2 = diameter
             */
            double[] circleResults = new double[3];
            bool isErrorPresent = false;

            // Check to make sure that the values are actually there
            // Add them to an array of answers to be displayed.
            if (area_checkBox_circle.Checked)
            {
                if((diameter.Equals(null) || diameter.Equals(0)) && (radius.Equals(null) || radius.Equals(0)))
                {
                    MessageBox.Show("You entered no value for Diameter or Radius.", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isErrorPresent = true;
                }
                if((diameter.Equals(null) || diameter.Equals(0)) && (!radius.Equals(null)))
                {
                    circleResults[0] = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
                }
                else if((radius.Equals(null) || radius.Equals(0)) && (!diameter.Equals(null)))
                {
                    circleResults[0] = Math.Round(Math.PI * Math.Pow(diameter/2, 2), 2);
                }
            }
            if (circumference_checkBox_circle.Checked)
            {
                if ((diameter.Equals(null) || diameter.Equals(0)) && (radius.Equals(null) || radius.Equals(0)))
                {
                    MessageBox.Show("You entered no value for Diameter or Radius.", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isErrorPresent = true;
                }
                if ((diameter.Equals(null) || diameter.Equals(0)) && (!radius.Equals(null) || !radius.Equals(0)))
                {
                    circleResults[1] = Math.Round(2 * (Math.PI * radius), 2);
                }
                else if ((radius.Equals(null) || radius.Equals(0)) && (!diameter.Equals(null) || !diameter.Equals(0)))
                {
                    circleResults[1] = Math.Round(2 * (Math.PI * (diameter / 2)), 2);
                }
            }
            if (diameter_checkBox_circle.Checked)
            {
                if (diameter.Equals(0) && !radius.Equals(0))
                {
                    // 2xr = diameter
                    circleResults[2] = Math.Round(2 * radius, 2);
                }
                if (!diameter.Equals(0) && radius.Equals(0))
                {
                    // diameter = d
                    circleResults[2] = Math.Round(diameter, 2);
                }
                if (!diameter.Equals(0) && !radius.Equals(0))
                {
                    MessageBox.Show("Check your values for Diameter and Radius.", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isErrorPresent = true;
                }
                else if (diameter.Equals(0) && radius.Equals(0))
                {
                    MessageBox.Show("Check your values for Diameter and Radius.", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isErrorPresent = true;
                }
            }
            if (!diameter_checkBox_circle.Checked && !area_checkBox_circle.Checked && !circumference_checkBox_circle.Checked)
            {
                MessageBox.Show("You need to select one of the formulas to apply to the data!", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isErrorPresent = true;
            }
            if (!isErrorPresent)
            {
                // Display the data!
                MessageBox.Show(string.Format("Area: {0}\nCircumference: {1}\nDiameter: {2}.", circleResults[0], circleResults[1], circleResults[2]), "Circle Results!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void square_submit_Click(object sender, EventArgs e)
        {
            double side1 = 0;
            double side2 = 0;
            double side3 = 0;
            double side4 = 0;

            if (side1_textBox_square.Text.Length > 0)
            {
                side1 = Convert.ToDouble(side1_textBox_square.Text);
            }
            if (side2_textBox_square.Text.Length > 0)
            {
                side2 = Convert.ToDouble(side2_textBox_square.Text);
            }
            if (side3_textBox_square.Text.Length > 0)
            {
                side3 = Convert.ToDouble(side3_textBox_square.Text);
            }
            if (side4_textBox_square.Text.Length > 0)
            {
                side4 = Convert.ToDouble(side4_textBox_square.Text);
            }
            if (!side1.Equals(0) && !side2.Equals(0) && !side3.Equals(0) && !side4.Equals(0))
            {
                if (Array.TrueForAll<double>(new double[] { side1, side2, side3, side4 },
                    val => (side1 == val)))
                {
                    // check to see if area or perimeter checked
                    double[] squareResults = new double[2];
                    if (square_area_checkBox.Checked)
                    {
                        squareResults[0] = Math.Pow(side1, 2);
                    }
                    if (square_perimeter_checkBox.Checked)
                    {
                        squareResults[1] = 4 * side1;
                    }
                    if (!square_area_checkBox.Checked && !square_perimeter_checkBox.Checked)
                    {
                        MessageBox.Show("You need to select a formula to apply. Area or Perimeter!", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!squareResults[0].Equals(0) || !squareResults[1].Equals(0))
                    {
                        MessageBox.Show(string.Format("Area: {0}\nPerimeter: {1}", squareResults[0], squareResults[1]), "Square Results!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                } else
                {
                    MessageBox.Show("All sides of a square are equal!", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // you need to find all 4 sides
                MessageBox.Show("You need to input all 4 sides of the square!", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rectangle_submit_Click(object sender, EventArgs e)
        {

            double width = 0;
            double length = 0;

            if (!width_textBox_rectangle.Equals(null) || !width_textBox_rectangle.Equals(0))
            {
                width = Convert.ToDouble(width_textBox_rectangle.Text);
            }
            if (!length_textBox_rectangle.Equals(null) || !length_textBox_rectangle.Equals(0))
            {
                length = Convert.ToDouble(length_textBox_rectangle.Text);
            }

            double[] rectangleAnswers = new double[2];

            if (area_checkBox_rectangle.Checked && (!width.Equals(0) || !length.Equals(0)))
            {
                // calculate area if both length / width are > 0
                rectangleAnswers[0] = length * width;
            }
            if (perimeter_checkBox_rectangle.Checked && (!width.Equals(0) || !length.Equals(0)))
            {
                // calculate perimeter if both length / width are > 0
                rectangleAnswers[1] = ((2*length) + (2*width));
            }
            if (width.Equals(0) || length.Equals(0))
            {
                MessageBox.Show("You need to input both the length and width of the rectangle! (greater than 0)", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!perimeter_checkBox_rectangle.Checked && !area_checkBox_rectangle.Checked)
            {
                // throw an error to select a box.
                MessageBox.Show("You need to select a formula to apply. Area or Perimeter!", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // return all the infos
                MessageBox.Show(string.Format("Area: {0}\nPerimeter: {1}", rectangleAnswers[0], rectangleAnswers[1]), "Rectangle Results!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void triangle_submit_Click(object sender, EventArgs e)
        {

        }
    }
}
