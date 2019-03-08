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

        private void diameter_textbox_circle_TextChanged(object sender, EventArgs e)
        {

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
                if (diameter.Equals(null) && radius.Equals(null))
                {
                    MessageBox.Show("You entered no value for Diameter or Radius.", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isErrorPresent = true;
                }
                if ((diameter.Equals(null) || (!radius.Equals(null))))
                {
                    circleResults[1] = 2 * (Math.PI * radius);
                }
                else if ((!diameter.Equals(null) || (radius.Equals(null))))
                {
                    circleResults[1] = 2 * (Math.PI * (diameter / 2));
                }
            }
            if (diameter_checkBox_circle.Checked)
            {
                if (diameter.Equals(null) && radius.Equals(null))
                {
                    MessageBox.Show("You entered no value for Diameter or Radius.", "Mathematical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isErrorPresent = true;
                }
                if ((diameter.Equals(null) || (!radius.Equals(null))))
                {
                    circleResults[2] = 2 * radius;
                }
                else if ((!diameter.Equals(null) || (radius.Equals(null))))
                {
                    circleResults[1] = diameter;
                }
            }
            if(!diameter_checkBox_circle.Checked && !area_checkBox_circle.Checked && !circumference_checkBox_circle.Checked)
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
    }
}
