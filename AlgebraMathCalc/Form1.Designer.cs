using System;

namespace AlgebraMathCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab = new System.Windows.Forms.TabControl();
            this.circle_tabPage = new System.Windows.Forms.TabPage();
            this.circle_info_label = new System.Windows.Forms.Label();
            this.circle_submit = new System.Windows.Forms.Button();
            this.diameter_checkBox_circle = new System.Windows.Forms.CheckBox();
            this.circumference_checkBox_circle = new System.Windows.Forms.CheckBox();
            this.area_checkBox_circle = new System.Windows.Forms.CheckBox();
            this.circumference_textbox_circle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.radius_textbox_circle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.diameter_textbox_circle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.square_tabPage = new System.Windows.Forms.TabPage();
            this.square_submit = new System.Windows.Forms.Button();
            this.square_perimeter_checkBox = new System.Windows.Forms.CheckBox();
            this.square_area_checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.side4_textBox_square = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.side3_textBox_square = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.side2_textBox_square = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.side1_textBox_square = new System.Windows.Forms.TextBox();
            this.rectangle_tabPage = new System.Windows.Forms.TabPage();
            this.rectangle_submit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.perimeter_checkBox_rectangle = new System.Windows.Forms.CheckBox();
            this.area_checkBox_rectangle = new System.Windows.Forms.CheckBox();
            this.length_textBox_rectangle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.width_textBox_rectangle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.triangle_tabPage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.triangle_submit = new System.Windows.Forms.Button();
            this.pythagorean_checkBox = new System.Windows.Forms.CheckBox();
            this.perimeter_checkBox = new System.Windows.Forms.CheckBox();
            this.area_checkBox = new System.Windows.Forms.CheckBox();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.side3_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.side2_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.side1_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.circle_tabPage.SuspendLayout();
            this.square_tabPage.SuspendLayout();
            this.rectangle_tabPage.SuspendLayout();
            this.triangle_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            resources.ApplyResources(this.tab, "tab");
            this.tab.Controls.Add(this.circle_tabPage);
            this.tab.Controls.Add(this.square_tabPage);
            this.tab.Controls.Add(this.rectangle_tabPage);
            this.tab.Controls.Add(this.triangle_tabPage);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            // 
            // circle_tabPage
            // 
            this.circle_tabPage.Controls.Add(this.circle_info_label);
            this.circle_tabPage.Controls.Add(this.circle_submit);
            this.circle_tabPage.Controls.Add(this.diameter_checkBox_circle);
            this.circle_tabPage.Controls.Add(this.circumference_checkBox_circle);
            this.circle_tabPage.Controls.Add(this.area_checkBox_circle);
            this.circle_tabPage.Controls.Add(this.circumference_textbox_circle);
            this.circle_tabPage.Controls.Add(this.label16);
            this.circle_tabPage.Controls.Add(this.radius_textbox_circle);
            this.circle_tabPage.Controls.Add(this.label15);
            this.circle_tabPage.Controls.Add(this.diameter_textbox_circle);
            this.circle_tabPage.Controls.Add(this.label14);
            resources.ApplyResources(this.circle_tabPage, "circle_tabPage");
            this.circle_tabPage.Name = "circle_tabPage";
            this.circle_tabPage.UseVisualStyleBackColor = true;
            // 
            // circle_info_label
            // 
            resources.ApplyResources(this.circle_info_label, "circle_info_label");
            this.circle_info_label.Name = "circle_info_label";
            // 
            // circle_submit
            // 
            resources.ApplyResources(this.circle_submit, "circle_submit");
            this.circle_submit.Name = "circle_submit";
            this.circle_submit.UseVisualStyleBackColor = true;
            this.circle_submit.Click += new System.EventHandler(this.circle_submit_Click);
            // 
            // diameter_checkBox_circle
            // 
            resources.ApplyResources(this.diameter_checkBox_circle, "diameter_checkBox_circle");
            this.diameter_checkBox_circle.Name = "diameter_checkBox_circle";
            this.diameter_checkBox_circle.UseVisualStyleBackColor = true;
            // 
            // circumference_checkBox_circle
            // 
            resources.ApplyResources(this.circumference_checkBox_circle, "circumference_checkBox_circle");
            this.circumference_checkBox_circle.Name = "circumference_checkBox_circle";
            this.circumference_checkBox_circle.UseVisualStyleBackColor = true;
            // 
            // area_checkBox_circle
            // 
            resources.ApplyResources(this.area_checkBox_circle, "area_checkBox_circle");
            this.area_checkBox_circle.Name = "area_checkBox_circle";
            this.area_checkBox_circle.UseVisualStyleBackColor = true;
            // 
            // circumference_textbox_circle
            // 
            resources.ApplyResources(this.circumference_textbox_circle, "circumference_textbox_circle");
            this.circumference_textbox_circle.Name = "circumference_textbox_circle";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // radius_textbox_circle
            // 
            resources.ApplyResources(this.radius_textbox_circle, "radius_textbox_circle");
            this.radius_textbox_circle.Name = "radius_textbox_circle";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // diameter_textbox_circle
            // 
            resources.ApplyResources(this.diameter_textbox_circle, "diameter_textbox_circle");
            this.diameter_textbox_circle.Name = "diameter_textbox_circle";
            this.diameter_textbox_circle.TextChanged += new System.EventHandler(this.diameter_textbox_circle_TextChanged);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // square_tabPage
            // 
            this.square_tabPage.Controls.Add(this.square_submit);
            this.square_tabPage.Controls.Add(this.square_perimeter_checkBox);
            this.square_tabPage.Controls.Add(this.square_area_checkBox);
            this.square_tabPage.Controls.Add(this.label5);
            this.square_tabPage.Controls.Add(this.label4);
            this.square_tabPage.Controls.Add(this.side4_textBox_square);
            this.square_tabPage.Controls.Add(this.label3);
            this.square_tabPage.Controls.Add(this.side3_textBox_square);
            this.square_tabPage.Controls.Add(this.label2);
            this.square_tabPage.Controls.Add(this.side2_textBox_square);
            this.square_tabPage.Controls.Add(this.label1);
            this.square_tabPage.Controls.Add(this.side1_textBox_square);
            resources.ApplyResources(this.square_tabPage, "square_tabPage");
            this.square_tabPage.Name = "square_tabPage";
            this.square_tabPage.UseVisualStyleBackColor = true;
            // 
            // square_submit
            // 
            resources.ApplyResources(this.square_submit, "square_submit");
            this.square_submit.Name = "square_submit";
            this.square_submit.UseVisualStyleBackColor = true;
            // 
            // square_perimeter_checkBox
            // 
            resources.ApplyResources(this.square_perimeter_checkBox, "square_perimeter_checkBox");
            this.square_perimeter_checkBox.Name = "square_perimeter_checkBox";
            this.square_perimeter_checkBox.UseVisualStyleBackColor = true;
            // 
            // square_area_checkBox
            // 
            resources.ApplyResources(this.square_area_checkBox, "square_area_checkBox");
            this.square_area_checkBox.Name = "square_area_checkBox";
            this.square_area_checkBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // side4_textBox_square
            // 
            resources.ApplyResources(this.side4_textBox_square, "side4_textBox_square");
            this.side4_textBox_square.Name = "side4_textBox_square";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // side3_textBox_square
            // 
            resources.ApplyResources(this.side3_textBox_square, "side3_textBox_square");
            this.side3_textBox_square.Name = "side3_textBox_square";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // side2_textBox_square
            // 
            resources.ApplyResources(this.side2_textBox_square, "side2_textBox_square");
            this.side2_textBox_square.Name = "side2_textBox_square";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // side1_textBox_square
            // 
            resources.ApplyResources(this.side1_textBox_square, "side1_textBox_square");
            this.side1_textBox_square.Name = "side1_textBox_square";
            // 
            // rectangle_tabPage
            // 
            this.rectangle_tabPage.Controls.Add(this.rectangle_submit);
            this.rectangle_tabPage.Controls.Add(this.label13);
            this.rectangle_tabPage.Controls.Add(this.perimeter_checkBox_rectangle);
            this.rectangle_tabPage.Controls.Add(this.area_checkBox_rectangle);
            this.rectangle_tabPage.Controls.Add(this.length_textBox_rectangle);
            this.rectangle_tabPage.Controls.Add(this.label12);
            this.rectangle_tabPage.Controls.Add(this.width_textBox_rectangle);
            this.rectangle_tabPage.Controls.Add(this.label11);
            resources.ApplyResources(this.rectangle_tabPage, "rectangle_tabPage");
            this.rectangle_tabPage.Name = "rectangle_tabPage";
            this.rectangle_tabPage.UseVisualStyleBackColor = true;
            // 
            // rectangle_submit
            // 
            resources.ApplyResources(this.rectangle_submit, "rectangle_submit");
            this.rectangle_submit.Name = "rectangle_submit";
            this.rectangle_submit.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // perimeter_checkBox_rectangle
            // 
            resources.ApplyResources(this.perimeter_checkBox_rectangle, "perimeter_checkBox_rectangle");
            this.perimeter_checkBox_rectangle.Name = "perimeter_checkBox_rectangle";
            this.perimeter_checkBox_rectangle.UseVisualStyleBackColor = true;
            // 
            // area_checkBox_rectangle
            // 
            resources.ApplyResources(this.area_checkBox_rectangle, "area_checkBox_rectangle");
            this.area_checkBox_rectangle.Name = "area_checkBox_rectangle";
            this.area_checkBox_rectangle.UseVisualStyleBackColor = true;
            // 
            // length_textBox_rectangle
            // 
            resources.ApplyResources(this.length_textBox_rectangle, "length_textBox_rectangle");
            this.length_textBox_rectangle.Name = "length_textBox_rectangle";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // width_textBox_rectangle
            // 
            resources.ApplyResources(this.width_textBox_rectangle, "width_textBox_rectangle");
            this.width_textBox_rectangle.Name = "width_textBox_rectangle";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // triangle_tabPage
            // 
            this.triangle_tabPage.Controls.Add(this.label10);
            this.triangle_tabPage.Controls.Add(this.triangle_submit);
            this.triangle_tabPage.Controls.Add(this.pythagorean_checkBox);
            this.triangle_tabPage.Controls.Add(this.perimeter_checkBox);
            this.triangle_tabPage.Controls.Add(this.area_checkBox);
            this.triangle_tabPage.Controls.Add(this.height_textBox);
            this.triangle_tabPage.Controls.Add(this.label9);
            this.triangle_tabPage.Controls.Add(this.side3_textBox);
            this.triangle_tabPage.Controls.Add(this.label8);
            this.triangle_tabPage.Controls.Add(this.side2_textBox);
            this.triangle_tabPage.Controls.Add(this.label7);
            this.triangle_tabPage.Controls.Add(this.side1_textBox);
            this.triangle_tabPage.Controls.Add(this.label6);
            resources.ApplyResources(this.triangle_tabPage, "triangle_tabPage");
            this.triangle_tabPage.Name = "triangle_tabPage";
            this.triangle_tabPage.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // triangle_submit
            // 
            resources.ApplyResources(this.triangle_submit, "triangle_submit");
            this.triangle_submit.Name = "triangle_submit";
            this.triangle_submit.UseVisualStyleBackColor = true;
            // 
            // pythagorean_checkBox
            // 
            resources.ApplyResources(this.pythagorean_checkBox, "pythagorean_checkBox");
            this.pythagorean_checkBox.Name = "pythagorean_checkBox";
            this.pythagorean_checkBox.UseVisualStyleBackColor = true;
            // 
            // perimeter_checkBox
            // 
            resources.ApplyResources(this.perimeter_checkBox, "perimeter_checkBox");
            this.perimeter_checkBox.Name = "perimeter_checkBox";
            this.perimeter_checkBox.UseVisualStyleBackColor = true;
            // 
            // area_checkBox
            // 
            resources.ApplyResources(this.area_checkBox, "area_checkBox");
            this.area_checkBox.Name = "area_checkBox";
            this.area_checkBox.UseVisualStyleBackColor = true;
            // 
            // height_textBox
            // 
            resources.ApplyResources(this.height_textBox, "height_textBox");
            this.height_textBox.Name = "height_textBox";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // side3_textBox
            // 
            resources.ApplyResources(this.side3_textBox, "side3_textBox");
            this.side3_textBox.Name = "side3_textBox";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // side2_textBox
            // 
            resources.ApplyResources(this.side2_textBox, "side2_textBox");
            this.side2_textBox.Name = "side2_textBox";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // side1_textBox
            // 
            resources.ApplyResources(this.side1_textBox, "side1_textBox");
            this.side1_textBox.Name = "side1_textBox";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.tab.ResumeLayout(false);
            this.circle_tabPage.ResumeLayout(false);
            this.circle_tabPage.PerformLayout();
            this.square_tabPage.ResumeLayout(false);
            this.square_tabPage.PerformLayout();
            this.rectangle_tabPage.ResumeLayout(false);
            this.rectangle_tabPage.PerformLayout();
            this.triangle_tabPage.ResumeLayout(false);
            this.triangle_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage circle_tabPage;
        private System.Windows.Forms.TabPage square_tabPage;
        private System.Windows.Forms.TabPage rectangle_tabPage;
        private System.Windows.Forms.TabPage triangle_tabPage;
        private System.Windows.Forms.Button square_submit;
        private System.Windows.Forms.CheckBox square_perimeter_checkBox;
        private System.Windows.Forms.CheckBox square_area_checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox side4_textBox_square;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox side3_textBox_square;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox side2_textBox_square;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox side1_textBox_square;
        private System.Windows.Forms.Button rectangle_submit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox perimeter_checkBox_rectangle;
        private System.Windows.Forms.CheckBox area_checkBox_rectangle;
        private System.Windows.Forms.TextBox length_textBox_rectangle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox width_textBox_rectangle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button triangle_submit;
        private System.Windows.Forms.CheckBox pythagorean_checkBox;
        private System.Windows.Forms.CheckBox perimeter_checkBox;
        private System.Windows.Forms.CheckBox area_checkBox;
        private System.Windows.Forms.TextBox height_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox side3_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox side2_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox side1_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label circle_info_label;
        private System.Windows.Forms.Button circle_submit;
        private System.Windows.Forms.CheckBox diameter_checkBox_circle;
        private System.Windows.Forms.CheckBox circumference_checkBox_circle;
        private System.Windows.Forms.CheckBox area_checkBox_circle;
        private System.Windows.Forms.TextBox circumference_textbox_circle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox radius_textbox_circle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox diameter_textbox_circle;
        private System.Windows.Forms.Label label14;
        private EventHandler checkBox1_CheckedChanged;
        private EventHandler checkBox2_CheckedChanged;
        private EventHandler button1_Click;
    }
}

