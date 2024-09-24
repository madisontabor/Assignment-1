using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment_1
{
    partial class Assignment_1
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
            lblFirstname = new Label();
            lblLastname = new Label();
            lblHoursworked = new Label();
            tbxFirstname = new TextBox();
            tbxLastname = new TextBox();
            tbxHoursworked = new TextBox();
            Bnsummarize = new Button();
            Bnclear = new Button();
            lblSummary = new Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new System.Drawing.Point(101, 83);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new System.Drawing.Size(35, 13);
            lblFirstname.TabIndex = 0;
            lblFirstname.Text = "&First Name";
            lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new System.Drawing.Point(377, 83);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new System.Drawing.Size(35, 13);
            lblLastname.TabIndex = 1;
            lblLastname.Text = "&Last Name";
            lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            lblHoursworked.AutoSize = true;
            lblHoursworked.Location = new System.Drawing.Point(652, 83);
            lblHoursworked.Name = "lblHoursworked";
            lblHoursworked.Size = new System.Drawing.Size(35, 13);
            lblHoursworked.TabIndex = 2;
            lblHoursworked.Text = "&Hours Worked";
            lblHoursworked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            tbxFirstname.Location = new System.Drawing.Point(73, 99);
            tbxFirstname.Name = "tbxFirstname";
            tbxFirstname.Size = new System.Drawing.Size(100, 20);
            tbxFirstname.TabIndex = 1;
            tbxFirstname.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            tbxLastname.Location = new System.Drawing.Point(347, 99);
            tbxLastname.Name = "tbxLastname";
            tbxLastname.Size = new System.Drawing.Size(100, 20);
            tbxLastname.TabIndex = 4;
            tbxLastname.TextAlign = HorizontalAlignment.Center;

            // 
            // textBox3
            // 
            tbxHoursworked.Location = new System.Drawing.Point(626, 99);
            tbxHoursworked.Name = "tbxHoursworked";
            tbxHoursworked.Size = new System.Drawing.Size(100, 20);
            tbxHoursworked.TabIndex = 5;
            tbxHoursworked.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            Bnsummarize.Location = new System.Drawing.Point(73, 214);
            Bnsummarize.Name = "Bnsummarize";
            Bnsummarize.Size = new System.Drawing.Size(75, 23);
            Bnsummarize.TabIndex = 6;
            Bnsummarize.Text = "&Summarize";
            Bnsummarize.UseVisualStyleBackColor = true;
            Bnsummarize.Click += Bnsummarize_click;
            // 
            // button2
            // 
            Bnclear.Location = new System.Drawing.Point(165, 214);
            Bnclear.Name = "Bnclear";
            Bnclear.Size = new System.Drawing.Size(75, 23);
            Bnclear.TabIndex = 7;
            Bnclear.Text = "&Clear";
            Bnclear.UseVisualStyleBackColor = true;
            Bnclear.Click += Bnclear_Click;
            // 
            // label4
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new System.Drawing.Point(375, 357);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new System.Drawing.Size(35, 13);
            lblSummary.TabIndex = 0;
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblSummary);
            this.Controls.Add(Bnclear);
            this.Controls.Add(Bnsummarize);
            this.Controls.Add(tbxHoursworked);
            this.Controls.Add(tbxLastname);
            this.Controls.Add(tbxFirstname);
            this.Controls.Add(lblHoursworked);
            this.Controls.Add(lblLastname);
            this.Controls.Add(lblFirstname);
            this.Name = "Assingment_1";
            this.Text = "Assignment_1";
            this.Load += new System.EventHandler(this.Assignment_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private Label lblFirstname;
        private Label lblLastname;
        private Label lblHoursworked;
        private TextBox tbxFirstname;
        private TextBox tbxLastname;
        private TextBox tbxHoursworked;
        private Button Bnsummarize;
        private Button Bnclear;
        private Label lblSummary;

    }
}

