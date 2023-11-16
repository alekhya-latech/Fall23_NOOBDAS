using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class MenuForm : Form
    {
        private Button button2;
        private Button button3;
        

        public MenuForm() { 
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "New Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MenuForm
            // 
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.ClientSize = new System.Drawing.Size(1260, 694);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "MenuForm";
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
