using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class ResultForm : Form
    {
        private Label label1;
        private Button buttonPlayAgain;
        private Button button2;

        // Store the game result.
        private bool button1;

        public ResultForm(bool isWin)
        {
            InitializeComponent();
            this.button1 = isWin;
            DisplayResult();
        }

        private void DisplayResult()
        {
            if (button1)
            {
                // You can customize the message and appearance for a win.
                label1.Text = "You Win!";
                this.BackColor = System.Drawing.Color.Green; // Change the background color for a win.
            }
            else
            {
                // Customize the message and appearance for a loss.
                label1.Text = "You Lose!";
                this.BackColor = System.Drawing.Color.Red; // Change the background color for a loss.
            }
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            // Handle the "Play Again" button click.
            // You can hide the result form and return to the main game window.
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            Close();
            // Add code to resume or restart the game here.
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Handle the "Close" button click.
            // You can close the result form and return to the main menu or exit the game.
            this.Close();
            Close();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.play_again;
            this.buttonPlayAgain.Location = new System.Drawing.Point(165, 317);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(401, 135);
            this.buttonPlayAgain.TabIndex = 1;
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(815, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 169);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ResultForm
            // 
            this.ClientSize = new System.Drawing.Size(1211, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.label1);
            this.Name = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
