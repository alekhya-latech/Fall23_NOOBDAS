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
        private Button easy;
        private Button hard;
        private Label label1;
        private Button button5;
        private int level = -1;

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
            this.easy = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(384, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select  level and character!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.fireman;
            this.button4.Location = new System.Drawing.Point(891, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 241);
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
            this.button3.Location = new System.Drawing.Point(651, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 251);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.cute_man;
            this.button2.Location = new System.Drawing.Point(419, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 241);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.swordman;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(196, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 241);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.easy.Location = new System.Drawing.Point(628, 134);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(175, 80);
            this.easy.TabIndex = 5;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.hard.Location = new System.Drawing.Point(628, 286);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(175, 75);
            this.hard.TabIndex = 6;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hard_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(1132, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 53);
            this.button5.TabIndex = 7;
            this.button5.Text = "Help";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Welcome
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1749, 707);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Welcome";
            this.Text = "Main menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (level == 0)
            {
                FrmLevel frmlevel = new FrmLevel(button1.BackgroundImage);
                frmlevel.ShowDialog();
                Close();
            }
            else if (level == 1)
            {
                FrmHardLevel frmHardlevel = new FrmHardLevel(button1.BackgroundImage);
                frmHardlevel.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please Select Level first!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 0)
            {
                FrmLevel frmlevel = new FrmLevel(button2.BackgroundImage);
                frmlevel.ShowDialog();
                Close();
            }
            else if(level == 1)
            {
                FrmHardLevel frmHardlevel = new FrmHardLevel(button2.BackgroundImage);
                frmHardlevel.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please Select Level first!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (level == 0)
            {
                FrmLevel frmlevel = new FrmLevel(button3.BackgroundImage);
                frmlevel.ShowDialog();
                Close();
            }
            else if (level == 1)
            {
                FrmHardLevel frmHardlevel = new FrmHardLevel(button3.BackgroundImage);
                frmHardlevel.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please Select Level first!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (level == 0)
            {
                FrmLevel frmlevel = new FrmLevel(button4.BackgroundImage);
                frmlevel.ShowDialog();
                Close();
            }
            else if (level == 1)
            {
                FrmHardLevel frmHardlevel = new FrmHardLevel(button4.BackgroundImage);
                frmHardlevel.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please Select Level first!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void easy_Click(object sender, EventArgs e)
        {
            hard.Enabled = false;
            level = 0;

        }

        private void hard_Click_1(object sender, EventArgs e)
        {
            easy.Enabled = false;
            level = 1;


        }
    }
}
