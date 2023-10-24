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
        private Button button1;

        public Welcome()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.button1);
            this.Name = "Welcome";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLevel frmlevel = new FrmLevel();
            frmlevel.ShowDialog();
        }
    }
}
