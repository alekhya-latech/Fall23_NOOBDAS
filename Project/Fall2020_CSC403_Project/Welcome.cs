using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    internal class Welcome : Form
    {
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Label label1;

        public Welcome()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(403, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 163);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(652, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 163);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(984, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 163);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select character!!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 182);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.ClientSize = new System.Drawing.Size(1210, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLevel frmlevel = new FrmLevel(button1.BackgroundImage);
            frmlevel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLevel frmlevel = new FrmLevel(button2.BackgroundImage);
            frmlevel.ShowDialog();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            FrmLevel frmlevel = new FrmLevel(button2.BackgroundImage);
            frmlevel.ShowDialog();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmLevel frmlevel = new FrmLevel(button2.BackgroundImage);
            frmlevel.ShowDialog();

        }

    }
}
