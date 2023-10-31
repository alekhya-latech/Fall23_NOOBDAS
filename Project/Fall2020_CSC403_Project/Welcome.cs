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
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(376, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 109);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select character!!";
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.fireman;
            this.button4.Location = new System.Drawing.Point(958, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 231);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.pumpkinHead;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(707, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 247);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.cute_man;
            this.button2.Location = new System.Drawing.Point(423, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 255);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.swordman;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(82, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 254);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLevel frmlevel = new FrmLevel(button1.BackgroundImage);
            frmlevel.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLevel frmlevel = new FrmLevel(button2.BackgroundImage);
            frmlevel.ShowDialog();
            Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {   
            FrmLevel frmlevel = new FrmLevel(button3.BackgroundImage);
            frmlevel.ShowDialog();
            Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {   
            FrmLevel frmlevel = new FrmLevel(button4.BackgroundImage);
            frmlevel.ShowDialog();
            Close();

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
